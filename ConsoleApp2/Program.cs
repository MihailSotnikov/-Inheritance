using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vasya vasya = new Vasya();
            vasya.ShowParametres("Vasya");
            Console.WriteLine();
            vasya.Eat();
            Console.WriteLine("Vasya pokushal");
            Console.WriteLine();
            vasya.ShowParametres("Vasya");

            Console.WriteLine();
            vasya.Buy("apples",3);
            Console.WriteLine("Vasya kupil 3 apples");
            Console.WriteLine();
            vasya.ShowParametres("Vasya");

            Petro petro = new Petro();
            petro.ShowParametres("Petro");
            Console.WriteLine();
            petro.Buy("apples", 5, vasya);
            vasya.ShowParametres("Vasya");
            petro.ShowParametres("petro");

            Alex alex = new Alex();
            alex.ShowParametres("Alex");
            Console.WriteLine();

            Maria maria = new Maria();
            maria.ShowParametres("Maria");
            Console.WriteLine();
            maria.Sell("water", 3, alex);
            maria.ShowParametres("Maria");
            alex.ShowParametres("Alex");

            maria.ShowParametres("Maria");
            Console.WriteLine();
            maria.Buy("water", 1, vasya);
            maria.ShowParametres("Maria");
            vasya.ShowParametres("Vasya");

            maria.ShowParametres("Maria");
            Console.WriteLine();
            maria.Sell("apples", 2, petro);
            maria.ShowParametres("Maria");
            petro.ShowParametres("Petro");

            vasya.Sell("aples", 8, alex);
            vasya.ShowParametres("Vasya");
            alex.ShowParametres("Alex");

            petro.Buy("water", 2, alex);
            petro.ShowParametres("Petro");
            alex.ShowParametres("Alex");



        }
    }
}
