using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class CategoryService: ICategoryService
    {
        private ICategoryRepository categoryRepository = new CategoryRepository();
        public List<Category> GetAll()
        {
            return categoryRepository.GetAll(); //all product
        }

        public Models.Category GetById(int categoryId)
        {
            return categoryRepository.GetById(categoryId);
        }

        public int Add(Category category)
        {
            return categoryRepository.Add(category);
        }

        public bool Update(Category category)
        {
            return categoryRepository.Update(category);
        }

        public bool Delete(int categoryId)
        {
            return categoryRepository.Delete(categoryId);
        }
    }
}
