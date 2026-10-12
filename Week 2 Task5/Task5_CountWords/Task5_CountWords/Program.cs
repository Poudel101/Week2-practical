namespace Task5_CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Display a message asking the user to enter text
            Console.WriteLine("Enter a string:");

            // Read the user's input and store it in a string variable named text
            // ?? "" means use an empty string if Console.ReadLine() returns null
            string text = Console.ReadLine() ?? "";

            // Split the entered sentence into separate words using spaces
            // RemoveEmptyEntries ignores extra spaces between words
            // string[] means an array (collection) of strings
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Count the number of words in the array
            // int stores a whole number; Length returns the number of elements
            int wordCount = words.Length;

            // Display the original sentence
            // $ allows the variable {text} to be inserted into the message
            Console.WriteLine($"The sentence you inputted is: {text}");

            // Display the total number of words
            Console.WriteLine($"Number of words = {wordCount}");


        }
    }
}
