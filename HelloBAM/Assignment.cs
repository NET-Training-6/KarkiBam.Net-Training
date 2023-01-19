using System;
using System.Globalization;

// class Assignment
// {
//     public void Assignment1()
//     {
//         int number = Convert.ToInt32(Console.ReadLine());

//         for (int i = 1; i <= number; i++)
//         {
//             if (i % 3 == 0)
//                 if (i % 5 == 0)
//                 {
//                     Console.WriteLine("3");
//                     Console.WriteLine("5");
//                 }
//                 else
//                 {
//                     Console.WriteLine(i);
//                 }

//         }
//     }

// }

// class Dob
// {
//     public void Dob1()
//     {


//         string[] dateValues = { "30-12-2011",
//                              };
//         string pattern = "MM-dd-yy";
//         DateTime parsedDate;

//         foreach (var dateValue in dateValues)
//         {
//             if (DateTime.TryParseExact("30-12-2011", pattern, null,
//                                       DateTimeStyles.None, out parsedDate))
//                 Console.WriteLine("Converted '{30 - 12 - 2011}'.",
//                                   dateValue, parsedDate);
//             else
//                 Console.WriteLine("Your date of birth is  '{30 - 12 - 2011}' to a date and time.",
//                                   dateValue);
//         }
//     }
// }

