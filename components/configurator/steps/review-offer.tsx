import Image from "next/image"
import type { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { Separator } from "@/components/ui/separator"
import { Check } from "lucide-react"

interface ReviewOfferProps {
  data: ConfiguratorData
}

export function ReviewOffer({ data }: ReviewOfferProps) {
  // This would typically come from an API based on the selected options
  const getBrandName = (brandId: string) => {
    const brands: Record<string, string> = {
      alfaromeo: "Alfa Romeo",
      audi: "Audi",
      bmw: "BMW",
      byd: "BYD",
      chery: "Chery",
      chevrolet: "Chevrolet",
      citroen: "Citroen",
      cupra: "Cupra",
      dacia: "Dacia",
      fiat: "FIAT",
      ford: "Ford",
      haval: "Haval",
      honda: "Honda",
      hyundai: "Hyundai",
      jaguar: "Jaguar",
      jeep: "Jeep",
      kia: "Kia",
      landrover: "Land Rover",
      mahindra: "Mahindra",
      mercedes: "Mercedes",
      mg: "MG",
      mini: "Mini",
      mitsubishi: "Mitsubishi",
      nissan: "Nissan",
      opel: "Opel",
      peugeot: "Peugeot",
      porsche: "Porsche",
      renault: "Renault",
      seat: "SEAT",
      skoda: "Skoda",
      kgm: "KGM",
      suzuki: "Suzuki",
      toyota: "Toyota",
      volkswagen: "Volkswagen",
      volvo: "Volvo",
      wallys: "Wallys",
    }
    return brands[brandId] || brandId
  }

  const getModelName = (brandId: string, modelId: string) => {
    if (brandId === "audi") {
      const models: Record<string, string> = {
        a3: "A3",
        a4: "A4",
        q3: "Q3",
        q5: "Q5",
      }
      return models[modelId] || modelId
    }
    return modelId
  }

  const getTrimName = (trimId: string) => {
    const trims: Record<string, string> = {
      basic: "Basic",
      comfort: "Comfort",
      premium: "Premium",
      "2.0-turbo-super-bva": "2.0 Turbo Super BVA",
    }
    return trims[trimId] || trimId
  }

  const getFirstRateText = (percentage: number) => {
    if (percentage === 0) return "No first rate payment"
    return `${percentage}% first rate payment`
  }

  // Get estimated vehicle list price based on trim
  const getVehicleListPrice = () => {
    switch (data.trim) {
      case "premium":
        return 45000
      case "comfort":
        return 38000
      case "2.0-turbo-super-bva":
        return 42000
      case "basic":
      default:
        return 32000
    }
  }

  const vehicleListPrice = getVehicleListPrice()

  // Calculate first rate amount based on percentage
  const getFirstRateAmount = () => {
    return Math.round((data.firstRatePercentage / 100) * vehicleListPrice)
  }

  // Calculate purchase price based on vehicle and rental duration
  const calculatePurchasePrice = () => {
    // Base price depends on the trim
    const basePrice = getVehicleListPrice()

    // Depreciation based on rental duration
    // Longer rental = lower purchase price
    const depreciationFactor = 0.5 + (data.duration / 60) * 0.3
    return Math.round(basePrice * (1 - depreciationFactor))
  }

  // Calculate monthly price based on all selections
  const getMonthlyPrice = () => {
    // Base financing amount after first rate is applied
    const financingAmount = vehicleListPrice * (1 - data.firstRatePercentage / 100)

    // Calculate monthly payment based on financing amount and duration
    let baseMonthlyPayment = financingAmount / data.duration

    // Duration discount
    const durationDiscount = Math.min(20, (data.duration - 12) * 0.4)
    baseMonthlyPayment = baseMonthlyPayment * (1 - durationDiscount / 100)

    // Kilometers adjustment
    const kmFactor = 1 + ((data.kilometers - 10000) / 10000) * 0.05 // 5% increase per 10,000 km over 10,000
    baseMonthlyPayment = baseMonthlyPayment * kmFactor

    // Add extras (only monthly fees)
    let extras = 0
    if (data.extras.insurance) extras += 49
    if (data.extras.maintenance) extras += 39
    // Purchase option is not a monthly fee, so it's not added here

    return Math.round(baseMonthlyPayment) + extras
  }

  // Format number with thousand separators and 3 decimal places
  const formatCurrency = (num: number) => {
    return num.toFixed(3).replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }

  const getCarImage = () => {
    if (data.brand === "audi" && data.model === "a3") {
      return "/placeholder.svg?key=89yvw"
    }
    if (data.brand === "audi" && data.model === "a4") {
      return "/sleek-audi-a4.png"
    }
    if (data.brand === "audi" && data.model === "q3") {
      return "/placeholder.svg?key=t9har"
    }
    return "/classic-red-convertible.png"
  }

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Review Your Configuration</h3>

      <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
        <Card>
          <CardContent className="p-4">
            <h4 className="text-lg font-medium mb-4">Vehicle Details</h4>

            <div className="relative h-40 w-full mb-4">
              <Image src={getCarImage() || "/placeholder.svg"} alt="Selected vehicle" fill className="object-contain" />
            </div>

            <div className="space-y-2">
              <div className="flex justify-between">
                <span className="text-gray-500">Brand:</span>
                <span className="font-medium">{getBrandName(data.brand)}</span>
              </div>
              <div className="flex justify-between">
                <span className="text-gray-500">Model:</span>
                <span className="font-medium">{getModelName(data.brand, data.model)}</span>
              </div>
              <div className="flex justify-between">
                <span className="text-gray-500">Trim:</span>
                <span className="font-medium">{getTrimName(data.trim)}</span>
              </div>
              <div className="flex justify-between">
                <span className="text-gray-500">List Price:</span>
                <span className="font-medium">TND {formatCurrency(vehicleListPrice)}</span>
              </div>
            </div>
          </CardContent>
        </Card>

        <Card>
          <CardContent className="p-4">
            <h4 className="text-lg font-medium mb-4">Rental Terms</h4>

            <div className="space-y-2">
              <div className="flex justify-between">
                <span className="text-gray-500">Duration:</span>
                <span className="font-medium">{data.duration} months</span>
              </div>
              <div className="flex justify-between">
                <span className="text-gray-500">Kilometers:</span>
                <span className="font-medium">
                  {data.kilometers.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",")} km total
                </span>
              </div>
              <div className="flex justify-between">
                <span className="text-gray-500">First Rate:</span>
                <span className="font-medium">{getFirstRateText(data.firstRatePercentage)}</span>
              </div>
              {data.firstRatePercentage > 0 && (
                <div className="flex justify-between">
                  <span className="text-gray-500">First Rate Amount:</span>
                  <span className="font-medium">TND {formatCurrency(getFirstRateAmount())}</span>
                </div>
              )}

              <Separator className="my-3" />

              <h5 className="font-medium">Additional Services:</h5>
              <div className="space-y-1 mt-2">
                <div className="flex items-center">
                  {data.extras.insurance ? (
                    <Check className="h-4 w-4 text-green-500 mr-2" />
                  ) : (
                    <span className="h-4 w-4 mr-2"></span>
                  )}
                  <span className={data.extras.insurance ? "font-medium" : "text-gray-500"}>
                    Full Insurance Coverage
                  </span>
                  {data.extras.insurance && <span className="ml-auto">TND 49.000/mo</span>}
                </div>
                <div className="flex items-center">
                  {data.extras.maintenance ? (
                    <Check className="h-4 w-4 text-green-500 mr-2" />
                  ) : (
                    <span className="h-4 w-4 mr-2"></span>
                  )}
                  <span className={data.extras.maintenance ? "font-medium" : "text-gray-500"}>Maintenance Package</span>
                  {data.extras.maintenance && <span className="ml-auto">TND 39.000/mo</span>}
                </div>
                <div className="flex items-center">
                  {data.extras.purchaseOption ? (
                    <Check className="h-4 w-4 text-green-500 mr-2" />
                  ) : (
                    <span className="h-4 w-4 mr-2"></span>
                  )}
                  <span className={data.extras.purchaseOption ? "font-medium" : "text-gray-500"}>Purchase Option</span>
                  {data.extras.purchaseOption && (
                    <span className="ml-auto text-sm">
                      TND {formatCurrency(calculatePurchasePrice())} at end of term
                    </span>
                  )}
                </div>
              </div>
            </div>
          </CardContent>
        </Card>
      </div>

      <Card className="bg-gray-50">
        <CardContent className="p-6">
          <div className="flex flex-col md:flex-row justify-between items-center">
            <div>
              <p className="text-gray-500">Monthly Payment</p>
              <p className="text-3xl font-bold">TND {formatCurrency(getMonthlyPrice())}</p>
            </div>

            <Separator className="my-4 md:hidden" />
            <Separator orientation="vertical" className="hidden md:block h-16" />

            <div>
              <p className="text-gray-500">Total Contract Value</p>
              <p className="text-lg font-semibold">
                TND {formatCurrency(getFirstRateAmount() + getMonthlyPrice() * data.duration)}
              </p>
              <p className="text-xs text-gray-500">
                (TND {formatCurrency(getFirstRateAmount())} first rate + TND{" "}
                {formatCurrency(getMonthlyPrice() * data.duration)} monthly payments)
              </p>
              {data.extras.purchaseOption && (
                <p className="text-xs text-blue-600 mt-1">
                  * Purchase option: TND {formatCurrency(calculatePurchasePrice())} at end of term (optional)
                </p>
              )}
            </div>
          </div>
        </CardContent>
      </Card>

      <div className="text-sm text-gray-500">
        <p>* Please review all details before proceeding to the next step.</p>
        <p>* Prices are estimates and may vary based on final credit approval.</p>
      </div>
    </div>
  )
}
