using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev elevator = new Elev();
            //elevator.Floor = 1; //default floor
            int i = 1;
            do
            {
                Console.WriteLine("If you want to get out, press 0 & enter.");
                Console.WriteLine("Select floor (1-5) -> ");
                string line = Console.ReadLine();
                //try to read number from the given line
                bool result = int.TryParse(line, out i);
                // number(int) was given correctly
                if (result)
                {
                    elevator.Floor = i;
                    Console.WriteLine("You are in floor " + elevator.Floor);
                    elevator.Do();
                }
                else Console.WriteLine("Try again!");
            }
            while ( i != 0);//tänne
            Console.WriteLine("Thank you for your corporation.");
            

        }
    }
}
