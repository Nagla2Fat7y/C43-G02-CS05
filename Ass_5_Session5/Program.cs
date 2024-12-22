using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass_5_Session5
{
    internal class Program
    {
        #region Question 01
        //static void Swap( int x,  int y)
        //{
        //    int temp = x; x = y; y = temp;
        //}

        #endregion

        #region Question 02

        //static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;

        //    if (arr != null)
        //    {
        //        arr = new int[] { 4, 5, 6 };
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }

        //    return sum;
        //}

        #endregion

        #region Question 03
        static void SumAndSub(int x, int y, out int sum, out int sub)
        {


            sum = x + y;
            sub = x - y;

        }
        #endregion

        #region Question 04
        static int SumofIndvidulDigit(int number)
        {

            int sum = (number % 10) + (number - (number % 10)) / 10;



            return sum;
        }
        #endregion

        #region Question 05

        static void IsPrime(int number)
        {


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Is Not a Prime Number");
                    return;
                }
            }

            Console.WriteLine("Is a Prime Number");
        }
        #endregion

        #region Question 06

        static void MaxMinArray(ref int[] Arr)
        {


            Array.Sort(Arr);
            Console.WriteLine($"Max Element : {Arr[Arr.Length - 1]}");
            Console.WriteLine($"Min Element : {Arr[0]}");
        }
        #endregion

        #region Question 07

        static int factorial(int num)
        {

            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;

            }
            return fact;

        }
        #endregion

        #region Question 08

        static string ChangeChar(ref string st, int index, char c)
        {
            char[] chars = st.ToCharArray();
            chars[index] = c;
            return new string(chars);

        }
        #endregion




        static void Main(string[] args)
        {

            #region Q1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.




            ///*
            // In Value type parameters passing by value the variables (Arguments) does not change
            // as the values inside variables will be sent not variables itself in passing by reference
            // the variables (Arguments) change as the variables itself will be sent.
            // */

            //int A = 3, B = 5;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Swap(A, B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region Q2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            ///*
            // In Reference type parameters in case of changing in value itself (Like array element) both of them
            //have the same effect but in different behavior as passing by value will create another array point
            //to the same address and passing by reference will send the array itself. In case in the function we change
            //the address to another array of element passing by value the passed array will not change unlike passing by reference.            
            // */

            //int[] numbers = { 1, 2, 3 };
            //SumArray(ref numbers);
            //Console.WriteLine(numbers[0]); //100


            #endregion

            #region Q3	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers



            //Console.Write("Entr The first Numbers : ");

            //int.TryParse(Console.ReadLine(), out int x);
            //Console.Write("Entr The Second Numbers : ");
            //int.TryParse(Console.ReadLine(), out int y);
            //int sum, sub;
            //SumAndSub(x, y, out sum, out sub);
            //Console.WriteLine($"Sumition of Two numbers = {sum}");
            //Console.WriteLine($"Subtriction of two numbers = {sub}");
            #endregion

            #region Q4 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //    Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7




            //Console.Write("Entr Number : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //int sum = SumofIndvidulDigit(number);
            //Console.WriteLine("Sum Of Individul Digits =  " + sum);



            #endregion


            #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:



            //Console.Write("Entr Number : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //IsPrime(number);





            #endregion

            #region  Q6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //Console.Write("entre the length of Array :");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] Arr = new int[n];
            //for(int i = 0; i<Arr.Length; i++)
            //{
            //    Console.WriteLine($"Entre the element {i+1}");
            //    int.TryParse(Console.ReadLine() , out Arr[i]);
            //}



            //MaxMinArray(ref Arr);





            #endregion

            #region Q7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter


            //Console.WriteLine("Entre the Number  :");
            //int.TryParse(Console.ReadLine(), out int n);
            //int fact = factorial(n);
            //Console.WriteLine($"Factorial of Number {n}!  = {fact}");
            #endregion

            #region Q8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter






            //Console.Write("Entre The Word :  ");
            //string Word = Console.ReadLine();
            //Console.Write("entr the index :  ");
            //int.TryParse(Console.ReadLine(), out int i);
            //Console.Write("Entr the Char :  ");
            //char.TryParse(Console.ReadLine(), out char c);

            //Console.WriteLine(ChangeChar(ref Word, i, c));

            #endregion
        }
    }
    }

