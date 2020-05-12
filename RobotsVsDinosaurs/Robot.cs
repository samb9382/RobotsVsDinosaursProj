using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        // member variables
        public string name;
        public double health;
        public double powerLevel;
        public double attackPower;
        public Weapon weapon;

        //Constructor
        public Robot(string name, double health, double powerLevel, double attackPower)
        {
            this.name = name;
            health = 100;
            powerLevel = 10;
            weapon = new Weapon();


        }



        //member methods
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= attackPower;
        }

        public void TakeDamage(Robot robot)
        {
            robot.health -= attackPower;

        }
    }
}
