internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        Console.Write("Enter your age:");
        string age = Console.ReadLine();
        Console.WriteLine("Hello " + name +", you are "+age+" old.");

        
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1+num2);


        Console.ReadLine();

    }
        
}