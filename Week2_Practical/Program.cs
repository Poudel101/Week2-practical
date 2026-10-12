/*
 * Practical 2
 * Information: Methods demo
 * Version: 1
 * Author: Chandra Bahadur Poudel
 * Date: 11/10/2026
 */
namespace Week2_Practical
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;

            do
            {
                PrintMenu();

                option = InputOption();

                string message = GetMessage(option);

                Console.WriteLine(message);

            } while (option != 0);

        }

        static void PrintMenu()
        {
            Console.WriteLine("Please enter a valid option from below:");
            Console.WriteLine("1. Hello in French?");
            Console.WriteLine("2. Hello in Spanish?");
            Console.WriteLine("3. Hello in German?");
            Console.WriteLine("4. Hello in Italian?");
            Console.WriteLine("0. Exit application");
        }

        static int InputOption()
        {
            try
            {
                Console.WriteLine("Enter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                return option;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a whole number.");
                return -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small.");
                return -1;
            }
            }
            static string GetMessage(int language)
            {
                switch (language)
                {
                    case 0:
                        return "Goodbye";

                    case 1:
                        return "Bonjour";

                    case 2:
                        return "Ola";

                    case 3:
                        return "Hallo";

                    case 4:
                        return "Ciao";

                    default:
                        return "Please enter a valid option";
                }
            

        }

    }
}
