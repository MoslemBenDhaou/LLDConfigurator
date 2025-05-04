import Image from "next/image"

export function AboutStory() {
  return (
    <section className="py-16 bg-white">
      <div className="container px-4 md:px-6">
        <div className="grid gap-6 lg:grid-cols-2 lg:gap-12 items-center">
          <div className="space-y-4">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl">Our Story</h2>
            <p className="text-gray-500 md:text-lg">
              Founded in 2010, OK Mobility began with a simple idea: to make long-term car rentals more accessible,
              flexible, and transparent. What started as a small operation with just 15 vehicles has grown into one of
              the leading mobility solution providers in the region.
            </p>
            <p className="text-gray-500 md:text-lg">
              Our journey has been driven by innovation and a deep understanding of our customers' evolving needs. We
              pioneered the digital configurator approach to car rentals, allowing customers to customize every aspect
              of their long-term rental experience.
            </p>
            <p className="text-gray-500 md:text-lg">
              Today, OK Mobility operates in 12 countries with a fleet of over 8,000 vehicles, serving both individual
              and corporate clients with the same dedication to excellence that has defined us from day one.
            </p>
          </div>
          <div className="relative h-[300px] sm:h-[400px] lg:h-[500px] rounded-lg overflow-hidden">
            <Image src="/placeholder.svg?key=3k3os" alt="OK Mobility Growth Timeline" fill className="object-cover" />
          </div>
        </div>
      </div>
    </section>
  )
}
