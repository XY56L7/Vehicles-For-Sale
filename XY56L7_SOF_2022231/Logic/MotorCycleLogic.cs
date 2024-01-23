using System;
using System.Linq;
using XY56L7_SOF_2022231.Data;
using XY56L7_SOF_2022231.Logic.Interfaces;
using XY56L7_SOF_2022231.Models;

namespace XY56L7_SOF_2022231.Logic
{
    public class MotorcycleLogic : IMotorcycleLogic
    {
        private readonly ApplicationDbContext _db;

        public MotorcycleLogic(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Motorcycle> GetAllMotorcycles()
        {
            return _db.Motorcycles.ToList();
        }

        public Motorcycle GetMotorcycleByTitleAndOwnerId(string title, string ownerId)
        {
            return _db.Motorcycles.FirstOrDefault(c => c.Title == title && c.OwnerId == ownerId);
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _db.Motorcycles.Add(motorcycle);
            _db.SaveChanges();
        }

        public void DeleteMotorcycle(string uid)
        {
            var motorcycle = _db.Motorcycles.FirstOrDefault(c => c.Uid == uid);
            if (motorcycle != null)
            {
                _db.Motorcycles.Remove(motorcycle);
                _db.SaveChanges();
            }
        }
    }
}
