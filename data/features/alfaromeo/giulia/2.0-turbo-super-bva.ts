// Detailed features for Alfa Romeo Giulia 2.0 Turbo Super BVA
import { FeatureGroup } from "../../../offers";

const detailedFeatures: FeatureGroup[] = [
  {
    name: "Caractéristiques",
    features: [
      { name: "Moteur", value: "2.0L Turbo" },
      { name: "Puissance", value: "200 ch" },
      { name: "Couple", value: "330 Nm" },
      { name: "Cylindrée", value: "1995 cc" }
    ]
  },
  {
    name: "Transmission",
    features: [
      { name: "Boîte de vitesses", value: "Automatique 8 rapports" },
      { name: "Transmission", value: "Propulsion arrière" }
    ]
  },
  {
    name: "Performances",
    features: [
      { name: "Vitesse maximale", value: "235 km/h" },
      { name: "0-100 km/h", value: "6.6 secondes" }
    ]
  },
  {
    name: "Consommation",
    features: [
      { name: "Cycle mixte", value: "6.4 L/100km" },
      { name: "Émissions CO2", value: "146 g/km" }
    ]
  },
  {
    name: "Équipements de confort",
    features: [
      { name: "Climatisation", value: "Automatique bi-zone" },
      { name: "Sièges", value: "Cuir" },
      { name: "Système multimédia", value: "Écran tactile avec navigation" },
      { name: "Connectivité", value: "Bluetooth, USB, Apple CarPlay, Android Auto" }
    ]
  },
  {
    name: "Équipements de sécurité",
    features: [
      { name: "ABS", value: "Oui" },
      { name: "Airbags", value: "Frontaux | Latéraux | Rideaux" },
      { name: "Anti-démarrage électronique", value: "Oui" },
      { name: "Contrôle de pression des pneus", value: "Oui" },
      { name: "Fixations ISOFIX", value: "Oui" }
    ]
  }
];

export default detailedFeatures;
