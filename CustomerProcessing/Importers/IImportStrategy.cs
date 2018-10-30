using System;
using System.Collections.Generic;
using System.Text;
using CustomerProcessing.Actors;
namespace CustomerProcessing.Importers
{
    interface IImportStrategy
    {
        Customer ImportCustomer();

        void UpdateCustomer(Customer customer);

    }
}
