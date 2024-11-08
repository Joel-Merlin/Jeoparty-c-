using System.CodeDom.Compiler;
using System.Drawing.Drawing2D;
namespace jeopardy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                GenerateButton(100 * i, 6, 40, 50 * i, 50, 100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateButton(int val, int num, int xstart, int ystart, int height, int width)
        {
            int xpos = xstart;
            int ypos = ystart;

            Button[] buttons = new Button[num];
            for (int i = 0; i < num; i++)
            {
                buttons[i] = new Button();
                buttons[i].Size = new Size(width, height);
                buttons[i].Location = new Point(xpos, ypos);
                gameboard.Controls.Add(buttons[i]);
                xpos += width;
                buttons[i].Click += new System.EventHandler(ClickButton);
                buttons[i].Text = val.ToString();
                //buttons[i].Tag[] = new[] {val, row};
                buttons[i].Tag = new buttonData{row = i, pts = val};
                buttons[i].BackColor = Color.Beige;
            }
        }

        private void ClickButton(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonData data = button.Tag as buttonData;
            int scoreGiven = data.pts;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Black;
            //MessageBox.Show(scoreGiven.ToString() + data.row.ToString() + filePath);
            qboard.Visible = true;
            questionLabel.Text = "question";
        }

        private bool firstCloseClick = true;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (firstCloseClick) {
                questionLabel.Text = "answer";
                firstCloseClick = false;
            } else {
                firstCloseClick = true;
                qboard.Visible = false;
            }

        }
    }
}
