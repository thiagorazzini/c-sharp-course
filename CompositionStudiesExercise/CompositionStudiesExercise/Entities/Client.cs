﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionStudiesExercise.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {
            
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return Name
                + " ("
                + birthDate.ToString()
                + ") "
                + " - "
                + Email;
        }


    }
}
