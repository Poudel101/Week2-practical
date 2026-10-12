
namespace Task6_Cipher
{
    internal class Program
    {
        // Main() is where the program starts
        static void Main(string[] args)
        {
            {
                // Keep displaying the menu until the user exits
                while (true)
                {
                    // Display the available options
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1 - encrypt text");
                    Console.WriteLine("2 - decrypt text");
                    Console.WriteLine("0 - End");

                    // Read the user's menu choice
                    string option = Console.ReadLine() ?? "";

                    // Exit the application if the user selects 0
                    if (option == "0")
                    {
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }

                    // Check whether the choice is valid
                    if (option == "1" || option == "2")
                    {
                        // Ask for the text
                        Console.WriteLine("Enter a string:");
                        string text = Console.ReadLine() ?? "";

                        // Ask for the rotation number

                        // Ask the user for a valid rotation number
                        int rotations;

                        try
                        {
                            Console.WriteLine("Enter number of rotations:");
                            rotations = Convert.ToInt32(Console.ReadLine());

                            // Valid rotations must be from 1 to 99
                            if (rotations <= 0 || rotations >= 100)
                            {
                                Console.WriteLine("Invalid rotation. Enter a number from 1 to 99.");
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            // Handle invalid numbers and conversion errors
                            Console.WriteLine("Invalid input. Please enter a whole number.");
                            continue;
                        }


                        // Encrypt the text if option 1 is selected
                        if (option == "1")
                        {
                            string encrypted = Encrypt(text, rotations);

                            Console.WriteLine($"The sentence you inputted is: {text}");
                            Console.WriteLine($"The encrypted sentence is now: {encrypted}");
                        }
                        // Decrypt the text if option 2 is selected
                        else
                        {
                            string decrypted = Decrpt(text, rotations);

                            Console.WriteLine($"The sentence you inputted is: {text}");
                            Console.WriteLine($"The decrypted sentence is now: {decrypted}");
                        }
                    }
                    else
                    {
                        // Handle an invalid menu choice
                        Console.WriteLine("Invalid option. Please choose 0, 1, or 2.");
                    }

                    // Leave a blank line before displaying the menu again
                    Console.WriteLine();
                }
            }

        }

        // This method receives text and a rotation number
        // It returns the encrypted text as a string

        // Encrypts text using Caesar cipher
        static string Encrypt(string text, int rotations)
        {
            // Store the encrypted result
            string result = "";

            // Process each character
            foreach (char letter in text)
            {
                // Check for uppercase English letters
                if (letter >= 'A' && letter <= 'Z')
                {
                    // Shift and wrap within A-Z
                    char newLetter = (char)('A' + (letter - 'A' + rotations) % 26);
                    result += newLetter;
                }
                // Check for lowercase English letters
                else if (letter >= 'a' && letter <= 'z')
                {
                    // Shift and wrap within a-z
                    char newLetter = (char)('a' + (letter - 'a' + rotations) % 26);
                    result += newLetter;
                }
                else
                {
                    // Keep spaces, numbers and symbols unchanged
                    result += letter;
                }
            }

            // Return encrypted text
            return result;
        }


        // Task 7: Decryption method

        // Decrypts Caesar cipher text
        static string Decrpt(string text, int rotations)
        {
            // Store the decrypted result
            string result = "";

            // Process every character
            foreach (char letter in text)
            {
                // Check uppercase letters
                if (letter >= 'A' && letter <= 'Z')
                {
                    // Shift backward and wrap within A-Z
                    char originalLetter = (char)('A' + (letter - 'A' - rotations % 26 + 26) % 26);
                    result += originalLetter;
                }
                // Check lowercase letters
                else if (letter >= 'a' && letter <= 'z')
                {
                    // Shift backward and wrap within a-z
                    char originalLetter = (char)('a' + (letter - 'a' - rotations % 26 + 26) % 26);
                    result += originalLetter;
                }
                else
                {
                    // Do not change spaces or symbols
                    result += letter;
                }
            }

            // Return the original text
            return result;
        }


    }





}