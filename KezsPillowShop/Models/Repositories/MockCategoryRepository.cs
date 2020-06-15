using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KezsPillowShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Small", Description = "Small Pillows"},
                new Category{CategoryId = 2, CategoryName = "Medium", Description = "Medium-sized Pillows"},
                new Category{CategoryId = 3, CategoryName = "Large", Description = "Large Pillows"}
            };
    }
}
