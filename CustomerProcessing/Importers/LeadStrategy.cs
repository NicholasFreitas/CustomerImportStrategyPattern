using System;
using System.Collections.Generic;
using System.Text;
using CustomerProcessing.Actors;

namespace CustomerProcessing.Importers
{
    class LeadStrategy : IImportStrategy
    {
        public Customer ImportCustomer()
        {
            return new Customer("Jane", "Doe", 27, "NY", "Lead");
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("Updated Customer Through Lead");
        }
    }
}
