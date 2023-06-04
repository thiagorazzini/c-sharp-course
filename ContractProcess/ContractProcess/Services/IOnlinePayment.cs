
namespace ContractProcess.Services
{
    internal interface IOnlinePayment
    {
        public double PaymentInterestMonthly(double amount, int month);
        public double PaymenteFee(double amount);
    }
}
