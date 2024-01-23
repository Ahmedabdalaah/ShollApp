using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShollApp
{
    internal class Person
    {
         public string firstName { get; set; }
         public string lastName { get; set; }
         public string addres { get; set; }
         public int age { get; set; }
        public bool checkName()
        {
            string expression = "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$";
            if (Regex.IsMatch(firstName, expression)&&(Regex.IsMatch(firstName, expression)))
            {
                return true;
            }
            else return false;
        }

    }
}
