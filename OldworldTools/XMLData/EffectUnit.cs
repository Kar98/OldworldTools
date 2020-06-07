using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OldworldTools.XMLData
{
    [XmlRoot("Root")]
    [Serializable]
    public class EffectUnit
    {
        [XmlElement("Entry")]
        public List<EffectUnit_Entry> Entries{ get; set; }

    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class EffectUnit_Entry
    {

        private string zTypeField;

        private string nameField;

        private string zIconNameField;

        private string iStrengthModifierField;

        private string iDefenseModifierField;

        private string iCriticalChanceField;

        private string iVisionExtraField;

        private string iMovementExtraField;

        private string iFatigueExtraField;

        private string iRangeExtraField;

        private string iRiverAttackModifierField;

        private string iSettlementAttackModifierField;

        private string iUrbanAttackModifierField;

        private string iDamagedModifierField;

        private string iGeneralModifierField;

        private string iBarbarianModifierField;

        private string iAdjacentEffectDefenseModifierField;

        private string iHealExtraField;

        private string iHealAlwaysField;

        private string bRoutField;

        private string bIgnoresDistanceField;

        private string bLaunchOffensiveField;

        private string bNoRoadCooldownField;

        private EntryAiTerrainModifier aiTerrainModifierField;

        private EntryAiHeightModifier aiHeightModifierField;

        private EntryAiVegetationModifier aiVegetationModifierField;

        private EntryAiUnitTraitModifier aiUnitTraitModifierField;

        private object aiUnitTraitModifierAttackField;

        private object aiUnitTraitModifierDefenseField;

        private object aiUnitTraitModifierMeleeField;

        private EntryAbHideVegetation abHideVegetationField;

        private EntryPair[] abUnitTraitValidField;

        /// <remarks/>
        public string zType
        {
            get
            {
                return this.zTypeField;
            }
            set
            {
                this.zTypeField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string zIconName
        {
            get
            {
                return this.zIconNameField;
            }
            set
            {
                this.zIconNameField = value;
            }
        }

        /// <remarks/>
        public string iStrengthModifier
        {
            get
            {
                return this.iStrengthModifierField;
            }
            set
            {
                this.iStrengthModifierField = value;
            }
        }

        /// <remarks/>
        public string iDefenseModifier
        {
            get
            {
                return this.iDefenseModifierField;
            }
            set
            {
                this.iDefenseModifierField = value;
            }
        }

        /// <remarks/>
        public string iCriticalChance
        {
            get
            {
                return this.iCriticalChanceField;
            }
            set
            {
                this.iCriticalChanceField = value;
            }
        }

        /// <remarks/>
        public string iVisionExtra
        {
            get
            {
                return this.iVisionExtraField;
            }
            set
            {
                this.iVisionExtraField = value;
            }
        }

        /// <remarks/>
        public string iMovementExtra
        {
            get
            {
                return this.iMovementExtraField;
            }
            set
            {
                this.iMovementExtraField = value;
            }
        }

        /// <remarks/>
        public string iFatigueExtra
        {
            get
            {
                return this.iFatigueExtraField;
            }
            set
            {
                this.iFatigueExtraField = value;
            }
        }

        /// <remarks/>
        public string iRangeExtra
        {
            get
            {
                return this.iRangeExtraField;
            }
            set
            {
                this.iRangeExtraField = value;
            }
        }

        /// <remarks/>
        public string iRiverAttackModifier
        {
            get
            {
                return this.iRiverAttackModifierField;
            }
            set
            {
                this.iRiverAttackModifierField = value;
            }
        }

        /// <remarks/>
        public string iSettlementAttackModifier
        {
            get
            {
                return this.iSettlementAttackModifierField;
            }
            set
            {
                this.iSettlementAttackModifierField = value;
            }
        }

        /// <remarks/>
        public string iUrbanAttackModifier
        {
            get
            {
                return this.iUrbanAttackModifierField;
            }
            set
            {
                this.iUrbanAttackModifierField = value;
            }
        }

        /// <remarks/>
        public string iDamagedModifier
        {
            get
            {
                return this.iDamagedModifierField;
            }
            set
            {
                this.iDamagedModifierField = value;
            }
        }

        /// <remarks/>
        public string iGeneralModifier
        {
            get
            {
                return this.iGeneralModifierField;
            }
            set
            {
                this.iGeneralModifierField = value;
            }
        }

        /// <remarks/>
        public string iBarbarianModifier
        {
            get
            {
                return this.iBarbarianModifierField;
            }
            set
            {
                this.iBarbarianModifierField = value;
            }
        }

        /// <remarks/>
        public string iAdjacentEffectDefenseModifier
        {
            get
            {
                return this.iAdjacentEffectDefenseModifierField;
            }
            set
            {
                this.iAdjacentEffectDefenseModifierField = value;
            }
        }

        /// <remarks/>
        public string iHealExtra
        {
            get
            {
                return this.iHealExtraField;
            }
            set
            {
                this.iHealExtraField = value;
            }
        }

        /// <remarks/>
        public string iHealAlways
        {
            get
            {
                return this.iHealAlwaysField;
            }
            set
            {
                this.iHealAlwaysField = value;
            }
        }

        /// <remarks/>
        public string bRout
        {
            get
            {
                return this.bRoutField;
            }
            set
            {
                this.bRoutField = value;
            }
        }

        /// <remarks/>
        public string bIgnoresDistance
        {
            get
            {
                return this.bIgnoresDistanceField;
            }
            set
            {
                this.bIgnoresDistanceField = value;
            }
        }

        /// <remarks/>
        public string bLaunchOffensive
        {
            get
            {
                return this.bLaunchOffensiveField;
            }
            set
            {
                this.bLaunchOffensiveField = value;
            }
        }

        /// <remarks/>
        public string bNoRoadCooldown
        {
            get
            {
                return this.bNoRoadCooldownField;
            }
            set
            {
                this.bNoRoadCooldownField = value;
            }
        }

        /// <remarks/>
        public EntryAiTerrainModifier aiTerrainModifier
        {
            get
            {
                return this.aiTerrainModifierField;
            }
            set
            {
                this.aiTerrainModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiHeightModifier aiHeightModifier
        {
            get
            {
                return this.aiHeightModifierField;
            }
            set
            {
                this.aiHeightModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiVegetationModifier aiVegetationModifier
        {
            get
            {
                return this.aiVegetationModifierField;
            }
            set
            {
                this.aiVegetationModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiUnitTraitModifier aiUnitTraitModifier
        {
            get
            {
                return this.aiUnitTraitModifierField;
            }
            set
            {
                this.aiUnitTraitModifierField = value;
            }
        }

        /// <remarks/>
        public object aiUnitTraitModifierAttack
        {
            get
            {
                return this.aiUnitTraitModifierAttackField;
            }
            set
            {
                this.aiUnitTraitModifierAttackField = value;
            }
        }

        /// <remarks/>
        public object aiUnitTraitModifierDefense
        {
            get
            {
                return this.aiUnitTraitModifierDefenseField;
            }
            set
            {
                this.aiUnitTraitModifierDefenseField = value;
            }
        }

        /// <remarks/>
        public object aiUnitTraitModifierMelee
        {
            get
            {
                return this.aiUnitTraitModifierMeleeField;
            }
            set
            {
                this.aiUnitTraitModifierMeleeField = value;
            }
        }

        /// <remarks/>
        public EntryAbHideVegetation abHideVegetation
        {
            get
            {
                return this.abHideVegetationField;
            }
            set
            {
                this.abHideVegetationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair[] abUnitTraitValid
        {
            get
            {
                return this.abUnitTraitValidField;
            }
            set
            {
                this.abUnitTraitValidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiTerrainModifier
    {

        private EntryAiTerrainModifierPair pairField;

        /// <remarks/>
        public EntryAiTerrainModifierPair Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiTerrainModifierPair
    {

        private string zIndexField;

        private byte iValueField;

        /// <remarks/>
        public string zIndex
        {
            get
            {
                return this.zIndexField;
            }
            set
            {
                this.zIndexField = value;
            }
        }

        /// <remarks/>
        public byte iValue
        {
            get
            {
                return this.iValueField;
            }
            set
            {
                this.iValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiHeightModifier
    {

        private EntryAiHeightModifierPair pairField;

        /// <remarks/>
        public EntryAiHeightModifierPair Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiHeightModifierPair
    {

        private string zIndexField;

        private byte iValueField;

        /// <remarks/>
        public string zIndex
        {
            get
            {
                return this.zIndexField;
            }
            set
            {
                this.zIndexField = value;
            }
        }

        /// <remarks/>
        public byte iValue
        {
            get
            {
                return this.iValueField;
            }
            set
            {
                this.iValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiVegetationModifier
    {

        private EntryAiVegetationModifierPair pairField;

        /// <remarks/>
        public EntryAiVegetationModifierPair Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiVegetationModifierPair
    {

        private string zIndexField;

        private byte iValueField;

        /// <remarks/>
        public string zIndex
        {
            get
            {
                return this.zIndexField;
            }
            set
            {
                this.zIndexField = value;
            }
        }

        /// <remarks/>
        public byte iValue
        {
            get
            {
                return this.iValueField;
            }
            set
            {
                this.iValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiUnitTraitModifier
    {

        private EntryAiUnitTraitModifierPair pairField;

        /// <remarks/>
        public EntryAiUnitTraitModifierPair Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiUnitTraitModifierPair
    {

        private string zIndexField;

        private byte iValueField;

        /// <remarks/>
        public string zIndex
        {
            get
            {
                return this.zIndexField;
            }
            set
            {
                this.zIndexField = value;
            }
        }

        /// <remarks/>
        public byte iValue
        {
            get
            {
                return this.iValueField;
            }
            set
            {
                this.iValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAbHideVegetation
    {

        private EntryAbHideVegetationPair pairField;

        /// <remarks/>
        public EntryAbHideVegetationPair Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAbHideVegetationPair
    {

        private string zIndexField;

        private byte bValueField;

        /// <remarks/>
        public string zIndex
        {
            get
            {
                return this.zIndexField;
            }
            set
            {
                this.zIndexField = value;
            }
        }

        /// <remarks/>
        public byte bValue
        {
            get
            {
                return this.bValueField;
            }
            set
            {
                this.bValueField = value;
            }
        }
    }
}
