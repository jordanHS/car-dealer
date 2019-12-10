using System;
using System.Collections.Generic;

public class Car
{
    public string MakeModel;
    public int Price;
    public int Miles;
    public string Description;


    public Car(string makeModel, int price, int miles, string description)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        Description = description;

    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
        return (Price < maxPrice && Miles < maxMiles);
    }
}

public class Program
{
    public static void Main()
    {
        Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Car yugo = new Car("1980 Yugo Koral", 700, 56000, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Car amc = new Car("AMC Pacer", 400, 19800, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

        List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

        Console.WriteLine("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);

        Console.WriteLine("Enter max miles: ");
        string stringMaxMiles = Console.ReadLine();
        int maxMiles = int.Parse(stringMaxMiles);

        List<Car> CarsMatchingSearch = new List<Car>(0);

        foreach (Car automobile in Cars)
        {
            if (automobile.WorthBuying(maxPrice, maxMiles))
            {
                CarsMatchingSearch.Add(automobile);
            }
        }

         if (CarsMatchingSearch.Count == 0)
            {
                Console.WriteLine("Sorry there are no cars matching those requirements.");
            }
         
        foreach(Car automobile in CarsMatchingSearch)
        {
            Console.WriteLine(automobile.MakeModel + " " + automobile.Description);    
        }    
    }
}



