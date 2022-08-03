namespace Day5_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 5 Practice Problems ");
            // FlipCoin.FlipTheCoin();
            Console.WriteLine("Enter the number ");
            int N = Convert.ToInt32(Console.ReadLine());

            PowerOfTwo.CalculatePowerOfTwo(N);
           
        }
    }
}