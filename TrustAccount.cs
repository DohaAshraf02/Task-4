namespace Task_4
{
    internal class TrustAccount : SavingsAccount
    {
        public const double BounsDeposited = 50;
        public const double BounsLimit = 5000;
        public const double WithdrawLimitRate = 0.2;
        public DateTime FirstWithdrawDate;
        public int AvailableWithdraw = 3;
        public TrustAccount(string name = "Unkown", double balace = 0.0, double interestRate = 0.0) : base(name, balace, interestRate) { }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                if (amount > BounsLimit)
                    Balance += amount + BounsDeposited;
                else
                    Balance += amount;
                return true;
            }
            return false;
        }
        public override bool Withdraw(double amount)
        {
            if (AvailableWithdraw == 3)
            {
                FirstWithdrawDate = DateTime.Now;
                AvailableWithdraw--;
                return WithdrawAmount(amount);

            }
            else if (AvailableWithdraw > 0 && AvailableWithdraw < 3)
            {
                var dateDifference = DateTime.Now - FirstWithdrawDate;
                if (dateDifference.Days < 365)
                {
                    AvailableWithdraw--;
                    return WithdrawAmount(amount);
                }
                return false;
            }
            else
            { return false; }

        }
        private bool WithdrawAmount(double amount)
        {
            if ((Balance * WithdrawLimitRate) > amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
