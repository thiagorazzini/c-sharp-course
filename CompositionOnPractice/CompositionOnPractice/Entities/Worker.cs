﻿using System.Collections.Generic;
using CompositionOnPractice.Entities.Enums;

namespace CompositionOnPractice.Entities
{
    internal class Worker
    {
        public string  Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContact(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContact(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mouth)
        {
            double sum = BaseSalary;
            
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
