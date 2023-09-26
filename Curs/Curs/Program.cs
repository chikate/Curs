namespace Curs
{
    internal class Program
    {
        static void tryGetAge(string name)
        {
            Console.Write("Enter your age: ");
            string ageString = Console.ReadLine();
            if (int.TryParse(ageString, out int age))
            {
                Console.WriteLine("Hello, " + name + " your age is: " + age + "! :)");
            }
            else
            {
                Console.WriteLine("Invalid age!");
                tryGetAge(name);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            tryGetAge(name);
        }
    }
}