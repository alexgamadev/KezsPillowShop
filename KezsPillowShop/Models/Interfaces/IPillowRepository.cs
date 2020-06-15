using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KezsPillowShop.Models
{
    public interface IPillowRepository
    {
        IEnumerable<Pillow> AllPillows { get; }
        IEnumerable<Pillow> PillowsOfTheWeek { get; }
        Pillow GetPillowById(int id);
    }
}
