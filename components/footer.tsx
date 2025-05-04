"use client"

import Link from "next/link"
import Image from "next/image"
import { Instagram, Youtube } from "lucide-react"

export function Footer() {
  return (
    <footer className="bg-[#151f54] text-white py-12">
      <div className="container max-w-7xl px-4 md:px-6 mx-auto">
        {/* Logo */}
        <div className="mb-10">
          <Image
            src="/OKMobitiliy-Logo-White.svg"
            alt="OK Mobility Logo"
            width={180}
            height={40}
          />
        </div>

        <div className="grid grid-cols-1 md:grid-cols-3 gap-10">
          {/* Social Networks Column */}
          <div>
            <h3 className="text-lg font-bold mb-6 uppercase">
              <span className="border-b-2 border-[#4361ee] pb-1">Nos réseaux sociaux</span>
            </h3>
            <div className="flex space-x-4">
              <Link href="https://www.instagram.com/okmobility" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                <Instagram className="h-6 w-6" />
                <span className="sr-only">Instagram</span>
              </Link>
              <Link href="https://www.youtube.com/channel/UCWxroqABTjErPuUieJnGldw/videos?view=0&sort=p&shelf_id=1" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                <Youtube className="h-6 w-6" />
                <span className="sr-only">YouTube</span>
              </Link>
            </div>
          </div>

          {/* About Column */}
          <div>
            <h3 className="text-lg font-bold mb-6 uppercase">
              <span className="border-b-2 border-[#4361ee] pb-1">À propos de OK Mobility</span>
            </h3>
            <ul className="space-y-3">
              <li>
                <Link href="https://corporate.okmobility.com/en/" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  OK Mobility Corporate
                </Link>
              </li>
              <li>
                <Link href="https://corporate.okmobility.com/en/news/" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Actualités de l'entreprise
                </Link>
              </li>
              <li>
                <Link href="https://corporate.okmobility.com/en/press-room/press-releases/" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Salle de presse
                </Link>
              </li>
              <li>
                <Link href="https://okmobility.com/en/blog/" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  OK Magazine
                </Link>
              </li>
              <li>
                <Link href="https://www.tanitjobs.com/company/937772/ok-mobility/" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Travaillez avec nous
                </Link>
              </li>
            </ul>
          </div>

          {/* Information Column */}
          <div>
            <h3 className="text-lg font-bold mb-6 uppercase">
              <span className="border-b-2 border-[#4361ee] pb-1">Informations</span>
            </h3>
            <ul className="space-y-3">
              <li>
                <Link href="https://okmobility.com/fr/help/" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  OK Help
                </Link>
              </li>
              <li>
                <Link href="https://okmobility.com/fr/conditions-generales" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Conditions Générales
                </Link>
              </li>
              <li>
                <Link href="https://okmobility.com/fr/conditions-utilisation" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Conditions du site web
                </Link>
              </li>
              <li>
                <Link href="https://okmobility.com/fr/politique-confidentialite" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Politique de confidentialité
                </Link>
              </li>
              <li>
                <Link href="https://okmobility.com/fr/avis-legal" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Informations légales
                </Link>
              </li>
              <li>
                <Link href="https://okmobility.com/fr/politique-cookies" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Cookies
                </Link>
              </li>
              <li>
                <Link href="https://speakup.integrityline.com/?lang=fr" className="hover:text-[#4361ee] transition-colors" target="_blank" rel="noopener noreferrer">
                  Canal de dénonciation
                </Link>
              </li>
            </ul>
          </div>
        </div>

        {/* Copyright Line */}
        <div className="mt-12 pt-6 border-t border-[#2a3366]">
          <p className="text-sm text-gray-400">&#169; {new Date().getFullYear()} OK Mobility. Tous droits réservés.</p>
        </div>
      </div>
    </footer>
  )
}
