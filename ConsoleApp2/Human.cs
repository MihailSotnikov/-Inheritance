using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Human
    {
        public int Hunger;
        public int Thirst;
        public int Water;
        public int WaterCost = 2;
        public int Apples;
        public int ApplesCost=4;
        public int EatApple;
        public int DrinkWater;
        public int Money;


        public void ShowParametres(string name)
        {
            Console.WriteLine(name + "s parametres");
            Console.WriteLine("Hunger: "+Hunger);
            Console.WriteLine("Thirst: "+Thirst);
            Console.WriteLine("Apples: "+Apples);
            Console.WriteLine("Water: "+Water);
            Console.WriteLine("EatApples: "+EatApple);
            Console.WriteLine("DrinkWater: "+DrinkWater);
            Console.WriteLine("Money: "+Money);

        }
        public void Eat()
        {
            Hunger -= EatApple;
            Apples -= EatApple;
        }

        public void Drink()
        {
            Thirst -= DrinkWater;
            Water -= DrinkWater;
        }

        public void Buy(string what, int amount)
        {
            if (what == "apples")
            {
                Apples += amount;
                Money -= ApplesCost * amount;
            }
            else if (what == "water")
            {
                Water += amount;
                Money -= WaterCost * amount;
            }
            else
            {
                Console.WriteLine("No apple and no Water");
            }
        }

        public void Sell(string what, int amount)
        {

        }
        public void Buy(string what, int amount, Human name)
        {
            if (what == "apples")
            {
                Apples += amount;
                Money -= ApplesCost * amount;
                name.Apples -= amount;
                name.Money += ApplesCost*amount;
            }
            else if (what == "water")
            {
                Water += amount;
                Money -= WaterCost * amount;
                name.Apples -= amount;
                name.Money +=WaterCost* amount;
            }
            else
            {
                Console.WriteLine("No apple and no Water");
            }
        }
        public void Sell(string what,int amount, Human name)
        {
            if (what == "apples")
            {
                Apples -= amount;
                Money += amount * ApplesCost;
                name.Apples += amount;
                name.Money += ApplesCost * amount;
            }
            else if(what=="water")
             {
                Water -= amount;
                Money += amount * WaterCost;
                name.Water += amount;
                name.Money -= WaterCost * amount;
            }
            {
                Console.WriteLine("No apple and no Water");
            }
        }

    }

   
}
