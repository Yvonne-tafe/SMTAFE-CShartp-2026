namespace PrimeGenerate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create 10 prime numbers and print them to the console
            int n = 10;
            PrimeGenerator PG = new PrimeGenerator();
            int[] PrimeList = PG.Generator(n);
            for (int i = 0; i < PrimeList.Length; i++)
            {
                    Console.WriteLine(PrimeList[i]);
            }
        }
    }
}
