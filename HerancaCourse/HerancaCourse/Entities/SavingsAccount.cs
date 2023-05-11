
namespace HerancaCourse.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
            
        }

        public SavingsAccount(int numberAccount, string holder, double balance, double interestRate) : base(numberAccount, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.00;

        }

    }
}
