// Utility for managing detailed features data
import { FeatureGroup } from "../offers";

// Type for features file references
export type FeaturesReference = {
  brandId: string;
  modelId: string;
  trimId: string;
};

// Cache for loaded features data
const featuresCache: Record<string, FeatureGroup[]> = {};

/**
 * Generates a unique key for a features reference
 */
export const getFeaturesKey = (ref: FeaturesReference): string => {
  return `${ref.brandId}_${ref.modelId}_${ref.trimId}`;
};

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
    const featuresModule = await import(`./${ref.brandId}/${ref.modelId}/${ref.trimId}.ts`);
    const detailedFeatures = featuresModule.default as FeatureGroup[];
    
    // Cache the result
    featuresCache[key] = detailedFeatures;
    
    return detailedFeatures;
  } catch (error) {
    console.error(`Failed to load detailed features for ${key}:`, error);
    return []; // Return empty features array on error
  }
};

/**
 * Gets detailed features synchronously (from cache or empty if not loaded)
 */
export const getDetailedFeatures = (ref: FeaturesReference): FeatureGroup[] => {
  const key = getFeaturesKey(ref);
  return featuresCache[key] || [];
};

/**
 * Preloads all detailed features for a list of references
 */
export const preloadDetailedFeatures = async (refs: FeaturesReference[]): Promise<void> => {
  await Promise.all(refs.map(ref => loadDetailedFeatures(ref)));
};
