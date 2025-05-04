import Image from "next/image"
import Link from "next/link"
import { Button } from "@/components/ui/button"

export function Navbar() {
  return (
    <header className="sticky top-0 z-50 w-full border-b bg-white">
      <div className="container flex h-16 items-center justify-between">
        <Link href="/" className="flex items-center">
          <Image
            src="https://hebbkx1anhila5yf.public.blob.vercel-storage.com/OK-Mobility-imagotipo_RGB-1-yqgYvosjNz6NFB2wJlQsIyDQx79F04.webp"
            alt="OK Mobility Logo"
            width={180}
            height={40}
            priority
          />
        </Link>
        <nav className="hidden md:flex gap-6">
          <Link href="#features" className="text-sm font-medium hover:text-primary">
          Avantages
          </Link>
          <Link href="#configurator" className="text-sm font-medium hover:text-primary">
          Configurateur
          </Link>
          <Link href="#testimonials" className="text-sm font-medium hover:text-primary">
          Témoignages
          </Link>
        </nav>
        <div className="flex items-center gap-4">
          <Button><a href="#configurator">Commencer!</a></Button>
        </div>
      </div>
    </header>
  )
}
