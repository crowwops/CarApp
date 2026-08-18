using Configuration;
using Models;
using Services;

ICarService carService = new CarService();
foreach (var car in carService.GetCars)
{
Console.WriteLine($"Car registration number: {car.RegNr}");
};