using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //member variables
        public List<Robot> robotFleet;

        //constructor
        public Fleet()
        {
            robotFleet = new List<Robot>();

            Robot robotOne = new Robot("Optimus", "gun");

            Robot robotTwo = new Robot("Wall-e", "RPG");

            Robot robotThree = new Robot("Rob", "Brass Knuckles");

            robotFleet.Add(robotOne);
            robotFleet.Add(robotTwo);
            robotFleet.Add(robotThree);
        }
  
    }
}
