using OldworldTools.XMLData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldworldTools.XMLParser
{
    public class OldWorldXmlParser
    {
        public OldWorldXmlParser() { }

        public Dictionary<string,Dictionary<string,object>> GetArchtypes(List<string> listOfArchtypes)
        {
            var retDict = new Dictionary<string, Dictionary<string, object>>();
            Serializer ser = new Serializer();
            Trait xmlTrait = ser.Deserialize<Trait>("trait.xml");
            EffectCity xmlEffectCity = ser.Deserialize<EffectCity>("effectCity.xml");
            EffectPlayer xmlEffectPlayer = ser.Deserialize<EffectPlayer>("effectPlayer.xml");
            EffectUnit xmlEffectUnit = ser.Deserialize<EffectUnit>("effectUnit.xml");

            foreach(var archtype in listOfArchtypes)
            {
                var zealotEntry = xmlTrait.Entries.First(a => a.Name.Contains(archtype));
                var archtypeStats = new Dictionary<string, object>();

                // LeaderEffectPlayer - strategic
                // GeneralEffectUnit - tactical
                // GovernorEffectCity - city
                // LeaderEffectUnit - tactical

                if (zealotEntry.LeaderEffectPlayer != null)
                {
                    var newdict = GetLeaderEffectPlayer(zealotEntry, xmlEffectPlayer);
                    archtypeStats = archtypeStats.Concat(newdict).ToDictionary(x=>x.Key,x=>x.Value);
                }
                if (zealotEntry.GeneralEffectUnit != null)
                {

                }
                if (zealotEntry.GovernorEffectCity != null)
                {

                }
                if (zealotEntry.LeaderEffectUnit != null)
                {

                }

                retDict[archtype] = archtypeStats;
            }
            

            return retDict;
        }

        private Dictionary<string,object> GetLeaderEffectPlayer(Trait_Entry trait, EffectPlayer xmlEffectPlayer)
        {
            var archtypeStats = new Dictionary<string, object>();

            var effPlayerEntry = xmlEffectPlayer.Entries.First(a => a.zType == trait.LeaderEffectPlayer);
            if (effPlayerEntry == null)
            {
                Console.WriteLine("Missing player entry in Xml");
            }
            else
            {
                var archtypeType = effPlayerEntry.GetType();
                var archtypeProps = archtypeType.GetProperties();
                foreach (var prop in archtypeProps)
                {
                    var propval = prop.GetValue(effPlayerEntry);
                    //If there is a value and isnt' not a generic name then save value.
                    if (propval != null && prop.Name != "zType" && prop.Name != "Name" && prop.Name != "SourceTrait")
                    {
                        archtypeStats[prop.Name] = propval;
                    }
                }

            }
            
            return archtypeStats;
        }

    }
}
