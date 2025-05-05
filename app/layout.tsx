import type { Metadata } from 'next'
import { Nunito } from 'next/font/google'
import './globals.css'
import { PricingLoader } from '@/components/pricing-loader'

// Initialize the Nunito font with Latin subset
const nunito = Nunito({
  subsets: ['latin'],
  display: 'swap',
  variable: '--font-nunito',
})

export const metadata: Metadata = {
  title: 'OK Mobility - Location Longue Durée',
  description: 'Configurez votre location longue durée avec OK Mobility',
}

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode
}>) {
  return (
    <html lang="fr" className={nunito.className}>
      <body>
        <PricingLoader>
          {children}
        </PricingLoader>
      </body>
    </html>
  )
}
