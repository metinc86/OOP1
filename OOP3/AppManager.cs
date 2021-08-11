using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppManager
    {
        public void Apply(ILoanManager loanManager, List <ILoggerService> loggerServices) 
        {
            loanManager.Calculate(); 

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }
        public void LoanPreliminaryInform(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
            
            Console.WriteLine("Chosen loans are compared! ");
        }
    }
}
