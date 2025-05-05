// Default detailed features for generic trims
import { FeatureGroup } from "../../offers";

// Basic trim detailed features
export const basicDetailedFeatures: FeatureGroup[] = [
  {
    name: "Équipements de confort",
    features: [
      { name: "Climatisation", value: "Manuelle" },
      { name: "Vitres électriques", value: "Avant" },
      { name: "Connectivité", value: "Bluetooth" }
    ]
  },
  {
    name: "Équipements de sécurité",
    features: [
      { name: "ABS", value: "Oui" },
      { name: "Airbags", value: "Frontaux" },
      { name: "Fixations ISOFIX", value: "Oui" }
    ]
  }
];

// Comfort trim detailed features
export const comfortDetailedFeatures: FeatureGroup[] = [
  {
    name: "Équipements de confort",
    features: [
      { name: "Climatisation", value: "Automatique" },
      { name: "Vitres électriques", value: "Avant et arrière" },
      { name: "Connectivité", value: "Bluetooth, USB" },
      { name: "Régulateur de vitesse", value: "Oui" }
    ]
  },
  {
    name: "Équipements de sécurité",
    features: [
      { name: "ABS", value: "Oui" },
      { name: "Airbags", value: "Frontaux | Latéraux" },
      { name: "Capteurs de stationnement", value: "Arrière" },
      { name: "Fixations ISOFIX", value: "Oui" }
    ]
  }
];

// Premium trim detailed features
export const premiumDetailedFeatures: FeatureGroup[] = [
  {
    name: "Équipements de confort",
    features: [
      { name: "Climatisation", value: "Automatique bi-zone" },
      { name: "Vitres électriques", value: "Avant et arrière" },
      { name: "Connectivité", value: "Bluetooth, USB, Apple CarPlay, Android Auto" },
      { name: "Régulateur de vitesse", value: "Adaptatif" },
      { name: "Sièges", value: "Cuir, chauffants" },
      { name: "Système de navigation", value: "Intégré" }
    ]
  },
  {
    name: "Équipements de sécurité",
    features: [
      { name: "ABS", value: "Oui" },
      { name: "Airbags", value: "Frontaux | Latéraux | Rideaux" },
      { name: "Capteurs de stationnement", value: "Avant et arrière" },
      { name: "Caméra de recul", value: "Oui" },
      { name: "Fixations ISOFIX", value: "Oui" }
    ]
  }
];

// Map of default detailed features by trim ID
export const defaultDetailedFeatures: Record<string, FeatureGroup[]> = {
  basic: basicDetailedFeatures,
  comfort: comfortDetailedFeatures,
  premium: premiumDetailedFeatures
};
