class Program 
{
    public delegate Parent CovarTestDel();
    public delegate void ContrvarTestDel(Child lexus);
    public static Child CovarTest() 
    {
        return null;
    }

    public static void ContrvarTest(Parent car) 
    {
        Console.WriteLine("Контрвариантность работает!");
    }
    static void Main(string[] args) 
    {
        CovarTestDel covariancyDel = CovarTest;
        ContrvarTestDel contrvariancyDel = ContrvarTest;
        contrvariancyDel.Invoke(new Child());
    }
}
class Parent { }
class Child : Parent { }