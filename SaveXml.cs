using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace BeenTogether
{
    public class SaveXml
    {
        public static void SaveData(object obj, string filename)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, obj);
            writer.Close();
        }
    }
}
