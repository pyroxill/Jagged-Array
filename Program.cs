namespace Jagged_Array
//Author: Jayden Robertson
//Date: 11/03/2025
//Description: A program that demonstrates the use of jagged arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Arrays");

            // Declare a jagged array
            string[][] names = new string[3][]; //Creating a new string called names with 3 rows

            names[0] = new string[] {"Mr", "Mrs", "Ms"}; //Creating a new row with 3 elements for titles
            names[1] = new string[] { "Anna", "Jones", "Ian"}; //Creating a new row with 3 elements for first names
            names[2] = new string[] { "Smith", "Johnson", "Brown" }; //Creating a new row with 3 elements for last names

            //Displaying the output of the jagged array
            Console.WriteLine("\nOutput: ");
            Console.WriteLine("Hello " + names[0][1] + " " + names[1][1] + " "  + names[2][0]);
            Console.WriteLine("\nHello " + names[0][0] + " " + names[1][2] + " " + names[2][1]);
            Console.WriteLine("\nHello " + names[0][2] + " " + names[1][0] + " " + names[2][2]);
        }
    }
}
