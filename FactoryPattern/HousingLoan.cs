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
        private readonly float _maxAmmount=500000;
        public HousingLoan(float ammount, float repaymentPeriod)
        {
            _loanType = "Housing loan";
            this._ammount = ammount;
            this._repaymentPeriod = repaymentPeriod;
            _interestRate = 3.99f;
        }
        public override string LoanType
        {
            get { return _loanType; }
        }

        public override float Ammount
        {
            get { return _ammount; }
            set
            {
                _ammount = value;
                if (value > _maxAmmount)
                {
                    value = _maxAmmount;
                    Console.Write("Maximmum ammount is 500000");
                }
            }
        }

        public override float InterestRate
        {
            get { return _interestRate; }
        }

        public override float RepaymentPeriod
        {
            get { return _repaymentPeriod; }
            set
            {
                _repaymentPeriod = value;
                if (value > _maxRepaymentPeriod)
                {
                    value = _maxRepaymentPeriod;
                    Console.Write("Maximmum repayment period is 30 years");
                }
            }
        }
    }
}


