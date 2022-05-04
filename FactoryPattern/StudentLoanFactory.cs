using System;
namespace FactoryPattern
{
    public class StudentLoanFactory : LoanFactory
    {
        private float _ammount;
        private float _repaymentPeriod;
        public StudentLoanFactory(float ammount,float RepaymentPeriod)
        {
            this._ammount = ammount;
            this._repaymentPeriod = RepaymentPeriod;
        }
        public override Loan GetLoanType()
        {
            return new StudentLoan(_ammount, _repaymentPeriod);
        }
    }
}
