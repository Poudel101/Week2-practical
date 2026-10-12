
namespace Task10_CircleArea
{
    internal class Program
    {
        // Main method: starts the program
        static void Main(string[] args)
        {
            // Repeat until the user enters 0
            while (true)
            {
                // Display the menu
                Console.WriteLine("Circle Area Calculator");
                Console.WriteLine("Enter a radius (0 to exit):");

                // Read the user's input
                string input = Console.ReadLine() ?? "";

                // Convert the input into a double
                // TryParse prevents errors for invalid text
                if (!double.TryParse(input, out double radius))
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }

                // Exit when the user enters 0
                if (radius == 0)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // Reject negative radius values
                if (radius < 0)
                {
                    Console.WriteLine("Radius cannot be negative.");
                    continue;
                }

                // Call CircleArea() and store the result
                double area = CircleArea(radius);

                // Display the calculated area
                Console.WriteLine($"Area of circle = {area:F2}");
            }
        }

        // Method receives a radius and returns circle area
        static double CircleArea(double radius)
        {
            // Math.PI stores the value of Pi
            // Math.Pow(radius, 2) calculates radius squared
            double area = Math.PI * Math.Pow(radius, 2);

            // Return the calculated area to Main()
            return area;
        }
    }
}
