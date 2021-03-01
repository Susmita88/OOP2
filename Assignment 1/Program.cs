using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("4","319A","Dhaka","Bangladesh");
            Account account1 = new Account(1001, "Shakib", 2000, address1);
            account1.PrintAccount();
            //account1.ShowAccountInformation();
            
        }
    }
}
