import { Card, CardContent } from "@/components/ui/card"
import { Car, MapPin, Users, Calendar } from "lucide-react"

export function AboutStats() {
  return (
    <section className="py-16 bg-white">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center mb-10">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl">OK Mobility in Numbers</h2>
            <p className="max-w-[900px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
              Our growth and impact over the years.
            </p>
          </div>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
          <Card>
            <CardContent className="p-6 flex flex-col items-center justify-center text-center">
              <Car className="h-12 w-12 text-[#4361ee] mb-4" />
              <h3 className="text-4xl font-bold">8,000+</h3>
              <p className="text-gray-500">Vehicles in our fleet</p>
            </CardContent>
          </Card>

          <Card>
            <CardContent className="p-6 flex flex-col items-center justify-center text-center">
              <MapPin className="h-12 w-12 text-[#4361ee] mb-4" />
              <h3 className="text-4xl font-bold">12</h3>
              <p className="text-gray-500">Countries with OK Mobility presence</p>
            </CardContent>
          </Card>

          <Card>
            <CardContent className="p-6 flex flex-col items-center justify-center text-center">
              <Users className="h-12 w-12 text-[#4361ee] mb-4" />
              <h3 className="text-4xl font-bold">50,000+</h3>
              <p className="text-gray-500">Happy customers served</p>
            </CardContent>
          </Card>

          <Card>
            <CardContent className="p-6 flex flex-col items-center justify-center text-center">
              <Calendar className="h-12 w-12 text-[#4361ee] mb-4" />
              <h3 className="text-4xl font-bold">13</h3>
              <p className="text-gray-500">Years of mobility excellence</p>
            </CardContent>
          </Card>
        </div>
      </div>
    </section>
  )
}
