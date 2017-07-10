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
            int answer = Add(3, 9);
            Console.WriteLine(answer);
        }
        //Declaring a method = Method header and method body.
        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
            //If a method does not return a value use the keyword "void".
        }
    }
}
