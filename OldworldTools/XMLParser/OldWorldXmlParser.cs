using OldworldTools.XMLData;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OldworldTools.XMLParser
{
    public class OldWorldXmlParser
    {

        List<string> ignoreList = new List<string>() { "zType", "Name", "zIconName","SourceTrait" };

        public OldWorldXmlParser() { }

        public Dictionary<string,Dictionary<string,object>> GetArchtypeMetadata()
        {
            var retDict = new Dictionary<string, Dictionary<string, object>>();
            Serializer ser = new Serializer();
            Trait xmlTrait = ser.Deserialize<Trait>("trait.xml");
            EffectCity xmlEffectCity = ser.Deserialize<EffectCity>("effectCity.xml");
            EffectPlayer xmlEffectPlayer = ser.Deserialize<EffectPlayer>("effectPlayer.xml");
            EffectUnit xmlEffectUnit = ser.Deserialize<EffectUnit>("effectUnit.xml");
            var listOfArchtypes = GetArchtypes(xmlTrait);

            foreach (var archtype in listOfArchtypes)
            {
                var traitEntry = xmlTrait.Entries.First(a => a.Name.Contains(archtype));
                var archtypeStats = new Dictionary<string, object>();

                // LeaderEffectPlayer - EffectPlayer (applies global)
                // GeneralEffectUnit - EffectUnit (applies bonuses to the unit it is controlling.)
                // LeaderEffectUnit - EffectUnit (not sure)
                // GovernorEffectCity - EffectCity (governor)


                if (traitEntry.LeaderEffectPlayer != null)
                {
                    //var newdict = GetLeaderEffectPlayer(zealotEntry, xmlEffectPlayer);
                    var effPlayerEntry = xmlEffectPlayer.Entries.First(a => a.zType == traitEntry.LeaderEffectPlayer);
                    var newdict = GetKeyValuesFromXml(effPlayerEntry);
                    archtypeStats = archtypeStats.Concat(newdict).ToDictionary(x=>x.Key,x=>x.Value);
                }
                if (traitEntry.GeneralEffectUnit != null)
                {
                    var effPlayerEntry = xmlEffectUnit.Entries.First(a => a.zType == traitEntry.GeneralEffectUnit);
                    var newdict = GetKeyValuesFromXml(effPlayerEntry);
                    archtypeStats = archtypeStats.Concat(newdict).ToDictionary(x => x.Key, x => x.Value);
                }
                if (traitEntry.LeaderEffectUnit != null)
                {
                    var effPlayerEntry = xmlEffectUnit.Entries.First(a => a.zType == traitEntry.LeaderEffectUnit);
                    var newdict = GetKeyValuesFromXml(effPlayerEntry);
                    archtypeStats = archtypeStats.Concat(newdict).ToDictionary(x => x.Key, x => x.Value);
                }
                if (traitEntry.GovernorEffectCity != null)
                {
                    var effPlayerEntry = xmlEffectCity.Entries.First(a => a.zType == traitEntry.GovernorEffectCity);
                    var newdict = GetKeyValuesFromXml(effPlayerEntry);
                    archtypeStats = archtypeStats.Concat(newdict).ToDictionary(x => x.Key, x => x.Value);
                }

                List<string> removeProcessedKeys = new List<string>();
                Dictionary<string, object> postProcessDict = new Dictionary<string, object>();
                // Post process elements.
                foreach (var stat in archtypeStats)
                {
                    if (stat.Key.Contains("EffectCity"))
                    {
                        var entry = xmlEffectCity.Entries.First(a => a.zType == (string)stat.Value);
                        var childValues = GetKeyValuesFromXml(entry);
                        foreach(var childval in childValues)
                        {
                            postProcessDict[childval.Key] = childval.Value;
                        }
                        removeProcessedKeys.Add("EffectCity");
                    }
                }

                removeProcessedKeys.ForEach(a => archtypeStats.Remove(a));
                archtypeStats = archtypeStats.Concat(postProcessDict).ToDictionary(x => x.Key, x => x.Value);

                retDict[archtype] = archtypeStats;
            }
            

            return retDict;
        }

        /// <summary>
        /// Will get any non null keys and their associated values from an xml Entry
        /// </summary>
        /// <param name="entry">Single XML Entry object from Old World template</param>
        /// <returns></returns>
        private Dictionary<string, object> GetKeyValuesFromXml(object entry)
        {
            var archtypeStats = new Dictionary<string, object>();

            var archtypeType = entry.GetType();
            var archtypeProps = archtypeType.GetProperties();
            foreach (var prop in archtypeProps)
            {
                var propval = prop.GetValue(entry);
                //If there is a value and the value found isn't a generic name then save value.
                
                if (propval != null && !ignoreList.Contains(prop.Name))
                {
                    archtypeStats[prop.Name] = propval;
                }
            }

            return archtypeStats;
        }

        public List<string> GetArchtypes(Trait xmlTrait)
        {
            List<string> traits =  new List<string>();
            Regex rgx = new Regex("TRAIT_(.*?)_");
            foreach(var trait in xmlTrait.Entries)
            {
                if (trait.IsArchtype())
                {
                    traits.Add(rgx.Match(trait.zType).Groups[1].Value);
                }
            }
            return traits;
        }

        public Dictionary<string,object> EvaluateKeyInXmlFiles()
        {

            return null;
        }

    }
}
