using System;
namespace FactoryPattern
{
	public abstract class Loan
	{
		public abstract string LoanType { get; }
		public abstract float Ammount { get; set; }
		public abstract float InterestRate { get;  }
		public abstract float RepaymentPeriod { get; set; }
	}

}


