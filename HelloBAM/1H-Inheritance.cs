// class A1
// {
//     public int x;

// }
// class B : A1 //single, A is base/parent/super and B is derived /child/sub
// {
//     public string y;

// }
// class C : B //multi-level
// {
//     public byte Z;
//     public void Test()
//     {

//     }
// }
// interface ID
// {

// }
// //Multiple
// class E : B, ID // class E inherits B and implement ID
// {

// }

// //write a class for rectangle, this class should have method to calculate area and perimeter

// class Rectangle
// {
//     double length;
//     double width;

//     public double GetArea() => length * width;
//     public double GetPerimeter() => 2 * (length + width);
// }

// class square : Triangle
// {
//     double sides;
//     public square(double s) : base(s, s)
//     {
//         sides = s;
//     }
// }

// class Triangle : Ishape
// {
//     double a, b, c;
//     public Triangle(double a, double b, double c)
//     {
//         this.a = a;
//         this.b = b;
//         this.c = c;
//     }
//     public double GetPerimeter() => a + b + c;
//     public double GetArea()
//     {
//         var s = (a + b + c) / 2;
//         var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
//         return area;
//     }
//     public void PrintDetails()
//     {
//         Console.WriteLine($" I am triangle with sides A = {a}, B={b}, C={c}");
//     }
// }

// //display details fo all the 2D shapes

// interface Ishape
// {
//     public void PrintDetails();

// }


// 7.Think of a real world scenario for following:
// i.Class 1 should has some fields and methods
// ii. Class 2 inherits Class 1
// iii. Class 3 has some fields on it
// iv. Interface 1 have some method definitions
// v. Class 2 and Class 3 implements Interface 1

//mobile class looks like,

// public class Mobile
// {
//     private string IEMICode;
//     public string SIMCard;
//     public String Processor;
//     public int InternalMemory;
//     public bool IsSingleSIM;
//     public void GetIEMICode()
//     {
//         Console.WriteLine("IEMI Code - BPDK23232333334");
//     }
//     public void Dial()
//     {
//         Console.WriteLine("Dial number");
//     }
//     public void Received()
//     {
//         Console.WriteLine("Received a call");
//     }

//     public virtual void SendMessage()
//     {
//         Console.WriteLine("Message Sent");
//     }
// }


