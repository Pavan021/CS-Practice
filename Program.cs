using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyRecapProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello!..Back to business");

            //Variables

            // number based
            /*int a = 10, b = 20, c = 30;
            Console.WriteLine("ID of A : {0}, B: {1}, C: {2}", a, b, c);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);     //Shortcuts: CW tab

            long Salary = 90000000L;
            Console.WriteLine("Salary is" + Salary);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            float RelevExp = 1.5F;
            Console.WriteLine("Relevent Experience is" + RelevExp);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            double Experience = 2.34;
            Console.WriteLine("Experience is:{0}", Experience);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            decimal Weight = 75.3M;
            Console.WriteLine("Weight is {0}", Weight);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue); */

            // Text based 

           /* char Lastname = 'C';
            string FirstName = "Pavan";

            Console.WriteLine("May name is :" + FirstName + Lastname);     

            var ExpSalary = 120000000;   // Explicit typing
            Console.WriteLine("Expected salary is :" + ExpSalary);

            bool isGenz = true;
            //Console.WriteLine("GenZ :{0}", isGenz); */


            // TypeCasting 

            /*var Age = "32";
            int MyAge = Convert.ToInt32(Age);
            long HerAge = Convert.ToInt64(Age);
            double DoubleAge = Convert.ToDouble(Age);
            float FloatAge = Convert.ToSingle(Age);
            decimal DecAge = Convert.ToDecimal(Age);

            Console.WriteLine("age :{0}, Myage :{1}, HerAge:{2}, doubleAge : {3}, floatAge: {4}, decAge : {5}", Age,MyAge, HerAge, DoubleAge, FloatAge, DecAge);

            // Remainder

            var num1 = 10;
            var num2 = 2;
            var remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 13;            //Reassigning Value 
            remainder = num1 % num2;
            Console.WriteLine(remainder);  */


            // Console Input/Output

            Console.WriteLine("What is your name :");
            string name = Console.ReadLine();

            Console.Write("What is your age :");
            //int age = Console.ReadLine();                        // throw error as ReadLine() returns string
            var ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            //Console.WriteLine("Hi "+ name + ", your age is "+ age); 


            // If else statement

            if (age <= 0 || age >= 150)
                Console.WriteLine("Invalid Age!!......");
            else
            {
                if (age >=18 && age <= 25)
                    Console.WriteLine("your age is between 18 and 25");
                else if (age >=25)
                    Console.WriteLine("You're 25 or older ");
            }







                Console.ReadLine();


        }
    }
}
