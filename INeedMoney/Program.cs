namespace INeedMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //中華民國的稅率級距表如下：
            // 年收入 0 ~540,000 : 5 %
            // 年收入 540,001 ~1,210,000 : 12 %
            // 年收入 1,210,001 ~2,420,000 : 20 %
            // 年收入 2,420,001 ~4,530,000 : 30 %
            // 年收入 4,530,001 ~10,310,000 : 40 %
            // 年收入 10,310,001~ : 50 %
            // 撰寫一個程式可以輸入年收入，然後依照上面的公式
            //  計算應繳納稅額。
            // 請使用 Decimalk
            Console.WriteLine("請輸入年收入");
            string coco = Console.ReadLine();

            if (decimal.TryParse(coco, out decimal CocoYear))
            {
                if (CocoYear < 0)
                {
                    Console.WriteLine("破產的免算");
                    return;
                }
                decimal sleep = 0m;

                if (CocoYear <= 540000m)
                {
                    sleep = CocoYear * 0.05m;
                }
                else if (CocoYear <= 1210000m)
                {
                    sleep = (CocoYear * 0.12m) - 37800m;
                }
                else if (CocoYear <= 2420000m)
                {
                    sleep = (CocoYear * 0.20m) - 134600m;
                }
                else if (CocoYear <= 4530000m)
                {
                    sleep = (CocoYear * 0.30m) - 376600m;
                }
                else if (CocoYear <= 10310000m)
                {
                    sleep = (CocoYear * 0.40m) - 829600m;
                }
                else
                {
                    sleep = (CocoYear * 0.50m) - 1860600m;
                }

               
                Console.WriteLine($"應繳納稅額：{sleep}");
            }
            else
            {
                Console.WriteLine("請輸入正確的數字格式。");
            }

            Console.ReadLine(); 
        }
    }
}
}
    }
}
