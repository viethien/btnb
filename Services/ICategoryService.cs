﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
        int Add(Category category);
        bool Update(Category category);
        bool Delete(int categoryId);  
    }
}
