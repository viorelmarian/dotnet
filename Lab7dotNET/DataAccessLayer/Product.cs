using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        private Product()
        {
            //EF
        }
        private Product(string name, double price)
        {
            Id = Guid.NewGuid();
            SetProperties(name, price);
        }
        private void SetProperties(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
