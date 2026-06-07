using System.IO;
namespace LifeSoulNumber

{
    public partial class Form1 : Form

    {
        private Dictionary<string, string> dict;
        public Form1()
        {
            InitializeComponent();
            dict = LoadData();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            string birthday = $"{d.Year}{d.Month:D2}{d.Day:D2}"; //D2補0到二位數
            int sum = 0;
            foreach (char c in birthday)
            {
                sum += c - '0';
            }
            while (sum >= 10)
            {
                int newSum = 0;
                foreach (char c in sum.ToString())
                {
                    newSum += c - '0';
                }
                sum = newSum;
            }
            int lifeSoulnum = sum;
            string zodiac = GetZodiac(d.Month, d.Day);
            string key = zodiac + sum; 

            if (dict.ContainsKey(key))　 // 查字典
            {
                string desc = dict[key];
                label3.Text = $"你的星座：{zodiac}，生命靈數：{sum}\n{desc}";
            }
            else
            {
                label3.Text = $"你的星座：{zodiac}，生命靈數：{sum}\n（抱歉，資料庫中尚未建立此組合的評論。）";
            }


        }
        private string GetZodiac(int month, int day)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "牧羊座";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "金牛座";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
                return "雙子座";
            if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                return "巨蟹座";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "獅子座";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "處女座";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
                return "天秤座";
            if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
                return "天蠍座";
            if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
                return "射手座";
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "魔羯座";
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "水瓶座";
            if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return "雙魚座";

            return "未知";
        }

        private Dictionary<string, string> LoadData()
        {
            var d = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines("生命靈數.txt");

            string currentZodiac = "";

            foreach (string line in lines)
            {
                // 把整行前後的空白（包含全形/半形空格）全部去掉
                string cleanLine = line.Trim().Replace(" ", "");

                if (string.IsNullOrWhiteSpace(cleanLine)) continue;

                // 判斷星座大標題
                if (cleanLine.Contains("【") && cleanLine.Contains("】"))
                {
                    if (line.Contains("牧羊座")) currentZodiac = "牧羊座";
                    else if (line.Contains("金牛")) currentZodiac = "金牛座";
                    else if (line.Contains("雙子")) currentZodiac = "雙子座";
                    else if (line.Contains("巨蟹")) currentZodiac = "巨蟹座";
                    else if (line.Contains("獅子")) currentZodiac = "獅子座";
                    else if (line.Contains("處女")) currentZodiac = "處女座";
                    else if (line.Contains("天秤")) currentZodiac = "天秤座";
                    else if (line.Contains("天蠍")) currentZodiac = "天蠍座";
                    else if (line.Contains("射手")) currentZodiac = "射手座";
                    else if (line.Contains("摩羯")) currentZodiac = "魔羯座";   
                    else if (line.Contains("水瓶")) currentZodiac = "水瓶座";
                    else if (line.Contains("雙魚")) currentZodiac = "雙魚座";
                }
                //  判斷生命靈數內容
                else if (cleanLine.StartsWith("生命靈數"))
                {
                    // 考慮到文字檔中可能是英文冒號 ':' 或全形冒號 '：'，我們用陣列同時切
                    string[] parts = cleanLine.Split(new char[] { ':', '：' }, 2);
                    if (parts.Length >= 2)
                    {
                        // 把 "生命靈數" 移除，只留下數字
                        string number = parts[0].Replace("生命靈數", "").Trim();
                        string desc = parts[1].Trim();

                        // 組合放入字典，例如：d["牧羊座1"] = "你是個主觀很強的人..."
                        d[currentZodiac + number] = desc;
                    }
                }
            }
            return d;


        }
    }
}
