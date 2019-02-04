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
                    double total = value * 304.8;
                    Console.WriteLine(total + "Centimeters");
                    break;
            }
        }
    }
}