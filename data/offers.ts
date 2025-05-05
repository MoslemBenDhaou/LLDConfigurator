// Types for the offer data
export type Brand = {
  id: string;
  name: string;
  logo: string;
  isActive: boolean;
  models?: Model[];
};

export type Model = {
  id: string;
  name: string;
  image: string;
  isActive: boolean;
  trims?: Trim[];
};

export type TrimFeature = string;

// Types for detailed features
export type FeatureDetail = {
  name: string;
  value: string;
};

export type FeatureGroup = {
  name: string;
  features: FeatureDetail[];
};

import { PriceMatrix } from "./price-matrix";
// Import the pricing utilities
import { loadPriceMatrix, getPriceMatrix } from "./pricing/pricing-loader";
import { PricingReference } from "./pricing/pricing-manager";
// Import the features utilities
import { loadDetailedFeatures, getDetailedFeatures } from "./features/features-loader";
import { FeaturesReference } from "./features/features-manager";

export type Trim = {
  id: string;
  name: string;
  features: TrimFeature[]; // Simple features list for overview
  detailedFeatures?: FeatureGroup[]; // Detailed features grouped by category
  price: number; // Base price (starting from)
  listPrice: number; // Full list price of the vehicle
  priceMatrix: PriceMatrix; // Price matrix for different duration/km combinations
  isActive: boolean;
};

