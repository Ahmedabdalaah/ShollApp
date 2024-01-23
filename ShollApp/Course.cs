using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShollApp
{
    internal class Course
    {
        public string name { get; set; }
        public void addCourse()
        {
            StreamWriter stream = new StreamWriter("course.txt", true);
            stream.WriteLine("course name : " + name);
            stream.Close();
            Console.WriteLine("Success");
        }
    }
}
