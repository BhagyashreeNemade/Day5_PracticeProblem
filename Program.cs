namespace Day5_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 5 Practice Problems ");
            Console.WriteLine("Enter the Dividend ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Devisor ");
            int devisor = Convert.ToInt32(Console.ReadLine());
            QuotientAndReminder.FindQuotientAndReminder(dividend, devisor);
        }
    }
}