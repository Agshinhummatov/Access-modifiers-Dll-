using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__Dll_Homework
{
    internal class Doctor
    {
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string Address { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        int dob = int.Parse(DateOfBirth.ToString("yyyyMMdd"));


        public Doctor(string name, string surname, string address, DateTime dateOfBirth)
        {
             
            Name = name; Surname = surname; Address = address; DateOfBirth = dateOfBirth;
        }

    }
}
