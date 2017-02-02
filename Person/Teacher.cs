using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person//Application
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // Constructor
        public Teacher()
        {

        }
        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }
        public void TeacherMethod()
        {
            Console.WriteLine("This method belogs to Teacher!");
        }
        public override string ToString()
        {
            // person-luokan ToSrting + Room
            // Firstname  + Lastname... + Room
            // base viittaa yliluokkaan eli nyt Person-luokkaan
            return base.ToString() + " " + Room ;
        }
    }

}
