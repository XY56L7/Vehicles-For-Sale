using XY56L7_SOF_2022231.Data;
using XY56L7_SOF_2022231.Models;
using XY56L7_SOF_2022231.Repository.Interfaces;

namespace XY56L7_SOF_2022231.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext db)
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
