

namespace InterfaceConsolidationExercise.Entities
{
    internal class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double TotalValue { get; set; }
        public List<Installments> Installments { get; set; }

        public Contract(int contractNumber, DateTime contractDate, double totalValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            TotalValue = totalValue;
            Installments = new List<Installments>();
        }

        public void AddInstalments(Installments installments)
        {
            Installments.Add(installments);
        }
    }
}
