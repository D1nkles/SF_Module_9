class Program 
{
    public delegate void MyDelegate(int num1, int num2);

    static void Subtraction(int num1, int num2)
    {
        Console.WriteLine($"Результат вычитания: {num1 - num2}");
    }

    static void Addition(int num1, int num2) 
    {
        Console.WriteLine($"Результат сложения: {num1 + num2}");
    }
    static void Main(string[] args) 
    {
        MyDelegate myDel = Subtraction;
        myDel += Addition;
        myDel.Invoke(10, 4);
    }
}