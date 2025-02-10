namespace Task_4
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        //public SavingsAccount() : base() { }
        //public SavingsAccount(string name) : base(name) { }
        //public SavingsAccount(string name, double balance) : base(name, balance) { }
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double interstRate = 0.0) : base(name, balance)
        {
            InterestRate = interstRate;
        }

        public override string ToString()
        {
            return base.ToString() + $" and  the interstRate {InterestRate}";
        }
    }



}
