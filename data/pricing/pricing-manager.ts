// Utility for managing pricing data
import { PriceMatrix } from "../price-matrix";

// Type for pricing file references
export type PricingReference = {
  brandId: string;
  modelId: string;
  trimId: string;
};

// Cache for loaded pricing data
const pricingCache: Record<string, PriceMatrix> = {};

/**
 * Generates a unique key for a pricing reference
 */
export const getPricingKey = (ref: PricingReference): string => {
  return `${ref.brandId}_${ref.modelId}_${ref.trimId}`;
};

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
    const pricingModule = await import(`./${ref.brandId}/${ref.modelId}/${ref.trimId}.ts`);
    const priceMatrix = pricingModule.default as PriceMatrix;
    
    // Cache the result
    pricingCache[key] = priceMatrix;
    
    return priceMatrix;
  } catch (error) {
    console.error(`Failed to load pricing for ${key}:`, error);
    return []; // Return empty price matrix on error
  }
};

/**
 * Gets a price matrix synchronously (from cache or empty if not loaded)
 */
export const getPriceMatrix = (ref: PricingReference): PriceMatrix => {
  const key = getPricingKey(ref);
  return pricingCache[key] || [];
};

/**
 * Preloads all price matrices for a list of references
 */
export const preloadPriceMatrices = async (refs: PricingReference[]): Promise<void> => {
  await Promise.all(refs.map(ref => loadPriceMatrix(ref)));
};
