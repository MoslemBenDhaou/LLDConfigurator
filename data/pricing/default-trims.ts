// Default pricing matrices for generic trims
import { PriceMatrix } from "../price-matrix";

// Basic trim pricing
export const basicPriceMatrix: PriceMatrix = [
  // 12 months
  {
    duration: 12,
    kilometers: 10000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 24,
    kilometers: 20000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 36,
    kilometers: 30000,
    prices: { advance0:   0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 48,
    kilometers: 40000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 60,
    kilometers: 50000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  }
];

// Comfort trim pricing
export const comfortPriceMatrix: PriceMatrix = [
  // 12 months
  {
    duration: 12,
    kilometers: 10000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 24,
    kilometers: 20000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 36,
    kilometers: 30000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 48,
    kilometers: 40000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 60,
    kilometers: 50000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  }
];

// Premium trim pricing
export const premiumPriceMatrix: PriceMatrix = [
  // 12 months
  {
    duration: 12,
    kilometers: 10000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 24,
    kilometers: 20000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 36,
    kilometers: 30000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 48,
    kilometers: 40000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  },
  {
    duration: 60,
    kilometers: 50000,
    prices: { advance0: 0, advance10: 0, advance20: 0, advance30: 0 }
  }
];

// Map of default price matrices by trim ID
export const defaultPriceMatrices: Record<string, PriceMatrix> = {
  basic: basicPriceMatrix,
  comfort: comfortPriceMatrix,
  premium: premiumPriceMatrix
};
