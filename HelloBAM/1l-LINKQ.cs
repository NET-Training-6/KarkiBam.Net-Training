using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numbers = { 2, 0, 3, 4, 5, 56, 12, 10, 23, 45, 67, 40 };
    List<string> names = new() { "Bishnu", "Sagar", "Prem", "Kamal", "Sajan", "Naresh" };

    List<Employee> employees = new()
    {
       new Employee() { Name = "Harish Bohara", age = 21, Department = "HR", Designation = " Software Engineer"},
       new Employee { Name = "Bam Karki", age = 23, Department = "HR", Designation = " Information Technology"},
       new Employee { Name = "Bhoj Joshi", age = 18, Department = "S&D", Designation = " Software Engineer"},
       new Employee { Name = "Prakash Saud", age = 20, Department = "R&D", Designation = " Software Engineer"},
       new Employee { Name = "Badri Giri", age = 24, Department = "HR", Designation = " Software er"},
       new Employee { Name = "Shankar Bhagwan", age = 40, Department = "HR", Designation = " Computer Engineer"}
    };

    public void Test()
    {
        //Quantifiers:Any, All
        // 1. Find if "numbers" array contai any even numbers

        var hasEven = numbers.Any(n => n % 2 == 0);

        // 2. Find if numbers array has all even numbers

        var allEven = numbers.All(n => n % 2 == 0);

        // 3. Get first elements from numbers

        var firstFive = numbers.Take(5);

        //4. Get 5 elements skipping first 2 from numbers 

        var x = numbers.Skip(2).Take(5);
    }

    public void LINQDay2()
    {

    }

    public void LearnToQueryComplexCollection()
    {

        // 1. Get all employee in HR department

        var x = employees.Where(e => e.Department == "HR");

        // 2. Get names of employees in HR department

        var x1 = employees.Where(e => e.Department == "HR").Select(e => e.Name);

        x1 = from e in employees
             where e.Department == "HR"
             select e.Name;

        // 3. Get all software engineers under age of 22

        var xx1 = employees.Where(e => e.Designation == "Software Engineer" && e.age < 22);

        foreach (var e in xx1)
        {

            Console.WriteLine($"{e.Name}");

        }


    }

}

public class Employee
{
    public string Name { get; set; }

    public int age { get; set; }

    public string Department { get; set; }

    public string Designation { get; set; }

}