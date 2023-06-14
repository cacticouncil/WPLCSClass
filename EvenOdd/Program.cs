namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");

            string? answer = Console.ReadLine();

            int number = Convert.ToInt32(answer);

            if (number % 2 == 0)
            {
                Console.WriteLine("Even!");
            }
            else
            {
                Console.WriteLine("Odd!");
            }
        }
    }
}