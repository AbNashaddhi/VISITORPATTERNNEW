using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Accept(Mobile andriod);
        void Accept(Laptop laptop);
    }

    public class Mobile : IStore
    {
        public string MobileName { get; set; }
        public decimal Price { get; set; }
        public string ModelName { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
    public class Laptop : IStore
    {
        public string LaptopName { get; set; }
        public decimal Price { get; set; }
        public string ModelName { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
    public class PriceVisitor : IVisitor
    {
        private const int Mobile_Discount = 5;
        private const int Laptop_Discount = 2;

        public void Accept(Mobile mobile)
        {
            decimal mobilePriceAfterDiscount = mobile.Price - ((mobile.Price / 100) * Mobile_Discount);
            Console.WriteLine("Mobile {0} price: {1}", mobile.MobileName, mobilePriceAfterDiscount);

        }

        public void Accept(Laptop laptop)
        {
            decimal laptopPriceAfterDiscount = laptop.Price - ((laptop.Price / 100) * Mobile_Discount);
            Console.WriteLine("Mobile {0} price: {1}", laptop.ModelName, laptopPriceAfterDiscount);

        }

    }
}
