class Entry
{
    public static void Main()
    {


        //     {
        //         int num;
        //         Console.WriteLine("Enter your check number:");
        //         num = Convert.ToInt32(Console.ReadLine());
        //         if (num % 3 == 0 && num % 5 == 0)
        //         {
        //             Console.WriteLine(num + " is even");
        //             Console.WriteLine(num + " is a multiple of 3 and 5");
        //         }
        //         else if (num % 5 == 0)
        //         {
        //             Console.WriteLine(num + " is multiple of 5");
        //         }
        //         else if (num % 3 == 0)
        //         {
        //             Console.WriteLine(num + " is multiple of 3");
        //         }
        //         else
        //         {
        //             Console.WriteLine(num + " is odd");
        //             Console.WriteLine(num + " is not multiple of 3 nor 5");
        //         }
        //     }
        // }


        //find if user supplied number is multiple of 3 and 5



        Console.Write("enter number");
        var input = Console.ReadLine();
        var n = int.Parse(input);

        if (n % 3 == 0 && n % 5 == 0)
        {
            Console.WriteLine(n + " is multiple of 3 and 5.");

        }
        else
        {
            Console.WriteLine(n + " is not divisible of 3 and/or 5.");

        }
    }
}