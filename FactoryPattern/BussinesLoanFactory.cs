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

        public override Loan GetLoanType()
        {
           return new BussinesLoan(_ammount,_repaymentPeriod);
        }
      
    }
}


