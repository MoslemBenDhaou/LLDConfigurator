import { Navbar } from "@/components/navbar"
import { Footer } from "@/components/footer"
import { AboutHero } from "@/components/about/hero"
import { AboutStory } from "@/components/about/story"
import { AboutValues } from "@/components/about/values"
import { AboutStats } from "@/components/about/stats"
import { AboutLocations } from "@/components/about/locations"
import { AboutCta } from "@/components/about/cta"

export default function AboutPage() {
  return (
    <div className="min-h-screen flex flex-col">
      <Navbar />
      <main className="flex-grow">
        <AboutHero />
        <AboutStory />
        <AboutValues />
        <AboutStats />
        <AboutLocations />
        <AboutCta />
      </main>
      <Footer />
    </div>
  )
}
