using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OldworldTools.XMLData
{

    [XmlRoot("Root")]
    [Serializable]
    public class EffectCity
    {
        [XmlElement("Entry")]
        public List<EffectCity_Entry> Entries { get; set; }

    }


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EffectCity_Entry
    {

        private string zTypeField;

        private string nameField;

        private string sourceField;

        private string effectCityUnlockField;

        private string sourceUnlockField;

        private object sourceEffectPlayerField;

        private string sourceFamilyClassField;

        private string sourceCultureField;

        private string sourceDifficultyField;

        private string sourceImprovementField;

        private string sourceLawField;

        private string sourceNationField;

        private string sourceOpinionFamilyField;

        private string sourceOpinionReligionField;

        private string sourceProjectField;

        private string sourceReligionField;

        private string sourceResourceField;

        private string sourceSpecialistField;

        private string sourceTheologyField;

        private string sourceTraitField;

        private string sourceUnitField;

        private string[] aeSourceImprovementsField;

        private string[] aeSourceResourcesField;

        private string iCityHPField;

        private string iUnitXPField;

        private string iUnitLevelField;

        private object iUnitHealField;

        private string iRangeChangeField;

        private string iRandomPromotionsField;

        private string iStrengthModifierField;

        private string iImprovementCostModifierField;

        private string iSpecialistCostModifierField;

        private string iSpecialistRuralTrainTimeModifierField;

        private string iSpecialistUrbanCostModifierField;

        private string iSpecialistUrbanTrainTimeModifierField;

        private string iDiscipleTrainTimeModifierField;

        private string iHurryDiscontentModifierField;

        private string iUrbanBuildTurnChangeField;

        private string iFamilyOpinionField;

        private string iRebelProbField;

        private string bLuxuryField;

        private string bNoHurryField;

        private object bHurryCivicsField;

        private string bHurryTrainingField;

        private object bHurryMoneyField;

        private string bHurryPopulationField;

        private string bHurryOrdersField;

        private string bEnablesGovernorField;

        private string bAlwaysConnectedField;

        private string bBuyTileField;

        private string bStateReligionImprovementsField;

        private EntryAiYieldCultureGrowth aiYieldCultureGrowthField;

        private EntryPair[] aiYieldRateField;

        private EntryPair[] aiYieldRatePopulationField;

        private EntryAiYieldRateCulture aiYieldRateCultureField;

        private EntryAiYieldRateOpinion aiYieldRateOpinionField;

        private EntryAiYieldRateMilitary aiYieldRateMilitaryField;

        private EntryAiYieldRateSpecialist aiYieldRateSpecialistField;

        private EntryAiYieldRateReligion aiYieldRateReligionField;

        private EntryAiYieldRateReligionWorld aiYieldRateReligionWorldField;

        private EntryPair[] aiYieldModifierField;

        private EntryPair[] aiImprovementModifierField;

        private EntryPair[] aiImprovementRiverModifierField;

        private EntryPair[] aiImprovementClassModifierField;

        private EntryAiUnitCostModifier aiUnitCostModifierField;

        private EntryAiUnitTrainModifier aiUnitTrainModifierField;

        private EntryAiUnitTraitXP aiUnitTraitXPField;

        private object aiUnitTraitLevelField;

        private EntryAiUnitTraitCostModifier aiUnitTraitCostModifierField;

        private EntryAiUnitTraitTrainModifier aiUnitTraitTrainModifierField;

        private EntryAiImprovementClassUpgradeTurnChange aiImprovementClassUpgradeTurnChangeField;

        private EntryAbNoImprovementClassMax abNoImprovementClassMaxField;

        private object aeHurryCivicsField;

        private object aeHurryTrainingField;

        private EntryAeHurryMoney aeHurryMoneyField;

        private object aeHurryPopulationField;

        private object aeHurryOrdersField;

        private EntryAeFreePromotion aeFreePromotionField;

        private string[] aeFreeUnitEffectCityField;

        private EntryPair[] aeTraitPromotionField;

        private EntryPair[] aaiImprovementClassYieldField;

        private EntryAaiEffectCityYieldRate aaiEffectCityYieldRateField;

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
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public string EffectCityUnlock
        {
            get
            {
                return this.effectCityUnlockField;
            }
            set
            {
                this.effectCityUnlockField = value;
            }
        }

        /// <remarks/>
        public string SourceUnlock
        {
            get
            {
                return this.sourceUnlockField;
            }
            set
            {
                this.sourceUnlockField = value;
            }
        }

        /// <remarks/>
        public object SourceEffectPlayer
        {
            get
            {
                return this.sourceEffectPlayerField;
            }
            set
            {
                this.sourceEffectPlayerField = value;
            }
        }

        /// <remarks/>
        public string SourceFamilyClass
        {
            get
            {
                return this.sourceFamilyClassField;
            }
            set
            {
                this.sourceFamilyClassField = value;
            }
        }

        /// <remarks/>
        public string SourceCulture
        {
            get
            {
                return this.sourceCultureField;
            }
            set
            {
                this.sourceCultureField = value;
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
        public string SourceOpinionFamily
        {
            get
            {
                return this.sourceOpinionFamilyField;
            }
            set
            {
                this.sourceOpinionFamilyField = value;
            }
        }

        /// <remarks/>
        public string SourceOpinionReligion
        {
            get
            {
                return this.sourceOpinionReligionField;
            }
            set
            {
                this.sourceOpinionReligionField = value;
            }
        }

        /// <remarks/>
        public string SourceProject
        {
            get
            {
                return this.sourceProjectField;
            }
            set
            {
                this.sourceProjectField = value;
            }
        }

        /// <remarks/>
        public string SourceReligion
        {
            get
            {
                return this.sourceReligionField;
            }
            set
            {
                this.sourceReligionField = value;
            }
        }

        /// <remarks/>
        public string SourceResource
        {
            get
            {
                return this.sourceResourceField;
            }
            set
            {
                this.sourceResourceField = value;
            }
        }

        /// <remarks/>
        public string SourceSpecialist
        {
            get
            {
                return this.sourceSpecialistField;
            }
            set
            {
                this.sourceSpecialistField = value;
            }
        }

        /// <remarks/>
        public string SourceTheology
        {
            get
            {
                return this.sourceTheologyField;
            }
            set
            {
                this.sourceTheologyField = value;
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
        public string SourceUnit
        {
            get
            {
                return this.sourceUnitField;
            }
            set
            {
                this.sourceUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("zValue", IsNullable = false)]
        public string[] aeSourceImprovements
        {
            get
            {
                return this.aeSourceImprovementsField;
            }
            set
            {
                this.aeSourceImprovementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("zValue", IsNullable = false)]
        public string[] aeSourceResources
        {
            get
            {
                return this.aeSourceResourcesField;
            }
            set
            {
                this.aeSourceResourcesField = value;
            }
        }

        /// <remarks/>
        public string iCityHP
        {
            get
            {
                return this.iCityHPField;
            }
            set
            {
                this.iCityHPField = value;
            }
        }

        /// <remarks/>
        public string iUnitXP
        {
            get
            {
                return this.iUnitXPField;
            }
            set
            {
                this.iUnitXPField = value;
            }
        }

        /// <remarks/>
        public string iUnitLevel
        {
            get
            {
                return this.iUnitLevelField;
            }
            set
            {
                this.iUnitLevelField = value;
            }
        }

        /// <remarks/>
        public object iUnitHeal
        {
            get
            {
                return this.iUnitHealField;
            }
            set
            {
                this.iUnitHealField = value;
            }
        }

        /// <remarks/>
        public string iRangeChange
        {
            get
            {
                return this.iRangeChangeField;
            }
            set
            {
                this.iRangeChangeField = value;
            }
        }

        /// <remarks/>
        public string iRandomPromotions
        {
            get
            {
                return this.iRandomPromotionsField;
            }
            set
            {
                this.iRandomPromotionsField = value;
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
        public string iImprovementCostModifier
        {
            get
            {
                return this.iImprovementCostModifierField;
            }
            set
            {
                this.iImprovementCostModifierField = value;
            }
        }

        /// <remarks/>
        public string iSpecialistCostModifier
        {
            get
            {
                return this.iSpecialistCostModifierField;
            }
            set
            {
                this.iSpecialistCostModifierField = value;
            }
        }

        /// <remarks/>
        public string iSpecialistRuralTrainTimeModifier
        {
            get
            {
                return this.iSpecialistRuralTrainTimeModifierField;
            }
            set
            {
                this.iSpecialistRuralTrainTimeModifierField = value;
            }
        }

        /// <remarks/>
        public string iSpecialistUrbanCostModifier
        {
            get
            {
                return this.iSpecialistUrbanCostModifierField;
            }
            set
            {
                this.iSpecialistUrbanCostModifierField = value;
            }
        }

        /// <remarks/>
        public string iSpecialistUrbanTrainTimeModifier
        {
            get
            {
                return this.iSpecialistUrbanTrainTimeModifierField;
            }
            set
            {
                this.iSpecialistUrbanTrainTimeModifierField = value;
            }
        }

        /// <remarks/>
        public string iDiscipleTrainTimeModifier
        {
            get
            {
                return this.iDiscipleTrainTimeModifierField;
            }
            set
            {
                this.iDiscipleTrainTimeModifierField = value;
            }
        }

        /// <remarks/>
        public string iHurryDiscontentModifier
        {
            get
            {
                return this.iHurryDiscontentModifierField;
            }
            set
            {
                this.iHurryDiscontentModifierField = value;
            }
        }

        /// <remarks/>
        public string iUrbanBuildTurnChange
        {
            get
            {
                return this.iUrbanBuildTurnChangeField;
            }
            set
            {
                this.iUrbanBuildTurnChangeField = value;
            }
        }

        /// <remarks/>
        public string iFamilyOpinion
        {
            get
            {
                return this.iFamilyOpinionField;
            }
            set
            {
                this.iFamilyOpinionField = value;
            }
        }

        /// <remarks/>
        public string iRebelProb
        {
            get
            {
                return this.iRebelProbField;
            }
            set
            {
                this.iRebelProbField = value;
            }
        }

        /// <remarks/>
        public string bLuxury
        {
            get
            {
                return this.bLuxuryField;
            }
            set
            {
                this.bLuxuryField = value;
            }
        }

        /// <remarks/>
        public string bNoHurry
        {
            get
            {
                return this.bNoHurryField;
            }
            set
            {
                this.bNoHurryField = value;
            }
        }

        /// <remarks/>
        public object bHurryCivics
        {
            get
            {
                return this.bHurryCivicsField;
            }
            set
            {
                this.bHurryCivicsField = value;
            }
        }

        /// <remarks/>
        public string bHurryTraining
        {
            get
            {
                return this.bHurryTrainingField;
            }
            set
            {
                this.bHurryTrainingField = value;
            }
        }

        /// <remarks/>
        public object bHurryMoney
        {
            get
            {
                return this.bHurryMoneyField;
            }
            set
            {
                this.bHurryMoneyField = value;
            }
        }

        /// <remarks/>
        public string bHurryPopulation
        {
            get
            {
                return this.bHurryPopulationField;
            }
            set
            {
                this.bHurryPopulationField = value;
            }
        }

        /// <remarks/>
        public string bHurryOrders
        {
            get
            {
                return this.bHurryOrdersField;
            }
            set
            {
                this.bHurryOrdersField = value;
            }
        }

        /// <remarks/>
        public string bEnablesGovernor
        {
            get
            {
                return this.bEnablesGovernorField;
            }
            set
            {
                this.bEnablesGovernorField = value;
            }
        }

        /// <remarks/>
        public string bAlwaysConnected
        {
            get
            {
                return this.bAlwaysConnectedField;
            }
            set
            {
                this.bAlwaysConnectedField = value;
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
        public string bStateReligionImprovements
        {
            get
            {
                return this.bStateReligionImprovementsField;
            }
            set
            {
                this.bStateReligionImprovementsField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldCultureGrowth aiYieldCultureGrowth
        {
            get
            {
                return this.aiYieldCultureGrowthField;
            }
            set
            {
                this.aiYieldCultureGrowthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair[] aiYieldRate
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair[] aiYieldRatePopulation
        {
            get
            {
                return this.aiYieldRatePopulationField;
            }
            set
            {
                this.aiYieldRatePopulationField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRateCulture aiYieldRateCulture
        {
            get
            {
                return this.aiYieldRateCultureField;
            }
            set
            {
                this.aiYieldRateCultureField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRateOpinion aiYieldRateOpinion
        {
            get
            {
                return this.aiYieldRateOpinionField;
            }
            set
            {
                this.aiYieldRateOpinionField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRateMilitary aiYieldRateMilitary
        {
            get
            {
                return this.aiYieldRateMilitaryField;
            }
            set
            {
                this.aiYieldRateMilitaryField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRateSpecialist aiYieldRateSpecialist
        {
            get
            {
                return this.aiYieldRateSpecialistField;
            }
            set
            {
                this.aiYieldRateSpecialistField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRateReligion aiYieldRateReligion
        {
            get
            {
                return this.aiYieldRateReligionField;
            }
            set
            {
                this.aiYieldRateReligionField = value;
            }
        }

        /// <remarks/>
        public EntryAiYieldRateReligionWorld aiYieldRateReligionWorld
        {
            get
            {
                return this.aiYieldRateReligionWorldField;
            }
            set
            {
                this.aiYieldRateReligionWorldField = value;
            }
        }


        /// <remarks/>
        public EntryAiUnitCostModifier aiUnitCostModifier
        {
            get
            {
                return this.aiUnitCostModifierField;
            }
            set
            {
                this.aiUnitCostModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiUnitTrainModifier aiUnitTrainModifier
        {
            get
            {
                return this.aiUnitTrainModifierField;
            }
            set
            {
                this.aiUnitTrainModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiUnitTraitXP aiUnitTraitXP
        {
            get
            {
                return this.aiUnitTraitXPField;
            }
            set
            {
                this.aiUnitTraitXPField = value;
            }
        }

        /// <remarks/>
        public object aiUnitTraitLevel
        {
            get
            {
                return this.aiUnitTraitLevelField;
            }
            set
            {
                this.aiUnitTraitLevelField = value;
            }
        }

        /// <remarks/>
        public EntryAiUnitTraitCostModifier aiUnitTraitCostModifier
        {
            get
            {
                return this.aiUnitTraitCostModifierField;
            }
            set
            {
                this.aiUnitTraitCostModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiUnitTraitTrainModifier aiUnitTraitTrainModifier
        {
            get
            {
                return this.aiUnitTraitTrainModifierField;
            }
            set
            {
                this.aiUnitTraitTrainModifierField = value;
            }
        }

        /// <remarks/>
        public EntryAiImprovementClassUpgradeTurnChange aiImprovementClassUpgradeTurnChange
        {
            get
            {
                return this.aiImprovementClassUpgradeTurnChangeField;
            }
            set
            {
                this.aiImprovementClassUpgradeTurnChangeField = value;
            }
        }

        /// <remarks/>
        public EntryAbNoImprovementClassMax abNoImprovementClassMax
        {
            get
            {
                return this.abNoImprovementClassMaxField;
            }
            set
            {
                this.abNoImprovementClassMaxField = value;
            }
        }

        /// <remarks/>
        public object aeHurryCivics
        {
            get
            {
                return this.aeHurryCivicsField;
            }
            set
            {
                this.aeHurryCivicsField = value;
            }
        }

        /// <remarks/>
        public object aeHurryTraining
        {
            get
            {
                return this.aeHurryTrainingField;
            }
            set
            {
                this.aeHurryTrainingField = value;
            }
        }

        /// <remarks/>
        public EntryAeHurryMoney aeHurryMoney
        {
            get
            {
                return this.aeHurryMoneyField;
            }
            set
            {
                this.aeHurryMoneyField = value;
            }
        }

        /// <remarks/>
        public object aeHurryPopulation
        {
            get
            {
                return this.aeHurryPopulationField;
            }
            set
            {
                this.aeHurryPopulationField = value;
            }
        }

        /// <remarks/>
        public object aeHurryOrders
        {
            get
            {
                return this.aeHurryOrdersField;
            }
            set
            {
                this.aeHurryOrdersField = value;
            }
        }

        /// <remarks/>
        public EntryAeFreePromotion aeFreePromotion
        {
            get
            {
                return this.aeFreePromotionField;
            }
            set
            {
                this.aeFreePromotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("zValue", IsNullable = false)]
        public string[] aeFreeUnitEffectCity
        {
            get
            {
                return this.aeFreeUnitEffectCityField;
            }
            set
            {
                this.aeFreeUnitEffectCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair[] aeTraitPromotion
        {
            get
            {
                return this.aeTraitPromotionField;
            }
            set
            {
                this.aeTraitPromotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair[] aaiImprovementClassYield
        {
            get
            {
                return this.aaiImprovementClassYieldField;
            }
            set
            {
                this.aaiImprovementClassYieldField = value;
            }
        }

        /// <remarks/>
        public EntryAaiEffectCityYieldRate aaiEffectCityYieldRate
        {
            get
            {
                return this.aaiEffectCityYieldRateField;
            }
            set
            {
                this.aaiEffectCityYieldRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EntryAiYieldCultureGrowth
    {

        private EntryAiYieldCultureGrowthPair pairField;

        /// <remarks/>
        public EntryAiYieldCultureGrowthPair Pair
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
    public partial class EntryAiYieldCultureGrowthPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiYieldRateCulture
    {

        private EntryAiYieldRateCulturePair pairField;

        /// <remarks/>
        public EntryAiYieldRateCulturePair Pair
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
    public partial class EntryAiYieldRateCulturePair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiYieldRateOpinion
    {

        private EntryAiYieldRateOpinionPair pairField;

        /// <remarks/>
        public EntryAiYieldRateOpinionPair Pair
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
    public partial class EntryAiYieldRateOpinionPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiYieldRateMilitary
    {

        private EntryAiYieldRateMilitaryPair pairField;

        /// <remarks/>
        public EntryAiYieldRateMilitaryPair Pair
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
    public partial class EntryAiYieldRateMilitaryPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiYieldRateSpecialist
    {

        private EntryAiYieldRateSpecialistPair pairField;

        /// <remarks/>
        public EntryAiYieldRateSpecialistPair Pair
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
    public partial class EntryAiYieldRateSpecialistPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiYieldRateReligion
    {

        private EntryAiYieldRateReligionPair pairField;

        /// <remarks/>
        public EntryAiYieldRateReligionPair Pair
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
    public partial class EntryAiYieldRateReligionPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiYieldRateReligionWorld
    {

        private EntryAiYieldRateReligionWorldPair pairField;

        /// <remarks/>
        public EntryAiYieldRateReligionWorldPair Pair
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
    public partial class EntryAiYieldRateReligionWorldPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiUnitCostModifier
    {

        private EntryAiUnitCostModifierPair pairField;

        /// <remarks/>
        public EntryAiUnitCostModifierPair Pair
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
    public partial class EntryAiUnitCostModifierPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiUnitTrainModifier
    {

        private EntryAiUnitTrainModifierPair pairField;

        /// <remarks/>
        public EntryAiUnitTrainModifierPair Pair
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
    public partial class EntryAiUnitTrainModifierPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiUnitTraitXP
    {

        private EntryAiUnitTraitXPPair pairField;

        /// <remarks/>
        public EntryAiUnitTraitXPPair Pair
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
    public partial class EntryAiUnitTraitXPPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiUnitTraitCostModifier
    {

        private EntryAiUnitTraitCostModifierPair pairField;

        /// <remarks/>
        public EntryAiUnitTraitCostModifierPair Pair
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
    public partial class EntryAiUnitTraitCostModifierPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiUnitTraitTrainModifier
    {

        private EntryAiUnitTraitTrainModifierPair pairField;

        /// <remarks/>
        public EntryAiUnitTraitTrainModifierPair Pair
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
    public partial class EntryAiUnitTraitTrainModifierPair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAiImprovementClassUpgradeTurnChange
    {

        private EntryAiImprovementClassUpgradeTurnChangePair pairField;

        /// <remarks/>
        public EntryAiImprovementClassUpgradeTurnChangePair Pair
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
    public partial class EntryAiImprovementClassUpgradeTurnChangePair
    {

        private string zIndexField;

        private short iValueField;

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
        public short iValue
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
    public partial class EntryAbNoImprovementClassMax
    {

        private EntryAbNoImprovementClassMaxPair pairField;

        /// <remarks/>
        public EntryAbNoImprovementClassMaxPair Pair
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
    public partial class EntryAbNoImprovementClassMaxPair
    {

        private string zIndexField;

        private short bValueField;

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
        public short bValue
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EntryAeHurryMoney
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
    public partial class EntryAeFreePromotion
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
    public partial class EntryPair6
    {

        private string zIndexField;

        private string zValueField;

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
    public partial class EntryPair7
    {

        private string zIndexField;

        private EntryPairSubPair subPairField;

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
        public EntryPairSubPair SubPair
        {
            get
            {
                return this.subPairField;
            }
            set
            {
                this.subPairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EntryPairSubPair
    {

        private string zSubIndexField;

        private short iValueField;

        /// <remarks/>
        public string zSubIndex
        {
            get
            {
                return this.zSubIndexField;
            }
            set
            {
                this.zSubIndexField = value;
            }
        }

        /// <remarks/>
        public short iValue
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
    public partial class EntryAaiEffectCityYieldRate
    {

        private EntryAaiEffectCityYieldRatePair pairField;

        /// <remarks/>
        public EntryAaiEffectCityYieldRatePair Pair
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
    public partial class EntryAaiEffectCityYieldRatePair
    {

        private string zIndexField;

        private EntryAaiEffectCityYieldRatePairSubPair[] subPairField;

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
        [System.Xml.Serialization.XmlElementAttribute("SubPair")]
        public EntryAaiEffectCityYieldRatePairSubPair[] SubPair
        {
            get
            {
                return this.subPairField;
            }
            set
            {
                this.subPairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EntryAaiEffectCityYieldRatePairSubPair
    {

        private string zSubIndexField;

        private short iValueField;

        /// <remarks/>
        public string zSubIndex
        {
            get
            {
                return this.zSubIndexField;
            }
            set
            {
                this.zSubIndexField = value;
            }
        }

        /// <remarks/>
        public short iValue
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


}
