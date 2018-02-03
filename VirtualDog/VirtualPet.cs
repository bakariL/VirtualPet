using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDog
{
    class VirtualPet  //VirtualPet class
    {
        //Fields
        private string name;
        private int energy;
        private int hungar;
        private bool isBord = true;

        //Properties 3
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }

        public int Hungar
        {
            get { return this.hungar; }
            set { this.hungar = value; }
        }

        public bool Isbord
        {
            get { return this.isBord; }
            set { this.isBord = value; }
        }



        //Contructors at least 1
        public VirtualPet()
        {
            this.name = "BoBo the Bear";//maybe put something better here....
        }

        public VirtualPet(int energy)
        {
            this.Energy = energy;
        }

        public VirtualPet(string name, int energy, int hungar)
        {
            this.name = name;
            this.Energy = energy;
            this.hungar = hungar;
        }
        public VirtualPet(string name, int energy, int hungar, bool isBord)
        {
            this.name = name;
            this.hungar = hungar;
            this.isBord = isBord;
            this.energy = energy;
        }


        //Methods 3
        public void GetName(string name)
        {
            this.name = "BoBo";
        }

        public void GetSleep()
        {

            energy += (energy - 25);
            Console.WriteLine("Engergy:" + energy);
        }

        public int Feed(int hungar)
        {
            return hungar += hungar;
        }
        public string Play()
        {
            if (isBord)
            {
                return "Play with me!";

            }
            else
            {
                return "Im getting tired of playing.";
            }
        }
        public void Eat()
        {
            if(energy < 50)
            {
                Console.WriteLine("I am getting tired.");
                energy += energy;
            }
            else
            {
                Console.WriteLine("i am well rested");
            }
        }
    }
 }

