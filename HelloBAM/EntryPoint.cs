// class Entry

// {
//     public static void Main()
//     {
//         Console.ReadLine();

//         var number = 50; // if 50 is even or odd how to know.

//         if (number % 2 == 0)
//         {

//             Console.WriteLine(number + " is even");
//         }
//         else
//         {
//             Console.WriteLine(number + " is odd");

//         }
//     }
// }
// find simple interest for principal amount, time and rate given by user.

class classork
{
    public static void Main()
    {

        Console.WriteLine("principal amount");
        int amount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a time period");
        int time_period = int.Parse(Console.ReadLine());
        Console.WriteLine("interest rate");
        int interestrate = int.Parse(Console.ReadLine());
        int simple_interest = amount * time_period * interestrate / 100;
        Console.WriteLine("The simple interest =" + simple_interest);

        Console.ReadLine();

    }


}


