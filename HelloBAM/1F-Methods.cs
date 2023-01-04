// class MethodLearner
// {
//     //Method that returns nothing and takes no argjments
//     public void Print()
//     {
//         Console.WriteLine("Hello There!");
//         Console.WriteLine("I am inside simplest possible method")

//     }

//     //method that returns nothing and task some arguments(s)
//     public void PrintMessage(string message)
//     {
//         Console.WriteLine("Hello there!");
//         Console.WriteLine("message");
//     }

//     //method that returns nothing and task some arguments(s)
//     public double sum(double a, double b)
//     {
//         var s = a + b;
//         return s;

//     }
//     //Write a method takes number as a argument and 
//     //and returns if number is even or odd

//     public bool isEven(int number)
//     {
//         if (number % 2 == 0)
//             return true;
//         else
//             return false;

//     }


//     // if (number % = 2 == 0)
//     //     return true;
//     // else
//     //     return false;

//     //implementation 2
//     // var y = number % 2 == 0 ? true : false;
//     // return y;

//     //implementation 3 (for fast matter )

//     //return number % 2 ==0;

//     public double CalculateAverage(int num1, int num2, int num3)
//     {
//         var sum = num1 + num2 + num3;
//         var average = sum / 3;
//         return average;
//     }

//     // Write a method that takes an number array and returns average of those. 

//     public static double CalculatecAverage(int[] numbers)
//     {
//         var sum = 0;
//         foreach (var num in numbers)
//         {
//             sum = sum + num;

//         }
//         var average = sum / numbers.Length;
//         return average;


//     }

//     // Write a method that takes bunch of numbers and returns minimum among them.

//     public int CalculateMinimum(params int[] numbers)

//     {
//         var min = 0;
//         foreach (var num in numbers)
//         {
//             if (num < min)
//             {
//                 min = num;
//             }
//         }

//         return min;
//     }
// }

// // write a method to find sum and product two numbers.


