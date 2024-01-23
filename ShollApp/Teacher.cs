using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShollApp
{
    internal class Teacher : Person
    {
       public string email { get; set; }
       public double salary { get; set; } 
        public void addTeacher()
        {
            bool status = checkName();
            if (status==true)
            {
                StreamWriter stream = new StreamWriter("teacher.txt", true);
                stream.WriteLine("first name : " + firstName);
                stream.WriteLine("last name : " + lastName);
                stream.WriteLine("address : " + addres);
                stream.WriteLine("age : " + age);
                stream.WriteLine("email : " + email);
                stream.WriteLine("salary : " + salary);
                stream.Close();
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid data , try again");
            }

        }
    }
}
