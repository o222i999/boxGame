using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace boxGame
{
    public partial class Form1 : Form
    {
        Random xNum = new Random(DateTime.Now.Second);
        Random yNum = new Random(DateTime.Now.Millisecond);
        int score = 0;
        int score2;
        int score3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            endlessBtn.Visible = false;
            normalBtn.Visible = false;
            
            score3 = 0;

            changeDifficultyBtn.Visible = false;


            timer1.Enabled = true;

            closeBtn.Visible = false;
            startBtn.Visible = false;
            box.Visible = true;
            scoreGB.Visible = true;
            scoreTB.Visible = true;
            label2.Visible = true;

            label1.Visible = false;

            if (score == 10)
            {
                score -= 10;
            }
            else
            {
                score = 0;
            }

            if (endless == true)
            {
                scoreTB.Text = score3.ToString();
            }
            else
            {
                scoreTB.Text = score.ToString();
            }
        }


        bool loss = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScoreSwitch();

            timer2.Enabled = false;
            timer1.Enabled = false;
            score2 = score + 1;
            score2 = score3 + 1;



            if (score < score2)
            {
                if (click == false)
                {

                    MessageBox.Show("you lose");
                    box.Visible = false;
                    timer1.Enabled = false;
                    box.Visible = false;
                    loss = true;
                    startBtn.Visible = true;
                    startBtn.Text = "restart";
                    closeBtn.Visible = true;
                    scoreTB.Visible = false;
                    label2.Visible = false;
                    scoreGB.Visible = false;
                    changeDifficultyBtn.Visible = true;
                    endlessBtn.Visible = true;
                    score3 = 0;

                    if (endless == true)
                    {
                        normalBtn.Visible = true;
                        endlessBtn.Visible = false;
                    }
                }
            }
            else if (score3 < score2)
            {
                MessageBox.Show("you lose");
                box.Visible = false;
                timer1.Enabled = false;
                box.Visible = false;
                loss = true;
                startBtn.Visible = true;
                startBtn.Text = "restart";
                closeBtn.Visible = true;
                scoreTB.Visible = false;
                label2.Visible = false;
                scoreGB.Visible = false;
                changeDifficultyBtn.Visible = true;
                endlessBtn.Visible = true;
                score3 = 0;

                if (endless == true)
                {
                    normalBtn.Visible = true;
                    endlessBtn.Visible = false;
                }
            }
        }

        private void CallOnLoad()
        {
            if (score < score2)
            {
                loss = true;
            }

            if (loss == true)
            {
                MessageBox.Show("you lose");
                box.Visible = false;

                if (endless == true)
                {
                    normalBtn.Visible = true;
                    endlessBtn.Visible = false;
                }
            }
        }
       private void Form_Load(object sender, EventArgs e)
        {
            CallOnLoad();
            closeBtn.Visible = true;

        }
        private void box_Click(object sender, EventArgs e)
        {
            
            ScoreSwitch();

            if (endless == true)
            {
            }

            timer1.Enabled = false;
            timer2.Enabled = false;

            

            if (score == 0 || score % 2 == 0)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
            else if (score == 1 || score % 2 != 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            Random xNum3 = new Random(DateTime.Now.Millisecond);
            Random yNum3 = new Random(DateTime.Now.Second);

            int x4 = xNum3.Next(0, 300);
            int y4 = yNum3.Next(0, 300);


            


            Point Boxx = new Point(x4, y4);
            box.Location = Boxx;
            Boxx = new Point(Boxx.X = x4, Boxx.Y = y4);
            score += 1;
            score3 += 1;
            
            if (score == 10)
            {
                scoreTB.Text = score.ToString();
                startBtn.Visible = true;
                startBtn.Text = "restart";
                box.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                loss = true;
                closeBtn.Visible = true;
                changeDifficultyBtn.Visible = true;

                score3 = 0;
                MessageBox.Show("you win");


            }
            if (endless == true)
            {
                scoreTB.Text = score3.ToString();
            }
            else
            {
                scoreTB.Text = score.ToString();
            }

            
            
        }

        bool click = false;

        private void Form1_Click(object sender, EventArgs e)
        {
            if (score > 1 && score <= 9)
            {

                MessageBox.Show("you lose");
                box.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                box.Visible = false;
                loss = true;
                startBtn.Visible = true;
                startBtn.Text = "restart";
                closeBtn.Visible = true;
                click = true;
                scoreTB.Visible = false;
                label2.Visible = false;
                scoreGB.Visible = false;
                changeDifficultyBtn.Visible = true;
                endlessBtn.Visible = true;
                score3 = 0;

                 if (endless == true)
                {
                    normalBtn.Visible = true;
                    endlessBtn.Visible = false;
                }
            }
            else if (score3 > 1 )
                                   
            {

                MessageBox.Show("you lose");
                box.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                box.Visible = false;
                loss = true;
                startBtn.Visible = true;
                startBtn.Text = "restart";
                closeBtn.Visible = true;
                click = true;
                scoreTB.Visible = false;
                label2.Visible = false;
                scoreGB.Visible = false;
                changeDifficultyBtn.Visible = true;
                endlessBtn.Visible = true;
                score3 = 0;

                if (endless == true)
                {
                    normalBtn.Visible = true;
                    endlessBtn.Visible = false;
                }

            }
            else if (score == 10 || score3 == 10)

            {


            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ScoreSwitch();

            timer1.Enabled = false;
            timer2.Enabled = false;
            score2 = score + 1;
            score2 = score3 + 1;

            

            if (score < score2)
            {
                if (click == false)
                {

                    MessageBox.Show("you lose");
                    box.Visible = false;
                    timer2.Enabled = false;
                    box.Visible = false;
                    loss = true;
                    startBtn.Visible = true;
                    startBtn.Text = "restart";
                    closeBtn.Visible = true;
                    scoreTB.Visible = false;
                     label2.Visible = false;
                    scoreGB.Visible = false;
                    changeDifficultyBtn.Visible = true;
                    endlessBtn.Visible = true;
                    score3 = 0;

                    if (endless == true)
                    {
                        normalBtn.Visible = true;
                        endlessBtn.Visible = false;
                    }
                }
            }
            else if (score3 < score2)
            {
                MessageBox.Show("you lose");
                box.Visible = false;
                timer2.Enabled = false;
                box.Visible = false;
                loss = true;
                startBtn.Visible = true;
                startBtn.Text = "restart";
                closeBtn.Visible = true;
                scoreTB.Visible = false;
                label2.Visible = false;
                scoreGB.Visible = false;
                changeDifficultyBtn.Visible = true;
                endlessBtn.Visible = true;
                score3 = 0;

                if (endless == true)
                {
                    normalBtn.Visible = true;
                    endlessBtn.Visible = false;
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int ez = 2500;
        int md = 1500;
        int hard = 900;
        int insane = 300;

        private void ezBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = ez;
            timer2.Interval = ez;
            startBtn.Enabled = true;
            startBtn.Visible=true;
            groupBox1.Visible = false;
            endlessBtn.Visible = true;
        }

        private void mdBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = md;
            timer2.Interval = md;
            startBtn.Enabled = true;
            startBtn.Visible = true;
            groupBox1.Visible = false;
            endlessBtn.Visible = true;
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = hard;
            timer2.Interval = hard;
            startBtn.Enabled = true;
            startBtn.Visible = true;
            groupBox1.Visible = false;
            endlessBtn.Visible = true;
        }

        private void insaneBtn_Click(object sender, EventArgs e)
        {
            endlessBtn.Visible = true;
            timer1.Interval = insane;
            timer2.Interval = insane;
            groupBox1.Visible = false;
            startBtn.Enabled = true;
            startBtn.Visible = true;
            groupBox1.Visible = false;
           
        }

        private void changeDifficultyBtn_Click(object sender, EventArgs e)
        {
            box.Visible = false;
            timer2.Enabled = false;
            timer1.Enabled = false;
            box.Visible = false;
            loss = false;
            startBtn.Visible = true;
            timer1.Interval = 10;
            timer2.Interval = 10;
            score = 0;
            closeBtn.Visible = true;
            scoreTB.Visible = false;
            label2.Visible = false;
            scoreGB.Visible = false;

            groupBox1.Visible = true;
        }
        bool endless = false;
        private void endlessBtn_Click(object sender, EventArgs e)
        {
            score = 0;

            endless = true;

            changeDifficultyBtn.Visible = false;

            score -= 2000;
            endlessBtn.Visible = false;

            groupBox1.Visible = false;
            startBtn.Enabled = true;
            startBtn.Visible = true;
            groupBox1.Visible = false;

            timer2.Enabled = true;

            closeBtn.Visible = false;
            startBtn.Visible = false;
            box.Visible = true;
            scoreGB.Visible = true;
            scoreTB.Visible = true;
            label2.Visible = true;
            normalBtn.Visible = false;

            label1.Visible = false;

            
                int score3 = 0;
            



            if (score3 == 9999)
            {
                this.Close();
            }
            else if (score3 >1 && score3 < 10)
            {
                MessageBox.Show(score3.ToString() + "...is pretty good!!. keep practicing");
                normalBtn.Visible = true;
            }
            else if (score3 > 10)
            {
                MessageBox.Show(score3.ToString() + "isn't bad. good job");
                normalBtn.Visible = true;
            }

            scoreTB.Text = score3.ToString();
        }

        private void ScoreSwitch()
        {
            if (endless == true)
            {
                score = 0; 
            }
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            score = 0;
            score3 = 0;
            scoreTB.Text = score.ToString();
            timer1.Enabled = true;
            endless = false;
            closeBtn.Visible = false;
            startBtn.Visible = false;
            box.Visible = true;
            scoreGB.Visible = true;
            scoreTB.Visible = true;
            label2.Visible = true;
            normalBtn.Visible = false;
            changeDifficultyBtn.Visible = false;    

            label1.Visible = false;
        }
    }
}

