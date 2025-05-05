"use client"

import { useEffect, useState } from "react"
import { preloadAllData } from "@/data/offers"

export function PricingLoader({ children }: { children: React.ReactNode }) {
  const [isLoaded, setIsLoaded] = useState(false)

  useEffect(() => {
    const loadPricing = async () => {
      try {
        await preloadAllData()
        setIsLoaded(true)
      } catch (error) {
        console.error("Failed to preload data:", error)
        setIsLoaded(true) // Continue even if there's an error
      }
    }

    loadPricing()
  }, [])

  if (!isLoaded) {
    return (
      <div className="fixed inset-0 bg-white bg-opacity-80 z-50 flex items-center justify-center">
        <div className="text-center">
          <div className="inline-block animate-spin rounded-full h-8 w-8 border-4 border-[#4361ee] border-t-transparent"></div>
          <p className="mt-2 text-gray-700">Chargement des données...</p>
        </div>
      </div>
    )
  }

  return <>{children}</>
}
