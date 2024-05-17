using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the height of the Triangle");
        if (int.TryParse(Console.ReadLine(), out int Triangle_Height) && Triangle_Height > 0)
        {
            for (int i = 1; i <= Triangle_Height; i++)
            {
                int spaces = (Triangle_Height - i);
                Console.WriteLine(new string(' ', spaces) + new string('*', i * 2 - 1));
            }
        }
        else
        {
            Console.WriteLine("Please enter a Valid  Number.");
        }
    }
}
