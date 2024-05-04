class Program 
{
    public delegate Car CovarTestDel();
    public static Lexus CovarTest() 
    {
        return null;
    }
    static void Main(string[] args) 
    {
        CovarTestDel covariancyDel = CovarTest;
    }
}
class Car { }
class Lexus : Car { }