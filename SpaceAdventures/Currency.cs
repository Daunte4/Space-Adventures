using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Currency
    {
        public void Run()
        {
            Money();
            Jewlery();
            Water();
            Fuel();
            PlantSeeds();
        }

        int Box = 100;

        public double Money()
        {
            double MoneyOption = 1;
            double money = Box * 2;
            MoneyOption = MoneyOption * money;
            Console.WriteLine($"\n{MoneyOption} credits for the valuse of 100 dollars.");
            return MoneyOption;
        }
        public double Jewlery()
        {
            double JewleryOption = 1;
            double jewlery = Box * 2.5;
            JewleryOption = JewleryOption * jewlery;
            Console.WriteLine($"\n{JewleryOption} credits for the valuse of 100 pieces of Jewlery.");
            return JewleryOption;
        }
        public double Water()
        {
            double WaterOption = 1;
            double water = Box * 1;
            WaterOption = WaterOption * water;
            Console.WriteLine($"\n{WaterOption} credits for the valuse of 100 bottles of Water.");
            return WaterOption;
        }
        public double Fuel()
        {
            double FuelOption = 1;
            double fuel = Box * 1.5;
            FuelOption = FuelOption * fuel;
            Console.WriteLine($"\n{FuelOption} credits for the valuse of 100 pounds of Fuel.");
            return FuelOption;
        }
        public double PlantSeeds()
        {
            double PlantOption = 1;
            double Plant = Box * 1.25;
            PlantOption = PlantOption * Plant;
            Console.WriteLine($"\n{PlantOption} credits for the valuse of 100 packets of Plant Seeds.");
            return PlantOption;
        }



    }
}
/*
public class Metals // get a base modifier of 2
{
    Creds metalCredits = new Creds();
    public void Platinium() // will have a modifier of 3
    {
        Console.WriteLine("One of the better metals available, not as rare as palladium, though better for different projects." +
            "The base modifier for platinium 3");
        int metalModifier = 3;
        metalCredits.MetalCreds(metalModifier);
    }

    public void Palladium() // will have a modifier of 4
    {
        int metalModifier = 4;
        metalCredits.MetalCreds(metalModifier);
    }

    public void Titanium()
    {
        int metalModifier = 2;
        metalCredits.MetalCreds(metalModifier);
    }
}
/*

}

