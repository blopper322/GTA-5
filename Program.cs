﻿using System;


class Transport
{
    public string Model { get; set; }

    public Transport(string model)
    {
        Model = model;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine($"Двигатель транспорта {Model} запущен.");
    }
}


class Car : Transport
{
    public string Brand { get; set; }

    public Car(string model, string brand) : base(model)
    {
        Brand = brand;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель автомобиля {Brand} {Model} запущен.");
    }
}


class Motorcycle : Transport
{
    public string Type { get; set; }

    public Motorcycle(string model, string type) : base(model)
    {
        Type = type;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель мотоцикла {Type} {Model} запущен.");
    }
}


class Helicopter : Transport
{
    public string Manufacturer { get; set; }

    public Helicopter(string model, string manufacturer) : base(model)
    {
        Manufacturer = manufacturer;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель вертолета {Manufacturer} {Model} запущен.");
    }
}


class Airplane : Transport
{
    public string Airline { get; set; }

    public Airplane(string model, string airline) : base(model)
    {
        Airline = airline;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель самолета {Airline} {Model} запущен.");
    }
}


class Moped : Transport
{
    public string Style { get; set; }

    public Moped(string model, string style) : base(model)
    {
        Style = style;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель мопеда {Style} {Model} запущен.");
    }
}


class Motorboat : Transport
{
    public string BoatType { get; set; }

    public Motorboat(string model, string boatType) : base(model)
    {
        BoatType = boatType;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель катера {BoatType} {Model} запущен.");
    }
}


class Tram : Transport
{
    public string City { get; set; }

    public Tram(string model, string city) : base(model)
    {
        City = city;
    }

    
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель трамвая в городе {City} {Model} запущен.");
    }
}

class Program
{
    static void Main()
    {
       
        Transport[] vehicles = new Transport[]
        {
            new Car("Priora", "Lada"),
            new Car("Camry", "Toyota"),
            new Motorcycle("Ninja", "Sport"),
            new Motorcycle("Harley", "Cruiser"),
            new Helicopter("H145", "Airbus"),
            new Airplane("Boeing 747", "Delta"),
            new Moped("Vespa", "Classic"),
            new Motorboat("Speedster", "Speedboat"),
            new Tram("T-1000", "New York")
        };

        
        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
        }
    }
}

