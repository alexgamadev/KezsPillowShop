using System.Collections.Generic;

namespace KezsPillowShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pillow> Pillow { get; set; }
    }
}