using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_3_3_1_
{
    internal class MainClass
    {
        static void Main(string[] args) // головна функція
        {
            List<Trapezium> _list = new List<Trapezium>();

            Trapezium T1 = new Trapezium();
            Trapezium T2 = new Trapezium("Black", "White", 3, 4, 2);
            Trapezium T3 = new Trapezium("Green", "Yellow",1, 1.5, 3);

            _list.Add(T1);
            _list.Add(T2);
            _list.Add(T3);

            BinForm binForm = new BinForm();
            binForm.Writer(_list);
            string s = binForm.Reader();
            Console.WriteLine(s);

            XMLForm xml = new XMLForm();

            xml.Writer(_list);
             s = xml.Reader();

            Console.WriteLine("-", 40);
            Console.WriteLine(s);

            JSONForm JSON = new JSONForm();

            JSON.Writer(_list);
            s = JSON.Reader();

            Console.WriteLine("-", 40);
            Console.WriteLine(s);




        }
    }
}
