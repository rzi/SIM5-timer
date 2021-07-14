﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool firstStart, secondStart, thirdStart, fourhtStart, fivthStart, sixthStart, seventhStart, eightStart, ninthStart, tenthStart;

        private void button6_Click(object sender, EventArgs e)
        {
            fivthStart = false;
            label42.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label42.Text);
            DateTime timeEnd = DateTime.Parse(label41.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label43.Text = diff1.ToString();

            label44.Text = "";
            label45.Text = "";
            label46.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label44.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            sixthStart = true;
            progressBar6.ForeColor = Color.LightGreen;
            progressBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sixthStart = false;
            label45.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label45.Text);
            DateTime timeEnd = DateTime.Parse(label44.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label46.Text = diff1.ToString();

            label47.Text = "";
            label48.Text = "";
            label49.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label47.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            seventhStart = true;
            progressBar7.ForeColor = Color.LightGreen;
            progressBar7.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seventhStart = false;
            label48.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label48.Text);
            DateTime timeEnd = DateTime.Parse(label47.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label49.Text = diff1.ToString();

            label50.Text = "";
            label51.Text = "";
            label52.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label50.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            eightStart = true;
            progressBar8.ForeColor = Color.LightGreen;
            progressBar8.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eightStart = false;
            label51.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label51.Text);
            DateTime timeEnd = DateTime.Parse(label50.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label52.Text = diff1.ToString();

            label53.Text = "";
            label54.Text = "";
            label55.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label53.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            ninthStart = true;
            progressBar9.ForeColor = Color.LightGreen;
            progressBar9.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ninthStart = false;
            label54.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label54.Text);
            DateTime timeEnd = DateTime.Parse(label53.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label55.Text = diff1.ToString();

            label56.Text = "";
            label57.Text = "";
            label58.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label56.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            tenthStart = true;
            progressBar10.ForeColor = Color.LightGreen;
            progressBar10.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tenthStart = false;
            label57.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label57.Text);
            DateTime timeEnd = DateTime.Parse(label56.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label58.Text = diff1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fourhtStart = false;
            label39.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label39.Text);
            DateTime timeEnd = DateTime.Parse(label38.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label40.Text = diff1.ToString();

            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label41.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            fivthStart = true;
            progressBar6.ForeColor = Color.LightGreen;
            progressBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            firstStart = false;
            secondStart = false;
            thirdStart = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            label8.Text = "";
            label9.Text = "";
            label33.Text = "";
            DateTime timeStart = DateTime.Parse(label3.Text);
            label29.Text = timeStart.TimeOfDay.ToString(); //czas rozpoczęcia
            firstStart = true;
            progressBar1.ForeColor = Color.LightGreen;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label3.Text = now.ToLongTimeString(); //bieżący czas
            if (firstStart)
            {

                if (progressBar1.Maximum == progressBar1.Value)
                {
                    firstStart = false;
                    progressBar1.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart1 = DateTime.Parse(label29.Text);
                    int timeTarget1 = Convert.ToInt32(textBox1.Text); //set time in sec.
                    DateTime timeEnd1 = timeStart1.AddSeconds(timeTarget1);
                    DateTime timeNow1 = DateTime.Parse(label3.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart1);
                    double tEnd = ConvertToUnixTimestamp(timeEnd1);
                    double tNow = ConvertToUnixTimestamp(timeNow1);

                    Console.WriteLine("tStart: " + (tStart - tStart));
                    Console.WriteLine("tNow: " + (tNow - tStart));
                    Console.WriteLine("tEnd: " + (tEnd - tStart));
                    progressBar1.Maximum = (int)(tEnd - tStart);
                    progressBar1.Value = (int)(tNow - tStart);
                    int yellowTriger = (int)((tEnd - tStart) * 0.8) ;
                    int redTriger = (int)((tEnd - tStart) * 0.9);
                    Console.WriteLine("yellowTriger: " +yellowTriger);
                    int percentTNow = (int)((tNow-tStart ) / (tEnd-tStart )*100);
                    label33.Text = percentTNow.ToString("N0") +"%";
                    Console.WriteLine("label33: " + percentTNow);
                    if (progressBar1.Value > yellowTriger)
                    {
                        progressBar1.ForeColor = Color.Yellow;
                    }
                    if (progressBar1.Value > redTriger)
                    {
                        progressBar1.ForeColor = Color.Red;
                    }

               
                }
            }
            if (secondStart)
            {

                if (progressBar2.Maximum == progressBar2.Value)
                {
                    secondStart = false;
                    progressBar2.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart1 = DateTime.Parse(label30.Text);
                    int timeTarget1 = Convert.ToInt32(textBox2.Text); //set time in sec.
                    DateTime timeEnd1 = timeStart1.AddSeconds(timeTarget1);
                    DateTime timeNow1 = DateTime.Parse(label3.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart1);
                    double tEnd = ConvertToUnixTimestamp(timeEnd1);
                    double tNow = ConvertToUnixTimestamp(timeNow1);

                    Console.WriteLine("tStart: " + (tStart - tStart));
                    Console.WriteLine("tNow: " + (tNow - tStart));
                    Console.WriteLine("tEnd: " + (tEnd - tStart));
                    progressBar2.Maximum = (int)(tEnd - tStart);
                    progressBar2.Value = (int)(tNow - tStart);
                    int yellowTriger = (int)((tEnd - tStart) * 0.8);
                    int redTriger = (int)((tEnd - tStart) * 0.9);
                    Console.WriteLine("yellowTriger: " + yellowTriger);
                    int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                    label34.Text = percentTNow.ToString("N0") + "%";
                    Console.WriteLine("label34 " + percentTNow);
                    if (progressBar2.Value > yellowTriger)
                    {
                        progressBar2.ForeColor = Color.Yellow;
                    }
                    if (progressBar2.Value > redTriger)
                    {
                        progressBar2.ForeColor = Color.Red;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            firstStart = false;
            label8.Text = label3.Text; 
            DateTime timeStart = DateTime.Parse(label8.Text); 
            DateTime timeEnd = DateTime.Parse(label29.Text); 
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label9.Text = diff1.ToString();

            label30.Text = "";
            label31.Text = "";
            label32.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label30.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            secondStart = true;
            progressBar2.ForeColor = Color.LightGreen;
            progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            secondStart = false;
            label31.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label31.Text);
            DateTime timeEnd = DateTime.Parse(label30.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label32.Text = diff1.ToString();

            label35.Text = "";
            label36.Text = "";
            label37.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label35.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            thirdStart = true;
            progressBar3.ForeColor = Color.LightGreen;
            progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thirdStart = false;
            label36.Text = label3.Text;
            DateTime timeStart = DateTime.Parse(label36.Text);
            DateTime timeEnd = DateTime.Parse(label35.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            label37.Text = diff1.ToString();

            label38.Text = "";
            label39.Text = "";
            label40.Text = "";
            DateTime timeStart1 = DateTime.Parse(label3.Text);
            label38.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            fourhtStart = true;
            progressBar4.ForeColor = Color.LightGreen;
            progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }
    }
}
