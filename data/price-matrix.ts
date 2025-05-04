// Types for the price matrix
export type AdvancePaymentPrices = {
  advance0: number;  // 0% advance payment
  advance10: number; // 10% advance payment
  advance20: number; // 20% advance payment
  advance30: number; // 30% advance payment
};

export type PricePoint = {
  duration: number;   // Duration in months (12-60)
  kilometers: number; // Total kilometers for the contract
  prices: AdvancePaymentPrices;
};

export type PriceMatrix = PricePoint[];

// Helper function to get the price for a specific duration, kilometers, and advance percentage
export const getPriceFromMatrix = (
  priceMatrix: PriceMatrix,
  duration: number,
  kilometers: number,
  advancePercentage: number
): number => {
  // If the price matrix is empty, return 0
  if (!priceMatrix || priceMatrix.length === 0) {
    return 0;
  }
  
  // Find the closest price point in the matrix
  const pricePoint = findClosestPricePoint(priceMatrix, duration, kilometers);
  
  if (!pricePoint) {
    return 0; // Return 0 if no price point is found
  }

  // Get the price based on the advance percentage
  switch (advancePercentage) {
    case 0:
      return pricePoint.prices.advance0;
    case 10:
      return pricePoint.prices.advance10;
    case 20:
      return pricePoint.prices.advance20;
    case 30:
      return pricePoint.prices.advance30;
    default:
      return pricePoint.prices.advance0; // Default to 0% advance
  }
};

// Helper function to find the closest price point in the matrix
const findClosestPricePoint = (
  priceMatrix: PriceMatrix,
  duration: number,
  kilometers: number
): PricePoint | undefined => {
  // First, try to find an exact match
  const exactMatch = priceMatrix.find(
    point => point.duration === duration && point.kilometers === kilometers
  );

  if (exactMatch) {
    return exactMatch;
  }

  // If no exact match, find the closest match
  // This is a simple implementation that prioritizes duration first, then kilometers
  const durationMatches = priceMatrix.filter(point => point.duration === duration);
  
  if (durationMatches.length > 0) {
    // Find the closest kilometers match
    return durationMatches.reduce((closest, current) => {
      const closestDiff = Math.abs(closest.kilometers - kilometers);
      const currentDiff = Math.abs(current.kilometers - kilometers);
      return currentDiff < closestDiff ? current : closest;
    });
  }

  // If no duration match, find the closest duration and then closest kilometers
  return priceMatrix.reduce((closest, current) => {
    const closestDurationDiff = Math.abs(closest.duration - duration);
    const currentDurationDiff = Math.abs(current.duration - duration);
    
    if (currentDurationDiff < closestDurationDiff) {
      return current;
    } else if (currentDurationDiff === closestDurationDiff) {
      const closestKmDiff = Math.abs(closest.kilometers - kilometers);
      const currentKmDiff = Math.abs(current.kilometers - kilometers);
      return currentKmDiff < closestKmDiff ? current : closest;
    }
    
    return closest;
  });
};
