using System;
namespace FactoryPattern
{
    public class BussinesLoanFactory:LoanFactory
    {
        private float _ammount;
        private float _repaymentPeriod;
        public BussinesLoanFactory(float ammount,float RepaymentPeriod)
        {
            this._ammount = ammount;
            this._repaymentPeriod = RepaymentPeriod;
        }

        protected override Loan GetLoanType()
        {
           return new BussinesLoan(_ammount,_repaymentPeriod);
        }
        public static float SetAmmount()
        {
            float userInput;
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
    }
}


