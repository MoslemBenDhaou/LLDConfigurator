"use client"

import { useState, useEffect } from "react"
import { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { Slider } from "@/components/ui/slider"
import { Tooltip, TooltipContent, TooltipProvider, TooltipTrigger } from "@/components/ui/tooltip"
import { Info } from "lucide-react"
import { getTrims } from "@/data/offers"
import { getPriceFromMatrix } from "@/data/price-matrix"

interface DurationSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function DurationSelection({ data, setData }: DurationSelectionProps) {
  // Calculate max yearly kilometers based on duration
  const [maxYearlyKm, setMaxYearlyKm] = useState(30000)
  const [maxTotalKm, setMaxTotalKm] = useState(150000)

  // Calculate yearly kilometers based on total and duration
  const yearlyKilometers = Math.round(data.kilometers / (data.duration / 12))

  // Update max kilometers when duration changes
  useEffect(() => {
    // For 60 months, max yearly is 30,000 (150,000 total)
    // For shorter durations, max yearly is 30,000 but total can't exceed 150,000
    const durationInYears = data.duration / 12
    const calculatedMaxYearly = Math.min(30000, Math.floor(150000 / durationInYears))
    setMaxYearlyKm(calculatedMaxYearly)

    // Calculate max total kilometers based on duration and round to nearest 5000
    const calculatedMaxTotal = Math.min(150000, Math.floor(calculatedMaxYearly * durationInYears))
    const roundedMaxTotal = Math.ceil(calculatedMaxTotal / 5000) * 5000
    setMaxTotalKm(roundedMaxTotal)

    // Adjust kilometers if they exceed the new maximum
    if (data.kilometers > roundedMaxTotal) {
      setData({ ...data, kilometers: roundedMaxTotal })
    }
  }, [data.duration, setData, data])

  const handleDurationChange = (values: number[]) => {
    setData({ ...data, duration: values[0] })
  }

  const handleKilometersChange = (values: number[]) => {
    setData({ ...data, kilometers: values[0] })
  }

  // Format number with thousand separators
  const formatNumber = (num: number) => {
    return num.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }

  // Format currency with 3 decimal places
  const formatCurrency = (num: number) => {
    return num.toFixed(3).replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }

  // Get the monthly price based on the selected trim, duration, and kilometers
  const getMonthlyPrice = () => {
    if (!data.trim) return 0

    // Get the selected trim
    const trims = getTrims(data.brand, data.model)
    const selectedTrim = trims.find(trim => trim.id === data.trim)
    
    if (!selectedTrim) return 0

    // Use the price matrix to get the price
    return getPriceFromMatrix(selectedTrim.priceMatrix, data.duration, data.kilometers, 0)
  }

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Sélectionnez la durée et les kilomètres</h3>

      <Card>
        <CardContent className="p-6">
          <div>
            <div className="flex justify-between items-center mb-2">
              <span className="text-sm font-medium">Durée</span>
              <span className="text-sm font-bold">{data.duration} mois</span>
            </div>
            <Slider
              value={[data.duration]}
              min={12}
              max={60}
              step={12}
              onValueChange={handleDurationChange}
              className="my-6"
            />
            <div className="flex justify-between text-xs text-gray-500">
              <span>12 mois</span>
              <span>36 mois</span>
              <span>60 mois</span>
            </div>
          </div>

          <div className="mt-8">
            <div className="flex justify-between items-center mb-2">
              <div className="flex items-center">
                <span className="text-sm font-medium">Kilomètres</span>
                <TooltipProvider>
                  <Tooltip>
                    <TooltipTrigger asChild>
                      <span className="ml-1 cursor-help">
                        <Info className="h-4 w-4 text-gray-400" />
                      </span>
                    </TooltipTrigger>
                    <TooltipContent>
                      <p className="max-w-xs">
                        Le kilométrage total pour la durée du contrat. Maximum de 30,000 km par an.
                      </p>
                    </TooltipContent>
                  </Tooltip>
                </TooltipProvider>
              </div>
              <span className="text-sm font-bold">{formatNumber(data.kilometers)} km</span>
            </div>
            <Slider
              value={[data.kilometers]}
              min={5000}
              max={maxTotalKm}
              step={5000}
              onValueChange={handleKilometersChange}
              className="my-6"
            />
            <div className="flex justify-between text-xs text-gray-500">
              <span>5,000 km</span>
              <span>{formatNumber(Math.round(maxTotalKm / 2) - (Math.round(maxTotalKm / 2) % 5000))} km</span>
              <span>{formatNumber(maxTotalKm)} km</span>
            </div>
            <div className="mt-2 text-sm text-gray-600">
              <span className="font-medium">{formatNumber(yearlyKilometers)} km</span> par an
            </div>
          </div>

          <div className="mt-8 p-4 bg-gray-50 rounded-lg">
            <div className="flex justify-between items-center">
              <div>
                <p className="text-sm text-gray-500">Paiement mensuel estimé</p>
                <p className="text-2xl font-bold">TND {formatCurrency(getMonthlyPrice())}</p>
              </div>
              <div className="text-right">
                <p className="text-sm text-gray-500">Valeur du contrat</p>
                <p className="text-lg font-semibold">TND {formatCurrency(getMonthlyPrice() * data.duration)}</p>
              </div>
            </div>
          </div>
        </CardContent>
      </Card>

      <div className="text-sm text-gray-500">
        <p>* Les prix sont des estimations et peuvent varier en fonction de la configuration finale et de l'approbation du crédit.</p>
        <p>* Les durées plus longues offrent des taux mensuels meilleurs.</p>
      </div>
    </div>
  )
}