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
            VirtualPet tick = new VirtualPet();
           


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

                userPet.Tick();
                userChoice = int.Parse(Console.ReadLine());
            
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(userPet.Name);
                        break;
                    case 2:
                        Console.Clear();
                        userPet.Feed();
                        Console.WriteLine("Your pet is hungry!");
                    //    Console.WriteLine("Hungar: "+ userPet.Hungar);
                        break;
                    case 3:
                        Console.Clear();
                        userPet.GetSleep();
                        Console.WriteLine("Your pet needs some rest");
                      //  Console.WriteLine("Energy: " + userPet.Energy);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Im bored");
                        userPet.Play();
                      //  Console.WriteLine(userPet.Isbord);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(userPet.Name);
                        Console.WriteLine("Health: " + userPet.Energy);
                        Console.WriteLine("Hungar: " + userPet.Hungar);
                        Console.WriteLine("Bordem: " + userPet.Isbord);
                            break;
                    
                }
            }                
            while (userChoice != 6);

        }

        
    }
}
