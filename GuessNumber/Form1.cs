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


        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = 
        }
    }
}
