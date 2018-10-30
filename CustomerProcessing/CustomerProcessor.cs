using System;
using System.Collections.Generic;
using System.Text;
using CustomerProcessing.Importers;
using CustomerProcessing.Actors;
namespace CustomerProcessing
{
    class CustomerProcessor
    {
        private IImportStrategy ImporterStrategy;
        
        public CustomerProcessor(IImportStrategy importStrategy)
        {
            ImporterStrategy = importStrategy;
        }

        public Customer GetCustomer()
        {
            return ImporterStrategy.ImportCustomer();
        }

        public void UpdateCustomer(Customer cus)
        {
            ImporterStrategy.UpdateCustomer(cus);
        }


    }
}
