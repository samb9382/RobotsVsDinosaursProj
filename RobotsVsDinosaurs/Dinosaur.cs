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
        public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            energy = 20;
            attackPower = 15;
        }



        //member methods
        public void Attack(Robot robotAttacked)
        {
            robotAttacked.health -= attackPower;
        }

        public void TakeDameage(Dinosaur dinosaur)
        {
            dinosaur.health -= attackPower;
        
        }

    }
}
