using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KezsPillowShop.Models.Repositories
{
    public class MockPillowRepository : IPillowRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pillow> AllPillows =>
            new List<Pillow>
            { 
                new Pillow { 
                    PillowId = 1,
                    Name = "Fluffy Pillow",
                    Price = 4.00M,
                    ShortDescription = "Fluffy",
                    LongDescription = "This pillow is fluffy",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageURL = "https://ae01.alicdn.com/kf/H1c61b06d8d0a4e6ab356c550559c47a4k/Ins-Fluffy-Pillow-Wool-Cushions-Fur-Cushion-Cover-Sofa-Long-Plush-Bed-Pillows-Christmas-Decorations-Christmas.jpg",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRXsK2fq0Tqa8fE5rD1AxovFIHY_HveG4PlGilg0H-GSWpv0BYN&usqp=CAU",
                    InStock = true,
                    IsPillowOfTheWeek = true,
                },
                new Pillow {
                    PillowId = 2,
                    Name = "Patchwork Pillow",
                    Price = 10.00M,
                    ShortDescription = "Patchy",
                    LongDescription = "This pillow is patchy",
                    Category = _categoryRepository.AllCategories.ToList()[2],
                    ImageURL = "https://www.livelaughlove.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/l/l/lll_53_32.jpg",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSWaBdPWH3paRAS4LQKhr36RjkeiRx3aYVTtgMhSgbzK5FPIieh&usqp=CAU",
                    InStock = false,
                    IsPillowOfTheWeek = false,
                },
                new Pillow {
                    PillowId = 3,
                    Name = "Heart Pillow",
                    Price = 7.00M,
                    ShortDescription = "Hearty",
                    LongDescription = "This pillow is shaped like a heart",
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    ImageURL = "https://i1.adis.ws/i/dm/30180876.jpg?$standardplayerdefault$&img404=noimagedefault",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS47efweL_I18knIGa3nLg0KGTeGlp_x6jf4rOaRvWVvs2PlaEz&usqp=CAU",
                    InStock = true,
                    IsPillowOfTheWeek = true,
                },
                new Pillow {
                    PillowId = 4,
                    Name = "Animal Pillow",
                    Price = 4.00M,
                    ShortDescription = "Animalistic",
                    LongDescription = "This pillow is decorated with animals",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageURL = "https://seoulify.net/wp-content/uploads/2017/11/40x30cm-Pusheen-Cat-Plush-Toys-Stuffed-Animal-Doll-Animal-Pillow-Toy-Pusheen-Cat-For-Kid-Kawaii-5.jpg",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSMdOkIfISIK2jYNoWsJVpmk0raK-rKlcTTRAeQpAwl0wHky_Xq&usqp=CAU",
                    InStock = true,
                    IsPillowOfTheWeek = false,
                }
            };

        public IEnumerable<Pillow> PillowsOfTheWeek { get; }

        public Pillow GetPillowById(int id)
        {
            return AllPillows.FirstOrDefault(p => p.PillowId == id);
        }
    }
}
