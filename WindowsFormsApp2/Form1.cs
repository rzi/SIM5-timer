using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool intro, safety, quality, customerService, performance, people, projects, priority, visits, feedback;
        public string currentAction, procentBar;
        public int currentBar, maxiBar;

        //ItemObj2 intro1 = new ItemObj2(); //test
        Result result = new Result();

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
            DateTime now = DateTime.Now;
            currentTime.Text = now.ToLongTimeString(); //bieżący czas
            if (intro)
            {
                if (introProgressBar.Maximum == introProgressBar.Value)
                {
                    intro = false;
                    introProgressBar.ForeColor = Color.Red;
                }
                else
                {
                    double progressBarMaximum = maximumFN(introStart.Text, introTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(introStart.Text, currentTime.Text);
                    introProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        introProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int) ((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " +percentTNow);
                        introProgressValue.Text = percentTNow.ToString("N0") + "%";
                        procentBar = introProgressValue.Text;
                        if (introProgressBar.Value > yellowTriger) introProgressBar.ForeColor = Color.Yellow;
                        if (introProgressBar.Value > redTriger) introProgressBar.ForeColor = Color.Red;
                        result.isIntro = intro;
                        result.setIntro = introTimePicker.ToString();
                        result.startIntro = introStart.ToString();
                        result.stopIntro = introEnd.ToString();
                        result.resultIntro = introResult.ToString();
                        result.intro = "intro";
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
                    double progressBarMaximum = maximumFN(safetyStart.Text, safetyTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(safetyStart.Text, currentTime.Text);
                    safetyProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        safetyProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(qualityStart.Text, qualityTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(qualityStart.Text, currentTime.Text);
                    qualityProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        qualityProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(customerServiceStart.Text, customerServiceTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(customerServiceStart.Text, currentTime.Text);
                    customerServiceProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        customerServiceProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(performanceStart.Text, performanceTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(performanceStart.Text, currentTime.Text);
                    performanceProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        performanceProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(peopleStart.Text, peopleTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(peopleStart.Text, currentTime.Text);
                    peopleProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        peopleProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(projectsStart.Text, projectsTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(projectsStart.Text, currentTime.Text);
                    projectsProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        projectsProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(priorityStart.Text, priorityTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(priorityStart.Text, currentTime.Text);
                    priorityProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        priorityProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(visitsStart.Text, visitsTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(visitsStart.Text, currentTime.Text);
                    visitsProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        visitsProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
                    double progressBarMaximum = maximumFN(feedbackStart.Text, feedbackTimePicker.Value.Ticks);
                    int progressBarValue = valueFN(feedbackStart.Text, currentTime.Text);
                    feedbackProgressBar.Maximum = (int)progressBarMaximum;

                    if (progressBarValue == 1)
                    {
                        // obsługa błedu gdy wartośc zadana jest równa 0
                    }
                    else
                    {
                        feedbackProgressBar.Value = progressBarValue;
                        currentBar = progressBarValue;
                        maxiBar = (int)progressBarMaximum;
                        double yellowTriger = (progressBarMaximum * 0.8);
                        int redTriger = (int)progressBarMaximum;
                        int percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
                        Console.WriteLine("procentTNow " + percentTNow);
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
        private double maximumFN(string start, long ticks)
        {
            DateTime timeStart = DateTime.Parse(start);
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
            saveToDB("intro" , introTimePicker.Value.ToString(),introStart.Text,introEnd.Text,introResult.Text,introProgressValue.Text );
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
            saveToDB("safety", safetyTimePicker.Value.ToString(), safetyStart.Text, safetyEnd.Text, safetyResult.Text, safetyProgressValue.Text);
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
            saveToDB("quality", qualityTimePicker.Value.ToString(), qualityStart.Text, qualityEnd.Text, qualityResult.Text, qualityProgressValue.Text);
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
            saveToDB("customerService", customerServiceTimePicker.Value.ToString(), customerServiceStart.Text, customerServiceEnd.Text, customerServiceResult.Text, customerServiceProgressValue.Text);
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
            saveToDB("performance", performanceTimePicker.Value.ToString(), performanceStart.Text, performanceEnd.Text, performanceResult.Text, performanceProgressValue.Text);
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
            saveToDB("people", peopleTimePicker.Value.ToString(), peopleStart.Text, peopleEnd.Text, peopleResult.Text, peopleProgressValue.Text);
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
            priorityResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            priorityStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            priority = true;
            priorityProgressBar.ForeColor = Color.LightGreen;
            priorityProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            saveToDB("projects", projectsTimePicker.Value.ToString(), projectsStart.Text, projectsEnd.Text, projectsResult.Text, projectsProgressValue.Text);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            priority = false;
            priorityEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(priorityEnd.Text);
            DateTime timeEnd = DateTime.Parse(priorityStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            priorityResult.Text = diff1.ToString();

            currentAction = visitsTitle.Text;

            visitsStart.Text = "";
            visitsEnd.Text = "";
            visitsResult.Text = "";
            DateTime timeStart1 = DateTime.Parse(currentTime.Text);
            visitsStart.Text = timeStart1.TimeOfDay.ToString(); //czas rozpoczęcia
            visits = true;
            visitsProgressBar.ForeColor = Color.LightGreen;
            visitsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            saveToDB("priority", priorityTimePicker.Value.ToString(), priorityStart.Text, priorityEnd.Text, priorityResult.Text, priorityProgressValue.Text);
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
            saveToDB("visits", visitsTimePicker.Value.ToString(), visitsStart.Text, visitsEnd.Text, visitsResult.Text, visitsProgressValue.Text);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            feedback = false;
            feedbackEnd.Text = currentTime.Text;
            DateTime timeStart = DateTime.Parse(feedbackEnd.Text);
            DateTime timeEnd = DateTime.Parse(feedbackStart.Text);
            TimeSpan diff1 = timeStart.Subtract(timeEnd);
            feedbackResult.Text = diff1.ToString();
            saveToDB("feedback", feedbackTimePicker.Value.ToString(), feedbackStart.Text, feedbackEnd.Text, feedbackResult.Text, feedbackProgressValue.Text);
            //createChart();
        }

        private void createChart()
        {
            throw new NotImplementedException();
        }

        private void saveToDB(string block, string timeSet, string timeStart, string timeEnd, string timeResult,string progressValue)
        {
            Console.WriteLine("zapis do DB");
            // db connection
            string connectionstring = "Server=localhost; Database=timedb ;Uid=root; Password=Klucze2021!1";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            try
            {
                conn.Open();
                //SQL Query to execute
                //insert Query
                // we are inserting actor_id, first_name, last_name, last_updated columns data
                //21:36:01	insert into timedb.timedb(date,block,timeSet,timeStart,timeEnd,timeResult,progressValue)Values ("2021-08-15","safety","3:00", "20:02:00","20:05:00","03:00","100%")	1 row(s) affected	0.000 sec

                string date = dateTimePicker1.Value.ToString().Substring(0,10);
                    Console.WriteLine("data: " + date);
                string timeSet1 = timeSet.Substring(10, 9);
                Console.WriteLine("timeSet1: " + timeSet1);
                string sql = "insert into timedb(date,block,timeSet,timeStart,timeEnd,timeResult,progressValue)Values ("
                    + "\"" + date +"\""
                    +",\"" + block +"\""
                    +",\"" +timeSet1+ "\""
                    +",\"" +timeStart + "\""
                    +",\"" + timeEnd +"\""
                    +",\"" + timeResult +"\""
                    +",\"" + progressValue +"\""
                    + ")";
                Console.WriteLine(" sql; " + sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab == tabControl1.TabPages[3])// Historia
            {
                // db connection
                string connectionstring = "Server=localhost; Database=timedb ;Uid=root; Password=Klucze2021!1";
                MySqlConnection conn = new MySqlConnection(connectionstring);
                try
                {
                    string mysql = "Select * FROM timedb";
                    MySqlCommand command = new MySqlCommand(mysql, conn);
                    conn.Open();

                    MySqlDataReader rdr = command.ExecuteReader();
                    //read the data
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + "  " + rdr[1] + "  " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5]);
                    }
                    rdr.Close();

                    MySqlDataAdapter dtb = new MySqlDataAdapter();
                    dtb.SelectCommand = command;
                    System.Data.DataTable dTable = new DataTable();
                    dtb.Fill(dTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dTable;

                    dataGridView1.DataSource = bSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            
        }
    }
}
