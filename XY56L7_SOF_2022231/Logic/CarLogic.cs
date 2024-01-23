using XY56L7_SOF_2022231.Data;
using XY56L7_SOF_2022231.Logic.Interfaces;
using XY56L7_SOF_2022231.Models;

namespace XY56L7_SOF_2022231.Logic
{
    public class CarLogic : ICarLogic
    {
        private readonly ApplicationDbContext _db;

        public CarLogic(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _db.Cars.ToList();
        }

        public Car GetCarByTitleAndOwnerId(string title, string ownerId)
        {
            return _db.Cars.FirstOrDefault(c => c.Title == title && c.OwnerId == ownerId);
        }

        public void AddCar(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }
        public void DeleteCar(string uid)
        {
            var car = _db.Cars.FirstOrDefault(c => c.Uid == uid);
            if (car != null)
            {
                _db.Cars.Remove(car);
                _db.SaveChanges();
            }
        }

    }
}
