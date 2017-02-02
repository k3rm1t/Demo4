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
            do
            {
                Console.WriteLine("If you want to get out, press x & enter.");
                Console.WriteLine("Select floor -> ");

                elevator.Floor = int.Parse(Console.ReadLine());// ota muuttujaan ja vertaa sitä alle
                Console.WriteLine("You are in room" + Floor);
            }
            while (elevator.Floor != "x");//tänne
            

        }
    }
}
