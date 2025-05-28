"use client"

import { useState, useEffect } from "react"
import { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { getTrimPriceMatrix, getTrimDetailedFeatures } from "@/data/offers"
import { Button } from "@/components/ui/button"
import { Dialog, DialogContent, DialogHeader, DialogTitle, DialogTrigger, DialogClose } from "@/components/ui/dialog"
import { Info } from "lucide-react"
import { getPriceFromMatrix } from "@/data/price-matrix"
import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs"

interface FeatureGroup {
  name: string;
  features: {
    name: string;
    value: string;
  }[];
}

interface Trim {
  trimCode: string;
  name: string;
  modelCode: string;
  fiscalPower: number;
  seats: number;
  cylinderCount: number;
  horsePower: number;
  fuelType: string;
  transmission: string;
  maxSpeedKph: number;
  extendedCharacteristicsUrl?: string;
  listPrice: number;
  isActive: boolean;
  fullInsurance0PercentPrice: number;
  fullInsurance4PercentPrice: number;
  maintenancePackagePrice: number;
  vignettesPrice: number;
  maxDurationMonths: number;
  geolocalisationPrice: number;
  purchaseOptionPrice: number;
  
  // Keep these properties for compatibility with existing code
  id?: string;
  code?: string;
  price?: number;
  features?: string[];
  priceMatrix?: any[];
  detailedFeatures?: FeatureGroup[];
}

interface TrimSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function TrimSelection({ data, setData }: TrimSelectionProps) {
  const [trims, setTrims] = useState<Trim[]>([])
  const [selectedTrimForDetails, setSelectedTrimForDetails] = useState<string | null>(null)
  const [isLoading, setIsLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)
  
  // Fetch trims from API
  useEffect(() => {
    if (!data.brand || !data.model) return
    
    const fetchTrims = async () => {
      try {
        setIsLoading(true)
        const apiUrl = process.env.NEXT_PUBLIC_API_URL || ''
        const response = await fetch(`${apiUrl}/api/Vehicles/brands/${data.brand}/models/${data.model}/trims`)
        
        if (!response.ok) {
          throw new Error('Failed to fetch trims')
        }
        
        const trimsData = await response.json()
        setTrims(trimsData)
      } catch (err) {
        console.error('Error fetching trims:', err)
        setError('Failed to load trims. Please try again later.')
      } finally {
        setIsLoading(false)
      }
    }
    
    fetchTrims()
  }, [data.brand, data.model])
  
  const handleTrimSelect = (trimId: string) => {
    setData({ ...data, trim: trimId })
  }

  // Format currency with 3 decimal places
  const formatCurrency = (num: number) => {
    if (num === 0) return "N/A"
    return num.toFixed(3).replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }
  
  // Convert fuelType enum value to human-readable string
  const getFuelTypeLabel = (fuelType: string | number) => {
    const fuelTypeStr = String(fuelType);
    switch (fuelTypeStr) {
      case "0":
      case "Essence":
        return "Essence"
      case "1":
      case "Diesel":
        return "Diesel"
      case "2":
      case "Hybrid":
        return "Hybride"
      case "3":
      case "LPG":
        return "GPL"
      case "4":
      case "PlugInHybrid":
        return "Hybride Rechargeable"
      case "5":
      case "LightHybrid":
        return "Hybride Léger"
      case "6":
      case "Electric":
        return "Électrique"
      default:
        return String(fuelType)
    }
  }
  
  // Convert transmission enum value to human-readable string
  const getTransmissionLabel = (transmission: string | number) => {
    const transmissionStr = String(transmission);
    switch (transmissionStr) {
      case "0":
      case "Manual":
        return "Manuelle"
      case "1":
      case "Automatique":
        return "Automatique"
      default:
        return String(transmission)
    }
  }

  // Get the selected trim for details
  const getSelectedTrimDetails = () => {
    if (!selectedTrimForDetails) return null
    return trims.find(trim => trim.id === selectedTrimForDetails)
  }

  const trimDetails = getSelectedTrimDetails()

  if (isLoading) {
    return (
      <div className="flex justify-center items-center h-40">
        <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-gray-900"></div>
      </div>
    )
  }

  if (error) {
    return <div className="text-red-500 text-center p-4">{error}</div>
  }
  
  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Sélectionnez une version</h3>

      <div className="grid grid-cols-1 gap-4">
        {trims.map((trim) => (
          <Card
            key={trim.trimCode}
            className={`cursor-pointer transition-all hover:shadow-md ${
              data.trim === trim.trimCode ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
            }`}
            onClick={() => handleTrimSelect(trim.trimCode)}
          >
            <CardContent className="p-4">
              <div className="flex justify-between items-center mb-2">
                <div className="flex items-center">
                  <h4 className="text-lg font-medium">{trim.name}</h4>
                  <Button 
                        variant="ghost" 
                        size="sm" 
                        className="ml-2 p-1 h-auto" 
                        onClick={(e) => {
                          e.stopPropagation();
                          if (trim.extendedCharacteristicsUrl) {
                            window.open(trim.extendedCharacteristicsUrl, '_blank');
                          } else {
                            window.open(`https://example.com/details/${trim.extendedCharacteristicsUrl}`, '_blank');
                          }
                        }}
                      >
                        <Info className="h-4 w-4 text-gray-500" />
                        <span className="sr-only">Détails</span>
                      </Button>
                </div>
                <div className="text-right">
                  <div className="text-lg font-bold">
                    {trim.price === 0 ? "N/A" : `TND x/mois`}
                  </div>
                  <div className="text-xs text-gray-500">
                    Prix du véhicule: TND {formatCurrency(trim.listPrice)}
                  </div>
                </div>
              </div>
              <div className="mt-2">
                <h5 className="text-sm font-medium text-gray-500 mb-1">Caractéristiques:</h5>
                <ul className="grid grid-cols-1 md:grid-cols-3 gap-1">
                  <li className="text-sm flex items-center">
                    <svg
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20"
                      fill="#4361ee"
                      className="h-4 w-4 mr-2 flex-shrink-0"
                    >
                      <path
                        fillRule="evenodd"
                        d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                        clipRule="evenodd"
                      />
                    </svg>
                    {trim.seats} sièges
                  </li>
                  <li className="text-sm flex items-center">
                    <svg
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20"
                      fill="#4361ee"
                      className="h-4 w-4 mr-2 flex-shrink-0"
                    >
                      <path
                        fillRule="evenodd"
                        d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                        clipRule="evenodd"
                      />
                    </svg>
                    {trim.cylinderCount} cylindres
                  </li>
                  <li className="text-sm flex items-center">
                    <svg
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20"
                      fill="#4361ee"
                      className="h-4 w-4 mr-2 flex-shrink-0"
                    >
                      <path
                        fillRule="evenodd"
                        d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                        clipRule="evenodd"
                      />
                    </svg>
                    {trim.horsePower} ch din
                  </li>
                  <li className="text-sm flex items-center">
                    <svg
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20"
                      fill="#4361ee"
                      className="h-4 w-4 mr-2 flex-shrink-0"
                    >
                      <path
                        fillRule="evenodd"
                        d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                        clipRule="evenodd"
                      />
                    </svg>
                    {getFuelTypeLabel(trim.fuelType)}
                  </li>
                  <li className="text-sm flex items-center">
                    <svg
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20"
                      fill="#4361ee"
                      className="h-4 w-4 mr-2 flex-shrink-0"
                    >
                      <path
                        fillRule="evenodd"
                        d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                        clipRule="evenodd"
                      />
                    </svg>
                    {getTransmissionLabel(trim.transmission)}
                  </li>
                  <li className="text-sm flex items-center">
                    <svg
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 20 20"
                      fill="#4361ee"
                      className="h-4 w-4 mr-2 flex-shrink-0"
                    >
                      <path
                        fillRule="evenodd"
                        d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                        clipRule="evenodd"
                      />
                    </svg>
                    {trim.maxSpeedKph} km/h
                  </li>
                </ul>
              </div>
            </CardContent>
          </Card>
        ))}
      </div>
    </div>
  )
}
