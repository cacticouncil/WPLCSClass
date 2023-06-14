
class Program
{
    static void Main()
    {
        Random prng = new Random();
        int flip;
        int heads = 0;
        int tails = 0;

        while (true)
        {
            flip = prng.Next();

            if (flip % 2 == 0)
            {
                heads++;
                Console.Write("Heads!");
            }
            else
            {
                tails++;
                Console.Write("Tails!");
            }

            Console.WriteLine(" (" + heads + ", " + tails + ")");

            Thread.Sleep(300);
        }
    }
}
