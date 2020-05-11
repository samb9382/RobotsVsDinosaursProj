using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {   //member variables
        public string type;
        public double health;
        public double energy;
        public double attackPower;

        //constructor
        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }



        //member methods




        //instantiation
        Dinosaur dinosaurOne = new Dinosaur("Brontosaurus", 100, 30, 25);

        Dinosaur dinosaurTwo = new Dinosaur("Megalodon", 100, 80, 95);

        Dinosaur dinosaurThree = new Dinosaur("T-Rex", 100, 90, 90);

    }
}
