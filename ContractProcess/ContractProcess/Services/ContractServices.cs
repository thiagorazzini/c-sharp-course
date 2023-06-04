

using ContractProcess.Entities;

namespace ContractProcess.Services
{
    internal class ContractServices
    {
        private IOnlinePayment _ionlinePayment;

        public ContractServices(IOnlinePayment ionlinePayment)
        {
            _ionlinePayment = ionlinePayment;
        }

        public void ProcessContract(Contract contract, int month)
        {
            double valuePerMonth = contract.TotalValue / month;//dividindo por mes 600 / 3 = 200 mes
            for(int i = 1; i <= month; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);//adiciona 1 mes a cada for que passar
                double updateValue = valuePerMonth + _ionlinePayment.PaymentInterestMonthly(valuePerMonth, i); // armazena resultado do valor resultante do serviço
                double sumAllValue = updateValue + _ionlinePayment.PaymenteFee(updateValue);
                contract.addInstallments(new Installments(date, sumAllValue));
            }
        }
    }
}
