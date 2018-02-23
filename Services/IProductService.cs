﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        int Add(Product product);
        bool Update(Product product);
        bool Delete(int productId);  
    }
}
