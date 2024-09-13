namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char choice = ' ';
            do
            {
                Console.WriteLine("\nP - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.Write("\nEnter your choice: ");

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Unknown selection, please try again");
                    continue;
                }

                choice = char.ToUpper(input[0]);

                switch (choice)
                {
                    case 'P':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.WriteLine("[" + string.Join(" ", numbers) + "]");
                        }
                        break;

                    case 'A':
                        Console.Write("Enter a number to add: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            numbers.Add(number);
                            Console.WriteLine($"{number} added.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please enter a valid number.");
                        }
                        break;

                    case 'M':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            double mean = numbers.Average();
                            Console.WriteLine($"The mean is {mean}");
                        }
                        break;

                    case 'S':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers.Min();
                            Console.WriteLine($"The smallest number is {smallest}");
                        }
                        break;

                    case 'L':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers.Max();
                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;

                    case 'Q':
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            } while (choice != 'Q');
        }
    }
}
