using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__Dll_Homework
{
    internal class Calculator
    {

        public void Calculation()
        {

            float result = 0;

            Console.WriteLine( "Enter frist number");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter secound number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

            switch (op)
            {

                case"+":
                    result = num1 + num2;
                    break;
                case"-":
                    result = num1 - num2;
                    break;
                case"*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;  
            }

            Console.WriteLine("Result = " + result );



        }


        




    }
  
}
