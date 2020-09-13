using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHandling
{
        class Myexception:Exception
        {
          /*  public override string Message
            {
               get
               {
                    return "Attempted to divide with odd number";
               }
            }*/
          public Myexception()
          {
           // Console.WriteLine("Exception has occured since divisor is an odd");
          }
        }
    class code
    { 
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the values of a and b\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b % 2 > 0)
               throw new Myexception();
           /* try
             {
                 if (b % 2 > 0)
                     throw new Myexception();
             }
             catch(Myexception e)
             {
                 Console.WriteLine(e.Message);
             }*/
            /*  finally
              {
                  Console.WriteLine("Enter another value of b\n");
                  b = Convert.ToInt32(Console.ReadLine());
                  int c = a / b;
                  Console.WriteLine("Result is {0}", c);
              }*/


            /* try
             {

                 Console.WriteLine(c);
             }
             catch(Myexception e)
             {
                 Console.WriteLine(e.Message);

             }*/
        }
    }
}
