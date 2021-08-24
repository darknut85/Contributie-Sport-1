using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributie_Sport_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // parameters
            DateTime currentDate = DateTime.Now;
            DateTime joinDate = DateTime.Now;
            DateTime birthDate = DateTime.Now;

            string name = "";

            double contribution = 0;
            double discount = 0;

            bool playing = false;

            // data
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("Are you playing official matches? (Yes or no)");
                    string a = Console.ReadLine();
                    if (a == "yes" || a == "Yes" || a == "YES")
                    {
                        playing = true;
                        break;
                    }
                    else if (a == "no" || a == "No" || a == "NO")
                    {
                        playing = false;
                        break;
                    }

                }
                catch (Exception) { Console.WriteLine("Invalid: Please try again."); }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the current date");
                    currentDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: Please try again."); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your birth date");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: Please try again."); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the date you joined");
                    joinDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: Please try again."); }
            }

            // math
            double years = currentDate.Year - birthDate.Year;
            double months = currentDate.Month - birthDate.Month;
            double days = currentDate.Day - birthDate.Day;

            double years2 = currentDate.Year - joinDate.Year;
            double months2 = currentDate.Month - joinDate.Month;
            double days2 = currentDate.Day - joinDate.Day;

            if (years2 > 4 || (years2 == 4 && months2 > 0) || (years2 == 4 && months2 == 0 && days2 >= 0)) 
            { discount = 2; }
            else if (years2 > 7 || (years2 == 7 && months2 > 0) || (years2 == 7 && months2 == 0 && days2 >= 0))
            { discount = 3.5; }
            else { discount = 0; }

            if (years > 18) { contribution = 75; }
            else if (years == 18 && months > 0) { contribution = 75; }
            else if (years == 18 && months == 0 && days >= 0) { contribution = 75; }
            else { contribution = 40; }

            contribution -= (contribution / 100 * discount);

            if (playing == true)
            {
                contribution += 45;
            }

            double yer = 0;
            double yer2 = 0;

            if (months > 0 || (months == 0 && days > 0))
            {
                yer = years;
            }
            else
            {
                yer = years - 1;
            }
            if (months2 > 0 || (months2 == 0 && days2 > 0))
            {
                yer2 = years2;
            }
            else
            {
                yer2 = years2 - 1;
            }

            // conclusion
            Console.WriteLine("The name of the contributor is: " + name);
            Console.WriteLine("The age of the contributor is: " + yer);
            Console.WriteLine("The starting date is: " + joinDate);
            Console.WriteLine("The current date is:" + currentDate);
            Console.WriteLine("The years of the membership are: " + yer2);
            Console.WriteLine("The contribution is: " + contribution);
        }
    }
    // jaarlijkse contributie
    // seniorleden (18+) 75 euro
    // juniorleden 40 euro
    // spelend lid heeft bondscontributie: 45 euro voor alle leeftijden
    // korting op clubcontributie (niet bondscontributie)
        // 4 tot 7 jaar: 2% korting
        // 7 jaar of meer: 3,5% korting
    // bereken contributie
    // leeftijd bepalen
}
