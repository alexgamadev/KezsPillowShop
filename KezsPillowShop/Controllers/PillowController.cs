using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KezsPillowShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace KezsPillowShop.Controllers
{
    public class PillowController : Controller
    {
        private readonly IPillowRepository _pillowRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PillowController(IPillowRepository pillowRepository, ICategoryRepository categoryRepository)
        {
            _pillowRepository = pillowRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_pillowRepository.AllPillows);
        }
    }
}
