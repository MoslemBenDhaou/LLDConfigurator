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

import { PriceMatrix } from "./price-matrix";

export type Trim = {
  id: string;
  name: string;
  features: TrimFeature[];
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
            price: 449,
            listPrice: 198000,
            priceMatrix: [
              // 12 months
              {
                duration: 12,
                kilometers: 10000,
                prices: { advance0: 449, advance10: 425, advance20: 405, advance30: 385 }
              },
              {
                duration: 12,
                kilometers: 15000,
                prices: { advance0: 469, advance10: 445, advance20: 425, advance30: 405 }
              },
              {
                duration: 12,
                kilometers: 20000,
                prices: { advance0: 489, advance10: 465, advance20: 445, advance30: 425 }
              },
              {
                duration: 12,
                kilometers: 25000,
                prices: { advance0: 509, advance10: 485, advance20: 465, advance30: 445 }
              },
              {
                duration: 12,
                kilometers: 30000,
                prices: { advance0: 529, advance10: 505, advance20: 485, advance30: 465 }
              },
              
              // 24 months
              {
                duration: 24,
                kilometers: 20000,
                prices: { advance0: 429, advance10: 405, advance20: 385, advance30: 365 }
              },
              {
                duration: 24,
                kilometers: 30000,
                prices: { advance0: 449, advance10: 425, advance20: 405, advance30: 385 }
              },
              {
                duration: 24,
                kilometers: 40000,
                prices: { advance0: 469, advance10: 445, advance20: 425, advance30: 405 }
              },
              {
                duration: 24,
                kilometers: 50000,
                prices: { advance0: 489, advance10: 465, advance20: 445, advance30: 425 }
              },
              {
                duration: 24,
                kilometers: 60000,
                prices: { advance0: 509, advance10: 485, advance20: 465, advance30: 445 }
              },
              
              // 36 months
              {
                duration: 36,
                kilometers: 30000,
                prices: { advance0: 409, advance10: 385, advance20: 365, advance30: 345 }
              },
              {
                duration: 36,
                kilometers: 45000,
                prices: { advance0: 429, advance10: 405, advance20: 385, advance30: 365 }
              },
              {
                duration: 36,
                kilometers: 60000,
                prices: { advance0: 449, advance10: 425, advance20: 405, advance30: 385 }
              },
              {
                duration: 36,
                kilometers: 75000,
                prices: { advance0: 469, advance10: 445, advance20: 425, advance30: 405 }
              },
              {
                duration: 36,
                kilometers: 90000,
                prices: { advance0: 489, advance10: 465, advance20: 445, advance30: 425 }
              },
              
              // 48 months
              {
                duration: 48,
                kilometers: 40000,
                prices: { advance0: 389, advance10: 365, advance20: 345, advance30: 325 }
              },
              {
                duration: 48,
                kilometers: 60000,
                prices: { advance0: 409, advance10: 385, advance20: 365, advance30: 345 }
              },
              {
                duration: 48,
                kilometers: 80000,
                prices: { advance0: 429, advance10: 405, advance20: 385, advance30: 365 }
              },
              {
                duration: 48,
                kilometers: 100000,
                prices: { advance0: 449, advance10: 425, advance20: 405, advance30: 385 }
              },
              {
                duration: 48,
                kilometers: 120000,
                prices: { advance0: 469, advance10: 445, advance20: 425, advance30: 405 }
              },
              
              // 60 months
              {
                duration: 60,
                kilometers: 50000,
                prices: { advance0: 369, advance10: 345, advance20: 325, advance30: 305 }
              },
              {
                duration: 60,
                kilometers: 75000,
                prices: { advance0: 389, advance10: 365, advance20: 345, advance30: 325 }
              },
              {
                duration: 60,
                kilometers: 100000,
                prices: { advance0: 409, advance10: 385, advance20: 365, advance30: 345 }
              },
              {
                duration: 60,
                kilometers: 125000,
                prices: { advance0: 429, advance10: 405, advance20: 385, advance30: 365 }
              },
              {
                duration: 60,
                kilometers: 150000,
                prices: { advance0: 449, advance10: 425, advance20: 405, advance30: 385 }
              }
            ],
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
            price: 499,
            listPrice: 265000,
            priceMatrix: [
              // 12 months
              {
                duration: 12,
                kilometers: 10000,
                prices: { advance0: 499, advance10: 475, advance20: 455, advance30: 435 }
              },
              {
                duration: 12,
                kilometers: 15000,
                prices: { advance0: 519, advance10: 495, advance20: 475, advance30: 455 }
              },
              {
                duration: 12,
                kilometers: 20000,
                prices: { advance0: 539, advance10: 515, advance20: 495, advance30: 475 }
              },
              {
                duration: 12,
                kilometers: 25000,
                prices: { advance0: 559, advance10: 535, advance20: 515, advance30: 495 }
              },
              {
                duration: 12,
                kilometers: 30000,
                prices: { advance0: 579, advance10: 555, advance20: 535, advance30: 515 }
              },
              
              // 24 months
              {
                duration: 24,
                kilometers: 20000,
                prices: { advance0: 479, advance10: 455, advance20: 435, advance30: 415 }
              },
              {
                duration: 24,
                kilometers: 30000,
                prices: { advance0: 499, advance10: 475, advance20: 455, advance30: 435 }
              },
              {
                duration: 24,
                kilometers: 40000,
                prices: { advance0: 519, advance10: 495, advance20: 475, advance30: 455 }
              },
              {
                duration: 24,
                kilometers: 50000,
                prices: { advance0: 539, advance10: 515, advance20: 495, advance30: 475 }
              },
              {
                duration: 24,
                kilometers: 60000,
                prices: { advance0: 559, advance10: 535, advance20: 515, advance30: 495 }
              },
              
              // 36 months
              {
                duration: 36,
                kilometers: 30000,
                prices: { advance0: 459, advance10: 435, advance20: 415, advance30: 395 }
              },
              {
                duration: 36,
                kilometers: 45000,
                prices: { advance0: 479, advance10: 455, advance20: 435, advance30: 415 }
              },
              {
                duration: 36,
                kilometers: 60000,
                prices: { advance0: 499, advance10: 475, advance20: 455, advance30: 435 }
              },
              {
                duration: 36,
                kilometers: 75000,
                prices: { advance0: 519, advance10: 495, advance20: 475, advance30: 455 }
              },
              {
                duration: 36,
                kilometers: 90000,
                prices: { advance0: 539, advance10: 515, advance20: 495, advance30: 475 }
              },
              
              // 48 months
              {
                duration: 48,
                kilometers: 40000,
                prices: { advance0: 439, advance10: 415, advance20: 395, advance30: 375 }
              },
              {
                duration: 48,
                kilometers: 60000,
                prices: { advance0: 459, advance10: 435, advance20: 415, advance30: 395 }
              },
              {
                duration: 48,
                kilometers: 80000,
                prices: { advance0: 479, advance10: 455, advance20: 435, advance30: 415 }
              },
              {
                duration: 48,
                kilometers: 100000,
                prices: { advance0: 499, advance10: 475, advance20: 455, advance30: 435 }
              },
              {
                duration: 48,
                kilometers: 120000,
                prices: { advance0: 519, advance10: 495, advance20: 475, advance30: 455 }
              },
              
              // 60 months
              {
                duration: 60,
                kilometers: 50000,
                prices: { advance0: 419, advance10: 395, advance20: 375, advance30: 355 }
              },
              {
                duration: 60,
                kilometers: 75000,
                prices: { advance0: 439, advance10: 415, advance20: 395, advance30: 375 }
              },
              {
                duration: 60,
                kilometers: 100000,
                prices: { advance0: 459, advance10: 435, advance20: 415, advance30: 395 }
              },
              {
                duration: 60,
                kilometers: 125000,
                prices: { advance0: 479, advance10: 455, advance20: 435, advance30: 415 }
              },
              {
                duration: 60,
                kilometers: 150000,
                prices: { advance0: 499, advance10: 475, advance20: 455, advance30: 435 }
              }
            ],
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
        id: "a3",
        name: "A3",
        image: "/models/audi/a3.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      },
      {
        id: "a4",
        name: "A4",
        image: "/models/audi/a4.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
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
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      },
      {
        id: "q5",
        name: "Q5",
        image: "/models/audi/q5.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      }
    ]
  },
  {
    id: "bmw",
    name: "BMW",
    logo: "/brands/bmw.webp",
    isActive: true,
    models: [
      {
        id: "3series",
        name: "3 Series",
        image: "/models/bmw/3series.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      },
      {
        id: "5series",
        name: "5 Series",
        image: "/models/bmw/5series.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      },
      {
        id: "x3",
        name: "X3",
        image: "/models/bmw/x3.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      }
    ]
  },
  {
    id: "mercedes",
    name: "Mercedes",
    logo: "/brands/mercedes.webp",
    isActive: true,
    models: [
      {
        id: "cclass",
        name: "C-Class",
        image: "/models/mercedes/cclass.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      },
      {
        id: "eclass",
        name: "E-Class",
        image: "/models/mercedes/eclass.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      },
      {
        id: "glc",
        name: "GLC",
        image: "/models/mercedes/glc.webp",
        isActive: true,
        trims: [
          {
            id: "basic",
            name: "Basic",
            features: ["Air Conditioning", "Power Windows", "Bluetooth"],
            price: 299,
            listPrice: 32000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          },
          {
            id: "comfort",
            name: "Comfort",
            features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
            price: 349,
            listPrice: 38000,
            priceMatrix: [], // Empty price matrix
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
            price: 399,
            listPrice: 45000,
            priceMatrix: [], // Empty price matrix
            isActive: true,
          }
        ]
      }
    ]
  },
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
    price: 299,
    listPrice: 32000,
    priceMatrix: [], // Empty price matrix
    isActive: true,
  },
  {
    id: "comfort",
    name: "Comfort",
    features: ["Air Conditioning", "Power Windows", "Bluetooth", "Parking Sensors", "Cruise Control"],
    price: 349,
    listPrice: 38000,
    priceMatrix: [], // Empty price matrix
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
    price: 399,
    listPrice: 45000,
    priceMatrix: [], // Empty price matrix
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
