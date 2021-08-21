using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Projeto.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }
        public BusinessAccount (int number, string holder,double balance,double loanLimit):base(number,holder,balance)
        {
            
            LoanLimit = LoanLimit;
        }
       public void Loan(double amount)
        {
            Balance += amount;
        }

    }
}
