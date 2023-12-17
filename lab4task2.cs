using System;
using System.Collections.Generic;

class Car
{
    private string name;
    private int productionYear;
    private int maxSpeed;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ProductionYear
    {
        get { return productionYear; }
        set { productionYear = value; }
    }

    public int MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    public Car(string name, int productionYear, int maxSpeed)
    {
        Name = name;
        ProductionYear = productionYear;
        MaxSpeed = maxSpeed;
    }
}

class CarComparer : IComparer<Car>
{
    private string sortBy;

    public CarComparer(string sortBy)
    {
        this.sortBy = sortBy;
    }

    public int Compare(Car x, Car y)
    {
        switch (sortBy)
        {
            case "Name":
                return x.Name.CompareTo(y.Name);
            case "ProductionYear":
                return x.ProductionYear.CompareTo(y.ProductionYear);
            case "MaxSpeed":
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            default:
                return 0;
        }
    }
}

class lab4task2
{
    static void Main()
    {
        Car[] cars = new Car[]
        {
            new Car("Lamborgini", 2023, 350),
            new Car("Bugatti", 2013, 450),
            new Car("Ferrari", 2003, 350),
            new Car("lada 2108", 1984, 9999)
        };

        Console.WriteLine("\nCars:");
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Name}, {car.ProductionYear}, {car.MaxSpeed}");
        }

        int i = 0; while (i != 1)
        {
            Console.WriteLine("\nChoose the type of sort:"); string type = Console.ReadLine();
            switch (type)
            {
                case "Name":
                    Array.Sort(cars, new CarComparer("Name"));
                    i++;
                    break;
                case "Year":
                    Array.Sort(cars, new CarComparer("Year"));
                    i++;
                    break;
                case "Speed":
                    Array.Sort(cars, new CarComparer("Speed"));
                    i++;
                    break;
                default:
                    Console.WriteLine("Wrong name =(");
                    break;
            }
        }

        Console.WriteLine("\nSorted cars:");
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Name}, {car.ProductionYear}, {car.MaxSpeed}");
        }
    }
}
