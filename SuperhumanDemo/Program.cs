using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperhumanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Sahal Mohamed
            //Student Number: 300895007
            //2017/07/13
            
            //SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            //superHero.Powers.Add(new Power("Teleportation", 50));
           //superHero.Powers.Add(new Power("Phasing", 40));
            //superHero.Powers.Add(new Power("Invisibility", 30));
            //Console.WriteLine(superHero.ToString());
            //Console.WriteLine("Karma: " + superHero.Karma);
            

            SuperVillain superVillain = new SuperVillain("Hero Killer: Stain", 20);
            superVillain.Powers.Add(new SuperhumanDemo.Power("BloodCurdle", 50));
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice points: " + superVillain.Malice);
        }
    }
}
