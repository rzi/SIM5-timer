using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            label8.Text = "";
            label9.Text = "";
            int timeTarget = Convert.ToInt32(textBox1.Text);
            DateTime timeStart = DateTime.Parse(label3.Text);
            DateTime timeEnd = timeStart.AddSeconds(timeTarget);
            Console.WriteLine(timeStart);
            Console.WriteLine(timeTarget);
            Console.WriteLine(timeEnd);
            label29.Text = timeStart.TimeOfDay.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label3.Text = now.ToLongTimeString();
           
            int pb1Value=50;
            if (label8.Text == "")
            {

            }
            else
            {
                DateTime timeStart = DateTime.Parse(label8.Text);
                int timeTarget = Convert.ToInt32(textBox1.Text);
                DateTime timeEnd = timeStart.AddSeconds(timeTarget);

                TimeSpan diff1 = timeEnd.Subtract(timeStart);
                //pb1Value = (int) diff1;
                progressBar1.Value = pb1Value;
                Console.WriteLine(diff1);

               // TimeSpan timeStart1 = DateTime.Parse(label8.Text);
               // Console.WriteLine(timeStart.TotalSeconds);

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label8.Text);
            DateTime timeEnd = DateTime.Parse(label29.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label9.Text = diff1.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
