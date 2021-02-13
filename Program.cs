using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_Basic_13
{
    class Program
    {
        public static void PrintNumbers()
        {
        Console.WriteLine("/////////////////////////// PrintNumbers /////////////////////////// ");
            // Print all of the integers from 1 to 255.

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            Console.WriteLine("/////////////////////////// PrintOdds /////////////////////////// ");
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;

            for (int i = 1; i <= 255; i++)
            {

                Console.WriteLine($"Old Number: {sum}");
                sum += (int)i;
                Console.WriteLine($"New Number: {sum}");
            }
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]); 
                }

        }

        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int maxValue = numbers.Max();
            Console.WriteLine(maxValue);
            return maxValue;


        }
        
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            double avg = Queryable.Average(numbers.AsQueryable());
            Console.WriteLine(avg);

        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] terms = new int[256];
            for (int i = 1; i <= 255; i++)
            {
                terms[i] = i;
                // Console.WriteLine(i);
            }
            for (int i = 0; i < terms.Length; i++)
            {
                if (terms[i] % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            return terms;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int GTcount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    Console.WriteLine($"{numbers[i]} is greater than {y}");
                    GTcount += 1;
                }
            }
            Console.WriteLine($"There is/are {GTcount} number(s) that are greater than {y}");
            return GTcount;

        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Original Number: {numbers[i]}");
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine($"Squared Number: {numbers[i]}");
            }


        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                Console.WriteLine($"Original Number: {numbers[i]}");
                numbers[i] = 0;
                Console.WriteLine($"New Number: {numbers[i]}");
                }
                else
                {
                Console.WriteLine($"{numbers[i]} is not negative");
                }
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int minValue = numbers.Min();
            Console.WriteLine($"Min: {minValue}");
            
            int maxValue = numbers.Max();
            Console.WriteLine($"Max: {maxValue}");
            
            double avg = Queryable.Average(numbers.AsQueryable());
            Console.WriteLine($"Avg: {avg}");

        }
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.WriteLine($"Original Number: {numbers[i]}");
                numbers[i] = numbers[i+1];
                Console.WriteLine($"New Number: {numbers[i]}");
            }
            int lastNumber = numbers.Length - 1;
            numbers[lastNumber] = 0;
            Console.WriteLine($"Last Number: {numbers[lastNumber]}");
        }
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            string[] newArray = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                Console.WriteLine($"Original Number: {numbers[i]}");
                newArray[i] = "Dojo";
                Console.WriteLine($"New Number: {newArray[i]}");
                }
                else
                {
                newArray[i] = numbers[i].ToString();
                Console.WriteLine($"{numbers[i]} is not negative");
                }
            }
            return newArray;
        }

        public static void RandomArray()
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(25);
                randomArray[i] = num;
                Console.WriteLine($"{randomArray[i]} added to Array...");
            }
            int minValue = randomArray.Min();
            Console.WriteLine($"Min: {minValue}");
            
            int maxValue = randomArray.Max();
            Console.WriteLine($"Max: {maxValue}");
        }
                static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] theArray = { 1, 3, 5, 7, 9 };
            // LoopArray(theArray);
            // FindMax(theArray);
            // int[] theAvgArray = { 2, 10, 3 };
            // GetAverage(theAvgArray);
            // OddArray();
            // int[] arrayForGTY = {1, 3, 5, 7};
            // int comparison = 3;
            // GreaterThanY(arrayForGTY, comparison);
            // int[] arrayForSquare = {1,5,10,-10};
            // SquareArrayValues(arrayForSquare);
            // int[] arrayForNegatives = {1, 5, 10, -2};
            // EliminateNegatives(arrayForNegatives);
            // int[] arrayForMinMaxAvg = {1, 5, 10, -2};
            // MinMaxAverage(arrayForMinMaxAvg);
            // int[] arrayForShiftValues = {1, 5, 10, 7, -2};
            // ShiftValues(arrayForShiftValues);
            // int[] arrayForNumToString = {-1, -3, 2};
            // NumToString(arrayForNumToString);

            RandomArray();
        }
    }
}
