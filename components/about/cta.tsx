import { Button } from "@/components/ui/button"
import Link from "next/link"

export function AboutCta() {
  return (
    <section className="py-20 bg-[#4361ee]">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl text-white">
              Ready to Experience OK Mobility?
            </h2>
            <p className="max-w-[900px] text-blue-100 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
              Configure your perfect long-term rental today and join thousands of satisfied customers.
            </p>
          </div>
          <div className="flex flex-col gap-2 min-[400px]:flex-row">
            <Button size="lg" className="bg-white text-[#4361ee] hover:bg-gray-100" asChild>
              <Link href="/#configurator">Configure Your Rental</Link>
            </Button>
            <Button size="lg" variant="outline" className="text-white border-white hover:bg-blue-800" asChild>
              <Link href="/contact">Contact Us</Link>
            </Button>
          </div>
        </div>
      </div>
    </section>
  )
}
