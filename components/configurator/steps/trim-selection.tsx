"use client"

import { useState, useEffect } from "react"
import { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { getTrims, getTrimPriceMatrix, getTrimDetailedFeatures } from "@/data/offers"
import { Button } from "@/components/ui/button"
import { Dialog, DialogContent, DialogHeader, DialogTitle, DialogTrigger, DialogClose } from "@/components/ui/dialog"
import { Info } from "lucide-react"
import { getPriceFromMatrix } from "@/data/price-matrix"
import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs"

interface TrimSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function TrimSelection({ data, setData }: TrimSelectionProps) {
  // Get trims from the centralized data file based on selected brand and model
  const trims = getTrims(data.brand, data.model)
  const [selectedTrimForDetails, setSelectedTrimForDetails] = useState<string | null>(null)
  
  // Load price matrices and detailed features for all trims
  useEffect(() => {
    // Ensure each trim has its price matrix and detailed features loaded
    trims.forEach(trim => {
      // Load price matrix
      const priceMatrix = getTrimPriceMatrix(data.brand, data.model, trim.id)
      
      // Update the trim's price matrix if it's empty
      if (trim.priceMatrix.length === 0 && priceMatrix.length > 0) {
        trim.priceMatrix = priceMatrix
      }
      
      // Update the base price based on the price matrix if available
      if (priceMatrix.length > 0) {
        // Use the default duration and kilometers from the wizard
        const price = getPriceFromMatrix(priceMatrix, data.duration, data.kilometers, data.firstRatePercentage)
        if (price > 0) {
          trim.price = price
        }
      }
      
      // Load detailed features
      const detailedFeatures = getTrimDetailedFeatures(data.brand, data.model, trim.id)
      
      // Update the trim's detailed features if they're empty
      if (trim.detailedFeatures?.length === 0 && detailedFeatures.length > 0) {
        trim.detailedFeatures = detailedFeatures
      }
    })
  }, [data.brand, data.model, data.duration, data.kilometers, data.firstRatePercentage, trims])

  const handleTrimSelect = (trimId: string) => {
    setData({ ...data, trim: trimId })
  }

  // Format currency with 3 decimal places
  const formatCurrency = (num: number) => {
    if (num === 0) return "N/A"
    return num.toFixed(3).replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }

  // Get the selected trim for details
  const getSelectedTrimDetails = () => {
    if (!selectedTrimForDetails) return null
    return trims.find(trim => trim.id === selectedTrimForDetails)
  }

  const trimDetails = getSelectedTrimDetails()

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Sélectionnez une version</h3>

      <div className="grid grid-cols-1 gap-4">
        {trims.map((trim) => (
          <Card
            key={trim.id}
            className={`cursor-pointer transition-all hover:shadow-md ${
              data.trim === trim.id ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
            }`}
            onClick={() => handleTrimSelect(trim.id)}
          >
            <CardContent className="p-4">
              <div className="flex justify-between items-center mb-2">
                <div className="flex items-center">
                  <h4 className="text-lg font-medium">{trim.name}</h4>
                  <Dialog>
                    <DialogTrigger asChild>
                      <Button 
                        variant="ghost" 
                        size="sm" 
                        className="ml-2 p-1 h-auto" 
                        onClick={(e) => {
                          e.stopPropagation();
                          setSelectedTrimForDetails(trim.id);
                        }}
                      >
                        <Info className="h-4 w-4 text-gray-500" />
                        <span className="sr-only">Détails</span>
                      </Button>
                    </DialogTrigger>
                    <DialogContent className="max-w-none w-[95vw] md:w-[85vw] lg:w-[75vw]">
                      <DialogHeader>
                        <DialogTitle className="text-xl">{trim.name} - Caractéristiques complètes</DialogTitle>
                      </DialogHeader>
                      <div className="mt-4 space-y-4">
                        <div>
                          <h4 className="font-medium text-lg">Prix</h4>
                          <p className="text-lg font-bold">TND {formatCurrency(trim.price)}/mois</p>
                          <p className="text-sm text-gray-500">Prix du véhicule: TND {formatCurrency(trim.listPrice)}</p>
                        </div>
                        
                        {trim.detailedFeatures && trim.detailedFeatures.length > 0 ? (
                          <Tabs defaultValue={trim.detailedFeatures[0]?.name || "features"} className="w-full">
                            <div className="border rounded-md">
                              <TabsList className="w-full flex-wrap justify-start h-auto p-1">
                                {trim.detailedFeatures.map((group) => (
                                  <TabsTrigger 
                                    key={group.name} 
                                    value={group.name} 
                                    className="px-3 py-1.5 text-sm"
                                  >
                                    {group.name}
                                  </TabsTrigger>
                                ))}
                              </TabsList>
                            </div>
                            
                            {trim.detailedFeatures.map((group) => (
                              <TabsContent key={group.name} value={group.name} className="pt-4">
                                <h4 className="font-medium text-lg mb-2">{group.name}</h4>
                                <div className="grid grid-cols-1 md:grid-cols-2 gap-2">
                                  {group.features.map((feature, index) => (
                                    <div key={index} className="flex items-start border-b border-gray-100 pb-1">
                                      <div className="w-1/2 font-medium text-sm">{feature.name}</div>
                                      <div className="w-1/2 text-sm">{feature.value}</div>
                                    </div>
                                  ))}
                                </div>
                              </TabsContent>
                            ))}
                          </Tabs>
                        ) : (
                          <div>
                            <h4 className="font-medium text-lg">Caractéristiques</h4>
                            <ul className="grid grid-cols-1 gap-2 mt-2">
                              {trim.features.map((feature, index) => (
                                <li key={index} className="flex items-start">
                                  <svg
                                    xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 20 20"
                                    fill="#4361ee"
                                    className="h-5 w-5 mr-2 flex-shrink-0 mt-0.5"
                                  >
                                    <path
                                      fillRule="evenodd"
                                      d="M16.704 4.153a.75.75 0 01.143 1.052l-8 10.5a.75.75 0 01-1.127.075l-4.5-4.5a.75.75 0 011.06-1.06l3.894 3.893 7.48-9.817a.75.75 0 011.05-.143z"
                                      clipRule="evenodd"
                                    />
                                  </svg>
                                  <span>{feature}</span>
                                </li>
                              ))}
                            </ul>
                          </div>
                        )}
                        
                        <div className="pt-4 flex justify-end">
                          <DialogClose asChild>
                            <Button>Fermer</Button>
                          </DialogClose>
                        </div>
                      </div>
                    </DialogContent>
                  </Dialog>
                </div>
                <span className="text-lg font-bold">
                  {trim.price === 0 ? "N/A" : `TND ${formatCurrency(trim.price)}/mois`}
                </span>
              </div>
              <div className="mt-2">
                <h5 className="text-sm font-medium text-gray-500 mb-1">Caractéristiques:</h5>
                <ul className="grid grid-cols-1 md:grid-cols-2 gap-1">
                  {trim.features.slice(0, 6).map((feature, index) => (
                    <li key={index} className="text-sm flex items-center">
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
                      {feature}
                    </li>
                  ))}
                </ul>
                {trim.features.length > 6 && (
                  <p className="text-xs text-gray-500 mt-2 italic">
                    + {trim.features.length - 6} autres caractéristiques
                  </p>
                )}
              </div>
            </CardContent>
          </Card>
        ))}
      </div>
    </div>
  )
}
