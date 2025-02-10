namespace Task_4
{
    internal class CheckingAccount : Account
    {
        public const double FlatFee = 1.5;
        public CheckingAccount(string name = "Unkown", double balance = 0.0) : base(name, balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (Balance - amount - FlatFee >= 0)
            {
                Balance -= (amount + FlatFee);
                return true;
            }
            return false;
        }
    }
}
