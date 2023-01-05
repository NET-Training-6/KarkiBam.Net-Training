// constants

class Car
{

    public Car()
    {
        gears = 6;
    }
    String vendors;
    string catagory;
    double Price;
    const byte noOfWheels = 4; //Compile-Time
    readonly byte gears = 6; //Runtime

    static byte seats = 4;


    void Test()
    {
        //noOfWheels = 5;
        Car car1 = new();
        car1.vendors = "Tata";
        Console.WriteLine();

    }
}

//static

//Access Modifiers
// public- Highest visibility 

