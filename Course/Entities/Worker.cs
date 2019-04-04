﻿using Course.Entities.Enums;
using System.Collections.Generic;

namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel MyProperty { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel myProperty, double baseSalary, Department department)
        {
            Name = name;
            MyProperty = myProperty;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddConctract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveConctract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }

            }
            return sum;

        }

    }
}
