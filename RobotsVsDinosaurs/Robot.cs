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

        //Constructor
        public Robot(string name, double health, double powerLevel, double attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;

        }





        //member methods
        public void Attack()
        {

        }

        public void TakeDamage()
        {

        }
    }
}
