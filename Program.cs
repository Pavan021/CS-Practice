using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
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

            /* Console.WriteLine("What is your name :");
             string name = Console.ReadLine();

             Console.Write("What is your age :");
             //int age = Console.ReadLine();                        // throw error as ReadLine() returns string
             var ageInput = Console.ReadLine();
             int age = Convert.ToInt32(ageInput);

             //Console.WriteLine("Hi "+ name + ", your age is "+ age);  */


            // If else statement

            /*if (age <= 0 || age >= 150)
                Console.WriteLine("Invalid Age!!......");
            else
            {
                if (age >= 18 && age <= 25)
                    Console.WriteLine("your age is between 18 and 25");
                else if (age >= 25)
                    Console.WriteLine("You're 25 or older ");
            } */

            //Example

            /*Console.WriteLine("Enter first Number:");
            string numInput1 = Console.ReadLine();
            int number1 = Convert.ToInt32(numInput1);

            Console.WriteLine("Enter second number:");
            string numInput2 = Console.ReadLine();
            int number2 = Convert.ToInt32(numInput2);

            int ans = number1 * number2;

            Console.WriteLine("The value of "+ number1 +" X " + number2 +"is :");
            string ansInput = Console.ReadLine();
            int answer = Convert.ToInt32(ansInput);


            if (ans == answer)
            {
                Console.WriteLine("Well Done!");
            }
            else
            {
                Console.WriteLine("Close! Better luck next time...");
            }  */


            // Switch statement

            /*Console.WriteLine("Choose a number betweeen 1 and 7 :");
            int day = Convert.ToInt32(Console.ReadLine());

            switch(day)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Monday");
                    break;
                case 3: Console.WriteLine("Tuesday");
                    break;
                case 4: Console.WriteLine("Wednesday");
                    break;
                case 5: Console.WriteLine("Thursday");
                    break;
                case 6: Console.WriteLine("Friday");
                    break;
                case 7: Console.WriteLine("Saturday");
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }  */


            // Loops

            //For loop

            /*Console.WriteLine("What do you want me to say? :");
            string message = Console.ReadLine();

            Console.WriteLine("How many times you want this to repeat? :");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number <=0)
            {
                Console.WriteLine("Are you crazyy!?");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(message);
                }
            }   */

            // While Loop

            /*Console.WriteLine("What is your first number?");
            string numw1In = Console.ReadLine();
            int numw1 = Convert.ToInt32(numw1In);

            Console.WriteLine("What is your Second number?");
            string numw2In = Console.ReadLine();
            int numw2 = Convert.ToInt32(numw2In);
            Console.WriteLine();

            int actualAnswer = numw1 *numw2;

            int answer = 0;

            while(answer != actualAnswer)
            {
                Console.WriteLine("What is" + numw1 +" X " + numw2 +"?" );
                string usInAnswer = Console.ReadLine();
                answer = Convert.ToInt32(usInAnswer);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("Bad luck! Try Again...");
                }
            }
            Console.WriteLine("Well done!");   */

            //Do While

            /*do
            {
                Console.WriteLine("What is" + numw1 + " X " + numw2 + "?");
                string usInAnswer = Console.ReadLine();
                Console.WriteLine();
                answer = Convert.ToInt32(usInAnswer);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Bad luck! Try Again...");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!"); */

            //Conditional Operator
            /*Console.WriteLine("Enter age :");
            string ageIn = Console.ReadLine();
            int age = Convert.ToInt32(ageIn);
            

            string result = age >= 0 ? "Valid!" : "Invalid!";
            Console.WriteLine(result);  */


            //Numeric formatting

            double res = 40D / 3D;

            Console.WriteLine(string.Format("$ {0:0.00}", res));  //13.33
            Console.WriteLine(string.Format("$ {0:0.#}", res));  //$ 13.3
            Console.WriteLine(res); // 13.3333333333333

            double money = -55D / 3D;

            Console.WriteLine(money); // -18.3333333333333
            Console.WriteLine(string.Format("$-55 / $ 3 = ${0:0.00}", money));  //$-55 / $ 3 = $-18.33 wrong format

            Console.WriteLine(money.ToString("C"));  //-18.33
            Console.WriteLine(money.ToString("C0")); //-18
            Console.WriteLine(money.ToString("C1")); //-18.33

            Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture)); // -18.33
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));  //-£18.33
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));    //($18.33)
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));   // ? -18.33

           





            Console.ReadLine();


        }
    }
}
