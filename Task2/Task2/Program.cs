using System;

namespace Task2
{
    internal class Program
    {






        static void Main(string[] args)
        {
            string Name;
            string numberVal;
            double IDRVal;
           

            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine(); // Accepts the string Name

            //Converts to Double type
            Console.WriteLine("Enter interger Value: ");
            numberVal = Console.ReadLine();
            IDRVal = Convert.ToDouble(numberVal);
            //Console.WriteLine(Name + " has a IDR of " + IDRVal + " in his wallet");

            Console.WriteLine(IncomeTax(Name,IDRVal)); // function accept the values given and uses them in its function
            Console.Read();

        }
        public static double IncomeTax(string n,double num)
        {
            double excess = 0;
            double incometax = 0;
            double soc_contr = 0;
           

            if (num <= 1000) // we validate if the IDRVal is lower than 1000 and if its true it doesnt get taxed
            {
                Console.WriteLine(n+" has a salary of " + num +". "+ n +" would pay no taxes since this is below the taxation threshold and his net income is also "+num+".");
            }
            if (num > 1000) // we validate if the IDRval is bigger than 1000 so it does get taxed  the 10%
            {
                excess = num - 1000;
                incometax = excess * .10;
                Console.WriteLine(n + "has a salary of " + num +"."+ n + "owns income tax: 10% out of " + excess + " -> " + incometax);

            }
            if (excess > 1000 && excess < 3000) // This validates if the excess while alrealy been taken 1000 still complies with the paremeters 
                                                // this helps for accepting any value
            {
                soc_contr = 2000 * .15;
                Console.WriteLine(n+"'s Social Contribution are: " + soc_contr);
            }
            double total_tax = incometax + soc_contr; // we add up all the taxes deducted to basically show how much did you pay in tax total
            Console.Write("In total "+n+"'s tax amount is: "); // in order to be very organized and user friendly i used the Console.Write instead of Writeline so its aligned with the returned value
            return total_tax;


         
        }
    }
}
