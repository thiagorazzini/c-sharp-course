
namespace HerancaCourse.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }


        public BusinessAccount(int numberAccount, string holder, double balance, double loanLimit)
            : base(numberAccount, holder, balance)
        {
            LoanLimit = loanLimit;

        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
