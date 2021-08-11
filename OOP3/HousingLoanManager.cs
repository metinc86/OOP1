using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Loan is calculated! ");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
