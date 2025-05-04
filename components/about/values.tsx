import { Heart, Shield, Lightbulb, Users, Globe, Zap } from "lucide-react"

export function AboutValues() {
  return (
    <section className="py-16 bg-gray-50">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl">Our Values</h2>
            <p className="max-w-[900px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
              The principles that guide everything we do at OK Mobility.
            </p>
          </div>
        </div>
        <div className="mx-auto grid max-w-5xl grid-cols-1 gap-6 py-12 md:grid-cols-2 lg:grid-cols-3">
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Heart className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Customer First</h3>
            <p className="text-center text-gray-500">
              We put our customers at the center of everything we do, constantly seeking ways to exceed their
              expectations.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Shield className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Transparency</h3>
            <p className="text-center text-gray-500">
              We believe in clear, honest communication and pricing with no hidden fees or surprises.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Lightbulb className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Innovation</h3>
            <p className="text-center text-gray-500">
              We continuously innovate to improve our services and stay ahead of evolving mobility needs.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Users className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Team Excellence</h3>
            <p className="text-center text-gray-500">
              We foster a culture of excellence, collaboration, and continuous learning among our team members.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Globe className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Sustainability</h3>
            <p className="text-center text-gray-500">
              We are committed to reducing our environmental impact and promoting sustainable mobility solutions.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Zap className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Adaptability</h3>
            <p className="text-center text-gray-500">
              We embrace change and quickly adapt to new market conditions and customer needs.
            </p>
          </div>
        </div>
      </div>
    </section>
  )
}
