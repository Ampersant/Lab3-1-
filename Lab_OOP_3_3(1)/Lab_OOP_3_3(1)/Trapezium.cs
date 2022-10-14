using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_OOP_3_3_1_
{
    [Serializable]
    [DataContract]
    public class Trapezium
    {
        [DataMember]
        [XmlElement("FillColor")]
        protected string fillColor;
        [DataMember]
        [XmlElement("BorderColor")]
        protected string borderColor;
        [DataMember]
        [XmlElement("A")]
        protected double a;
        [DataMember]
        [XmlElement("B")]
        protected double b;
        [DataMember]
        [XmlElement("H")]
        protected double h;

        public string FillColor
        {
            get { return fillColor; }
            set { this.fillColor = value; }
        }
        public string BorderColor
        {
            get { return borderColor; }
            set { this.borderColor = value; }
        }
        public double A
        {
            get { return a; }
            set { this.a = value; }
        }
        public double B
        {
            get { return b; }
            set { this.b = value; }
        }
        public double H
        {
            get { return h; }
            set { this.h = value; }
        }

        public double CalcSq()
        {
            double Sq = (a + b) / 2 * h;
            return Sq;
        }
        public double CalcP()
        {
            double p = this.a + this.b + 2 * (Math.Sqrt(Math.Pow(this.h, 2) + Math.Pow(Math.Abs(this.b - this.a) / 2, 2)));
            return p;
        }
        public Trapezium()
        {
            this.FillColor = "none";
            this.BorderColor = "black";
            this.a = 1;
            this.b = 2;
            this.h = 3;
           
        }
        public Trapezium(string fillColor, string borderColor, double a, double b, double h)
        {
            FillColor = fillColor;
            BorderColor = borderColor;
            A = a;
            B = b;
            this.h = h;
           
        }
        public string GetData()
        {
            string s = $"A = {this.a} \n\tB = {this.b} \n\tH = {this.h} \n\tSquare = {this.CalcSq()} \n\tPerimeter = {this.CalcP()} \n\tBackground color = {FillColor} \n\tBorder color = {BorderColor}";
            return s;
        }

    }
}
