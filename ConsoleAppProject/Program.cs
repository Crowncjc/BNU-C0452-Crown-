using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Crown Caesar 
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            DistanceConverter converter = new DistanceConverter();

            converter.ConvertDistance();

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("                  BMI Calculator by            ");
            Console.WriteLine("                  Crown Caesar             ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            BmiCalculator calculate = new BmiCalculator();

            calculate.CalculateBMI();
        }
    }
}
