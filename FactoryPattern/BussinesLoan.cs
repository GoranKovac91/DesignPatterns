using System;
namespace FactoryPattern
{
    public class BussinesLoan : Loan
    {
        private readonly string _loanType;
        private float _ammount;
        private float _repaymentPeriod;
        private readonly float _interestRate;
        public BussinesLoan(float ammount, float repaymentPeriod)
        {
            _loanType = "Housing loan";
            this._ammount = ammount;
            this._repaymentPeriod = repaymentPeriod;
            _interestRate =1.22f;
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
                if (Ammount>1000000)
                {
                    _ammount = 1000000;
                    Console.WriteLine("Maximmum ammount is 1000000 ");
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
            set { _repaymentPeriod = value; }
        }
    }
}


