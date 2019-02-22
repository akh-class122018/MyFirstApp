using System;

namespace Quiz
{
    public class ConvertTypes
    {

        public enum FeetConvert
        {
            Centimeters, Inches, Meters, Millimeters, Yards
        };
        public void ConversionFeet(double value, FeetConvert feetConvert)
        {
            switch (feetConvert)
            {
                case FeetConvert.Centimeters:
                    double total = Math.Round((value * 30.48), 2);
                    Console.WriteLine(total + "Centimeters");
                    break;

                case FeetConvert.Inches:
                    double total1 = Math.Round((value * 12), 2);
                    Console.WriteLine(total1 + "Inches");
                    break;

                case FeetConvert.Meters:
                    double total2 = Math.Round((value * 0.3048), 2);
                    Console.WriteLine(total2 + "Inches");
                    break;

                case FeetConvert.Millimeters:
                    double total3 = Math.Round((value * 0.3048), 2);
                    Console.WriteLine(total3 + "Inches");
                    break;

                case FeetConvert.Yards:
                    double total4 = Math.Round((value * 0.33333333333), 2);
                    Console.WriteLine(total4 + "Inches");
                    break;

            }
        }
    }
}