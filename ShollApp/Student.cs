using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShollApp
{
    internal class Student : Person
    {
        public string grade { get; set; }
        public void addStudent()
        {
            bool status = checkName();
            if (status == true)
            {
                StreamWriter stream = new StreamWriter("student.txt", true);
                stream.WriteLine("first name : " + firstName);
                stream.WriteLine("last name : " + lastName);
                stream.WriteLine("address : " + addres);
                stream.WriteLine("age : " + age);
                stream.WriteLine("grade : " + grade);
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
