using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_OOP_3_3_1_
{
    internal class XMLForm
    {
        public XmlSerializer XMLFormatter = new XmlSerializer(typeof(List<Trapezium>));

        public void Writer(List<Trapezium> obj)
        {
            using (var file = new FileStream("XMLForm.xml", FileMode.OpenOrCreate))
            {
                XMLFormatter.Serialize(file, obj);
            }
        }

        public string Reader()
        {
            string s = "";
            using (var file = new FileStream("XMLForm.xml", FileMode.OpenOrCreate))
            {
                var ret = XMLFormatter.Deserialize(file) as List<Trapezium>;
                foreach (var item in ret)
                {
                    s += $"{item.GetData()} \n";
                }
                return s;
            }
        }
    }
}
