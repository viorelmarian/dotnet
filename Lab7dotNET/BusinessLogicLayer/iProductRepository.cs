﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public interface IProductRepository
    {
        void Create(Product product);
        IReadOnlyList<Product> GetAll();
        Product GetById(Guid id);
    }
}
