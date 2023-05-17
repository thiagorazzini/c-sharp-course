
namespace AbstractTrainingExercise.Entities
{
    internal class Individual : TaxPayers
    {
        public double HealthExpenditures { get; set; }


        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxValue = 0.0;
            if (AnualIncome < 20000.00)
            {
                if (HealthExpenditures > 0.0)
                {
                    taxValue = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);

                }
                else
                {
                    taxValue = (AnualIncome * 0.15);
                }
            }
            else
            {
                if(HealthExpenditures > 0.0)
                {
                    taxValue = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);

                }
                else
                {
                    taxValue = (AnualIncome * 0.25);
                }

            }
            return taxValue;
        }

    }
}
