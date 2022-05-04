using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanFactory factory = null;
            Client client = new Client("John Doe", true);
            Console.WriteLine("Select type of loan");
            string userString = Console.ReadLine();
            switch (userString.ToLower())
            {
                case "bussines":
                    
                    factory = new BussinesLoanFactory(client.SetAmmount(), client.SetPeriod());
                    break;
                case "student":
                    factory = new StudentLoanFactory(client.SetAmmount(), client.SetPeriod());
                    break;
                case "housing":
                    factory = new HousingLoanFactory(client.SetAmmount(), client.SetPeriod());
                    break;
            }
            Loan loan = factory.GetLoanType();
            string creditInfo = JsonSerializer.Serialize(loan);
            Console.WriteLine(creditInfo);
        }
    }
}
