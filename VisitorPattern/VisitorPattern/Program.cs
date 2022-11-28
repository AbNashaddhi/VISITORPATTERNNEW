using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStore> store = new List<IStore>
        {
            new Mobile() { MobileName = "A1", Price = 200M},
            new Mobile() { MobileName = "A2", Price = 100M},

            new Laptop() { LaptopName = "B1", Price = 50M, },
            new Laptop() { LaptopName = "B2", Price = 30M, }
        };

            PriceVisitor priceVisitor = new PriceVisitor();
            foreach (var element in store)
            {
                element.Visit(priceVisitor);
            }
           
            Console.ReadLine();

        }
    }
}
