namespace ContentChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個90以上的數字整數");

            if (int.TryParse(Console.ReadLine(), out int max))
            {
                if (max <= 90)
                {
                    Console.WriteLine("請輸入大於90的數字整數");
                }

                for (int i = 1; i <= max; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Dann");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Build");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("School");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}

