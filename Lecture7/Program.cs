namespace Lecture7
{
    internal class Program
    {
        static int DivideByUserInput(string userInput)
        {
            int number = int.Parse(userInput);
            if (number == 2)
            {
                throw new InvalidOperationException("Cannot divide by 2.");
            }
            int result = 10 / number;
            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();

                // Code that may cause an exception
                int result = DivideByUserInput(userInput);

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
            Console.WriteLine("fis.");

        }
    }
}
