namespace StringGroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                        .ToLower()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .GroupBy(w => w)
                        .OrderByDescending(g => g.Count());
            foreach (var a in input)
            {
                Console.WriteLine($"{a.Key}: {a.Count()}");
            }
            Console.ReadLine();

        }
    }
}
