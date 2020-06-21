using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KezsPillowShop.Models;
using KezsPillowShop.ViewModels;
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
            PillowsListViewModel pillowsListVM = new PillowsListViewModel();
            pillowsListVM.Pillows = _pillowRepository.AllPillows;
            pillowsListVM.CurrentCategory = "Small Pillows";

            return View(pillowsListVM);
        }
    }
}
