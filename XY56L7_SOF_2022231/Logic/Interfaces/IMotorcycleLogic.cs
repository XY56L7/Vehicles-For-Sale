using System.Collections.Generic;
using XY56L7_SOF_2022231.Models;

namespace XY56L7_SOF_2022231.Logic.Interfaces
{
    public interface IMotorcycleLogic
    {
        IEnumerable<Motorcycle> GetAllMotorcycles();
        Motorcycle GetMotorcycleByTitleAndOwnerId(string title, string ownerId);
        void AddMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(string uid);
    }
}
