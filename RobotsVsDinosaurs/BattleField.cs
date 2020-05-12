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
    }
}
