using AbstactClass.Const;
using AbstactClass.Interface;
using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AbstactClass.Models
{
    [Serializable]
    public class ColumnRound : StructuralMember, ICalculate, IDescription
    {
        public double lenght = 3;
        [XmlIgnore, JsonIgnore]
        private readonly string typeForm = Shape.Round.ToString();
        public double lambda { get; set; } = 1;
        public double diameter { get; set; } = 0.3;

        public ColumnRound()
        {

        }
        public ColumnRound(double diameter, double lenght, double lambda, Material material) : base(material)
        {
            this.diameter = diameter;
            this.lenght = lenght;
            this.lambda = lambda;   
        }
        public ColumnRound(double diameter, double lambda, Material material) : base(material)
        {
            this.diameter = diameter;
            this.lambda = lambda;
        }

        protected override double InertiaMoment()
        {
            return Math.PI*Math.Pow(diameter, 4)/64;
        }

        public bool TypeOfDeformation(double P)
        {
            double Pcr = (Math.PI*E*InertiaMoment())/Math.Pow(lambda*lenght, 2);
            if (Pcr>P) { return true; }
            else { return false; }
        }
        public bool TypeOfDeformation(int P)
        {
            double Pcr = (Math.PI*E*InertiaMoment())/Math.Pow(lambda*lenght, 2);
            if (Pcr>P) { return true; }
            else { return false; }
        }

        public override void Message(bool typeOfDeformation)
        {
            if (typeOfDeformation==true)
            {
                Console.WriteLine($"This is elastic type of deformation {typeForm} column, which is loaded with a single concentrated force");
            }
            else
            {
                Console.WriteLine($"This is plastic type of deformation or brittle failure {typeForm} column, which is loaded with a single concentrated force");
            }

        }

        public void Description()
        {
            Console.WriteLine($"This is a {Material.Steel.ToString()} column");
        }

        ~ColumnRound()
        {
          
        }
    }
}
