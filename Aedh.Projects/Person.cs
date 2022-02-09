using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aedh.Projects
{
    public class Person
    {
        public string? FirstName;
        public string? LastName;
        public int? age;

        public void Introduce()
        {
            Console.WriteLine( FirstName + " " + LastName + ". " + age + " yesrs old.");
        }

    }
}
