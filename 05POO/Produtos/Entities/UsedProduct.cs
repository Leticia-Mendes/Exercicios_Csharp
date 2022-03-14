using System;
using System.Globalization;

namespace Produtos.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureData)
            : base(name, price) 
        { 
            ManufactureDate = manufactureData;  
        }

        public override string PriceTag()
        {
            return Name 
                + "(used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
