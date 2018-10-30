using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProcessing.Actors
{
    class Customer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string State { get; set; }
        string ImportedFrom { get; set; }

        public Customer(string fn, string ln, int ag, string st, string frm)
        {
            FirstName = fn;
            LastName = ln;
            Age = ag;
            State = st;
            ImportedFrom = frm;
        }

        public void GetCustomerInformation()
        {
            string FullCustomerInformation = string.Format("{0} {1}, {2}, {3}, {4}",FirstName, LastName,Age.ToString(),State,ImportedFrom);
            Console.WriteLine(FullCustomerInformation);
        }


    }
}
