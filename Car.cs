using System;
class Car
{




    public string Brand;
    public int Speed;

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving at {Speed}km/h");
    }

    public static void Main18()
    {
        Car car1 = new Car();
        car1.Brand = "BMW";
        car1.Speed = 120;

        car1.Drive();
    }
}



