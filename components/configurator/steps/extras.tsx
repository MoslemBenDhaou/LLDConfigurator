"use client"

import type { ConfiguratorData } from "../wizard"
import { Card, CardContent } from "@/components/ui/card"
import { Checkbox } from "@/components/ui/checkbox"
import { Label } from "@/components/ui/label"
import { Shield, Wrench, ShoppingCart, AlertCircle } from "lucide-react"
import { Tooltip, TooltipContent, TooltipProvider, TooltipTrigger } from "@/components/ui/tooltip"

interface ExtrasProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function Extras({ data, setData }: ExtrasProps) {
  const handleInsuranceChange = (checked: boolean) => {
    setData({
      ...data,
      extras: {
        ...data.extras,
        insurance: checked,
      },
    })
  }

  const handleMaintenanceChange = (checked: boolean) => {
    setData({
      ...data,
      extras: {
        ...data.extras,
        maintenance: checked,
      },
    })
  }

  const handlePurchaseOptionChange = (checked: boolean) => {
    setData({
      ...data,
      extras: {
        ...data.extras,
        purchaseOption: checked,
      },
    })
  }

  // Check if purchase option is available based on rental duration
  const isPurchaseOptionAvailable = data.duration >= 36

  // Calculate purchase price based on vehicle and rental duration
  const calculatePurchasePrice = () => {
    // Base price depends on the trim
    let basePrice
    switch (data.trim) {
      case "premium":
        basePrice = 45000
        break
      case "comfort":
        basePrice = 38000
        break
      case "2.0-turbo-super-bva":
        basePrice = 42000
        break
      case "basic":
      default:
        basePrice = 32000
        break
    }

    // Depreciation based on rental duration
    // Longer rental = lower purchase price
    const depreciationFactor = 0.5 + (data.duration / 60) * 0.3
    return Math.round(basePrice * (1 - depreciationFactor))
  }

  // Format currency with 3 decimal places
  const formatCurrency = (num: number) => {
    return num.toFixed(3).replace(/\B(?=(\d{3})+(?!\d))/g, ",")
  }

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Select Additional Services</h3>

      <div className="grid grid-cols-1 gap-4">
        <Card
          className={`transition-all hover:shadow-md cursor-pointer ${
            data.extras.insurance ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
          }`}
          onClick={() => handleInsuranceChange(!data.extras.insurance)}
        >
          <CardContent className="p-4">
            <div className="flex items-start space-x-3 py-2">
              <Checkbox
                id="insurance"
                checked={data.extras.insurance}
                onCheckedChange={handleInsuranceChange}
                className="mt-1"
                onClick={(e) => e.stopPropagation()}
              />
              <div className="flex-1">
                <div className="flex items-center">
                  <Shield className="h-5 w-5 text-[#4361ee] mr-2" />
                  <Label htmlFor="insurance" className="text-base font-medium cursor-pointer">
                    Full Insurance Coverage
                  </Label>
                </div>
                <p className="text-sm text-gray-500 mt-1">
                  Comprehensive insurance with zero deductible, covering all damages, theft, and third-party liability.
                </p>
                <ul className="mt-2 space-y-1">
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
                    Zero deductible for all claims
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
                    24/7 roadside assistance
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
                    Replacement vehicle during repairs
                  </li>
                </ul>
              </div>
              <div className="text-right">
                <p className="text-lg font-bold">TND 49.000/mo</p>
              </div>
            </div>
          </CardContent>
        </Card>

