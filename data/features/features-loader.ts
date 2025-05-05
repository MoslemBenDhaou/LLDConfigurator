// Utility for loading detailed features data
import { FeatureGroup } from "../offers";
import { FeaturesReference, getFeaturesKey } from "./features-manager";
import { defaultDetailedFeatures } from "./default/default-trims";

// Cache for loaded features data
const featuresCache: Record<string, FeatureGroup[]> = {};

/**
 * Loads detailed features for a specific brand, model, and trim
 */
export const loadDetailedFeatures = async (ref: FeaturesReference): Promise<FeatureGroup[]> => {
  const key = getFeaturesKey(ref);
  
  // Return from cache if available
  if (featuresCache[key]) {
    return featuresCache[key];
  }
  
  try {
    // Dynamic import of the features file
    const featuresModule = await import(`./${ref.brandId}/${ref.modelId}/${ref.trimId}`);
    const detailedFeatures = featuresModule.default as FeatureGroup[];
    
    // Cache the result
    featuresCache[key] = detailedFeatures;
    
    return detailedFeatures;
  } catch (error) {
    console.warn(`No specific detailed features found for ${key}, using default features`);
    
    // If specific features are not available, use default features based on trim ID
    if (defaultDetailedFeatures[ref.trimId]) {
      featuresCache[key] = defaultDetailedFeatures[ref.trimId];
      return defaultDetailedFeatures[ref.trimId];
    }
    
    // If no default features for this trim ID, use basic features
    featuresCache[key] = defaultDetailedFeatures.basic;
    return defaultDetailedFeatures.basic;
  }
};

/**
 * Gets detailed features synchronously (from cache or default if not loaded)
 */
export const getDetailedFeatures = (ref: FeaturesReference): FeatureGroup[] => {
  const key = getFeaturesKey(ref);
  return featuresCache[key] || defaultDetailedFeatures.basic;
};

/**
 * Preloads all detailed features for a list of references
 */
export const preloadDetailedFeatures = async (refs: FeaturesReference[]): Promise<void> => {
  await Promise.all(refs.map(ref => loadDetailedFeatures(ref)));
};
