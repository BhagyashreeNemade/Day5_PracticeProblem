namespace Day5_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 5 Practice Problems ");
            Console.WriteLine("Enter the a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b ");
            int b = Convert.ToInt32(Console.ReadLine());
            SwapNumber.SwapNum(a, b);
        }
    }
}