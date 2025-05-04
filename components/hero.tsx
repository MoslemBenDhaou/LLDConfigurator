import { Button } from "@/components/ui/button"
import Image from "next/image"

export function Hero() {
  return (
    <section className="relative py-20 md:py-28 overflow-hidden">
      <div className="container px-4 md:px-6">
        <div className="grid gap-6 lg:grid-cols-2 lg:gap-12 items-center">
          <div className="space-y-4">
            <h1 className="text-3xl font-bold tracking-tighter sm:text-4xl md:text-5xl lg:text-6xl">
            Solutions flexibles de location de voiture longue durée
            </h1>
            <p className="max-w-[600px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
            Configurez votre location longue durée idéale avec OK Mobility. Conditions flexibles, tarifs transparents et large choix de véhicules.
            </p>
            <div className="flex flex-col gap-2 min-[400px]:flex-row">
              <Button size="lg" className="bg-[#4361ee] hover:bg-[#3a56d4]" asChild>
                <a href="#configurator">Configurez votre location</a>
              </Button>
            </div>
          </div>
          <div className="flex justify-center">
            <Image
              src="/hero_suscripcion_desktop.jpg"
              alt="OK Mobility Car Fleet"
              width={1050}
              height={710}
              className="rounded-lg"
              priority
            />
          </div>
        </div>
      </div>
    </section>
  )
}
