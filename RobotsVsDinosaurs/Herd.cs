using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //member variable
        public List<Dinosaur> dinosaurHerd;

        //constructor
        public Herd()
        {
            dinosaurHerd = new List<Dinosaur>();

            Dinosaur dinosaurOne = new Dinosaur("Brontosaurus");

            Dinosaur dinosaurTwo = new Dinosaur("Megalodon");

            Dinosaur dinosaurThree = new Dinosaur("T-Rex");

            dinosaurHerd.Add(dinosaurOne);
            dinosaurHerd.Add(dinosaurTwo);
            dinosaurHerd.Add(dinosaurThree);
        }
    }
}

        
    

