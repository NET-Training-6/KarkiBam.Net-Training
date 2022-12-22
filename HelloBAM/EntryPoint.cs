
//         {
//             int num;
//             Console.WriteLine("Enter your check number:");
//             num = Convert.ToInt32(Console.ReadLine());
//             if (num % 3 == 0 && num % 5 == 0)
//             {
//                 Console.WriteLine(num + " is even");
//                 Console.WriteLine(num + " is a multiple of 3 and 5");
//             }
//             else if (num % 5 == 0)
//             {
//                 Console.WriteLine(num + " is multiple of 5");
//             }
//             else if (num % 3 == 0)
//             {
//                 Console.WriteLine(num + " is multiple of 3");
//             }
//             else
//             {
//                 Console.WriteLine(num + " is odd");
//                 Console.WriteLine(num + " is not multiple of 3 nor 5");
//             }
//         }
//     }
// }



//find if user supplied number is multiple of 3 and 5



//         Console.Write("enter number");
//         var input = Console.ReadLine();
//         var n = int.Parse(input);

//         if (n % 3 == 0 && n % 5 == 0)
//         {
//             Console.WriteLine(n + " is multiple of 3 and 5.");

//         }
//         else
//         {
//             Console.WriteLine(n + " is not divisible of 3 and/or 5.");

//         }
//     }
// }


// calculate compound interest for principle a...



// class EntryPoint
// {
//     public static void Main()
//     {

//         Console.Write("Principle:");
//         var pText = Console.ReadLine();
//         var p = double.Parse(pText);

//         Console.Write("Time(Years):");
//         var tText = Console.ReadLine();
//         var t = double.Parse(tText);

//         Console.Write("Rate(%):");
//         var rText = Console.ReadLine();
//         var r = double.Parse(rText);

//         var ci = p * Math.Pow((1 + r / 100), t) - p;
//         // String interpolation
//         Console.WriteLine($"Compound Interest of {p} for {t} years at {r}% is {ci}");

//         Console.ReadKey();
//     }
// }

// class EntryPoint
// {

//     public static void Main()
//     {
//         Person person1 = new();
//         person1.name = "Bam karki";
//         person1.age = 23;
//     }

// }


// define a class representing an animal with at least 6 fields and a method. Create 5 objects/ instance from this class in our entry point

// class Animal
// {
//     bool isDomestic;
//     float height;
//     string color;
//     Boolean iswild;
//     float weight;

// }

class Animal
{

    Animal animal1 = new();
    Animal animal2 = new();
    Animal animal3 = new();
    Animal animal4 = new();
    Animal animal5 = new();

    void AnimalDetails()

    {

    }

}


