using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    class ProductRepository : IProductRepository
    {
        private readonly ProductContext context;

        public ProductRepository(ProductContext context)
        {
            this.context = context;
        }

        public void Create(Product product)
        {
            if (product != null)
            {
                this.context.Products.Add(product);
                this.context.SaveChanges();
            }
        }

        public IReadOnlyList<Product> GetAll()
        {
            return this.context.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return this.context.Products.FirstOrDefault(t => t.Id == id);
        }
    }
}
