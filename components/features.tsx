import { Car, ReceiptText, HandCoins, Shield, Wrench, Clock, MapPin, HeadphonesIcon, Repeat } from "lucide-react"

export function Features() {
  return (
    <section id="features" className="py-16 bg-gray-50">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl md:text-5xl">Pourquoi choisir OK Mobility</h2>
            <p className="max-w-[900px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
              Nos solutions de location à longue durée offrent flexibilité, commodité et tranquillité d'esprit.
            </p>
          </div>
        </div>
        <div className="mx-auto grid max-w-5xl grid-cols-1 gap-6 py-12 md:grid-cols-2 lg:grid-cols-3">
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Car className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Large selection</h3>
            <p className="text-center text-gray-500">
            Choisissez parmi une flotte diversifiée de véhicules pour répondre à vos besoins spécifiques.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <ReceiptText className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Conditions flexibles</h3>
            <p className="text-center text-gray-500">Durées de location allant de 12 à 60 mois pour s'adapter à votre calendrier.</p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <HandCoins className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Prix transparents</h3>
            <p className="text-center text-gray-500">Tarifs mensuels clairs sans frais cachés ou surprises.</p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Shield className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Assurance tous risques</h3>
            <p className="text-center text-gray-500">
              Option d'assurance tous risques pour une protection complète.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Wrench className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Maintenance incluse</h3>
            <p className="text-center text-gray-500">
              Option de maintenance incluse pour garder votre véhicule en parfait état.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Clock className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Processus rapide</h3>
            <p className="text-center text-gray-500">
              Processus de configuration et d'application simple pour vous mettre sur la route plus vite.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <Repeat className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Voiture de remplacement</h3>
            <p className="text-center text-gray-500">
              Véhicule de remplacement fourni en cas de panne ou d'entretien prolongé.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <MapPin className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Assistance routière</h3>
            <p className="text-center text-gray-500">
              Service d'assistance routière disponible 24/7 partout en Tunisie.
            </p>
          </div>
          <div className="flex flex-col items-center space-y-2 rounded-lg border p-6 shadow-sm">
            <HeadphonesIcon className="h-12 w-12 text-[#4361ee]" />
            <h3 className="text-xl font-bold">Support client dédié</h3>
            <p className="text-center text-gray-500">
              Équipe de support client dédiée pour répondre à toutes vos questions et besoins.
            </p>
          </div>
        </div>
      </div>
    </section>
  )
}
