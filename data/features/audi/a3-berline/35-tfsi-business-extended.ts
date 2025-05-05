// Detailed features for Audi A3 Berline 35 TFSI Business Extended
import { FeatureGroup } from "../../../offers";

const detailedFeatures: FeatureGroup[] = [
  {
    name: "Caractéristiques",
    features: [
      { name: "Moteur", value: "1.5L TFSI" },
      { name: "Puissance", value: "150 ch" },
      { name: "Couple", value: "250 Nm" },
      { name: "Cylindrée", value: "1498 cc" }
    ]
  },
  {
    name: "Transmission",
    features: [
      { name: "Boîte de vitesses", value: "Manuelle 6 rapports" },
      { name: "Transmission", value: "Traction avant" }
    ]
  },
  {
    name: "Performances",
    features: [
      { name: "Vitesse maximale", value: "224 km/h" },
      { name: "0-100 km/h", value: "8.4 secondes" }
    ]
  },
  {
    name: "Consommation",
    features: [
      { name: "Cycle mixte", value: "5.6 L/100km" },
      { name: "Émissions CO2", value: "128 g/km" }
    ]
  },
  {
    name: "Équipements de confort",
    features: [
      { name: "Climatisation", value: "Automatique bi-zone" },
      { name: "Sièges", value: "Tissu" },
      { name: "Système multimédia", value: "MMI avec écran tactile 10.1\"" },
      { name: "Connectivité", value: "Bluetooth, USB, Apple CarPlay, Android Auto" },
      { name: "Audi Virtual Cockpit", value: "10.25\"" }
    ]
  },
  {
    name: "Équipements de sécurité",
    features: [
      { name: "Audi Pre Sense Front", value: "Oui" },
      { name: "Airbags", value: "Frontaux | Latéraux | Rideaux" },
      { name: "Capteurs de stationnement", value: "Arrière" },
      { name: "Régulateur de vitesse", value: "Oui" },
      { name: "Fixations ISOFIX", value: "Oui" }
    ]
  }
];

export default detailedFeatures;
