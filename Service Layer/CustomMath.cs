using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public class CustomMath
    {

        public  void FactorialNumber(int number)
        {
            int multiple = 1;
            for (int i = 1; i <= number; i++)
            {
                multiple *= i;
            }

            Console.WriteLine(multiple);

        }


        public  void Main(int numbers,int m )
        {

            int count = 0;
            
            for (int i = m; i < numbers; i++)
            {

                if (i % 2 == 1)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
