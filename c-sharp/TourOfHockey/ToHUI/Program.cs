using System;
using ToHModels;

namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Create hockeyplayer method/logic
            HockeyPlayer newHockeyPlayer = new HockeyPlayer();
            Console.WriteLine("Eneter a hockey player name: ");
            newHockeyPlayer.HockeyPlayerName = Console.ReadLine();
            Console.WriteLine("Enter Overall value: ");
            newHockeyPlayer.SkillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Best Weapon details");
            BestWeapon newBestWeapon = new BestWeapon();

            Console.WriteLine("Enter Best Weapon name: ");
            newBestWeapon.Name = Console.ReadLine();
            Console.WriteLine("Enter Best Weapon description ");
            newBestWeapon.Description = Console.ReadLine();
            Console.WriteLine("Enter Best Weapon Speed: ");
            newBestWeapon.Speed = int.Parse(Console.ReadLine());
            newHockeyPlayer.BestWeapon = newBestWeapon;
            Console.WriteLine("What country id the player from: ");
            newHockeyPlayer.CountryName = Enum.Parse<Country>(Console.ReadLine());
            Console.WriteLine(newHockeyPlayer.HockeyPlayerName);
            Console.WriteLine($"Hockey Player created with details: \n\t name: {newHockeyPlayer.HockeyPlayerName} \n\t best weapon: {newHockeyPlayer.BestWeapon.Name} \n\t country: {newHockeyPlayer.CountryName}");
        }
    }
}
