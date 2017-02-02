using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person//Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one studen object
            Student student = new Student();
            student.Firstname = "Seppo";
            student.Lastname = "Virtuaalli";
            student.Address = "katu 6";
            student.Age = 300;
            student.PhoneNumber = "12323445";
            student.StudentID = "a1234";
            Console.WriteLine(student.ToString());

            // create on teacher

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D566");
            teacher.Age = 55;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "838383838";
            Console.WriteLine(teacher.ToString());
            student.PersonMethod();

        }
    }
}
