using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KezsPillowShop.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Category> AllCategories => _db.Categories;
    }
}
