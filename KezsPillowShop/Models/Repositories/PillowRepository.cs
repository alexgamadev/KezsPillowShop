using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KezsPillowShop.Models.Repositories
{
    public class PillowRepository : IPillowRepository
    {
        private readonly AppDbContext _db;

        public PillowRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Pillow> AllPillows
        {
            get
            {
                return _db.Pillows.Include(c => c.Category);
            }
        }

        public IEnumerable<Pillow> PillowsOfTheWeek
        {
            get
            {
                return _db.Pillows.Include(c => c.Category).Where(p => p.IsPillowOfTheWeek);
            }
        }

        public Pillow GetPillowById(int id)
        {
            return _db.Pillows.FirstOrDefault(p => p.PillowId == id);
        }
    }
}
