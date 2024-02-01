using Base; // подключение пространства имен Base

internal class Program
{
    private static void Main(string[] args)
    {
        Person tom = new("Tom");
        tom.Print();
    }
}