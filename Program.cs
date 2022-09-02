namespace BankAccountExercise
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            BankAccount checking = new BankAccount();

            Console.WriteLine("How much would you like to deposit into checkings?");
            double amount = double.Parse(Console.ReadLine());

            checking.Deposit(amount);
            double newBalance = checking.GetBalance();

            Console.WriteLine($"Thank you for your deposit. Your account now has ${newBalance} in checkings.");
        }
    }
}