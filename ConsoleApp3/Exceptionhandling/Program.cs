using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling
{
    class ExceptionTest
    {
        
        static void Main()
        {
            double a = 98, b = 0;
            double result = 0;

            try
            {
                result = a / b;
                //Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
                //throw e;
            }
        }
    }
}