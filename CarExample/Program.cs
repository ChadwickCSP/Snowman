using System;
using System.Collections.Generic;
using CarExample;

List<ICar> cars;
cars = new List<ICar>();

cars.Add(new LemonCar());
cars.Add(new FastCar());
cars.Add(new SlowCar());

int round = 1;

while (round <= 20)
{
    Console.WriteLine($"Round: {round}");
    foreach (ICar car in cars)
    {
        Console.WriteLine($"{car.GetName()} going {car.GetSpeed()} MPH!");
        car.Accelerate();
    }
    round++;
}