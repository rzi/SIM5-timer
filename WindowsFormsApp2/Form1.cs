using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool intro, safety, quality, customerService, performance, people, projects, priority, visits, feedback;
        public string currentAction, procentBar;
        public int currentBar, maxiBar;

        //ItemObj2 itemObj2 = new ItemObj2();
        ItemObj2 intro1 = new ItemObj2();

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();       
        }  
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true; 
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            //itemObj2.GetName("test2");
            //Console.WriteLine("itemObj2.Name2 " + itemObj2.Name2);
            //itemObj2.Name2 = "test2";
            //itemObj2.GetName("test3");
            //Console.WriteLine("itemObj2.Name2 " + itemObj2.Name2);

            DateTime now = DateTime.Now;
            currentTime.Text = now.ToLongTimeString(); //bieżący czas
            Console.WriteLine("Item 1 "+ ItemObj.Item1);

            //nowy
            //if (ItemObj.Item1)
            // {
            //     if (false)
            //     {
            //         ItemObj.Item1 = false;
            //         progressBar1.ForeColor = Color.Red;
            //         Console.WriteLine("w if");
            //     }
            //     else
            //     {
            //         long timeStart2 = DateTime.Parse(label29.Text).Ticks;
            //         int timeTarget2 = Convert.ToInt32(textBox1.Text); //set time in sec.
            //         long timeEnd2 = timeStart2 +timeTarget2;
            //         long timeNow2 = DateTime.Parse(label3.Text).Ticks;

            //         Console.WriteLine("timeStart2 " + timeStart2);
            //         Console.WriteLine("timeTarget2 " + timeTarget2);
            //         Console.WriteLine("timeEnd2 " + timeEnd2);
            //         Console.WriteLine("timeNow2 " + timeNow2);
            //         long tEnd_tStart = timeEnd2 - timeStart2;
            //         Console.WriteLine("tEnd_tStart " + tEnd_tStart);
            //         long tNow_tStart = timeNow2 - timeStart2;
            //         Console.WriteLine("tEnd_tStart " + tNow_tStart);

            //         TimeSpan elapsedSpan = new TimeSpan(tNow_tStart);
            //         Console.WriteLine("elapsedSpan " + elapsedSpan);

            //         //double tStart = ConvertToUnixTimestamp(timeStart1);
            //         //double tEnd = ConvertToUnixTimestamp(timeEnd1);
            //         //double tNow = ConvertToUnixTimestamp(timeNow1);
            //         //Console.WriteLine("timeStart2 "+timeStart2);

            //         DateTime timeStart1 = ItemObj.StartTime;
            //         int timeTarget1 = Convert.ToInt32(textBox1.Text); //set time in sec.
            //         DateTime timeEnd1 = timeStart1.AddSeconds(timeTarget1);
            //         DateTime timeNow1 = DateTime.Parse(label3.Text);
            //         double tStart = ConvertToUnixTimestamp(timeStart1);
            //         double tEnd = ConvertToUnixTimestamp(timeEnd1);
            //         double tNow = ConvertToUnixTimestamp(timeNow1);
            //         ItemObj.ProgressMax = (int)(tEnd - tStart);
            //         ItemObj.ProgressValue = (int)(tNow - tStart);
            //         currentBar = progressBar1.Value;
            //         maxiBar = progressBar1.Maximum;
            //         int yellowTriger = (int)((tEnd - tStart) * 0.8);
            //         int redTriger = (int)(tEnd - tStart);
            //         int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
            //         label33.Text = percentTNow.ToString("N0") + "%";
            //         procentBar = label33.Text;
            //         if (progressBar1.Value > yellowTriger) progressBar1.ForeColor customerService Color.Yellow;
            //         if (progressBar1.Value > redTriger) progressBar1.ForeColor = Color.Red;
            //         Console.WriteLine(introTimePicker.Value);
            //     }
            // }

            // Stary
            if (intro)
            {
                //intro1.Name2 = "aaa";
                if (introProgressBar.Maximum == introProgressBar.Value)
                {
                    intro = false;
                    introProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    double maximum = maximumFN(introStart.Text, introTimePicker.Value.Ticks);
                    int value = valueFN(introStart.Text, currentTime.Text);

                    introProgressBar.Maximum = (int) maximum;
                    Console.WriteLine("maximum " + maximum);
                    Console.WriteLine("value " + value);

                    if (value == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        introProgressBar.Value = value;
                        currentBar = value;
                        maxiBar = (int) maximum;
                        double yellowTriger = (maximum * 0.8);
                        int redTriger = (int) maximum;
                        int percentTNow = (int) ((value / maximum) * 100);
                        Console.WriteLine("procentTNow " +percentTNow);
                        introProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = introProgressValue.Text;
                        if (introProgressBar.Value > yellowTriger) introProgressBar.ForeColor = Color.Yellow;
                        if (introProgressBar.Value > redTriger) introProgressBar.ForeColor = Color.Red;
                    }
                }
                
            }
            if (safety)
            {
                if (safetyProgressBar.Maximum == safetyProgressBar.Value)
                {
                    safety = false;
                    safetyProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(safetyStart.Text);
                    TimeSpan setTime = new TimeSpan(safetyTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    safetyProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        safetyProgressBar.Value = (int)(tNow - tStart);
                        currentBar = safetyProgressBar.Value;
                        maxiBar = safetyProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        safetyProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = safetyProgressValue.Text;
                        if (safetyProgressBar.Value > yellowTriger) safetyProgressBar.ForeColor = Color.Yellow;
                        if (safetyProgressBar.Value > redTriger) safetyProgressBar.ForeColor = Color.Red;
                    }
                
                }
            }
            if (quality)
            {

                if (qualityProgressBar.Maximum == qualityProgressBar.Value)
                {
                    quality = false;
                    qualityProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(qualityStart.Text);
                    TimeSpan setTime = new TimeSpan(qualityTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    qualityProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        qualityProgressBar.Value = (int)(tNow - tStart);
                        currentBar = qualityProgressBar.Value;
                        maxiBar = qualityProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        qualityProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = qualityProgressValue.Text;
                        if (qualityProgressBar.Value > yellowTriger) qualityProgressBar.ForeColor = Color.Yellow;
                        if (qualityProgressBar.Value > redTriger) qualityProgressBar.ForeColor = Color.Red;
                    }

                }
            }
            if (customerService)
            {

                if (customerServiceProgressBar.Maximum == customerServiceProgressBar.Value)
                {
                    customerService = false;
                    customerServiceProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(customerServiceStart.Text);
                    TimeSpan setTime = new TimeSpan(customerServiceTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    customerServiceProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        customerServiceProgressBar.Value = (int)(tNow - tStart);
                        currentBar = customerServiceProgressBar.Value;
                        maxiBar = customerServiceProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        customerServiceProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = customerServiceProgressValue.Text;
                        if (customerServiceProgressBar.Value > yellowTriger) customerServiceProgressBar.ForeColor = Color.Yellow;
                        if (customerServiceProgressBar.Value > redTriger) customerServiceProgressBar.ForeColor = Color.Red;
                    }
                }
            }
            if (performance)
            {

                if (performanceProgressBar.Maximum == performanceProgressBar.Value)
                {
                    performance = false;
                    performanceProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(performanceStart.Text);
                    TimeSpan setTime = new TimeSpan(performanceTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    performanceProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        performanceProgressBar.Value = (int)(tNow - tStart);
                        currentBar = performanceProgressBar.Value;
                        maxiBar = performanceProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        performanceProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = performanceProgressValue.Text;
                        if (performanceProgressBar.Value > yellowTriger) performanceProgressBar.ForeColor = Color.Yellow;
                        if (performanceProgressBar.Value > redTriger) performanceProgressBar.ForeColor = Color.Red;
                    }

                }
            }
            if (people)
            {

                if (peopleProgressBar.Maximum == peopleProgressBar.Value)
                {
                    people = false;
                    peopleProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(peopleStart.Text);
                    TimeSpan setTime = new TimeSpan(peopleTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    peopleProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        peopleProgressBar.Value = (int)(tNow - tStart);
                        currentBar = peopleProgressBar.Value;
                        maxiBar = peopleProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        peopleProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = peopleProgressValue.Text;
                        if (peopleProgressBar.Value > yellowTriger) peopleProgressBar.ForeColor = Color.Yellow;
                        if (peopleProgressBar.Value > redTriger) peopleProgressBar.ForeColor = Color.Red;
                    }
                }
            }
            if (projects)
            {

                if (projectsProgressBar.Maximum == projectsProgressBar.Value)
                {
                    projects = false;
                    projectsProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(projectsStart.Text);
                    TimeSpan setTime = new TimeSpan(projectsTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    projectsProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        projectsProgressBar.Value = (int)(tNow - tStart);
                        currentBar = projectsProgressBar.Value;
                        maxiBar = projectsProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        projectsProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = projectsProgressValue.Text;
                        if (projectsProgressBar.Value > yellowTriger) projectsProgressBar.ForeColor = Color.Yellow;
                        if (projectsProgressBar.Value > redTriger) projectsProgressBar.ForeColor = Color.Red;
                    }
                }
            }
            if (priority)
            {

                if (priorityProgressBar.Maximum == priorityProgressBar.Value)
                {
                    priority = false;
                    priorityProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(priorityStart.Text);
                    TimeSpan setTime = new TimeSpan(priorityTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    priorityProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        priorityProgressBar.Value = (int)(tNow - tStart);
                        currentBar = priorityProgressBar.Value;
                        maxiBar = priorityProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        priorityProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = priorityProgressValue.Text;
                        if (priorityProgressBar.Value > yellowTriger) priorityProgressBar.ForeColor = Color.Yellow;
                        if (priorityProgressBar.Value > redTriger) priorityProgressBar.ForeColor = Color.Red;
                    }
                }
            }
            if (visits)
            {

                if (visitsProgressBar.Maximum == visitsProgressBar.Value)
                {
                    visits = false;
                    visitsProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(visitsStart.Text);
                    TimeSpan setTime = new TimeSpan(visitsTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    visitsProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        visitsProgressBar.Value = (int)(tNow - tStart);
                        currentBar = visitsProgressBar.Value;
                        maxiBar = visitsProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        visitsProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = visitsProgressValue.Text;
                        if (visitsProgressBar.Value > yellowTriger) visitsProgressBar.ForeColor = Color.Yellow;
                        if (visitsProgressBar.Value > redTriger) visitsProgressBar.ForeColor = Color.Red;
                    }
                }
            }
            if (feedback)
            {

                if (feedbackProgressBar.Maximum == feedbackProgressBar.Value)
                {
                    feedback = false;
                    feedbackProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    DateTime timeStart = DateTime.Parse(feedbackStart.Text);
                    TimeSpan setTime = new TimeSpan(feedbackTimePicker.Value.Ticks);
                    long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
                    DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
                    DateTime timeNow = DateTime.Parse(currentTime.Text);
                    double tStart = ConvertToUnixTimestamp(timeStart);
                    double tEnd = ConvertToUnixTimestamp(timeEnd);
                    double tNow = ConvertToUnixTimestamp(timeNow);
                    feedbackProgressBar.Maximum = (int)(tEnd - tStart);
                    if (((int)(tNow - tStart)) == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        feedbackProgressBar.Value = (int)(tNow - tStart);
                        currentBar = feedbackProgressBar.Value;
                        maxiBar = feedbackProgressBar.Maximum;
                        int yellowTriger = (int)((tEnd - tStart) * 0.8);
                        int redTriger = (int)(tEnd - tStart);
                        int percentTNow = (int)((tNow - tStart) / (tEnd - tStart) * 100);
                        feedbackProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = feedbackProgressValue.Text;
                        if (feedbackProgressBar.Value > yellowTriger) feedbackProgressBar.ForeColor = Color.Yellow;
                        if (feedbackProgressBar.Value > redTriger) feedbackProgressBar.ForeColor = Color.Red;
                    }

                }
            }
        }

        private int valueFN(string startTime, string currentTime)
        {
            DateTime timeStart = DateTime.Parse(startTime);
            DateTime timeNow = DateTime.Parse(currentTime);
            double tStart = ConvertToUnixTimestamp(timeStart);
            double tNow = ConvertToUnixTimestamp(timeNow);
            int result = (int)(tNow - tStart);
            return result;
        }

        private double maximumFN(string introStart, long ticks)
        {
            DateTime timeStart = DateTime.Parse(introStart);
            TimeSpan setTime = new TimeSpan(ticks);
            long timeInSeconds = setTime.Minutes * 60 + setTime.Seconds;
            DateTime timeEnd = timeStart.AddSeconds(timeInSeconds);
            double tStart = ConvertToUnixTimestamp(timeStart);
            double tEnd = ConvertToUnixTimestamp(timeEnd);
            double result = tEnd - tStart;
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentAction = introTitle.Text;
            introStart.Text = "";
            introEnd.Text = "";
            introResult.Text = "";
            introProgressValue.Text = "";
            DateTime timeStart = DateTime.Parse(currentTime.Text);
            introStart.Text = timeStart.TimeOfDay.ToString(); //czas rozpoczęcia
            intro = true;
            introProgressBar.ForeColor = Color.LightGreen;
            introProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            // obiektowo - test
            
            ItemObj.StartTime = DateTime.Parse(currentTime.Text);
            ItemObj.Item1 = true;
            introProgressBar.ForeColor = Color.LightGreen;
            introProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            Console.WriteLine(ItemObj.Item1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            intro = false;
            introEnd.Text = currentTime.Text; 
            DateTime timeStart = DateTime.Parse(introEnd.Text); 
            DateTime timeEnd = DateTime.Parse(introStart.Text); 
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            introResult.Text = diff1.ToString();
            currentAction = safetyTitle.Text;
            safetyStart.Text = "";
            safetyEnd.Text = "";
            safetyResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            safetyStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            safety = true;
            safetyProgressBar.ForeColor = Color.LightGreen;
            safetyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            safety = false;
            safetyEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(safetyEnd.Text);
            DateTime timeEnd = DateTime.Parse(safetyStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            safetyResult.Text = diff1.ToString();

            currentAction = qualityTitle.Text;

            qualityStart.Text = "";
            qualityEnd.Text = "";
            qualityResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            qualityStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            quality = true;
            qualityProgressBar.ForeColor = Color.LightGreen;
            qualityProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            quality = false;
            qualityEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(qualityEnd.Text);
            DateTime timeEnd = DateTime.Parse(qualityStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            qualityResult.Text = diff1.ToString();

            currentAction = customerServiceTitle.Text;

            customerServiceStart.Text = "";
            customerServiceEnd.Text = "";
            customerServiceResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            customerServiceStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            customerService = true;
            customerServiceProgressBar.ForeColor = Color.LightGreen;
            customerServiceProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            customerService = false;
            customerServiceEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(customerServiceEnd.Text);
            DateTime timeEnd = DateTime.Parse(customerServiceStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            customerServiceResult.Text = diff1.ToString();

            currentAction = performanceTitle.Text;

            performanceStart.Text = "";
            performanceEnd.Text = "";
            performanceResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            performanceStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            performance = true;
            performanceProgressBar.ForeColor = Color.LightGreen;
            performanceProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            performance = false;
            performanceEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(performanceEnd.Text);
            DateTime timeEnd = DateTime.Parse(performanceStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            performanceResult.Text = diff1.ToString();

            currentAction = peopleTitle.Text;

            peopleStart.Text = "";
            peopleEnd.Text = "";
            peopleResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            peopleStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            people = true;
            peopleProgressBar.ForeColor = Color.LightGreen;
            peopleProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            people = false;
            peopleEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(peopleEnd.Text);
            DateTime timeEnd = DateTime.Parse(peopleStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            peopleResult.Text = diff1.ToString();

            currentAction = projectsTitle.Text;

            projectsStart.Text = "";
            projectsEnd.Text = "";
            projectsResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            projectsStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            projects = true;
            projectsProgressBar.ForeColor = Color.LightGreen;
            projectsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            projects = false;
            projectsEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(projectsEnd.Text);
            DateTime timeEnd = DateTime.Parse(projectsStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            projectsResult.Text = diff1.ToString();

            currentAction = priorityTitle.Text;

            priorityStart.Text = "";
            priorityEnd.Text = "";
            priorityResults.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            priorityStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            priority = true;
            priorityProgressBar.ForeColor = Color.LightGreen;
            priorityProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            priority = false;
            priorityEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(priorityEnd.Text);
            DateTime timeEnd = DateTime.Parse(priorityStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            priorityResults.Text = diff1.ToString();

            currentAction = visitsTitle.Text;

            visitsStart.Text = "";
            visitsEnd.Text = "";
            visitsResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            visitsStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            visits = true;
            visitsProgressBar.ForeColor = Color.LightGreen;
            visitsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            visits = false;
            visitsEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(visitsEnd.Text);
            DateTime timeEnd = DateTime.Parse(visitsStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            visitsResult.Text = diff1.ToString();

            currentAction = feedbackTitle.Text;

            feedbackStart.Text = "";
            feedbackEnd.Text = "";
            feedbackResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            feedbackStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            feedback = true;
            feedbackProgressBar.ForeColor = Color.LightGreen;
            feedbackProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            feedback = false;
            feedbackEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(feedbackEnd.Text);
            DateTime timeEnd = DateTime.Parse(feedbackStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            feedbackResult.Text = diff1.ToString();
            // currentAction = "";
            //currentBar = 0;
            //maxiBar = 0;
            //procentBar = " ";

        }
        private void button12_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button ");
            // czyszczenie
            Application.Restart();
            Process.GetCurrentProcess().Kill();
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
