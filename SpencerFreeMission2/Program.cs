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
            Console.WriteLine("How many dice rolls would you like to simulate ? ");
            str = Console.ReadLine();
            numRolls = Convert.ToDouble(str);
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            myGame.PrintNumRolls(numRolls);

            Random rnd = new Random();

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int sum = dice1 + dice2;
                Console.WriteLine(sum);
            }
            
        }
    }
}
