using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerFreeMission2
{
    public class PrintStuff
    {
        public void PrintNumRolls(double numRolls)
        {
            Console.WriteLine("Total number of rolls = " + numRolls +".");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintStuff myGame = new PrintStuff();
            double numRolls = 0;
            string str = "";
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate ? ");

            //Read In User Entry and Store it to a Variable
            str = Console.ReadLine();
            numRolls = Convert.ToDouble(str);
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");

            //Prints out the Number of Rolls provided by user
            myGame.PrintNumRolls(numRolls);

            //Generate a random number between 1 and 6 and add them together as many times as the user requests. Store them to an array.
            Random rnd = new Random();
            int[] terms = new int[(int)(numRolls)];
            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int sum = dice1 + dice2;
                terms[i] = sum;
            }

            //Declare Variables for 2 through 12
            double Count2 = 0;
            double Percent2 = 0;
            double Count3 = 0;
            double Percent3 = 0;
            double Count4 = 0;
            double Percent4 = 0;
            double Count5 = 0;
            double Percent5 = 0;
            double Count6 = 0;
            double Percent6 = 0;
            double Count7 = 0;
            double Percent7 = 0;
            double Count8 = 0;
            double Percent8 = 0;
            double Count9 = 0;
            double Percent9 = 0;
            double Count10 = 0;
            double Percent10 = 0;
            double Count11 = 0;
            double Percent11 = 0;
            double Count12 = 0;
            double Percent12 = 0;

            //Iterate through array of numbers to count how many of each number are in it
            foreach (int i in terms)
            {
                if (i == 2)
                {
                    Count2 += 1;
                }
                if (i == 3)
                {
                    Count3 += 1;
                }
                if (i == 4)
                {
                    Count4 += 1;
                }
                if (i == 5)
                {
                    Count5 += 1;
                }
                if (i == 6)
                {
                    Count6 += 1;
                }
                if (i == 7)
                {
                    Count7 += 1;
                }
                if (i == 8)
                {
                    Count8 += 1;
                }
                if (i == 9)
                {
                    Count9 += 1;
                }
                if (i == 10)
                {
                    Count10 += 1;
                }
                if (i == 11)
                {
                    Count11 += 1;
                }
                if (i == 12)
                {
                    Count12 += 1;
                }
            }

            //Calculate the percentage of each number and round it to the nearest whole number
            Percent2 = Count2 / numRolls * 100;
            Percent2 = Math.Round(Percent2, 0);
            Console.Write(" 2: ");
            for (int i = 0; i < Percent2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent3 = Count3 / numRolls * 100;
            Percent3 = Math.Round(Percent3, 0);
            Console.Write(" 3: ");
            for (int i = 0; i < Percent3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent4 = Count4 / numRolls * 100;
            Percent4 = Math.Round(Percent4, 0);
            Console.Write(" 4: ");
            for (int i = 0; i < Percent4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent5 = Count5 / numRolls * 100;
            Percent5 = Math.Round(Percent5, 0);
            Console.Write(" 5: ");
            for (int i = 0; i < Percent5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent6 = Count6 / numRolls * 100;
            Percent6 = Math.Round(Percent6, 0);
            Console.Write(" 6: ");
            for (int i = 0; i < Percent6; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent7 = Count7 / numRolls * 100;
            Percent7 = Math.Round(Percent7, 0);
            Console.Write(" 7: ");
            for (int i = 0; i < Percent7; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent8 = Count8 / numRolls * 100;
            Percent8 = Math.Round(Percent8, 0);
            Console.Write(" 8: ");
            for (int i = 0; i < Percent8; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent9 = Count9 / numRolls * 100;
            Percent9 = Math.Round(Percent9, 0);
            Console.Write(" 9: ");
            for (int i = 0; i < Percent9; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent10 = Count10 / numRolls * 100;
            Percent10 = Math.Round(Percent10, 0);
            Console.Write("10: ");
            for (int i = 0; i < Percent10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent11 = Count11 / numRolls * 100;
            Percent11 = Math.Round(Percent11, 0);
            Console.Write("11: ");
            for (int i = 0; i < Percent11; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Percent12 = Count12 / numRolls * 100;
            Percent12 = Math.Round(Percent12, 0);
            Console.Write("12: ");
            for (int i = 0; i < Percent12; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