// Single data structure for all offers
export const carData = [
  {
    id: "alfaromeo",
    name: "Alfa Romeo",
    logo: "/brands/alfaromeo.webp",
    isActive: true,
    models: [
      {
        id: "giulia",
        name: "Giulia",
        image: "/models/alfaromeo/giulia.webp",
        isActive: true,
        trims: [
          {
            id: "2.0-turbo-super-bva",
            name: "2.0 Turbo Super BVA",
            features: [
              "2.0L Turbo Engine",
              "8-Speed Automatic Transmission",
              "Rear-Wheel Drive",
              "Leather Interior",
              "Dual-Zone Climate Control",
              "Infotainment System with Navigation",
              "Parking Sensors",
              "Cruise Control",
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 449,
            listPrice: 198000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "stelvio",
        name: "Stelvio",
        image: "/models/alfaromeo/stelvio.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "2.0 Turbo BVA Q4",
            features: [
              "2.0L Turbo Engine",
              "8-Speed Automatic Transmission",
              "Q4 All-Wheel Drive",
              "Leather Interior",
              "Dual-Zone Climate Control",
              "Infotainment System with Navigation",
              "Parking Sensors",
              "Cruise Control",
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 499,
            listPrice: 265000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      }
    ]
  },
  { 
    id: "audi", 
    name: "Audi", 
    logo: "/brands/audi.webp", 
    isActive: true, 
    models: [
      {
        id: "a3-berline",
        name: "A3 Berline",
        image: "/models/audi/a3-berline.webp",
        isActive: true,
        trims: [
          {
            id: "35-tfsi-business-extended",
            name: "35 TFSI Business Extended",
            features: [
              "1.5L TFSI Engine",
              "150 ch",
              "Manual 6-Speed Transmission",
              "Front-Wheel Drive",
              "MMI Navigation System",
              "Audi Virtual Cockpit",
              "Dual-Zone Climate Control",
              "Parking Sensors"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 349,
            listPrice: 145000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q2",
        name: "Q2",
        image: "/models/audi/q2.webp",
        isActive: true,
        trims: [
          {
            id: "35-tfsi-s-line-bva",
            name: "35 TFSI S-Line BVA",
            features: [
              "1.5L TFSI Engine",
              "150 ch",
              "S tronic 7-Speed Transmission",
              "Front-Wheel Drive",
              "S Line Exterior Package",
              "MMI Navigation System",
              "Sport Seats",
              "Parking Sensors"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 379,
            listPrice: 159000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q3",
        name: "Q3",
        image: "/models/audi/q3.webp",
        isActive: true,
        trims: [
          {
            id: "35-tfsi-advanced-line-s-tronic",
            name: "35 TFSI Advanced Line S-tronic",
            features: [
              "1.5L TFSI Engine",
              "150 ch",
              "S tronic 7-Speed Transmission",
              "Front-Wheel Drive",
              "MMI Navigation Plus",
              "Audi Virtual Cockpit",
              "Three-Zone Climate Control",
              "Parking Sensors"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 459,
            listPrice: 207000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q3-sportback",
        name: "Q3 Sportback",
        image: "/models/audi/q3-sportback.webp",
        isActive: true,
        trims: [
          {
            id: "35-tfsi-business-limited-s-tronic",
            name: "35 TFSI Business Limited S-tronic",
            features: [
              "1.5L TFSI Engine",
              "150 ch",
              "S tronic 7-Speed Transmission",
              "Front-Wheel Drive",
              "MMI Navigation Plus",
              "Audi Virtual Cockpit",
              "Panoramic Sunroof",
              "Parking Sensors"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 489,
            listPrice: 225000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q8-e-tron",
        name: "Q8 e-tron",
        image: "/models/audi/q8-e-tron.webp",
        isActive: true,
        trims: [
          {
            id: "55-e-quattro-advanced-line",
            name: "55 e-quattro Advanced Line",
            features: [
              "Electric Motor",
              "408 ch",
              "Quattro All-Wheel Drive",
              "106 kWh Battery",
              "Up to 582 km Range (WLTP)",
              "MMI Navigation Plus",
              "Audi Virtual Cockpit",
              "Leather Seats"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 739,
            listPrice: 299000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q8-sportback-e-tron",
        name: "Q8 Sportback e-tron",
        image: "/models/audi/q8-sportback-e-tron.webp",
        isActive: true,
        trims: [
          {
            id: "55-e-quattro-s-line",
            name: "55 e-quattro S-line",
            features: [
              "Electric Motor",
              "408 ch",
              "Quattro All-Wheel Drive",
              "106 kWh Battery",
              "Up to 600 km Range (WLTP)",
              "S Line Exterior Package",
              "Sport Seats",
              "21-inch Alloy Wheels"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 839,
            listPrice: 349000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "e-tron-gt",
        name: "e-tron GT",
        image: "/models/audi/e-tron-gt.webp",
        isActive: true,
        trims: [
          {
            id: "quattro",
            name: "quattro",
            features: [
              "Electric Motor",
              "476 ch (530 ch in boost)",
              "Quattro All-Wheel Drive",
              "93.4 kWh Battery",
              "Up to 488 km Range (WLTP)",
              "MMI Navigation Plus",
              "Audi Virtual Cockpit",
              "Panoramic Glass Roof"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 939,
            listPrice: 360000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q7",
        name: "Q7",
        image: "/models/audi/q7.webp",
        isActive: true,
        trims: [
          {
            id: "45-tfsi-quattro-2025-s-line-7-places-bva",
            name: "45 TFSI Quattro 2025 S-Line 7 places BVA",
            features: [
              "3.0L V6 TFSI Engine",
              "340 ch",
              "Tiptronic 8-Speed Transmission",
              "Quattro All-Wheel Drive",
              "7-Seat Configuration",
              "S Line Exterior & Interior Package",
              "Adaptive Air Suspension",
              "MMI Navigation Plus"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 1039,
            listPrice: 449000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      },
      {
        id: "q8",
        name: "Q8",
        image: "/models/audi/q8.webp",
        isActive: true,
        trims: [
          {
            id: "55-tfsi-quattro",
            name: "55 TFSI Quattro",
            features: [
              "3.0L V6 TFSI Engine",
              "340 ch",
              "Tiptronic 8-Speed Transmission",
              "Quattro All-Wheel Drive",
              "Adaptive Air Suspension",
              "MMI Navigation Plus",
              "Audi Virtual Cockpit",
              "Panoramic Sunroof"
            ],
            detailedFeatures: [], // Empty detailed features, will be loaded dynamically
            price: 1139,
            listPrice: 499000,
            priceMatrix: [], // Empty price matrix, will be loaded dynamically
            isActive: true,
          }
        ]
      }
    ]
  },
  { id: "bmw", name: "BMW", logo: "/brands/bmw.webp", isActive: true },
  { id: "byd", name: "BYD", logo: "/brands/byd.webp", isActive: true },
  { id: "chery", name: "Chery", logo: "/brands/chery.webp", isActive: true },
  { id: "chevrolet", name: "Chevrolet", logo: "/brands/chevrolet.webp", isActive: true },
  { id: "citroen", name: "Citroen", logo: "/brands/citroen.webp", isActive: true },
  { id: "cupra", name: "Cupra", logo: "/brands/cupra.webp", isActive: true },
  { id: "dacia", name: "Dacia", logo: "/brands/dacia.webp", isActive: true },
  { id: "fiat", name: "FIAT", logo: "/brands/fiat.webp", isActive: true },
  { id: "ford", name: "Ford", logo: "/brands/ford.webp", isActive: true },
  { id: "haval", name: "Haval", logo: "/brands/haval.webp", isActive: true },
  { id: "honda", name: "Honda", logo: "/brands/honda.webp", isActive: true },
  { id: "hyundai", name: "Hyundai", logo: "/brands/hyundai.webp", isActive: true },
  { id: "jaguar", name: "Jaguar", logo: "/brands/jaguar.webp", isActive: true },
  { id: "jeep", name: "Jeep", logo: "/brands/jeep.webp", isActive: true },
  { id: "kia", name: "Kia", logo: "/brands/kia.webp", isActive: true },
  { id: "landrover", name: "Land Rover", logo: "/brands/landrover.webp", isActive: true },
  { id: "mahindra", name: "Mahindra", logo: "/brands/mahindra.webp", isActive: true },
  { id: "mercedes", name: "Mercedes", logo: "/brands/mercedes.webp", isActive: true },
  { id: "mg", name: "MG", logo: "/brands/mg.webp", isActive: true },
  { id: "mini", name: "Mini", logo: "/brands/mini.webp", isActive: true },
  { id: "mitsubishi", name: "Mitsubishi", logo: "/brands/mitsubishi.webp", isActive: true },
  { id: "nissan", name: "Nissan", logo: "/brands/nissan.webp", isActive: true },
  { id: "opel", name: "Opel", logo: "/brands/opel.webp", isActive: true },
  { id: "peugeot", name: "Peugeot", logo: "/brands/peugeot.webp", isActive: true },
  { id: "porsche", name: "Porsche", logo: "/brands/porsche.webp", isActive: true },
  { id: "renault", name: "Renault", logo: "/brands/renault.webp", isActive: true },
  { id: "seat", name: "SEAT", logo: "/brands/seat.webp", isActive: true },
  { id: "skoda", name: "Skoda", logo: "/brands/skoda.webp", isActive: true },
  { id: "kgm", name: "KGM", logo: "/brands/kgm.webp", isActive: true },
  { id: "suzuki", name: "Suzuki", logo: "/brands/suzuki.webp", isActive: true },
  { id: "toyota", name: "Toyota", logo: "/brands/toyota.webp", isActive: true },
  { id: "volkswagen", name: "Volkswagen", logo: "/brands/volkswagen.webp", isActive: true },
  { id: "volvo", name: "Volvo", logo: "/brands/volvo.webp", isActive: true },
  { id: "wallys", name: "Wallys", logo: "/brands/wallys.webp", isActive: true }
];

// Default trims for models that don't have specific trims defined
export const defaultTrims: Trim[] = [
  {
    id: "basic",
    name: "Basic",
    features: ["Air Conditioning", "Power Windows", "Bluetooth"],
    detailedFeatures: [], // Empty detailed features, will be loaded dynamically
    price: 299,
    listPrice: 32000,
    priceMatrix: [], // Empty price matrix, will be loaded dynamically
    isActive: true,
  },
  {
    id: "comfort",
    name: "Comfort",
    features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
    detailedFeatures: [], // Empty detailed features, will be loaded dynamically
    price: 349,
    listPrice: 38000,
    priceMatrix: [], // Empty price matrix, will be loaded dynamically
    isActive: true,
  },
  {
    id: "premium",
    name: "Premium",
    features: [
      "Air Conditioning",
      "Power Windows",
      "Bluetooth",
      "Parking Sensors",
      "Cruise Control",
      "Leather Seats",
      "Navigation System",
    ],
    detailedFeatures: [], // Empty detailed features, will be loaded dynamically
    price: 399,
    listPrice: 45000,
    priceMatrix: [], // Empty price matrix, will be loaded dynamically
    isActive: true,
  },
];

// Helper functions to get data
export const getBrands = (): Brand[] => {
  return carData.filter(brand => brand.isActive);
};

export const getModels = (brandId: string): Model[] => {
  const brand = carData.find(b => b.id === brandId);
  return brand?.models?.filter(model => model.isActive) || [];
};

export const getTrims = (brandId: string, modelId: string): Trim[] => {
  const brand = carData.find(b => b.id === brandId);
  const model = brand?.models?.find(m => m.id === modelId);
  return model?.trims?.filter(trim => trim.isActive) || defaultTrims;
};

// Function to load price matrix for a trim
export const loadTrimPriceMatrix = async (brandId: string, modelId: string, trimId: string): Promise<PriceMatrix> => {
  const ref: PricingReference = { brandId, modelId, trimId };
  return await loadPriceMatrix(ref);
};

// Function to get price matrix for a trim (synchronous, from cache)
export const getTrimPriceMatrix = (brandId: string, modelId: string, trimId: string): PriceMatrix => {
  const ref: PricingReference = { brandId, modelId, trimId };
  return getPriceMatrix(ref);
};

// Function to load detailed features for a trim
export const loadTrimDetailedFeatures = async (brandId: string, modelId: string, trimId: string): Promise<FeatureGroup[]> => {
  const ref: FeaturesReference = { brandId, modelId, trimId };
  return await loadDetailedFeatures(ref);
};

// Function to get detailed features for a trim (synchronous, from cache)
export const getTrimDetailedFeatures = (brandId: string, modelId: string, trimId: string): FeatureGroup[] => {
  const ref: FeaturesReference = { brandId, modelId, trimId };
  return getDetailedFeatures(ref);
};

// Function to preload all price matrices and detailed features for active trims
export const preloadAllData = async (): Promise<void> => {
  const refs: PricingReference[] = [];
  const featureRefs: FeaturesReference[] = [];
  
  // Add references for all active trims
  carData.forEach(brand => {
    if (!brand.isActive) return;
    
    brand.models?.forEach(model => {
      if (!model.isActive) return;
      
      model.trims?.forEach(trim => {
        if (!trim.isActive) return;
        
        refs.push({
          brandId: brand.id,
          modelId: model.id,
          trimId: trim.id
        });
        
        featureRefs.push({
          brandId: brand.id,
          modelId: model.id,
          trimId: trim.id
        });
      });
    });
  });
  
  // Add references for default trims
  defaultTrims.forEach(trim => {
    if (!trim.isActive) return;
    
    refs.push({
      brandId: 'default',
      modelId: 'default',
      trimId: trim.id
    });
    
    featureRefs.push({
      brandId: 'default',
      modelId: 'default',
      trimId: trim.id
    });
  });
  
  // Preload all price matrices and detailed features
  await Promise.all([
    import('./pricing/pricing-loader').then(loader => 
      loader.preloadPriceMatrices(refs)
    ),
    import('./features/features-loader').then(loader => 
      loader.preloadDetailedFeatures(featureRefs)
    )
  ]);
};
