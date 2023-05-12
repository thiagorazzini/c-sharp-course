
namespace HerancaCourse.Entities
{
    internal class Account
    {
        public int NumberAccount { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account()
        {
            
        }

        public Account(int numberAccount, string holder, double balance)
        {
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
        }

        public  virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Desposit(double amount)
        {
            Balance += amount;
        }
    }
}
