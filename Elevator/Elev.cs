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
        private int minfloor, maxfloor,floor;
        public int Floor
        {
            get
            {
                return Floor;
            }
            set
            {
                if (minfloor >= value && value <= maxFloor) floor = value;
                else
                {
                    Console.WriteLine("You can't go through the roof.");
                    Floor = value;
                }
            }
        }
    }
}
