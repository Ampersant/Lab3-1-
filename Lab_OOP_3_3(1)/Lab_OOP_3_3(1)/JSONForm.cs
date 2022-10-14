using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_OOP_3_3_1_
{
    internal class JSONForm
    {
        public DataContractJsonSerializer JSONFormatter = new DataContractJsonSerializer(typeof(List<Trapezium>));

        public void Writer(List<Trapezium> obj)
        {
            using (var file = new FileStream("JSONForm.json", FileMode.OpenOrCreate))
            {
                JSONFormatter.WriteObject(file, obj);
            }
        }

        public string Reader()
        {
            string s = "";
            using (var file = new FileStream("JSONForm.json", FileMode.OpenOrCreate))
            {
                var ret = JSONFormatter.ReadObject(file) as List<Trapezium>;
                foreach (var item in ret)
                {
                    s += $"{item.GetData()} \n";
                }
                return s;
            }
        }
    }
}
