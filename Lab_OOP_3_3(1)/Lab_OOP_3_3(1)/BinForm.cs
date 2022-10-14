using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_3_3_1_
{
    internal class BinForm
    {
        public BinaryFormatter binFormatter = new BinaryFormatter();

        public void Writer(List<Trapezium> obj)
        {
            using (var file = new FileStream("binaryF.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, obj);
            }
        }

        public string Reader()
        {
            string s = "";
            using (var file = new FileStream("binaryF.bin", FileMode.OpenOrCreate))
            {
                var ret = binFormatter.Deserialize(file) as List<Trapezium>;
                foreach (var item in ret)
                {
                    s += $"{item.GetData()} \n";
                }
                return s;
            }
        }
    }
}
