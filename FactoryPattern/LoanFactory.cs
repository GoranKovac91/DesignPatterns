using System;
namespace FactoryPattern
{
    public abstract class LoanFactory
    {
        public abstract Loan GetLoanType();
    }
}


