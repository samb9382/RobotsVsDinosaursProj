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






        //instantiation
        Robot robotOne = new Robot("Optimus", 100, 50, 55);

        Robot robotTwo = new Robot("Walle", 100, 15, 30);

        Robot robotThree = new Robot("Rob", 100, 60, 80);


    }
}
