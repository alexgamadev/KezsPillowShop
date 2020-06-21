using KezsPillowShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KezsPillowShop.ViewModels
{
    public class PillowsListViewModel
    {
        public IEnumerable<Pillow> Pillows { get; set; }
        public string CurrentCategory { get; set; }
    }
}
