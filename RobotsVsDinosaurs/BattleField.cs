using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class BattleField
    {
        //member variables
        public Fleet fleet;
        public Herd herd;



        //constructor
        public BattleField()
        {
            herd = new Herd();
            fleet = new Fleet();
        }


        //member methods
        public void Fight()
        {
            while(fleet.robotFleet.Count > 0 && herd.dinosaurHerd.Count >0)
            fleet.robotFleet[0].Attack(herd.dinosaurHerd[0]);
            if (herd.dinosaurHerd[0].health <= 0)
            {
                herd.dinosaurHerd.Remove(herd.dinosaurHerd[0]);
            }
            if (fleet.robotFleet[0].health <= 0)
            {
                fleet.robotFleet.Remove(0);
            }
            if (fleet.robotFleet.Count > 0)
            {
                Console.WriteLine("Robots Win");
            }
            else
            {
                Console.WriteLine("Dinosaurs Win");
            }
        }
    }
}
