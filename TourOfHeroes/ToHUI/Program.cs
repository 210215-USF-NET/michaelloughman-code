using System;
using ToHModels;
namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add hero method
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name");
            newHero.HeroName = Console.ReadLine(); 
            Console.WriteLine("Enter HP Value");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower details");
            SuperPower newSuperPower = new SuperPower();
            Console.WriteLine("Enter SuperPower name: ");
            newSuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower damage");
            newSuperPower.Damage = int.Parse(Console.ReadLine()
            );
            newHero.SuperPower = newSuperPower;
            Console.WriteLine("Set the element of the hero: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());
            Console.WriteLine($"Hero Created with details: \n\t name = {newHero.HeroName} \n\t superpower: {newHero.SuperPower.Name} \n\t type: {newHero.ElementType}");
        }
    }
}
