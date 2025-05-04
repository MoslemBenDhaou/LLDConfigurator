"use client"

import { useState } from "react"
import type { ConfiguratorData } from "../wizard"
import { Input } from "@/components/ui/input"
import { Label } from "@/components/ui/label"
import { Checkbox } from "@/components/ui/checkbox"
import { Card, CardContent } from "@/components/ui/card"
import Image from "next/image"

interface ContactFormProps {
  data: ConfiguratorData
  setData: (data: ConfiguratorData) => void
}

export function ContactForm({ data, setData }: ContactFormProps) {
  const [errors, setErrors] = useState<Record<string, string>>({})
  const [privacyChecked, setPrivacyChecked] = useState(false)

  const handleChange = (field: keyof typeof data.contact, value: string) => {
    setData({
      ...data,
      contact: {
        ...data.contact,
        [field]: value,
      },
    })

    // Clear error when user types
    if (errors[field]) {
      setErrors({
        ...errors,
        [field]: "",
      })
    }
  }

  const validateEmail = (email: string) => {
    const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    return re.test(email)
  }

  const validatePhone = (phone: string) => {
    const re = /^\+?[0-9\s]{8,}$/
    return re.test(phone)
  }

  const validate = () => {
    const newErrors: Record<string, string> = {}

    if (!data.contact.firstName.trim()) {
      newErrors.firstName = "First name is required"
    }

    if (!data.contact.lastName.trim()) {
      newErrors.lastName = "Last name is required"
    }

    if (!data.contact.email.trim()) {
      newErrors.email = "Email is required"
    } else if (!validateEmail(data.contact.email)) {
      newErrors.email = "Please enter a valid email"
    }

    if (!data.contact.phone.trim()) {
      newErrors.phone = "Phone number is required"
    } else if (!validatePhone(data.contact.phone)) {
      newErrors.phone = "Please enter a valid phone number"
    }

    if (!privacyChecked) {
      newErrors.privacy = "You must accept the privacy policy"
    }

    setErrors(newErrors)
    return Object.keys(newErrors).length === 0
  }

  return (
    <div className="space-y-6">
      <h3 className="text-xl font-bold">Contact Information</h3>

      <Card>
        <CardContent className="p-6">
          <div className="flex justify-center mb-6">
            <div className="relative h-40 w-full max-w-md">
              <Image src="/email-placeholder.jpg" alt="Contact via email" fill className="object-contain rounded-md" />
            </div>
          </div>
          <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
            <div className="space-y-2">
              <Label htmlFor="firstName">First Name *</Label>
              <Input
                id="firstName"
                value={data.contact.firstName}
                onChange={(e) => handleChange("firstName", e.target.value)}
                className={errors.firstName ? "border-red-500" : ""}
              />
              {errors.firstName && <p className="text-sm text-red-500">{errors.firstName}</p>}
            </div>

            <div className="space-y-2">
              <Label htmlFor="lastName">Last Name *</Label>
              <Input
                id="lastName"
                value={data.contact.lastName}
                onChange={(e) => handleChange("lastName", e.target.value)}
                className={errors.lastName ? "border-red-500" : ""}
              />
              {errors.lastName && <p className="text-sm text-red-500">{errors.lastName}</p>}
            </div>

            <div className="space-y-2">
              <Label htmlFor="email">Email *</Label>
              <Input
                id="email"
                type="email"
                value={data.contact.email}
                onChange={(e) => handleChange("email", e.target.value)}
                className={errors.email ? "border-red-500" : ""}
              />
              {errors.email && <p className="text-sm text-red-500">{errors.email}</p>}
            </div>

            <div className="space-y-2">
              <Label htmlFor="phone">Phone Number *</Label>
              <Input
                id="phone"
                type="tel"
                value={data.contact.phone}
                onChange={(e) => handleChange("phone", e.target.value)}
                className={errors.phone ? "border-red-500" : ""}
              />
              {errors.phone && <p className="text-sm text-red-500">{errors.phone}</p>}
            </div>
          </div>

          <div className="mt-6 space-y-4">
            <div className="flex items-start space-x-2">
              <Checkbox
                id="privacy"
                checked={privacyChecked}
                onCheckedChange={(checked) => setPrivacyChecked(checked === true)}
                className={errors.privacy ? "border-red-500" : ""}
              />
              <div>
                <Label htmlFor="privacy" className="text-sm cursor-pointer">
                  I agree to the processing of my personal data according to the{" "}
                  <a href="#" className="text-[#4361ee] hover:underline">
                    Privacy Policy
                  </a>{" "}
                  *
                </Label>
                {errors.privacy && <p className="text-sm text-red-500">{errors.privacy}</p>}
              </div>
            </div>

            <div className="flex items-start space-x-2">
              <Checkbox id="marketing" />
              <Label htmlFor="marketing" className="text-sm cursor-pointer">
                I would like to receive marketing communications about OK Mobility products and services
              </Label>
            </div>
          </div>
        </CardContent>
      </Card>

      <div className="text-sm text-gray-500">
        <p>* Required fields</p>
        <p>* By submitting this form, you agree to be contacted by our sales team.</p>
      </div>
    </div>
  )
}
