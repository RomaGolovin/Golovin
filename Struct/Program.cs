struct Person
{
    public string name;
}
class Program
{
    static void Main(string[] args)
    {
        Person person;
        person.name = "Bob";
        Console.WriteLine(person.name);
    }
}