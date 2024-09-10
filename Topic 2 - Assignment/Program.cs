namespace Topic_2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/09/24
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I am " + (2024 - 2008) + " years old.");
            Console.WriteLine();

            Console.WriteLine("The average of 14, 15, and 16 = " + ((14 + 15 + 16) / 3));
            Console.WriteLine();

            Console.WriteLine("The average of 14, 15, 16, and 17 = " + ((14.0 + 15 + 16 + 17) / 4));
            Console.WriteLine();

            Console.WriteLine("If the radius of the circle is 3cm, the area is " + ((3.14 * (3*3))));
            Console.WriteLine();

            Console.WriteLine("When the '+' character is used around strings, C# knows it can't add them so it connects them.");
            Console.WriteLine();

            Console.WriteLine("When the '+' character is used around ints and floats, C# knows to add them together");
            
            Console.ReadLine();
        }
    }
}
