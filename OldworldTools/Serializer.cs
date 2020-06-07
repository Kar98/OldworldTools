using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OldworldTools
{
    public class Serializer
    {

        public T Deserialize<T>(string filepath) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using(FileStream fs = new FileStream(filepath,FileMode.Open))
            using(StreamReader sr = new StreamReader(fs))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}
