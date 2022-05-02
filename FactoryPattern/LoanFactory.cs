using System;
namespace FactoryPattern
{
    public abstract class LoanFactory
    {
        protected abstract Loan GetLoanType();
    }
}


