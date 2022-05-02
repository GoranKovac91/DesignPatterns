using System;

namespace FactoryPattern
{
    public class HousingLoanFactory:LoanFactory
    {
        private float _ammount;
        private float _repaymentPeriod;
        public HousingLoanFactory(float ammount,float RepaymentPeriod)
        {
            this._ammount = ammount;
            this._repaymentPeriod = RepaymentPeriod;
        }

        protected override Loan GetLoanType()
        {
            return new HousingLoan(_ammount, _repaymentPeriod);
        }
    }
}
