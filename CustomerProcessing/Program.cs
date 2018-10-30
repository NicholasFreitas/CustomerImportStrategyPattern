using System;
using CustomerProcessing.Importers;
namespace CustomerProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerProcessor cusProcProspect = new CustomerProcessor(new LeadStrategy());

            var cust = cusProcProspect.GetCustomer();
            cusProcProspect.UpdateCustomer(cust);
            cust.GetCustomerInformation();


            CustomerProcessor cusProcLead = new CustomerProcessor(new ProspectStrategy());
            var custLead = cusProcLead.GetCustomer();
            cusProcLead.UpdateCustomer(custLead);
            custLead.GetCustomerInformation();


            Console.ReadLine();
            Console.WriteLine("=====Complete=====");


        }
    }
}
