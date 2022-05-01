using System;
namespace FactoryPattern
{
	public abstract class Loan
	{
		protected abstract string LoanType { get; }
		protected abstract float Ammount { get; set; }
		protected abstract float InterestRate { get;  }
		protected abstract float RepaymentPeriod { get; set; }
	}

}


