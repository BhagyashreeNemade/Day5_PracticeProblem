namespace Day5_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 5 Practice Problems ");
           
            Console.WriteLine("Enter the value of N to get Nth number of Harmonic Series ");
            int N = Convert.ToInt32(Console.ReadLine());
            HarmonicNumber.HarmonicNum(N);
        }
    }
}