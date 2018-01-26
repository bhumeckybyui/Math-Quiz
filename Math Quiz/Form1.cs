using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {

        //make random object
        Random randomizer = new Random();

        //make two ini values for the addition
        int addend1;
        int addend2;

        int minuend;
        int sutrahend;

        int d1;
        int d2;

        int m1;
        int m2;


        int timeLeft;

        public void StartTheQuiz()
        {

            
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLable.Text = addend1.ToString();
            plusRightLable.Text = addend2.ToString();
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            sutrahend = randomizer.Next(1, minuend);
            minusLeftLable.Text = minuend.ToString();
            minusRightLable.Text = sutrahend.ToString();
            difference.Value = 0;

            m1 = randomizer.Next(2, 11);
            m2 = randomizer.Next(2, 11);
            timesLeftLable.Text = m1.ToString();
            timesRightLable.Text = m2.ToString();
            product.Value = 0;

            d2 = randomizer.Next(2, 11);
            int tQ = randomizer.Next(2, 11);
            d1 = d2 * tQ;
            dividedLeftLable.Text = d1.ToString();
            dividedRightLable.Text = d2.ToString();
            quotient.Value = 0;



            //start the timer
            timeLeft = 30;
            timeLable.Text = "30 seconds";
            timer1.Start();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }


        public Form1()
        {

            

            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
                
            }
            if(timeLeft > 0)
            {
                
                timeLeft = timeLeft - 1;
                timeLable.Text = timeLeft + " seconds";

                if(timeLeft <= 5)
                {
                    timeLable.BackColor = Color.Red;
                    timeLable.ForeColor = Color.White;
                }
                     
            } else
            {
                timer1.Stop();
                timeLable.Text = "Time's Up!";
                MessageBox.Show("You didn't finish in time. ", "Sorry!");

                sum.Value = addend1 + addend2;
                difference.Value = minuend - sutrahend;
                product.Value = m1 * m2;
                quotient.Value = d1 / d2;
                startButton.Enabled = true;
                timeLable.BackColor = default(Color);
                timeLable.ForeColor = default(Color);
                

            }
        }

        private bool CheckTheAnswer()
        {

            if ((addend1 + addend2 == sum.Value)
                && (minuend - sutrahend == difference.Value)
                && (m1 * m2 == product.Value)
                && (d1 / d2 == quotient.Value))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if(addend1 + addend2 == sum.Value)
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if(minuend - sutrahend == difference.Value)
            {
                System.Media.SystemSounds.Beep.Play();

            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if((m1 * m2 == product.Value))
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if((d1 / d2 == quotient.Value))
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
