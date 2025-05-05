// Utility for loading pricing data
import { PriceMatrix } from "../price-matrix";
import { PricingReference, getPricingKey } from "./pricing-manager";
import { defaultPriceMatrices } from "./default-trims";

// Cache for loaded pricing data
const pricingCache: Record<string, PriceMatrix> = {};

/**
 * Loads a price matrix for a specific brand, model, and trim
 */
export const loadPriceMatrix = async (ref: PricingReference): Promise<PriceMatrix> => {
  const key = getPricingKey(ref);
  
  // Return from cache if available
  if (pricingCache[key]) {
    return pricingCache[key];
  }
  
  try {
    // Dynamic import of the pricing file
    const pricingModule = await import(`./${ref.brandId}/${ref.modelId}/${ref.trimId}`);
    const priceMatrix = pricingModule.default as PriceMatrix;
    
    // Cache the result
    pricingCache[key] = priceMatrix;
    
    return priceMatrix;
  } catch (error) {
    console.warn(`No specific pricing found for ${key}, using default pricing`);
    
    // If specific pricing is not available, use default pricing based on trim ID
    if (defaultPriceMatrices[ref.trimId]) {
      pricingCache[key] = defaultPriceMatrices[ref.trimId];
      return defaultPriceMatrices[ref.trimId];
    }
    
    // If no default pricing for this trim ID, use basic pricing
    pricingCache[key] = defaultPriceMatrices.basic;
    return defaultPriceMatrices.basic;
  }
};

/**
 * Gets a price matrix synchronously (from cache or default if not loaded)
 */
export const getPriceMatrix = (ref: PricingReference): PriceMatrix => {
  const key = getPricingKey(ref);
  return pricingCache[key] || defaultPriceMatrices.basic;
};

/**
 * Preloads all price matrices for a list of references
 */
export const preloadPriceMatrices = async (refs: PricingReference[]): Promise<void> => {
  await Promise.all(refs.map(ref => loadPriceMatrix(ref)));
};
