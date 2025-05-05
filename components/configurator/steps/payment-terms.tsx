"use client"

import { useEffect, useState } from "react"
import { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { Label } from "@/components/ui/label"
import { RadioGroup, RadioGroupItem } from "@/components/ui/radio-group"
import { Tooltip, TooltipContent, TooltipProvider, TooltipTrigger } from "@/components/ui/tooltip"
import { Info } from "lucide-react"
import { getTrims, getTrimPriceMatrix } from "@/data/offers"
import { getPriceFromMatrix } from "@/data/price-matrix"

interface PaymentTermsProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function PaymentTerms({ data, setData }: PaymentTermsProps) {
  const [monthlyPrices, setMonthlyPrices] = useState<Record<string, number>>({})
  
  // Get estimated vehicle list price based on trim
  const getVehicleListPrice = () => {
    // Get the selected trim
    const trims = getTrims(data.brand, data.model)
    const selectedTrim = trims.find(trim => trim.id === data.trim)
    
    if (!selectedTrim) return 32000 // Default value if no trim is selected

    // Use the listPrice property from the trim data
    return selectedTrim.listPrice
  }

  const vehicleListPrice = getVehicleListPrice()

  // Load price matrix and calculate prices for all advance options
  useEffect(() => {
    if (!data.trim) return

    // Get the selected trim
    const trims = getTrims(data.brand, data.model)
    const selectedTrim = trims.find(trim => trim.id === data.trim)
    
    if (!selectedTrim) return

    // Get the price matrix for the selected trim
    const priceMatrix = getTrimPriceMatrix(data.brand, data.model, data.trim)
    
    // Update the trim's price matrix if it's empty
    if (selectedTrim.priceMatrix.length === 0 && priceMatrix.length > 0) {
      selectedTrim.priceMatrix = priceMatrix
    }
    
    // Calculate monthly prices for all advance options
    const prices: Record<string, number> = {}
    
    // Calculate for each advance percentage option
    for (const option of [0, 10, 20, 30]) {
      if (priceMatrix.length > 0) {
        // Use the price matrix to get the price
        prices[option] = getPriceFromMatrix(priceMatrix, data.duration, data.kilometers, option)
      } else {
        // Fallback calculation if no price matrix is available
        const basePricePerMonth = selectedTrim.price

        // Base financing amount after first rate is applied
        const financingAmount = vehicleListPrice * (1 - option / 100)

        // Calculate monthly payment based on financing amount and duration
        const baseMonthlyPayment = financingAmount / data.duration

        // Apply other adjustments
        const durationDiscount = Math.min(20, (data.duration - 12) * 0.4)
        const adjustedMonthlyPayment = baseMonthlyPayment * (1 - durationDiscount / 100)

        prices[option] = Math.round(adjustedMonthlyPayment)
      }
    }
    
    setMonthlyPrices(prices)
  }, [data.brand, data.model, data.trim, data.duration, data.kilometers, vehicleListPrice])

  const handleFirstRateChange = (value: string) => {
    setData({ ...data, firstRatePercentage: Number.parseInt(value) })
  }

  // Calculate first rate amount based on percentage
  const getFirstRateAmount = (percentage: number) => {
    return Math.round((percentage / 100) * vehicleListPrice)
  }

  // Get monthly price based on first rate percentage
  const getMonthlyPrice = (firstRatePercentage: number) => {
    return monthlyPrices[firstRatePercentage] || 0
  }

  // Format number with thousand separators and 3 decimal places
  const formatCurrency = (num: number) => {
    return num.toFixed(3).replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }

  const firstRateOptions = [
    { value: "0", label: "Pas d'apport initial", description: "Paiements mensuels standards" },
    { value: "10", label: "Apport initial de 10%", description: "Réduisez vos mensualités" },
    { value: "20", label: "Apport initial de 20%", description: "Réduisez davantage vos mensualités" },
    { value: "30", label: "Apport initial de 30%", description: "Réduisez considérablement vos mensualités" },
  ]

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Sélectionnez les conditions de paiement</h3>

      <div className="mb-6">
        <div className="flex items-center mb-2">
          <span className="text-sm font-medium">Apport initial</span>
          <TooltipProvider>
            <Tooltip>
              <TooltipTrigger asChild>
                <span className="ml-1 cursor-help">
                  <Info className="h-4 w-4 text-gray-400" />
                </span>
              </TooltipTrigger>
              <TooltipContent>
                <p className="max-w-xs">
                  Un apport initial est un pourcentage du prix du véhicule (TND
                  {formatCurrency(vehicleListPrice)}) que vous payez à l'avance. Cela réduit vos mensualités pendant la
                  durée du contrat.
                </p>
              </TooltipContent>
            </Tooltip>
          </TooltipProvider>
        </div>
      </div>

      <RadioGroup value={data.firstRatePercentage.toString()} onValueChange={handleFirstRateChange}>
        <div className="grid grid-cols-1 gap-4">
          {firstRateOptions.map((option) => (
            <Card
              key={option.value}
              className={`cursor-pointer transition-all hover:shadow-md ${
                data.firstRatePercentage.toString() === option.value ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
              }`}
              onClick={() => handleFirstRateChange(option.value)}
            >
              <CardContent className="p-4">
                <div className="flex items-start space-x-3 py-2">
                  <RadioGroupItem
                    value={option.value}
                    id={option.value}
                    className="mt-1"
                    onClick={(e) => e.stopPropagation()}
                  />
                  <div className="flex-1">
                    <Label htmlFor={option.value} className="text-base font-medium cursor-pointer">
                      {option.label}
                    </Label>
                    <p className="text-sm text-gray-500">{option.description}</p>
                    {option.value !== "0" && (
                      <p className="text-sm text-gray-500 mt-1">
                        Montant de l'apport: TND {formatCurrency(getFirstRateAmount(Number.parseInt(option.value)))}
                      </p>
                    )}
                  </div>
                  <div className="text-right">
                    <p className="text-lg font-bold">
                      TND {formatCurrency(getMonthlyPrice(Number.parseInt(option.value)))}/mois
                    </p>
                    {option.value !== "0" && (
                      <p className="text-sm text-green-600">
                        Économisez TND{" "}
                        {formatCurrency(
                          (getMonthlyPrice(0) - getMonthlyPrice(Number.parseInt(option.value))) * data.duration
                        )}
                      </p>
                    )}
                  </div>
                </div>
              </CardContent>
            </Card>
          ))}
        </div>
      </RadioGroup>
    </div>
  )
}
