using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elev
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;
        private int floor;
       
        public int Floor
        {
            get
            {
                Floor = floor;
                return floor;
            }
            set
            {
                if (minFloor >= value && value <= maxFloor) floor = value;
                else
                {
                    Console.WriteLine("Option is unavailable.");
                    
                }
            }
        }
        // def const
        public Elev()
        {
        }
        //methods
        public void Do()
        {
            Console.WriteLine(Floor + ".floor");
        }
       
    }
}
