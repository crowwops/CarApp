using Configuration;
using Models;

namespace Services;

public class CarService : ICarService
{
    private readonly List<ICar> _cars;

    public List<ICar> GetCars => _cars;

    public CarService()
    {
        {
        _cars = new List<ICar>();
        for (int i = 1; i <= CarConfiguration.CarService.NrOfCars; i++)
        {
            _cars.Add(new Car());

        }
    }
    }
}
