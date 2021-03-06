﻿using System;
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
        public Robot(string name, string weaponChoice)
        {
            this.name = name;
            health = 100;
            powerLevel = 10;
            weapon = new Weapon(weaponChoice);

        }



        //member methods
        public void Attack(Dinosaur dinosaurAttacked)
        {
            dinosaurAttacked.health -= weapon.attackPower;
        }

        
    }
}
