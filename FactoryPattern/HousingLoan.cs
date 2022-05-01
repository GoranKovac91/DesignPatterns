using System;
namespace FactoryPattern
{
    public class HousingLoan : Loan
    {
        private readonly string _loanType;
        private float _ammount;
        private float _repaymentPeriod;
        private readonly float _interestRate;
        private readonly float _maxRepaymentPeriod=30;
        public HousingLoan(float ammount, float repaymentPeriod)
        {
            _loanType = "Housing loan";
            this._ammount = ammount;
            this._repaymentPeriod = repaymentPeriod;
            _interestRate = 3.99f;
        }
        protected override string LoanType
        {
            get { return _loanType; }
        }

        protected override float Ammount
        {
            get { return _ammount; }
            set
            {
                _ammount = value;
                if (value > 500000)
                {
                    value = 500000;
                    Console.Write("Maximmum ammount is 500000");
                }
            }
        }

        protected override float InterestRate
        {
            get { return _interestRate; }
        }

        protected override float RepaymentPeriod
        {
            get { return _repaymentPeriod; }
            set
            {
                _repaymentPeriod = value;
                if (value > 30)
                {
                    value = 30;
                    Console.Write("Maximmum repayment period is 30 years");
                }
            }
        }
    }
}


