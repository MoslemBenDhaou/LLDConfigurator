"use client"

import { useEffect, useState } from "react"
import Image from "next/image"
import type { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"

interface Model {
  code: string;
  name: string;
  imgUrl: string;
  isActive: boolean;
}

interface ModelSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function ModelSelection({ data, setData }: ModelSelectionProps) {
  const [models, setModels] = useState<Model[]>([])
  const [isLoading, setIsLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    if (!data.brand) return

    const fetchModels = async () => {
      try {
        setIsLoading(true)
        const apiUrl = process.env.NEXT_PUBLIC_API_URL || ''
        const response = await fetch(`${apiUrl}/api/Vehicles/brands/${data.brand}/models`)
        
        if (!response.ok) {
          throw new Error('Failed to fetch models')
        }
        
        const modelsData = await response.json()
        setModels(modelsData)
      } catch (err) {
        console.error('Error fetching models:', err)
        setError('Failed to load models. Please try again later.')
      } finally {
        setIsLoading(false)
      }
    }

    fetchModels()
  }, [data.brand])

  const handleModelSelect = (modelCode: string) => {
    setData({ ...data, model: modelCode, trim: "" })
  }

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
      <h3 className="text-xl font-bold">Sélectionnez un modèle</h3>

      <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-4">
        {models
          .filter(model => model.isActive)
          .map((model) => (
            <Card
              key={model.code}
              className={`cursor-pointer transition-all hover:shadow-md ${
                data.model === model.code ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
              }`}
              onClick={() => handleModelSelect(model.code)}
            >
              <CardContent className="p-4">
                <div className="relative h-32 w-full mb-2">
                  <Image
                    src={model.imgUrl}
                    alt={model.name}
                    fill
                    className="object-cover rounded-md"
                  />
                </div>
                <h4 className="font-medium text-center">{model.name}</h4>
              </CardContent>
            </Card>
          ))}
      </div>
    </div>
  )
}
