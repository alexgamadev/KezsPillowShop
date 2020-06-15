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
                    ImageURL = "https://i.pinimg.com/originals/8f/0a/9c/8f0a9c30700533e2690ed6f4bf430034.jpg",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSEd4kbhBDJ_oxG62j-jmTeuLCDjS-UhBI8u4d4F-1QGO4wSeHo&usqp=CAU",
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
                    ImageURL = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F42%2F2013%2F06%2F08194731%2Fimg_patchwork-pillowlg_1_0.jpg&q=85",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTc1nIjtEoOMC3X79dNQ-uCEwg1rDAMoQLQh0QjpcvFV1gajzhK&usqp=CAU",
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
                    ImageURL = "https://ae01.alicdn.com/kf/H642d1cbe4e5d4d37a722cb135fe244283/New-Lovely-Huggable-sitting-Cat-Plush-Toys-Stuffed-Cute-Cat-Doll-Lovely-Animal-Pillow-Soft-Cartoon.jpg",
                    ImageThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ9njTiQtLqAuBXYAowRZtoS2hxvR1qoL1YTTuNLG1cgUnjK8-Q&usqp=CAU",
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
