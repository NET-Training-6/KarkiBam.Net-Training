// constants

// class Car
// {

//     public Car()
//     {
//         gears = 6;
//     }
//     String vendors;
//     string catagory;
//     double Price;
//     const byte noOfWheels = 4; //Compile-Time
//     readonly byte gears = 6; //Runtime

//     static byte seats = 4;


//     void Test()
//     {
//         //noOfWheels = 5;
//         Car car1 = new();
//         car1.vendors = "Tata";
//         Console.WriteLine();

//         string name = "Khem Karki";  //initial:
//         var parts = name.Split(" ");
//         var initial = parts[0][0] + parts[1][0];

//     }

//static

//Access Modifiers
// public- Highest visibility 


// I have a string variable called address which holds value like
// "Tinkune, Kathmandu, Nepal"
// 1.Print Country Locality
// 2.Print City Name
// 3.Print Country Name

// string address = "Tinkune, Kathmandu, Nepal";
// var TK = address.Split(", ");
// var Locality = TK[0];
// var City = TK[1];
// var Country = TK[2];
// Console.WriteLine("Locality = " + Locality);
// Console.WriteLine("City =" + City);
// Console.WriteLine("Country = " + Country);

//2. We have a pragraph

// var story = @"Nepal is a landlocked country in South Asia and is bordered by China and India.\\ 
//      It is located in the Himalayas and contains eight of the world's ten highest peaks.\\
//       The government system is a federal parliamentary republic; \\
//       the chief of state is the president, \\
//       and the head of government is the prime minister";

// Count number of sentences, words and characters in story variable above

class Paragraph
{
    string story = @"Nepal is a landlocked country in South Asia and is bordered by China and India.\\ 
     It is located in the Himalayas and contains eight of the world's ten highest peaks.\\
      The government system is a federal parliamentary republic; \\
      the chief of state is the president, \\
      and the head of government is the prime minister";

    public void CountSentences()
    {
        var separators = new char[] { '.', '?' };
        var sentences = story.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var noOfSentences = sentences.Length;
        Console.WriteLine("sentences Counts:" + noOfSentences);
        foreach (var s in sentences)
        {
            Console.WriteLine(s);
            Console.WriteLine("-----------------------");
        }
    }
}








