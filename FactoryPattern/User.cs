using System;

namespace FactoryPattern
{
    public class Client
    {
        private string _name { get; }
        private bool _isWorking { get; }
        public Client(string name, bool isWorking)
        {
            this._name = name;
            this._isWorking = isWorking;
        }

        public float SetAmmount()
        {
            float userInput;
            Console.WriteLine("Please enter ammount of loan");
            string userString = Console.ReadLine();
            if (float.TryParse(userString,out userInput))
            {
                return userInput;
            }
            else
            {
                return 0;
            }

        }
        public float SetPeriod()
        {
            float userInput;
            Console.WriteLine("Please enter repayment period of loan");
            string userString = Console.ReadLine();
            if (float.TryParse(userString, out userInput))
            {
                return userInput;
            }
            else
            {
                return 0;
            }
        }
    }
}


