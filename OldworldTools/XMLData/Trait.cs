using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OldworldTools.XMLData
{

    [XmlRoot("Root")]
    [Serializable]
    public class Trait
    {
        [XmlElement("Entry")]
        public List<Trait_Entry> Entries { get; set; }

    }


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Trait_Entry
    {

        private string zTypeField;

        private string nameField;

        private string zIconNameField;

        private string iAdjectiveDieField;

        private string iNoFamilyDieField;

        private string iBarbDieField;

        private string iInjuryDieField;

        private string iAdultProbField;

        private string iDieProbField;

        private string iRemoveProbField;

        private string iOpinionField;

        private string iOpinionFamilyField;

        private string iBirthModifierField;

        private string iWarModifierField;

        private string bArchetypeField;

        private string bAdjectiveField;

        private string bUpgradeField;

        private string bNoEventsField;

        private string bNoMarryField;

        private string bNoBirthField;

        private string bNoHeirField;

        private string bNoJobField;

        private string bGovernorPrereqField;

        private string bGeneralPrereqField;

        private string bRemoveLeaderField;

        private string leaderEffectPlayerField;

        private string governorEffectCityField;

        private string generalEffectUnitField;

        private string leaderEffectUnitField;

        private string cognomenField;

        private EntryPair[] aiRatingField;

        private EntryAiTraitProb aiTraitProbField;

        private EntryPair1[] aiMortalityDieProbField;

        private byte[] aiDecadeProbField;

        private EntryAbSkipDecade abSkipDecadeField;

        private string[] aeTraitInvalidField;

        private EntryAePositiveRating aePositiveRatingField;

        private EntryAeNegativeRating aeNegativeRatingField;

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
        public string iAdjectiveDie
        {
            get
            {
                return this.iAdjectiveDieField;
            }
            set
            {
                this.iAdjectiveDieField = value;
            }
        }

        /// <remarks/>
        public string iNoFamilyDie
        {
            get
            {
                return this.iNoFamilyDieField;
            }
            set
            {
                this.iNoFamilyDieField = value;
            }
        }

        /// <remarks/>
        public string iBarbDie
        {
            get
            {
                return this.iBarbDieField;
            }
            set
            {
                this.iBarbDieField = value;
            }
        }

        /// <remarks/>
        public string iInjuryDie
        {
            get
            {
                return this.iInjuryDieField;
            }
            set
            {
                this.iInjuryDieField = value;
            }
        }

        /// <remarks/>
        public string iAdultProb
        {
            get
            {
                return this.iAdultProbField;
            }
            set
            {
                this.iAdultProbField = value;
            }
        }

        /// <remarks/>
        public string iDieProb
        {
            get
            {
                return this.iDieProbField;
            }
            set
            {
                this.iDieProbField = value;
            }
        }

        /// <remarks/>
        public string iRemoveProb
        {
            get
            {
                return this.iRemoveProbField;
            }
            set
            {
                this.iRemoveProbField = value;
            }
        }

        /// <remarks/>
        public string iOpinion
        {
            get
            {
                return this.iOpinionField;
            }
            set
            {
                this.iOpinionField = value;
            }
        }

        /// <remarks/>
        public string iOpinionFamily
        {
            get
            {
                return this.iOpinionFamilyField;
            }
            set
            {
                this.iOpinionFamilyField = value;
            }
        }

        /// <remarks/>
        public string iBirthModifier
        {
            get
            {
                return this.iBirthModifierField;
            }
            set
            {
                this.iBirthModifierField = value;
            }
        }

        /// <remarks/>
        public string iWarModifier
        {
            get
            {
                return this.iWarModifierField;
            }
            set
            {
                this.iWarModifierField = value;
            }
        }

        /// <remarks/>
        public string bArchetype
        {
            get
            {
                return this.bArchetypeField;
            }
            set
            {
                this.bArchetypeField = value;
            }
        }

        /// <remarks/>
        public string bAdjective
        {
            get
            {
                return this.bAdjectiveField;
            }
            set
            {
                this.bAdjectiveField = value;
            }
        }

        /// <remarks/>
        public string bUpgrade
        {
            get
            {
                return this.bUpgradeField;
            }
            set
            {
                this.bUpgradeField = value;
            }
        }

        /// <remarks/>
        public string bNoEvents
        {
            get
            {
                return this.bNoEventsField;
            }
            set
            {
                this.bNoEventsField = value;
            }
        }

        /// <remarks/>
        public string bNoMarry
        {
            get
            {
                return this.bNoMarryField;
            }
            set
            {
                this.bNoMarryField = value;
            }
        }

        /// <remarks/>
        public string bNoBirth
        {
            get
            {
                return this.bNoBirthField;
            }
            set
            {
                this.bNoBirthField = value;
            }
        }

        /// <remarks/>
        public string bNoHeir
        {
            get
            {
                return this.bNoHeirField;
            }
            set
            {
                this.bNoHeirField = value;
            }
        }

        /// <remarks/>
        public string bNoJob
        {
            get
            {
                return this.bNoJobField;
            }
            set
            {
                this.bNoJobField = value;
            }
        }

        /// <remarks/>
        public string bGovernorPrereq
        {
            get
            {
                return this.bGovernorPrereqField;
            }
            set
            {
                this.bGovernorPrereqField = value;
            }
        }

        /// <remarks/>
        public string bGeneralPrereq
        {
            get
            {
                return this.bGeneralPrereqField;
            }
            set
            {
                this.bGeneralPrereqField = value;
            }
        }

        /// <remarks/>
        public string bRemoveLeader
        {
            get
            {
                return this.bRemoveLeaderField;
            }
            set
            {
                this.bRemoveLeaderField = value;
            }
        }

        /// <remarks/>
        public string LeaderEffectPlayer
        {
            get
            {
                return this.leaderEffectPlayerField;
            }
            set
            {
                this.leaderEffectPlayerField = value;
            }
        }

        /// <remarks/>
        public string GovernorEffectCity
        {
            get
            {
                return this.governorEffectCityField;
            }
            set
            {
                this.governorEffectCityField = value;
            }
        }

        /// <remarks/>
        public string GeneralEffectUnit
        {
            get
            {
                return this.generalEffectUnitField;
            }
            set
            {
                this.generalEffectUnitField = value;
            }
        }

        /// <remarks/>
        public string LeaderEffectUnit
        {
            get
            {
                return this.leaderEffectUnitField;
            }
            set
            {
                this.leaderEffectUnitField = value;
            }
        }

        /// <remarks/>
        public string Cognomen
        {
            get
            {
                return this.cognomenField;
            }
            set
            {
                this.cognomenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair[] aiRating
        {
            get
            {
                return this.aiRatingField;
            }
            set
            {
                this.aiRatingField = value;
            }
        }

        /// <remarks/>
        public EntryAiTraitProb aiTraitProb
        {
            get
            {
                return this.aiTraitProbField;
            }
            set
            {
                this.aiTraitProbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pair", IsNullable = false)]
        public EntryPair1[] aiMortalityDieProb
        {
            get
            {
                return this.aiMortalityDieProbField;
            }
            set
            {
                this.aiMortalityDieProbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("iValue", IsNullable = false)]
        public byte[] aiDecadeProb
        {
            get
            {
                return this.aiDecadeProbField;
            }
            set
            {
                this.aiDecadeProbField = value;
            }
        }

        /// <remarks/>
        public EntryAbSkipDecade abSkipDecade
        {
            get
            {
                return this.abSkipDecadeField;
            }
            set
            {
                this.abSkipDecadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("zValue", IsNullable = false)]
        public string[] aeTraitInvalid
        {
            get
            {
                return this.aeTraitInvalidField;
            }
            set
            {
                this.aeTraitInvalidField = value;
            }
        }

        /// <remarks/>
        public EntryAePositiveRating aePositiveRating
        {
            get
            {
                return this.aePositiveRatingField;
            }
            set
            {
                this.aePositiveRatingField = value;
            }
        }

        /// <remarks/>
        public EntryAeNegativeRating aeNegativeRating
        {
            get
            {
                return this.aeNegativeRatingField;
            }
            set
            {
                this.aeNegativeRatingField = value;
            }
        }
    }

    

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAiTraitProb
    {

        private EntryAiTraitProbPair pairField;

        /// <remarks/>
        public EntryAiTraitProbPair Pair
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
    public class EntryAiTraitProbPair
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
    public class EntryPair1
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
    public class EntryAbSkipDecade
    {

        private EntryAbSkipDecadePair pairField;

        /// <remarks/>
        public EntryAbSkipDecadePair Pair
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
    public class EntryAbSkipDecadePair
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntryAePositiveRating
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
    public class EntryAeNegativeRating
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
