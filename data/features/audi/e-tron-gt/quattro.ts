// Detailed features for Audi e-tron GT quattro
import { FeatureGroup } from "../../../offers";

const detailedFeatures: FeatureGroup[] = [
  {
    name: "Caractéristiques",
    features: [
      { name: "Moteur", value: "Électrique" },
      { name: "Puissance", value: "476 ch (530 ch en boost)" },
      { name: "Couple", value: "630 Nm" },
      { name: "Batterie", value: "93.4 kWh" }
    ]
  },
  {
    name: "Transmission",
    features: [
      { name: "Boîte de vitesses", value: "Automatique 2 rapports" },
      { name: "Transmission", value: "Intégrale quattro" }
    ]
  },
  {
    name: "Performances",
    features: [
      { name: "Vitesse maximale", value: "245 km/h" },
      { name: "0-100 km/h", value: "4.1 secondes" },
      { name: "Autonomie", value: "Jusqu'à 488 km (WLTP)" }
    ]
  },
  {
    name: "Recharge",
    features: [
      { name: "Puissance de charge AC", value: "11 kW" },
      { name: "Puissance de charge DC", value: "Jusqu'à 270 kW" },
      { name: "Temps de recharge DC (5-80%)", value: "22.5 minutes" }
    ]
  },
  {
    name: "Équipements de confort",
    features: [
      { name: "Climatisation", value: "Automatique 3 zones" },
      { name: "Sièges", value: "Cuir/Alcantara" },
      { name: "Sièges avant", value: "Chauffants et électriques" },
      { name: "Système multimédia", value: "MMI Navigation Plus avec écran tactile 10.1\"" },
      { name: "Audi Virtual Cockpit", value: "12.3\"" },
      { name: "Éclairage d'ambiance", value: "Multicolore" },
      { name: "Toit panoramique en verre", value: "Oui" }
    ]
  },
  {
    name: "Équipements de sécurité",
    features: [
      { name: "Audi Pre Sense Front", value: "Oui" },
      { name: "Airbags", value: "Frontaux | Latéraux | Rideaux" },
      { name: "Capteurs de stationnement", value: "Avant et arrière" },
      { name: "Caméra de recul", value: "Oui" },
      { name: "Régulateur de vitesse adaptatif", value: "Oui" },
      { name: "Assistant de maintien dans la voie", value: "Oui" }
    ]
  }
];

export default detailedFeatures;
