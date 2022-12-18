﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__Dll_Homework
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public Employee(string name, string surname, string address, int salary,int age)
        {

            Name = name; Surname = surname; Address = address;  Salary = salary;  Age = age;

        }

    }
}
