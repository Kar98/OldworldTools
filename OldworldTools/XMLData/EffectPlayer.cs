using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OldworldTools.XMLData
{

    [XmlRoot("Root")]
    [Serializable]
    public class EffectPlayer
    {
        [XmlElement("Entry")]
        public List<EffectPlayer_Entry> Entries { get; set; }

    }


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class EffectPlayer_Entry
    {

        private string zTypeField;

        private string nameField;

        private string sourceDifficultyField;

        private string sourceImprovementField;

        private string sourceLawField;

        private string sourceNationField;

        private string sourceReligionStateField;

        private string sourceTechField;

        private string sourceTraitField;

        private string effectPlayerField;

        private string effectCityField;

        private string coastEffectCityField;

        private string stateReligionEffectCityField;

        private string capitalEffectCityField;

        private string effectUnitField;

        private string startBonusField;

        private string foundBonusField;

        private string iVPField;

        private string iMaxActionsField;

        private string iXPIdleTurnField;

        private string iXPModifierField;

        private string iHarvestModifierField;

        private string iConsumptionModifierField;

        private string iWonderModifierField;

        private string iStartLawModifierField;

        private string iSwitchLawModifierField;

        private object iTrainingOrderModifierField;

        private string iBuildTurnChangeField;

        private string iFatigueLimitChangeField;

        private string iRevealChangeField;

        private string iTechsAvailableChangeField;

        private string iLeaderOpinionChangeField;

        private string bStartMusicField;

        private string bRedrawTechsField;

        private string bAddRoadField;

        private string bAddUrbanField;

        private string bRaiseImprovementField;

        private object bNoWondersField;

        private object bNoReligionsField;

        private object bNoTheologiesField;

        private string bMultipleWorkersField;

        private string bBuyTileField;

        private string bRiverMovementField;

        private string bNoSellPenaltyField;

        private string bNoUnitConsumptionField;

        private string bPurgeReligionsField;

        private string bBuildAllReligionsField;

        private string bHolyCitiesVisibleField;

        private string bLegitimacyOrdersField;

        private EntryAiUnitKillYield aiUnitKillYieldField;

        private EntryAiWarYield aiWarYieldField;

        private EntryAiYieldRate aiYieldRateField;

        private EntryAiYieldUpkeep aiYieldUpkeepField;

        private EntryAeTradeYield aeTradeYieldField;

        private EntryAeWaterUnit aeWaterUnitField;

        private EntryAeHideUnit aeHideUnitField;

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
        public string SourceDifficulty
        {
            get
            {
                return this.sourceDifficultyField;
            }
            set
            {
                this.sourceDifficultyField = value;
            }
        }

        /// <remarks/>
        public string SourceImprovement
        {
            get
            {
                return this.sourceImprovementField;
            }
            set
            {
                this.sourceImprovementField = value;
            }
        }

        /// <remarks/>
        public string SourceLaw
        {
            get
            {
                return this.sourceLawField;
            }
            set
            {
                this.sourceLawField = value;
            }
        }

        /// <remarks/>
        public string SourceNation
        {
            get
            {
                return this.sourceNationField;
            }
            set
            {
                this.sourceNationField = value;
            }
        }

        /// <remarks/>
        public string SourceReligionState
        {
            get
            {
                return this.sourceReligionStateField;
            }
            set
            {
                this.sourceReligionStateField = value;
            }
        }

        /// <remarks/>
        public string SourceTech
        {
            get
            {
                return this.sourceTechField;
            }
            set
            {
                this.sourceTechField = value;
            }
        }

        /// <remarks/>
        public string SourceTrait
        {
            get
            {
                return this.sourceTraitField;
            }
            set
            {
                this.sourceTraitField = value;
            }
        }

        /// <remarks/>
        public string EffectPlayer
        {
            get
            {
                return this.effectPlayerField;
            }
            set
            {
                this.effectPlayerField = value;
            }
        }

        /// <remarks/>
        public string EffectCity
        {
            get
            {
                return this.effectCityField;
            }
            set
            {
                this.effectCityField = value;
            }
        }

        /// <remarks/>
        public string CoastEffectCity
        {
            get
            {
                return this.coastEffectCityField;
            }
            set
            {
                this.coastEffectCityField = value;
            }
        }

        /// <remarks/>
        public string StateReligionEffectCity
        {
            get
            {
                return this.stateReligionEffectCityField;
            }
            set
            {
                this.stateReligionEffectCityField = value;
            }
        }

        /// <remarks/>
        public string CapitalEffectCity
        {
            get
            {
                return this.capitalEffectCityField;
            }
            set
            {
                this.capitalEffectCityField = value;
            }
        }

        /// <remarks/>
        public string EffectUnit
        {
            get
            {
                return this.effectUnitField;
            }
            set
            {
                this.effectUnitField = value;
            }
        }

        /// <remarks/>
        public string StartBonus
        {
            get
            {
                return this.startBonusField;
            }
            set
            {
                this.startBonusField = value;
            }
        }

        /// <remarks/>
        public string FoundBonus
        {
            get
            {
                return this.foundBonusField;
            }
            set
            {
                this.foundBonusField = value;
            }
        }

        /// <remarks/>
        public string iVP
        {
            get
            {
                return this.iVPField;
            }
            set
            {
                this.iVPField = value;
            }
        }

        /// <remarks/>
        public string iMaxActions
        {
            get
            {
                return this.iMaxActionsField;
            }
            set
            {
                this.iMaxActionsField = value;
            }
        }

        /// <remarks/>
        public string iXPIdleTurn
        {
            get
            {
                return this.iXPIdleTurnField;
            }
            set
            {
                this.iXPIdleTurnField = value;
            }
        }

        /// <remarks/>
        public string iXPModifier
        {
            get
            {
                return this.iXPModifierField;
            }
            set
            {
                this.iXPModifierField = value;
            }
        }

        /// <remarks/>
        public string iHarvestModifier
        {
            get
            {
                return this.iHarvestModifierField;
            }
            set
            {
                this.iHarvestModifierField = value;
            }
        }

        /// <remarks/>
        public string iConsumptionModifier
        {
            get
            {
                return this.iConsumptionModifierField;
            }
            set
            {
                this.iConsumptionModifierField = value;
            }
        }

        /// <remarks/>
        public string iWonderModifier
        {
            get
            {
                return this.iWonderModifierField;
            }
            set
            {
                this.iWonderModifierField = value;
            }
        }

        /// <remarks/>
        public string iStartLawModifier
        {
            get
            {
                return this.iStartLawModifierField;
            }
            set
            {
                this.iStartLawModifierField = value;
            }
        }

        /// <remarks/>
        public string iSwitchLawModifier
        {
            get
            {
                return this.iSwitchLawModifierField;
            }
            set
            {
                this.iSwitchLawModifierField = value;
            }
        }

        /// <remarks/>
        public object iTrainingOrderModifier
        {
            get
            {
                return this.iTrainingOrderModifierField;
            }
            set
            {
                this.iTrainingOrderModifierField = value;
            }
        }

        /// <remarks/>
        public string iBuildTurnChange
        {
            get
            {
                return this.iBuildTurnChangeField;
            }
            set
            {
                this.iBuildTurnChangeField = value;
            }
        }

        /// <remarks/>
        public string iFatigueLimitChange
        {
            get
            {
                return this.iFatigueLimitChangeField;
            }
            set
            {
                this.iFatigueLimitChangeField = value;
            }
        }

        /// <remarks/>
        public string iRevealChange
        {
            get
            {
                return this.iRevealChangeField;
            }
            set
            {
                this.iRevealChangeField = value;
            }
        }

        /// <remarks/>
        public string iTechsAvailableChange
        {
            get
            {
                return this.iTechsAvailableChangeField;
            }
            set
            {
                this.iTechsAvailableChangeField = value;
            }
        }

        /// <remarks/>
        public string iLeaderOpinionChange
        {
            get
            {
                return this.iLeaderOpinionChangeField;
            }
            set
            {
                this.iLeaderOpinionChangeField = value;
            }
        }

        /// <remarks/>
        public string bStartMusic
        {
            get
            {
                return this.bStartMusicField;
            }
            set
            {
                this.bStartMusicField = value;
            }
        }

        /// <remarks/>
        public string bRedrawTechs
        {
            get
            {
                return this.bRedrawTechsField;
            }
            set
            {
                this.bRedrawTechsField = value;
            }
        }

        /// <remarks/>
        public string bAddRoad
        {
            get
            {
                return this.bAddRoadField;
            }
            set
            {
                this.bAddRoadField = value;
            }
        }

        /// <remarks/>
        public string bAddUrban
        {
            get
            {
                return this.bAddUrbanField;
            }
            set
            {
                this.bAddUrbanField = value;
            }
        }

        /// <remarks/>
        public string bRaiseImprovement
        {
            get
            {
                return this.bRaiseImprovementField;
            }
            set
            {
                this.bRaiseImprovementField = value;
            }
        }

        /// <remarks/>
        public object bNoWonders
        {
            get
            {
                return this.bNoWondersField;
            }
            set
            {
                this.bNoWondersField = value;
            }
        }

        /// <remarks/>
        public object bNoReligions
        {
            get
            {
                return this.bNoReligionsField;
            }
            set
            {
                this.bNoReligionsField = value;
            }
        }

        /// <remarks/>
        public object bNoTheologies
        {
            get
            {
                return this.bNoTheologiesField;
            }
            set
            {
                this.bNoTheologiesField = value;
            }
        }

        /// <remarks/>
        public string bMultipleWorkers
        {
            get
            {
                return this.bMultipleWorkersField;
            }
            set
            {
                this.bMultipleWorkersField = value;
            }
        }

        /// <remarks/>
        public string bBuyTile
        {
            get
            {
                return this.bBuyTileField;
            }
            set
            {
                this.bBuyTileField = value;
            }
        }

        /// <remarks/>
        public string bRiverMovement
        {
            get
            {
                return this.bRiverMovementField;
            }
            set
            {
                this.bRiverMovementField = value;
            }
        }

        /// <remarks/>
        public string bNoSellPenalty
        {
            get
            {
                return this.bNoSellPenaltyField;
            }
            set
            {
                this.bNoSellPenaltyField = value;
            }
        }

        /// <remarks/>
        public string bNoUnitConsumption
        {
            get
            {
                return this.bNoUnitConsumptionField;
            }
            set
            {
                this.bNoUnitConsumptionField = value;
            }
        }

        /// <remarks/>
        public string bPurgeReligions
        {
            get
            {
                return this.bPurgeReligionsField;
            }
            set
            {
                this.bPurgeReligionsField = value;
            }
        }

        /// <remarks/>
        public string bBuildAllReligions
        {
            get
            {
                return this.bBuildAllReligionsField;
            }
            set
            {
                this.bBuildAllReligionsField = value;
            }
        }

        /// <remarks/>
        public string bHolyCitiesVisible
        {
            get
            {
                return this.bHolyCitiesVisibleField;
            }
            set
            {
                this.bHolyCitiesVisibleField = value;
            }
        }

        /// <remarks/>
        public string bLegitimacyOrders
        {
            get
            {
                return this.bLegitimacyOrdersField;
            }
            set
            {
                this.bLegitimacyOrdersField = value;
            }
        }

        /// <remarks/>
        public EntryAiUnitKillYield aiUnitKillYield
        {
            get
            {
                return this.aiUnitKillYieldField;
            }
            set
            {
                this.aiUnitKillYieldField = value;
            }
        }

        /// <remarks/>
        public EntryAiWarYield aiWarYield
        {
            get
            {
                return this.aiWarYieldField;
            }
            set
            {
                this.aiWarYieldField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRate aiYieldRate
        {
            get
            {
                return this.aiYieldRateField;
            }
            set
            {
                this.aiYieldRateField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldUpkeep aiYieldUpkeep
        {
            get
            {
                return this.aiYieldUpkeepField;
            }
            set
            {
                this.aiYieldUpkeepField = value;
            }
        }

        /// <remarks/>
        public EntryAeTradeYield aeTradeYield
        {
            get
            {
                return this.aeTradeYieldField;
            }
            set
            {
                this.aeTradeYieldField = value;
            }
        }

        /// <remarks/>
        public EntryAeWaterUnit aeWaterUnit
        {
            get
            {
                return this.aeWaterUnitField;
            }
            set
            {
                this.aeWaterUnitField = value;
            }
        }

        /// <remarks/>
        public EntryAeHideUnit aeHideUnit
        {
            get
            {
                return this.aeHideUnitField;
            }
            set
            {
                this.aeHideUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiUnitKillYield
    {

        private EntryAiUnitKillYieldPair pairField;

        /// <remarks/>
        public EntryAiUnitKillYieldPair Pair
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
    public class EntryAiUnitKillYieldPair
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
    public class EntryAiWarYield
    {

        private EntryAiWarYieldPair pairField;

        /// <remarks/>
        public EntryAiWarYieldPair Pair
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
    public class EntryAiWarYieldPair
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
    public class EntryAiYieldRate
    {

        private EntryAiYieldRatePair pairField;

        /// <remarks/>
        public EntryAiYieldRatePair Pair
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
    public class EntryAiYieldRatePair
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
    public class EntryAiYieldUpkeep
    {

        private EntryAiYieldUpkeepPair pairField;

        /// <remarks/>
        public EntryAiYieldUpkeepPair Pair
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
    public class EntryAiYieldUpkeepPair
    {

        private string zIndexField;

        private sbyte iValueField;

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
        public sbyte iValue
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
    public class EntryAeTradeYield
    {

        private string zValueField;

        /// <remarks/>
        public string zValue
        {
            get
            {
                return this.zValueField;
            }
            set
            {
                this.zValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAeWaterUnit
    {

        private string zValueField;

        /// <remarks/>
        public string zValue
        {
            get
            {
                return this.zValueField;
            }
            set
            {
                this.zValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAeHideUnit
    {

        private string zValueField;

        /// <remarks/>
        public string zValue
        {
            get
            {
                return this.zValueField;
            }
            set
            {
                this.zValueField = value;
            }
        }
    }


}
