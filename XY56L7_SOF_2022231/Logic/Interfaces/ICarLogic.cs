using XY56L7_SOF_2022231.Models;

namespace XY56L7_SOF_2022231.Logic.Interfaces
{
    public interface ICarLogic
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarByTitleAndOwnerId(string title, string ownerId);
        void AddCar(Car car);
        void DeleteCar(string uid);
    }
}
