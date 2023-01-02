//management and unmanaged code
//Memory management


class Animal
{
    public Animal()
    {

    }

    //parametrized constructor

    public Animal(string an, bool id)
    {
        isDomestic = id;

    }
    public int noOfLegs;
    public bool isDomestic;

}

class Test
{
    void Test1()
    {
        Animal animal = new();

        Animal anima2 = new();
        Animal anima3 = new();
        Animal anima4 = new();
        Animal anima5 = new();

    }
}