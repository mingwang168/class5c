using System;

namespace class5c
{
    struct BankAccountStruct
    {
        public string Name { get; set; }
        public float Balance { get; set; }
        public BankAccountStruct(string name, float balance)
        {
            Name = name;
            Balance = balance;
        }
        public void AddMonthlyInsterest()
        {
            Balance *= (1f + 0.56f / 12f);
        }
        public void SHowDetails(string title)
        {
            Console.WriteLine($"Title: {title}\n Name: {Name}: Balance: {Balance}");
        }
    }

    class BankAccountClass
    {
        public string Name { get; set; }
        public float Balance { get; set; }
        public BankAccountClass(string name, float balance)
        {
            Name = name;
            Balance = balance;
        }
        public void AddMonthlyInsterest()
        {
            Balance *= (1f + 0.56f / 12f);
        }
        public void SHowDetails(string title)
        {
            Console.WriteLine($"Title: {title}\n Name: {Name}: Balance: {Balance.ToString("C")}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string NAME = "Object Name";
            const float BALANCE = 593473.039f;
            BankAccountStruct structAccount = new BankAccountStruct(NAME, BALANCE);
            BankAccountClass classAccount = new BankAccountClass(NAME, BALANCE);

            BankAccountStruct copyStructAccount = structAccount;
            BankAccountClass copyClassAccount = classAccount;
            structAccount.SHowDetails("Original struct Account");
            classAccount.SHowDetails("Original class Account");

            Console.WriteLine();
            Add100(structAccount);
            classAccount.SHowDetails("Original Struct Account");

            Add100(classAccount);
            classAccount.SHowDetails("Original class Account");
            structAccount.Balance = Add100(structAccount.Balance);
            classAccount.Balance = Add100(classAccount.Balance);
            structAccount.Balance = Add100(structAccount.Balance);
            classAccount.Balance = Add100(classAccount.Balance);

            structAccount.SHowDetails("Original struct Account");
            classAccount.SHowDetails("Original class Account");

            Console.ReadLine();
        }
        static void Add100(BankAccountStruct structAccount)
        {
            structAccount.Balance += 100000000000f;
        }
        static void Add100(BankAccountClass classAccount)
        {
            classAccount.Balance += 100000000000f;
        }
        static float Add100(float balance)
        {
            return balance += 100000000000f;
        }
    }
}

