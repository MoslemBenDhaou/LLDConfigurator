import Image from "next/image"

export function Testimonials() {
  return (
    <section id="testimonials" className="py-16">
      <div className="container px-4 md:px-6">
        <div className="flex flex-col items-center justify-center space-y-4 text-center">
          <div className="space-y-2">
            <h2 className="text-3xl font-bold tracking-tighter sm:text-4xl md:text-5xl">Ce que disent nos clients</h2>
            <p className="max-w-[900px] text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
            Écoutez les témoignages de clients qui ont expérimenté nos solutions de location longue durée.
            </p>
          </div>
        </div>
        <div className="mx-auto grid max-w-5xl grid-cols-1 gap-6 py-12 md:grid-cols-2 lg:grid-cols-3">
          {testimonials.map((testimonial, index) => (
            <div key={index} className="flex flex-col justify-between space-y-4 rounded-lg border p-6 shadow-sm">
              <div className="space-y-2">
                <div className="flex items-center gap-1">
                  {[...Array(5)].map((_, i) => (
                    <svg
                      key={i}
                      xmlns="http://www.w3.org/2000/svg"
                      viewBox="0 0 24 24"
                      fill={i < testimonial.rating ? "#FFD700" : "#E5E7EB"}
                      className="h-5 w-5"
                    >
                      <path
                        fillRule="evenodd"
                        d="M10.788 3.21c.448-1.077 1.976-1.077 2.424 0l2.082 5.007 5.404.433c1.164.093 1.636 1.545.749 2.305l-4.117 3.527 1.257 5.273c.271 1.136-.964 2.033-1.96 1.425L12 18.354 7.373 21.18c-.996.608-2.231-.29-1.96-1.425l1.257-5.273-4.117-3.527c-.887-.76-.415-2.212.749-2.305l5.404-.433 2.082-5.006z"
                        clipRule="evenodd"
                      />
                    </svg>
                  ))}
                </div>
                <p className="text-gray-500">{testimonial.content}</p>
              </div>
              <div className="flex items-center gap-4">
                <div className="relative h-10 w-10 overflow-hidden rounded-full">
                  <Image
                    src={testimonial.avatar || "/placeholder.svg"}
                    alt={testimonial.name}
                    fill
                    className="object-cover"
                  />
                </div>
                <div>
                  <p className="font-medium">{testimonial.name}</p>
                  <p className="text-sm text-gray-500">{testimonial.location}</p>
                </div>
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  )
}

const testimonials = [
  {
    content:
      "Le processus de configuration a été si simple, et j'ai trouvé le véhicule parfait pour mes besoins. Le tarif mensuel est très compétitif et le service a été excellent.",
    name: "Mahdi Ben Hmouda",
    location: "Tunis",
    rating: 5,
    avatar: "",
  },
  {
    content:
      "J'avais besoin d'une voiture pendant 18 mois pour travailler sur un projet. OK Mobility m'a permis de trouver facilement le véhicule idéal, avec des conditions flexibles adaptées à mon emploi du temps.",
    name: "Abdelaziz Haj Sassi",
    location: "Sousse",
    rating: 5,
    avatar: "",
  },
  {
    content:
      "Le package de maintenance m'a apporté la paix d'esprit sachant que tout était pris en charge. Je recommande fortement pour les locations à long terme.",
    name: "Ayman Kessentini",
    location: "Sfax",
    rating: 4,
    avatar: "",
  },
]
