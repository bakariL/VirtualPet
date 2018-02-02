using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDog
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            VirtualPet userPet = new VirtualPet();
            Tick userTick = new Tick();
            int userChoice;


           
                Console.WriteLine("Hello, welcome to Virtual Pet.");
            do
            {
                
                Console.WriteLine("What would you like to do with your pet?");

                
                Console.WriteLine("To see the name of pet, Type 1");
                Console.WriteLine("To feed the pet, Type 2");
                Console.WriteLine("To put the pet to bed, Type 3");
                Console.WriteLine("To play with the pet, Type 4");
                Console.WriteLine("To see all, type 5");
                Console.WriteLine("To restart, type 6");
                Console.WriteLine("To quit, type 7");

                userChoice = int.Parse(Console.ReadLine());
            
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine(userPet.Name);
                        break;
                    case 2:
                        Console.WriteLine("Hungar: "+ userPet.IsHungry);
                        break;
                    case 3:
                        Console.WriteLine("Energy: " + userPet.IsHungry);
                        break;
                    case 4:
                        Console.WriteLine(userPet.Play());
                        break;
                    case 5:
                        Console.WriteLine(userPet.Name);
                        Console.WriteLine("Health: " + userPet.IsHungry);
                        Console.WriteLine("Energy: "+ userPet.Energy);
                        Console.WriteLine("Bored? "+ userPet.Play());
                        break;
                    
                }
            }                
            while (userChoice != 6);

        }


    }
}
