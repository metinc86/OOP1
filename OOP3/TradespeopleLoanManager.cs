using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradespeopleLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tradespeople loan is calculated! ");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
