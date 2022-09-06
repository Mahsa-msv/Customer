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
            DomainDrivenDesign.Customer customer = new DomainDrivenDesign.Customer(1, "Mahsa", "Mousavi");
            Console.WriteLine($"Hello customer {customer}");
        }
    }
}
