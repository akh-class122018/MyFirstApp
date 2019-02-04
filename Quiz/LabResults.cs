using System;

namespace Quiz
{
    public class LabResults
    {
        public string SampleConversion(ConvertEnum convertvariables)
        {
            switch (convertvariables)
            {
                case ConvertEnum.mm:
                    return "304.8 mm is a foot";

                case ConvertEnum.cm:
                    return "30.48 mm is a foot";

                case ConvertEnum.inch:
                    return "12 inch is a foot";

                case ConvertEnum.m:
                    return "0.3048 m is a foot";

                case ConvertEnum.y:
                    return "0.33333333333 yard is a foot";

                default:
                    return "nothing";

            }
        }

    }
}