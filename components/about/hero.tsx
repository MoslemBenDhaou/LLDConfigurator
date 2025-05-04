"use client"

import { useState } from "react"
import { Play } from "lucide-react"

export function AboutHero() {
  const [videoPlaying, setVideoPlaying] = useState(false)

  const playVideo = () => {
    setVideoPlaying(true)
  }

  return (
    <section className="relative py-20 md:py-28 overflow-hidden">
      <div className="container px-4 md:px-6 relative z-10">
        <div className="max-w-3xl mx-auto text-center space-y-4 mb-10">
          <h1 className="text-3xl font-bold tracking-tighter sm:text-4xl md:text-5xl lg:text-6xl">
            Driving the Future of Mobility
          </h1>
          <p className="max-w-[700px] mx-auto text-gray-500 md:text-xl/relaxed lg:text-base/relaxed xl:text-xl/relaxed">
            OK Mobility is revolutionizing the long-term car rental industry with flexible solutions, transparent
            pricing, and exceptional customer service.
          </p>
        </div>

        <div className="max-w-4xl mx-auto">
          <div className="relative aspect-video bg-gray-100 rounded-lg overflow-hidden shadow-lg">
            {videoPlaying ? (
              <iframe
                className="absolute inset-0 w-full h-full"
                src="https://www.youtube.com/embed/dQw4w9WgXcQ?autoplay=1"
                title="OK Mobility Company Video"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                allowFullScreen
              ></iframe>
            ) : (
              <div className="absolute inset-0 flex items-center justify-center">
                <div className="relative w-full h-full cursor-pointer" onClick={playVideo}>
                  <div
                    className="absolute inset-0 bg-black opacity-50"
                    style={{
                      backgroundImage: "url('/placeholder.svg?key=gmccj')",
                      backgroundSize: "cover",
                      backgroundPosition: "center",
                    }}
                  ></div>
                  <div className="absolute inset-0 flex items-center justify-center">
                    <div className="h-20 w-20 rounded-full bg-[#4361ee] bg-opacity-90 flex items-center justify-center shadow-lg hover:bg-opacity-100 transition-all duration-300">
                      <Play className="h-10 w-10 text-white ml-1" />
                    </div>
                  </div>
                  <div className="absolute bottom-6 left-6 right-6">
                    <h3 className="text-white text-xl font-bold drop-shadow-lg">Discover OK Mobility</h3>
                    <p className="text-white text-sm drop-shadow-lg">Learn about our mission and vision</p>
                  </div>
                </div>
              </div>
            )}
          </div>
        </div>
      </div>
    </section>
  )
}
