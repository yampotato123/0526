namespace GuessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Restartgame();
        }
        private string answer = "";
        private void Restartgame()
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();

            while (numbers.Count < 4)
            {
                int num = rand.Next(0, 10);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                }
            }

            answer = string.Join("", numbers);

            txtGuess.Clear();
            listHistory.Items.Clear();

            MessageBox.Show("NEW GAME!!!");
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = txtGuess.Text.Trim(); //trim去除空白

            if (input.Length != 4 || !input.All(char.IsDigit))
            {
                MessageBox.Show("輸入無效");
                return;
            }
            if (input.Distinct().Count() != 4)
            {
                MessageBox.Show("請輸入4個不重複數字");
                return;
            }

            int countA = 0;
            int countB = 0;

            for (int i = 0; i < 4; i++)
            {
                if (input[i] == answer[i])
                {
                    countA++;
                }

                else if (answer.Contains(input[i])) //前面已經過濾 "位置相同"
                {
                    countB++;
                }
            }

            string resultText = $"{input} => {countA} A {countB}B";
            listHistory.Items.Add(resultText);

            if (countA == 4)
            {
                MessageBox.Show($"通關!");
                Restartgame();
            }

            
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Restartgame();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是{answer}");
            Restartgame();
        }
    }
}