        <Card
          className={`transition-all hover:shadow-md cursor-pointer ${
            data.extras.maintenance ? "border-[#4361ee] ring-2 ring-[#4361ee]" : ""
          }`}
          onClick={() => handleMaintenanceChange(!data.extras.maintenance)}
        >
          <CardContent className="p-4">
            <div className="flex items-start space-x-3 py-2">
              <Checkbox
                id="maintenance"
                checked={data.extras.maintenance}
                onCheckedChange={handleMaintenanceChange}
                className="mt-1"
                onClick={(e) => e.stopPropagation()}
              />
              <div className="flex-1">
                <div className="flex items-center">
                  <Wrench className="h-5 w-5 text-[#4361ee] mr-2" />
                  <Label htmlFor="maintenance" className="text-base font-medium cursor-pointer">
                    Maintenance Package
                  </Label>
                </div>
                <p className="text-sm text-gray-500 mt-1">
                  Complete maintenance coverage including regular servicing, wear and tear repairs, and tire
                  replacements.
                </p>
                <ul className="mt-2 space-y-1">
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
                    All scheduled maintenance included
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
                    Wear and tear repairs
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
                    Tire replacements (up to 4 per year)
                  </li>
                </ul>
              </div>
              <div className="text-right">
                <p className="text-lg font-bold">TND 39.000/mo</p>
              </div>
            </div>
          </CardContent>
        </Card>

        {/* Purchase Option Card */}
        <Card
          className={`transition-all ${
            !isPurchaseOptionAvailable
              ? "opacity-70 cursor-not-allowed"
              : data.extras.purchaseOption
                ? "border-[#4361ee] ring-2 ring-[#4361ee] hover:shadow-md"
                : "hover:shadow-md cursor-pointer"
          }`}
          onClick={() => isPurchaseOptionAvailable && handlePurchaseOptionChange(!data.extras.purchaseOption)}
        >
          <CardContent className="p-4">
            <div className="flex items-start space-x-3 py-2">
              <Checkbox
                id="purchaseOption"
                checked={data.extras.purchaseOption}
                onCheckedChange={handlePurchaseOptionChange}
                disabled={!isPurchaseOptionAvailable}
                className="mt-1"
                onClick={(e) => e.stopPropagation()}
              />
              <div className="flex-1">
                <div className="flex items-center">
                  <ShoppingCart className="h-5 w-5 text-[#4361ee] mr-2" />
                  <Label
                    htmlFor="purchaseOption"
                    className={`text-base font-medium ${
                      isPurchaseOptionAvailable ? "cursor-pointer" : "text-gray-500"
                    }`}
                  >
                    Purchase Option
                  </Label>
                  {!isPurchaseOptionAvailable && (
                    <TooltipProvider>
                      <Tooltip>
                        <TooltipTrigger asChild>
                          <span className="ml-2 cursor-help">
                            <AlertCircle className="h-4 w-4 text-amber-500" />
                          </span>
                        </TooltipTrigger>
                        <TooltipContent>
                          <p className="max-w-xs">
                            Purchase option is only available for rental durations of 36 months or longer.
                          </p>
                        </TooltipContent>
                      </Tooltip>
                    </TooltipProvider>
                  )}
                </div>
                <p className="text-sm text-gray-500 mt-1">
                  Reserve the right to purchase the vehicle at a predetermined price after your rental period ends.
                </p>
                {isPurchaseOptionAvailable && (
                  <>
                    <ul className="mt-2 space-y-1">
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
                        Guaranteed purchase price at end of term
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
                        No obligation to purchase
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
                        Priority over other buyers
                      </li>
                    </ul>
                    <div className="mt-4 p-3 bg-blue-50 rounded-md border border-blue-100">
                      <p className="text-sm font-medium text-blue-800">Purchase Details:</p>
                      <p className="text-sm text-blue-700">
                        Guaranteed purchase price at end of term: TND {formatCurrency(calculatePurchasePrice())}
                      </p>
                      <p className="text-xs text-blue-600 mt-1">
                        * One-time payment at the end of your rental contract
                      </p>
                      <p className="text-xs text-blue-600">
                        * Final price may be adjusted based on vehicle condition and mileage
                      </p>
                    </div>
                  </>
                )}
                {!isPurchaseOptionAvailable && (
                  <div className="mt-2 p-2 bg-amber-50 rounded-md border border-amber-100">
                    <p className="text-xs text-amber-700">
                      This option is only available for rental durations of 36 months or longer. Please adjust your
                      rental duration to enable this option.
                    </p>
                  </div>
                )}
              </div>
              <div className="text-right">
                <p className="text-sm font-medium text-gray-600">One-time option</p>
                <p className="text-xs text-gray-500">No monthly fee</p>
              </div>
            </div>
          </CardContent>
        </Card>
      </div>
    </div>
  )
}
