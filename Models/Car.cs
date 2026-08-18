namespace Models;
using Configuration;

public class Car
{
    public string RegNr => Configuration.Car.RegNr[new Random().Next(0, Configuration.Car.RegNr.Length)];
}
