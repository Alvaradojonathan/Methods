using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the first number to be added.");
            //int numOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added,");
            //int numTwo = int.Parse(Console.ReadLine());
            //int answer = Add(numTwo, numOne);
            //Console.WriteLine(answer);

            //RobotWarning("Will Robinson");
            //Console.WriteLine("What's your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("What's your favorite food?");
            //string food = Console.ReadLine();
            //FavoriteFood(name, food);

            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());
            //RetirementCalculator(age);

            //double hours = 42.3d;
            //double wage = 12.50d;

            //Console.WriteLine("Your monthly wage is {0}", WageCalculator(hours, wage));
            double price = 17.50d;
            double tax = 0.08d;
            double shirts = 4;

            double netCost = NetTotal(price, shirts);
            double totalCost = TotalWithTax(netCost,tax);
            Console.WriteLine(totalCost);
        }
        ////Declaring a method = Method header and method body.
        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;
        //    return sum;
        //    //If a method does not return a value use the keyword "void".
        //}
        //public static void RobotWarning(string name)
        //{
        //    Console.WriteLine("Danger, " + name + "!!");
        //}
        //Create a method called favorite food
        //public static void FavoriteFood(string name, string favoriteFood)
        //{
        //    Console.WriteLine(name + "'s favorite food is " + favoriteFood);

        //}
        //public static void RetirementCalculator(int userAge)
        //{
        //    int yearsToRetirment = 65 - userAge;
        //    Console.WriteLine("The user will retire in {0} years.", yearsToRetirment);
        
        //public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        //{
        //    double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
        //    return monthlyWage;
        //}





        //Create two methods at least one of the methods should contain a non-void return type.
        //Both methods should take at least one parameter
        public static double NetTotal(double price, double amount)
        {
            double cost = price * amount;
            return cost;
        }
        public static double TotalWithTax (double netCost, double tax)
        {
            double total = (netCost * tax) + netCost;
            return total;
        }
    }
}
