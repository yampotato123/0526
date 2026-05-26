namespace KFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NumbersBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("請先選擇轉換方式!!");
                return;
            }
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("請輸入正確數字");
                return;
            }
            if (radioButton1.Checked)
            {
                var result = 9.0 / 5 * value + 32;
                label1.Text = $"結果: {value}°C = {result}°F";
            }

            else
            {
                var result = (value - 32) * 5.0 / 9;
                label1.Text = $"結果: {value}°F = {result}°C";
            }
        }

        private void NumbersBtn_Click(object sender, KeyEventArgs e)
        {

        }
    }
}
