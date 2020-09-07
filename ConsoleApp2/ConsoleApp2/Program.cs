using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfirstdll;
using A = System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
           A.WriteLine( c1.Add(5, 3));
        }
    }
}
