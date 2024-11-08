namespace jeopardy
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
            gameboard = new Panel();
            qboard = new Panel();
            questionLabel = new Label();
            closeBtn = new Button();
            qboard.SuspendLayout();
            SuspendLayout();
            // 
            // gameboard
            // 
            gameboard.BackColor = Color.Beige;
            gameboard.Location = new Point(50, 50);
            gameboard.Name = "gameboard"; 
            gameboard.Size = new Size(700, 700);
            gameboard.TabIndex = 0;
            // 
            // qboard
            // 
            qboard.BackColor = Color.CadetBlue;
            qboard.Controls.Add(questionLabel);
            qboard.Controls.Add(closeBtn);
            qboard.Location = new Point(50, 50);
            qboard.Name = "qboard";
            qboard.Size = new Size(700, 700);
            qboard.TabIndex = 0;
            qboard.Visible = false;
            // 
            // questionLabel
            // 
            questionLabel.Anchor = AnchorStyles.Top;
            questionLabel.Font = new Font("Segoe UI", 20F);
            questionLabel.Location = new Point(75, 50);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(550, 500);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "tstststtstststtsts";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            questionLabel.UseMnemonic = false;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(275, 600);
            closeBtn.Name = "closeBtn";
            closeBtn.Text = "REVEAL";
            closeBtn.Size = new Size(150, 50);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(qboard);
            Controls.Add(gameboard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            qboard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel gameboard;
        private Panel qboard;
        private Panel betboard;
        private Button closeBtn;
        private Label questionLabel;
    }
}
