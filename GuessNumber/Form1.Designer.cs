namespace GuessNumber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(387, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 372);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("黑体", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(43, 32);
            button1.Name = "button1";
            button1.Size = new Size(107, 46);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("黑体", 10F, FontStyle.Bold);
            button2.Location = new Point(43, 129);
            button2.Name = "button2";
            button2.Size = new Size(107, 46);
            button2.TabIndex = 1;
            button2.Text = "LOOK ANS";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 30);
            textBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("黑体", 10F, FontStyle.Bold);
            button3.Location = new Point(43, 346);
            button3.Name = "button3";
            button3.Size = new Size(107, 46);
            button3.TabIndex = 1;
            button3.Text = "GiveUp";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("黑体", 10F, FontStyle.Bold);
            button4.Location = new Point(209, 346);
            button4.Name = "button4";
            button4.Size = new Size(107, 46);
            button4.TabIndex = 1;
            button4.Text = "Enter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
    }
}
