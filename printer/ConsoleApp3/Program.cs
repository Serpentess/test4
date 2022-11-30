class Printer
{
    protected ConsoleColor color = Console.ForegroundColor;

    public void Print(string value)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
    }
}

class Company : Printer
{
    public Company()
    {
        color = ConsoleColor.Green;
    }
}

class Position : Printer
{
    public Position()
    {
        color = ConsoleColor.Blue;
    }
}

class NamePerson : Printer
{
    public NamePerson()
    {
        color = ConsoleColor.Red;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Printer name = new NamePerson();
        name.Print("Программа");
        Printer company = new Company();
        company.Print("Программуваня");
        Printer position = new Position();
        position.Print("Щось");
    }
}