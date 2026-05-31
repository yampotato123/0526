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
            listHistory = new ListBox();
            btnStart = new Button();
            btnAns = new Button();
            txtGuess = new TextBox();
            btnGiveUp = new Button();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // listHistory
            // 
            listHistory.FormattingEnabled = true;
            listHistory.Location = new Point(387, 32);
            listHistory.Name = "listHistory";
            listHistory.Size = new Size(326, 372);
            listHistory.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("黑体", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(43, 32);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(107, 46);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnAns
            // 
            btnAns.Font = new Font("黑体", 10F, FontStyle.Bold);
            btnAns.Location = new Point(43, 129);
            btnAns.Name = "btnAns";
            btnAns.Size = new Size(107, 46);
            btnAns.TabIndex = 1;
            btnAns.Text = "LOOK ANS";
            btnAns.UseVisualStyleBackColor = true;
            btnAns.Click += btnAns_Click;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(43, 264);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(259, 30);
            txtGuess.TabIndex = 2;
            // 
            // btnGiveUp
            // 
            btnGiveUp.Font = new Font("黑体", 10F, FontStyle.Bold);
            btnGiveUp.Location = new Point(43, 346);
            btnGiveUp.Name = "btnGiveUp";
            btnGiveUp.Size = new Size(107, 46);
            btnGiveUp.TabIndex = 1;
            btnGiveUp.Text = "GiveUp";
            btnGiveUp.UseVisualStyleBackColor = true;
            btnGiveUp.Click += btnGiveUp_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("黑体", 10F, FontStyle.Bold);
            btnEnter.Location = new Point(209, 346);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(107, 46);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGuess);
            Controls.Add(btnEnter);
            Controls.Add(btnGiveUp);
            Controls.Add(btnAns);
            Controls.Add(btnStart);
            Controls.Add(listHistory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listHistory;
        private Button btnStart;
        private Button btnAns;
        private TextBox txtGuess;
        private Button btnGiveUp;
        private Button btnEnter;
    }
}
