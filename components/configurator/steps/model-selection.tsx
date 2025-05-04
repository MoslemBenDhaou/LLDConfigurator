"use client"

import Image from "next/image"
import type { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { getModels } from "@/data/offers"

interface ModelSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function ModelSelection({ data, setData }: ModelSelectionProps) {
  // Get models from the centralized data file based on selected brand
  const models = getModels(data.brand)

  const handleModelSelect = (modelId: string) => {
    setData({ ...data, model: modelId, trim: "" })
  }

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Sélectionnez un modèle</h3>

      <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-4">
        {models.map((model) => (
          <Card
            key={model.id}
            className={`cursor-pointer transition-all hover:shadow-md ${
              data.model === model.id ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
            }`}
            onClick={() => handleModelSelect(model.id)}
          >
            <CardContent className="p-4">
              <div className="relative h-32 w-full mb-2">
                <Image
                  src={model.image || "/placeholder.svg"}
                  alt={model.name}
                  fill
                  className="object-cover rounded-md"
                />
              </div>
              <h4 className="text-lg font-medium text-center">{model.name}</h4>
            </CardContent>
          </Card>
        ))}
      </div>
    </div>
  )
}
