import { Navbar } from "@/components/navbar"
import { Hero } from "@/components/hero"
import { Features } from "@/components/features"
import { Testimonials } from "@/components/testimonials"
import { ConfiguratorWizard } from "@/components/configurator/wizard"
import { Footer } from "@/components/footer"

export function LandingPage() {
  return (
    <div className="min-h-screen flex flex-col">
      <Navbar />
      <main className="flex-grow">
        <Hero />
        <Features />
        <ConfiguratorWizard />
        <Testimonials />
      </main>
      <Footer />
    </div>
  )
}
