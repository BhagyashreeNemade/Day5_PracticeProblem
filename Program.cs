namespace Day5_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 5 Practice Problems ");
            Console.WriteLine("Enter the number to calculate it's Prime Factors");
            int N = Convert.ToInt32(Console.ReadLine());

            PrimeFactors.PrimeFactor(N);
        }
    }
}