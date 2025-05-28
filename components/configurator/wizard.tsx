"use client"

import { useState, useEffect } from "react"
import { BrandSelection } from "./steps/brand-selection"
import { ModelSelection } from "./steps/model-selection"
import { TrimSelection } from "./steps/trim-selection"
import { DurationSelection } from "./steps/duration-selection"
import { PaymentTerms } from "./steps/payment-terms"
import { Extras } from "./steps/extras"
import { ReviewOffer } from "./steps/review-offer"
import { ContactForm } from "./steps/contact-form"
import { ProgressBar } from "./progress-bar"
import { Button } from "@/components/ui/button"
import { Card, CardContent } from "@/components/ui/card"
import { ChevronLeft, ChevronRight } from "lucide-react"

// Update the ConfiguratorData type to include purchaseOption
export type ConfiguratorData = {
  brand: string
  model: string
  trim: string
  duration: number
  kilometers: number
  firstRatePercentage: number
  extras: {
    insurance: boolean
    maintenance: boolean
    purchaseOption: boolean
  }
  contact: {
    firstName: string
    lastName: string
    email: string
    phone: string
  }
}

// Update the initial state to include purchaseOption: false
export function ConfiguratorWizard() {
  const [currentStep, setCurrentStep] = useState(0)
  const [previousStep, setPreviousStep] = useState(0)
  const [data, setData] = useState<ConfiguratorData>({
    brand: "",
    model: "",
    trim: "",
    duration: 12,
    kilometers: 15000,
    firstRatePercentage: 0,
    extras: {
      insurance: false,
      maintenance: false,
      purchaseOption: false,
    },
    contact: {
      firstName: "",
      lastName: "",
      email: "",
      phone: "",
    },
  })

  const steps = [
    { title: "Marque", component: <BrandSelection data={data} setData={setData} /> },
    { title: "Modèle", component: <ModelSelection data={data} setData={setData} /> },
    { title: "Version", component: <TrimSelection data={data} setData={setData} /> },
    { title: "Paiement", component: <PaymentTerms data={data} setData={setData} /> },
    { title: "Durée", component: <DurationSelection data={data} setData={setData} /> },
    { title: "Options", component: <Extras data={data} setData={setData} /> },
    { title: "Résumé", component: <ReviewOffer data={data} /> },
    { title: "Contact", component: <ContactForm data={data} setData={setData} /> },
  ]

  // Effect to scroll when step changes
  useEffect(() => {
    if (currentStep !== previousStep) {
      const configurator = document.getElementById("configurator")
      if (configurator) {
        const headerOffset = 80 // Account for fixed header if present
        const elementPosition = configurator.getBoundingClientRect().top + window.scrollY
        const offsetPosition = elementPosition - headerOffset

        window.scrollTo({
          top: offsetPosition,
          behavior: "smooth",
        })
      }
      setPreviousStep(currentStep)
    }
  }, [currentStep, previousStep])

  const nextStep = () => {
    if (currentStep < steps.length - 1) {
      setCurrentStep(currentStep + 1)
    }
  }

  const prevStep = () => {
    if (currentStep > 0) {
      setCurrentStep(currentStep - 1)
    }
  }

  const isNextDisabled = () => {
    switch (currentStep) {
      case 0:
        return !data.brand
      case 1:
        return !data.model
      case 2:
        return !data.trim
      case 7:
        return !data.contact.firstName || !data.contact.lastName || !data.contact.email || !data.contact.phone
      default:
        return false
    }
  }

  const handleSubmit = () => {
    // Here you would typically send the data to your backend
    console.log("Form submitted:", data)
    // Show success message or redirect
    alert("Thank you for your submission! We will contact you shortly.")
  }

  return (
    <section id="configurator" className="py-16 bg-gradient-to-b from-white to-gray-50">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center mb-8">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl md:text-5xl">
            Configurez votre location longue durée
            </h2>
            <p className="max-w-[900px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
              Suivez les étapes ci-dessous pour personnaliser votre location longue durée parfaite.
            </p>
          </div>
        </div>

        <Card className="max-w-4xl mx-auto">
          <CardContent className="p-6">
            <ProgressBar currentStep={currentStep} totalSteps={steps.length} titles={steps.map((s) => s.title)} />

            <div className="mt-8 min-h-[400px]">{steps[currentStep].component}</div>

            <div className="mt-8 flex justify-between">
              {currentStep > 0 ? (
                <Button variant="outline" onClick={prevStep}>
                  <ChevronLeft className="mr-2 h-4 w-4" />
                  Précédent
                </Button>
              ) : (
                <div></div>
              )}

              {currentStep < steps.length - 1 ? (
                <Button onClick={nextStep} disabled={isNextDisabled()}>
                  Suivant
                  <ChevronRight className="ml-2 h-4 w-4" />
                </Button>
              ) : (
                <Button onClick={handleSubmit} disabled={isNextDisabled()} className="bg-[#4361ee] hover:bg-[#3a56d4]">
                  Envoyer
                </Button>
              )}
            </div>
          </CardContent>
        </Card>
      </div>
    </section>
  )
}
