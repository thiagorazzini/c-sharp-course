using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    internal class Students
    {
        //São 10  quartos de 0 a 9
        public string Name { get; set; }
        public string Email { get; set; }

        public Students(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
