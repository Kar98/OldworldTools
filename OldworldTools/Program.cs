using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OldworldTools.XMLData;
using OldworldTools.XMLParser;

namespace OldworldTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializer ser = new Serializer();
            Trait xmlTrait = ser.Deserialize<Trait>("trait.xml");
            EffectCity xmlEffectCity = ser.Deserialize<EffectCity>("effectCity.xml");
            EffectPlayer xmlEffectPlayer = ser.Deserialize<EffectPlayer>("effectPlayer.xml");
            EffectUnit xmlEffectUnit = ser.Deserialize<EffectUnit>("effectUnit.xml");

            // Load Trait.xml, then load other XMLs
            // Look for trait in city, player, unit. 
            // If found, add to output obj

            OldWorldXmlParser parser = new OldWorldXmlParser();
            var vals = parser.GetArchtypeMetadata();
            foreach(var key in vals)
            {
                Console.WriteLine(key.Key);
                foreach (var val in key.Value)
                {
                    Console.WriteLine($"{val.Key} + {val.Value}");
                }
            }
            
            Console.Read();

        }
    }



}
