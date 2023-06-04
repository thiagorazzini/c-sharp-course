using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractProcess.Services
{
    internal class PaypalServices:IOnlinePayment
    {
        private const double simpleInterest = 0.01;
        private const double paymentFee = 0.02;

        public double PaymentInterestMonthly(double amount, int month)
        {
            return amount * simpleInterest * month;
        }


        public double PaymenteFee(double amount)
        {
            return amount * paymentFee;
        }


    }
}
