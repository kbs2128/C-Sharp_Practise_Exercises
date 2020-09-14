using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using A = System.Console;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int yob;
                int mob;
                int dob;
                A.WriteLine("Enter the Year of your Birth");
                yob = Convert.ToInt32(A.ReadLine());
                A.WriteLine("Enter the Month of your Birth");
                mob = int.Parse(A.ReadLine());
                A.WriteLine("Enter the Day of your Birth");
                dob = int.Parse(A.ReadLine());
                int r = validitycheck(yob, mob, dob);
                switch (r)
                {
                    case -1:
                        A.WriteLine("U r born this year");
                        A.WriteLine("Your Sunsign is: " + Sunsign(mob, dob));
                        break;
                    case 0:
                        A.WriteLine("Hey u r born today,Welcome");
                        A.WriteLine("Alright Your Sunsign is: " + Sunsign(mob, dob));
                        break;
                    case 1:
                        A.Write("U entered a future date");
                        break;
                    case 2:
                        A.WriteLine("You r lucky to have lived>=135 years");
                        A.WriteLine("Anyway Your Sunsign is: " + Sunsign(mob, dob));
                        break;
                    default:
                        A.WriteLine("your age is: " + r);
                        if ((TodayBirthday(mob, dob)))
                            A.WriteLine("Happy Birthday");
                        A.WriteLine("Your Sunsign is: " + Sunsign(mob, dob));

                        break;
                }

            }
            catch (FormatException e)
            {
                A.WriteLine(e.Message);
                A.WriteLine("Enter the Accurate Credentials this time\n");
                int yob;
                int mob;
                int dob;
                A.WriteLine("Enter the Year of your Birth");
                yob = Convert.ToInt32(A.ReadLine());
                A.WriteLine("Enter the Month of your Birth");
                mob = int.Parse(A.ReadLine());
                A.WriteLine("Enter the Day of your Birth");
                dob = int.Parse(A.ReadLine());
                int r = validitycheck(yob, mob, dob);
                switch (r)
                {
                    case -1:
                        A.WriteLine("You are born this year");
                        A.WriteLine("Your Sunsign is: " + Sunsign(mob, dob));
                        break;
                    case 0:
                        A.WriteLine("Hey you are born today,Welcome");
                        A.WriteLine("Alright Your Sunsign is: " + Sunsign(mob, dob));
                        break;
                    case 1:
                        A.Write("You entered a future date");
                        break;
                    case 2:
                        A.WriteLine("You are lucky to have lived>=135 years");
                        A.WriteLine("Anyway Your Sunsign is: " + Sunsign(mob, dob));
                        break;
                    default:
                        A.WriteLine("your age is: " + r);
                        if ((TodayBirthday(mob, dob)))
                            A.WriteLine("Happy Birthday");
                        A.WriteLine("Your Sunsign is: " + Sunsign(mob, dob));

                        break;
                }
            }

        }
        public static bool TodayBirthday(int mob, int dob)
        {
            DateTime tdy = DateTime.Today;
            if (mob == DateTime.Today.Month && dob == DateTime.Today.Day)
                return true;
            else
                return false;
        }
        public static string Sunsign(int mob, int dob)
        {
            switch (mob)
            {
                case 1:
                    if (dob <= 21)
                        return "Capricorn";
                    else
                        return "Aquarius";
                case 2:
                    if (dob <= 20)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                    if (dob <= 19)
                        return "Pisces";
                    else
                        return "Aries";
                case 4:
                    if (dob <= 20)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (dob <= 21)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (dob <= 22)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (dob <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (dob <= 22)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (dob <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (dob <= 22)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (dob <= 22)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (dob <= 22)
                        return "Sagittarius";
                    else
                        return "Capricorn";
                default:
                    return "Not Found";
                    break;

            }
        }
        public static int validitycheck(int yob, int mob, int dob)
        {
            DateTime bdate = new DateTime(yob, mob, dob);
            DateTime tdate = DateTime.Today;
            int rvalue = DateTime.Compare(bdate, tdate);
            if (rvalue < 0)
            {
                if ((tdate.Year - bdate.Year) >= 135)
                    return 2;
                else if ((tdate.Year - bdate.Year) == 0)
                    return -1;
                else
                    return (tdate.Year - bdate.Year);
            }
            else if (rvalue > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }




        }
    }
}
