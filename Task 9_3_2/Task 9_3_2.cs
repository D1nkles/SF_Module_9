class Program 
{
    public delegate int myDelegate(int num1, int num2);
    static int Subtraction(int num1, int num2) 
    {
        return num1 - num2;
    }
    static void Main(string[] args) 
    {
        myDelegate myDel = Subtraction;

        Console.WriteLine(myDel.Invoke(10, 4));
    }
}
