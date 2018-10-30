using System;
using System.Collections.Generic;
using System.Text;
using CustomerProcessing.Actors;

namespace CustomerProcessing.Importers
{
    class ProspectStrategy : IImportStrategy
    {
        public Customer ImportCustomer()
        {
            return new Customer("John","Smith",34,"TX","Prospect");
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("Updated Customer Through Prospect");  
        }
    }
}
