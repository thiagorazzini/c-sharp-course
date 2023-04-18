using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Accout
    {
        public string Name { get; private set; }
        public int NumberAccount { get; private set; }
        public double Balance { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public static bool VerifyInicialValue(string confirm)
        {
            if (confirm.Contains('s'))
            {
                return true;
            }
            return false;

        }




    }
}
