import { Check } from "lucide-react"

interface ProgressBarProps {
  currentStep: number
  totalSteps: number
  titles: string[]
}

export function ProgressBar({ currentStep, totalSteps, titles }: ProgressBarProps) {
  return (
    <div className="hidden md:block">
      <div className="flex items-center justify-between">
        {Array.from({ length: totalSteps }).map((_, index) => (
          <div key={index} className="flex flex-col items-center">
            <div
              className={`flex h-8 w-8 items-center justify-center rounded-full border-2 ${
                index < currentStep
                  ? "border-[#4361ee] bg-[#4361ee] text-white"
                  : index === currentStep
                    ? "border-[#4361ee] text-[#4361ee]"
                    : "border-gray-300 text-gray-300"
              }`}
            >
              {index < currentStep ? <Check className="h-4 w-4" /> : <span>{index + 1}</span>}
            </div>
            <span className={`mt-2 text-xs ${index <= currentStep ? "text-[#4361ee] font-medium" : "text-gray-500"}`}>
              {titles[index]}
            </span>
          </div>
        ))}
      </div>
      <div className="relative mt-4">
        <div className="absolute top-0 h-1 w-full bg-gray-200"></div>
        <div
          className="absolute top-0 h-1 bg-[#4361ee] transition-all duration-300"
          style={{ width: `${(currentStep / (totalSteps - 1)) * 100}%` }}
        ></div>
      </div>
    </div>
  )
}
