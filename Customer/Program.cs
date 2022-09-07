using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDomainModel customer = new CustomerDomainModel(1, "Mahsa", "Mousavi");
            Console.WriteLine($"Hello customer {customer}");
        }
    }
}
