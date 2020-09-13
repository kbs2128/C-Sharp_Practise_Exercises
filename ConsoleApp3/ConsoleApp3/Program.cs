using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = System.Console;

namespace ConsoleApp1
{
    class Student
    {
        int uid;
        string name;
        string sem;
        string email;
        public void Readdata()
        {
            Console.WriteLine("Enter the Student_Details\n");
            A.WriteLine("UID\n");
            try
            {
                uid = int.Parse(A.ReadLine());
            }
            catch (FormatException e)
            {
                A.WriteLine("Inappropriate input\n");
            }
            finally
            {
                A.WriteLine("Enter UID again\n");
                uid = int.Parse(A.ReadLine());
                A.WriteLine("Name\n");
                name = A.ReadLine();
                A.WriteLine("Semester\n");
                sem = A.ReadLine();
                A.WriteLine("Email\n");
                email = A.ReadLine();
            }
           
        }
        public void Dispalydata()
        {
            A.WriteLine("Student Details\n");
            A.WriteLine(uid + "\n" + name + "\n" + "\n" + sem + "\n" + email);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Readdata();
            s1.Dispalydata();
        }
    }
}
