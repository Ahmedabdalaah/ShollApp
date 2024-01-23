using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShollApp
{
    internal class Department
    {
        public string name { get; set; }
        public void addDept()
        {
                StreamWriter stream = new StreamWriter("department.txt", true);
                stream.WriteLine("department name : " + name);
                stream.Close();
                Console.WriteLine("Success");
        }
    }
}
