"use client"

import { useState } from "react"
import { Search } from "lucide-react"
import Image from "next/image"
import { Card, CardContent } from "@/components/ui/card"
import { Input } from "@/components/ui/input"
import { ConfiguratorData } from "../wizard"
import { getBrands } from "@/data/offers"

interface BrandSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function BrandSelection({ data, setData }: BrandSelectionProps) {
  const [searchTerm, setSearchTerm] = useState("")

  // Get brands from the centralized data file
  const brands = getBrands()

  const filteredBrands = brands.filter((brand) => brand.name.toLowerCase().includes(searchTerm.toLowerCase()))

  const handleBrandSelect = (brandId: string) => {
    setData({ ...data, brand: brandId, model: "", trim: "" })
  }

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Choisissez une marque</h3>

      <div className="relative">
        <Search className="absolute left-3 top-1/2 h-4 w-4 -translate-y-1/2 text-gray-500" />
        <Input
          type="text"
          placeholder="Rechercher une marque..."
          className="pl-10"
          value={searchTerm}
          onChange={(e) => setSearchTerm(e.target.value)}
        />
      </div>

      <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-4">
        {filteredBrands.map((brand) => (
          <Card
            key={brand.id}
            className={`cursor-pointer transition-all hover:shadow-md ${
              data.brand === brand.id ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
            }`}
            onClick={() => handleBrandSelect(brand.id)}
          >
            <CardContent className="flex flex-col items-center justify-center p-4">
              <div className="relative h-16 w-16 mb-2">
                <Image src={brand.logo || "/placeholder.svg"} alt={brand.name} fill className="object-contain" />
              </div>
              <span className="text-sm font-medium">{brand.name}</span>
            </CardContent>
          </Card>
        ))}
      </div>
    </div>
  )
}
