"use client"

import { useState, useEffect } from "react"
import { Search } from "lucide-react"
import Image from "next/image"
import { Card, CardContent } from "@/components/ui/card"
import { Input } from "@/components/ui/input"
import { ConfiguratorData } from "../wizard"

interface Brand {
  code: string;
  name: string;
  imgUrl: string;
  isActive: boolean;
}

interface BrandSelectionProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function BrandSelection({ data, setData }: BrandSelectionProps) {
  const [searchTerm, setSearchTerm] = useState("")
  const [brands, setBrands] = useState<Brand[]>([])
  const [isLoading, setIsLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    const fetchBrands = async () => {
      try {
        const apiUrl = process.env.NEXT_PUBLIC_API_URL || ''
        const response = await fetch(`${apiUrl}/api/Vehicles/brands`)
        if (!response.ok) {
          throw new Error('Failed to fetch brands')
        }
        const data = await response.json()
        setBrands(data)
      } catch (err) {
        console.error('Error fetching brands:', err)
        setError('Failed to load brands. Please try again later.')
      } finally {
        setIsLoading(false)
      }
    }

    fetchBrands()
  }, [])

  const filteredBrands = brands
    .filter(brand => brand.isActive)
    .filter(brand => brand.name.toLowerCase().includes(searchTerm.toLowerCase()))

  const handleBrandSelect = (brandCode: string) => {
    setData({ ...data, brand: brandCode, model: "", trim: "" })
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

      {isLoading ? (
        <div className="flex justify-center items-center h-40">
          <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-gray-900"></div>
        </div>
      ) : error ? (
        <div className="text-red-500 text-center p-4">{error}</div>
      ) : (
        <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-4">
          {filteredBrands.map((brand) => (
            <Card
              key={brand.code}
              className={`cursor-pointer transition-all hover:shadow-md ${
                data.brand === brand.code ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
              }`}
              onClick={() => handleBrandSelect(brand.code)}
            >
              <CardContent className="flex flex-col items-center justify-center p-4">
                <div className="relative h-16 w-16 mb-2">
                  <Image
                    src={brand.imgUrl}
                    alt={brand.name}
                    fill
                    className="object-contain"
                  />
                </div>
                <span className="text-sm font-medium text-center">{brand.name}</span>
              </CardContent>
            </Card>
          ))}
        </div>
      )}
    </div>
  )
}
