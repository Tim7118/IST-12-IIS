using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace frame
{
    class forXML
    {
        string path = Environment.CurrentDirectory + "\\" + "frame.xml";


        public bool SaveXml(GroopFrame frames)
        {
            bool result = false;
            using (StreamWriter writer =
                new StreamWriter("frame.xml"))
            {
                try
                {
                    XmlSerializerNamespaces ns =
                        new XmlSerializerNamespaces();
                    ns.Add("", "");
                    XmlSerializer serializer =
                        new XmlSerializer(frames.GetType());
                    serializer.Serialize(writer, frames, ns);
                    result = true;
                }
                catch (Exception e)
                {
                    // Логирование
                }
                finally
                {
                    writer.Close();
                }
            }
            return result;
        }

        public object LoadXml(GroopFrame frames)
        {
            object result = null;
            using (StreamReader reader = new StreamReader("frame.xml"))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(frames.GetType());
                    result = serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    // Логирование
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }
    }
}
