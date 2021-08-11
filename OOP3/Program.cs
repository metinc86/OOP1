using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager housingLoanManager = new HousingLoanManager();
            ILoanManager tradespeopleLoanManager = new TradespeopleLoanManager(); 

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();
            //ILoggerService smsLoggerService = new SMSLoggerService(); 

            /* 
            -------------------------------------------------------------------------------------
                You can call the instance like above separately or inside the list like below    
            -------------------------------------------------------------------------------------
            */
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService(),new SMSLoggerService() };
            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager, vehicleLoanManager }; 

            AppManager appManager = new AppManager();
            appManager.Apply(tradespeopleLoanManager, loggers); 

            //appManager.Apply(vehicleLoanManager);
            //appManager.Apply(housingLoanManager);
            //appManager.LoanPreliminaryInform(loans);

        }
    }
}
