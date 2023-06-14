


namespace Highest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbas = new int[10];
            Random prng = new Random();

            for (int i = 0; i < numbas.Length; i++)
            {
                numbas[i] = prng.Next() % 1000;
                Console.WriteLine(numbas[i]);
            }

            int highest = numbas[0];

            for (int i=1; i<numbas.Length; i++)
            {
                if (numbas[i] > highest)
                    highest = numbas[i];
            }

            Console.WriteLine("Highest value is: " + highest);
        }
    }
}