namespace Models;
using Configuration;

public class Car :ICar
{
    public string RegNr => Configuration.CarConfiguration.CarService.RegNr[new Random().Next(0, Configuration.CarConfiguration.CarService.RegNr.Length)];
}
