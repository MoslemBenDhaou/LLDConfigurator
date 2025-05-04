import Image from "next/image"
import { Card, CardContent } from "@/components/ui/card"

export function AboutLocations() {
  const locations = [
    {
      city: "Madrid",
      country: "Spain",
      address: "Calle Gran Vía 28, 28013 Madrid",
      image: "/placeholder.svg?key=ospdv",
    },
    {
      city: "Paris",
      country: "France",
      address: "15 Avenue des Champs-Élysées, 75008 Paris",
      image: "/placeholder.svg?height=300&width=500&query=paris france cityscape",
    },
    {
      city: "Berlin",
      country: "Germany",
      address: "Friedrichstraße 123, 10117 Berlin",
      image: "/placeholder.svg?height=300&width=500&query=berlin germany cityscape",
    },
    {
      city: "Rome",
      country: "Italy",
      address: "Via del Corso 112, 00186 Roma",
      image: "/placeholder.svg?height=300&width=500&query=rome italy cityscape",
    },
    {
      city: "Tunis",
      country: "Tunisia",
      address: "Avenue Habib Bourguiba 45, Tunis 1001",
      image: "/placeholder.svg?height=300&width=500&query=tunis tunisia cityscape",
    },
    {
      city: "London",
      country: "United Kingdom",
      address: "123 Oxford Street, London W1D 2LG",
      image: "/placeholder.svg?height=300&width=500&query=london uk cityscape",
    },
  ]

  return (
    <section className="py-16 bg-white">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center mb-10">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl">Our Locations</h2>
            <p className="max-w-[900px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
              Find OK Mobility offices across Europe and North Africa.
            </p>
          </div>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
          {locations.map((location, index) => (
            <Card key={index} className="overflow-hidden">
              <div className="relative h-48 w-full">
                <Image
                  src={location.image || "/placeholder.svg"}
                  alt={`${location.city}, ${location.country}`}
                  fill
                  className="object-cover"
                />
              </div>
              <CardContent className="p-6">
                <h3 className="text-xl font-bold">{location.city}</h3>
                <p className="text-sm text-[#4361ee] mb-2">{location.country}</p>
                <p className="text-sm text-gray-500">{location.address}</p>
              </CardContent>
            </Card>
          ))}
        </div>
      </div>
    </section>
  )
}
