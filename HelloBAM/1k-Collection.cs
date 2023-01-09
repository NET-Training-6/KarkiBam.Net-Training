using System;
using System.Collections.Generic;

class CollectionLearner
{
    //list of something

    public void LearnList()
    {
        //     List<int> numbers = new List<int>();
        //     numbers.Add(2345);
        //     numbers.Add(4355);
        //     numbers.Add(123);
        //     numbers.Add(2555);
        //     numbers.Add(2654);
        //     numbers.Add(83757);
        //     numbers.Remove(123);

        //     foreach (var num in numbers)
        //     {
        //         Console.WriteLine(num);
        //     }

        //create list to store name of 10 people

        List<string> Peoples = new List<string>();
        Peoples.Add("Bam");
        Peoples.Add("Harish");
        Peoples.Add("Prakash");
        Peoples.Add("Bhoj");
        Peoples.Add("Khem");
        Peoples.Add("Gopal");
        Peoples.Add("Rajendra");
        Peoples.Add("Velubaze");
        Peoples.Add("Ganesh");
        Peoples.Add("Bimal");

        foreach (var name in Peoples)
        {

            if (name.Length < 5)
            {
                Console.WriteLine(name.ToUpper());
            }
        }
    }
}