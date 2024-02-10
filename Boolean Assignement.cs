using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 && packageWidth > 25);
            //Console.WriteLine(tooBig);
            //Console.ReadLine();

            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 || packageWidth > 25);
            //Console.WriteLine(tooBig);
            //Console.ReadLine();

            //int bankAccountBalance = 500;
            //bool isInARockBand = false;
            //string name = "Jesse";

            //bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == "Jesse");

            //Console.WriteLine(isReallyCool);
            //Console.ReadLine();

            //bool result = (true && (true || false));
            //Console.WriteLine(result);
            //Console.ReadLine();

            //int num1 = 7;
            //int num2 = 12;
            //int num3 = 23;
            //int num4 = 14;
            //int num5 = 8;
            //int num6 = 5;

            //bool result = (num1 > num2 && (num3 == num4 || num5 > num6));
            //Console.WriteLine(result);
            //Console.ReadLine();

            //Console.WriteLine(true && true && true || false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.ReadLine();

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            //Console.ReadLine():

            //Boolean Logic Assignment is listed below

            int age = 32;
            bool hasTicket = true;
            bool hasDUI = false;
            bool isQualified = true;

            bool QualifiesForCarInsurance = age >= 15 && hasTicket && hasDUI;
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
