using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string type;
        public double attackPower;


        //constructor
        public Weapon(string type)
        {
            this.type = type;
            attackPower = 5;

        }

    }
}
