// class ArrayLearner
// {
//     public void LearnArrays()
//     {
//         // One dimensional arrays
//         byte[] ages = { 56, 89, 12, 34, 55, 33 };
//         var x = ages[4];

//         var l = ages.Length;
//         Console.WriteLine(l);

//         var numbers = new int[100];

//         // Multi dimensional array
//         var matrix = new double[20, 10];
//         // 45   89
//         // 33   55

//         matrix[0, 0] = 45;
//         matrix[0, 1] = 89;
//         matrix[1, 0] = 33;
//         matrix[1, 1] = 55;

//         // Jagged array
//         var jArray = new decimal[20][];
//         jArray[0] = new decimal[] { 2, 3, 4, 5, 7 };
//         jArray[1] = new decimal[] { 21, 30, 47 };
//     }
// }


//class ArrayLearner
//{
//     public void ArraysAssigment();
//  public void ArraysAssigment()
//     {
//         Console.WriteLine($"{names[i]}\n");
//     }
//     var salaries = new double[6];
// }

// Program to find maximum Salary from the list of Array:
var salaries = new double[4];
Console.WriteLine("Enter Salary:\n");
for (int s = 0; s < salaries.Length; s++)
{
    salaries[s] = double.Parse(Console.ReadLine());
}
Console.WriteLine("The recorded list of Salary are:\n");
double maxSalary = 0;

// Console.WriteLine("The recorded list of Salary are:\n");
{
    foreach (var salary in salaries)
    {
        Console.WriteLine(salary);
        if (salary > maxSalary)
        {
            maxSalary = salary;
        }
    }
    Console.WriteLine("The Maximum Salary is: \n" + maxSalary);
}

