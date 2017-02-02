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
                //elevator.Floor
                i = int.Parse(Console.ReadLine());// ota muuttujaan ja vertaa sitä alle
                elevator.Floor = i;
                Console.WriteLine("You are in floor " + elevator.Floor);
                elevator.Do();
            }
            while ( i != 0);//tänne
            Console.WriteLine("Thank you for your corporation.");
            

        }
    }
}
