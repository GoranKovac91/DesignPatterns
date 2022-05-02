using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanFactory factory = null;
            Console.WriteLine("Select type of loan");
            string userString = Console.ReadLine();
            switch (userString.ToLower())
            {
                case "bussines":
                    
                    factory = new BussinesLoanFactory(BussinesLoanFactory.SetAmmount(), 20);

                    break;
            }
        }
    }
}
