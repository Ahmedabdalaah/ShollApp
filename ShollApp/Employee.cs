using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShollApp
{
    internal class Employee : Person 
    {
        public string department { get; set; }
        public void addEmployee()
        {
            bool status = checkName();
            if (status == true)
            {
                StreamWriter stream = new StreamWriter("employee.txt", true);
                stream.WriteLine("first name : " + firstName);
                stream.WriteLine("last name : " + lastName);
                stream.WriteLine("address : " + addres);
                stream.WriteLine("age : " + age);
                stream.WriteLine("email : " + department);
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
