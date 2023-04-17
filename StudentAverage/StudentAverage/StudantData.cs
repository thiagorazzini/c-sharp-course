using System;
using System.Globalization;

namespace StudentAverage
{
    internal class StudantData
    {
        public string Name;
        public double GradesOne;
        public double GradesTwo;
        public double GradesThree;


        public double gradesSum()
        {
            return GradesOne + GradesTwo + GradesThree;
        }

        public string verifySituation()
        {
            if(GradesOne + GradesTwo + GradesThree > 60.0)
            {
                return "APROVADO";
            }
            else
            {
                double needPoint = 60.0 - (GradesOne + GradesTwo + GradesThree);
                return $"REPROVADO \nFALTARAM {needPoint.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
            
        }
    }
}
