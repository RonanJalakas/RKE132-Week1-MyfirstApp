internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:"); //Output
        string userName;
        userName = Console.ReadLine(); //Input
        Console.WriteLine("Hello" + userName + "!"); //Output
        Console.WriteLine($"Hello, {userName} !"); //Output
    }
}