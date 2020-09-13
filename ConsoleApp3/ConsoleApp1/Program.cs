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
        double uid;
        string name;
        int sem;
        string email;
        public void Readdata()
        {
            Console.WriteLine("Enter the Student_Details: \n");
            A.Write("UID: ");
            uid = Convert.ToDouble(A.ReadLine());
            A.Write("Name: ");
            name = A.ReadLine();
            A.Write("Semester: ");
            sem = Convert.ToInt32(A.ReadLine());
            if (sem<1 || sem>8)
                throw new Myexception();
            A.Write("Email: ");
            email = A.ReadLine();

        }
        public void Dispalydata()
        {
            A.WriteLine("\nStudent Details\n");
            A.WriteLine("UID: "+uid+"\n" + "Name: "+name+"\n"+"Sem: "+sem+"\n" + "Email: "+email);
        }
    }
    class Myexception:ApplicationException
    {
        public Myexception()
        {

        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            try
            {
                s1.Readdata();
            }
            catch (Myexception ex)
            {
                A.WriteLine("Input for Semester is Inappropriate");
                A.WriteLine("Enter accurate credentials this time\n");
                try
                {
                    s1.Readdata();
                }
                catch (Exception e)
                {
                    A.WriteLine("Inappropriate input");
                    A.WriteLine("Enter accurate credentials this time\n");
                    s1.Readdata();
                }

            }
            catch (FormatException f)
            {
                A.WriteLine("Inappropriate input");
                A.WriteLine("Enter accurate credentials this time\n");
                try
                {
                    s1.Readdata();
                }
                catch (Myexception a)
                {
                    A.WriteLine("Inappropriate input");
                    A.WriteLine("Enter accurate credentials this time\n");
                    s1.Readdata();
                }
            }
            catch(Exception e)
            {
                A.WriteLine("Inappropriate input");
                A.WriteLine("Enter accurate credentials this time\n");
                s1.Readdata();
            }
            finally
            {
                s1.Dispalydata();
            }
           
        }
    }
}
