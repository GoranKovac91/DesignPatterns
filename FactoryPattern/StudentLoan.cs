using System;

namespace FactoryPattern
{
    public class StudentLoan : Loan
    {
        private readonly string _loanType;
        private float _ammount;
        private float _repaymentPeriod;
        private readonly float _interestRate;
        private readonly float _maxRepaymentPeriod=5;
        private readonly float _maxAmmount = 100000;
        public StudentLoan (float ammount,float repaymentPeriod)
        {
            _loanType = "Student Loan";
            this._ammount = ammount;
            this._repaymentPeriod = repaymentPeriod;
            _interestRate = 4.5f;
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
                if (value > _maxAmmount)
                {
                    value = _maxAmmount;
                    Console.Write("Maximmum ammount is 100000");
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
                if (value > _maxRepaymentPeriod)
                {
                    value = _maxRepaymentPeriod;
                    Console.Write("Maximmum repayment period is 5 years");
                }
            }
        }



    }
}
