using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool Sound, Sound1, Sound2, intro, safety, quality, customerService, performance, people, projects, priority, visits, feedback;
        public string currentAction, procentBar, status;
        public int currentBar, maxiBar;
        Result result = new Result();
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            sumValue.Text = calcSumOfTime().ToString();

            Bitmap image = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            Graphics g = Graphics.FromImage(image);
            g.DrawLine(new Pen(Color.LightGray, 2) { DashPattern = new float[] { 4, 2F } }, 8, 87, 940, 87);
            g.DrawLine(new Pen(Color.LightGray, 2) { DashPattern = new float[] { 4, 2F } }, 8, 500, 940, 500);
            canvas.Image = image;

            int counter = 0;
            string line;
            string curpath = @"c:\Timekeeper\settings1.txt";
            if (File.Exists(curpath))
            {
                // Read the file and display it line by line.  
                using (StreamReader file = new StreamReader(curpath))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        counter++;

                        if (counter == 1)
                        {
                            if (line == "true")
                            {
                                checkBoxServer.Checked = true;
                                Console.WriteLine("checked = " + line);
                            }
                            else
                            {
                                checkBoxServer.Checked = false;
                                Console.WriteLine("checked = " + line);
                            }
                        }
                        if (counter == 2)
                        {
                            locationSite.Text = line;
                        }
                        if (counter == 3)
                        {
                            hostInput.Text = line;
                        }
                        if (counter == 4)
                        {
                            loginInput.Text = line;
                        }
                        if (counter == 5)
                        {
                            passwordInput.Text = line;
                        }
                        if (counter == 6)
                        {
                            baseInput.Text = line;
                        }
                        if (counter == 7)
                        {
                            tableInput.Text = line;
                        }
                    }
                    file.Dispose();
                    file.Close();
                }
                System.Console.WriteLine("There were {0} lines.", counter);
            }  
            else
            {
                if (!Directory.Exists(@"c:\Timekeeper"))
                {
                    Directory.CreateDirectory(@"c:\Timekeeper");
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(curpath))
                    {
                        sw.WriteLine("false");
                        sw.Close();
                    }
                }
                else if (!File.Exists(curpath))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(curpath))
                    {
                        sw.WriteLine("false");
                        sw.Close();
                    }
                }
            }
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
            switch (status)
            {
                case "intro":
                    introTick();
                    break;

                case "safety":
                    safetyTick();
                    break;

                case "quality":
                    qualityTick();
                    break;

                case "customerService":
                    customerServiceTick();
                    break;

                case "performance":
                    performanceTick();
                    break;

                case "people":
                    peopleTick();
                    break;

                case "projects":
                    projectsTick();
                    break;

                case "priority":
                    priorityTick();
                    break;

                case "visits":
                    visitsTick();
                    break;

                case "feedback":
                    feedbackTick();
                    break;

                default:
                    Console.WriteLine($"default: {status}.");
                    break;
            }
        }
        private void introTick()
        {
            double progressBarMaximum = maximumFN(introStart.Text, introTimePicker.Value.Ticks);
            double progressBarValue = valueFN(introStart.Text, currentTime.Text);
            introProgressBar.Maximum = (int)progressBarMaximum;
            Console.WriteLine("introProgressBar.Maximum" + introProgressBar.Maximum);
            if (progressBarValue <= introProgressBar.Maximum && introProgressBar.Value <= introProgressBar.Maximum) introProgressBar.Value = (int)progressBarValue;
            Console.WriteLine("introProgressBar.Value: " + introProgressBar.Value);
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            introProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = introProgressValue.Text;
            if (progressBarValue > yellowTriger) introProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) introProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
            result.isIntro = intro;
            result.setIntro = introTimePicker.ToString();
            result.startIntro = introStart.ToString();
            result.stopIntro = introEnd.ToString();
            result.resultIntro = introResult.ToString();
            result.intro = "intro";
        }
        private void safetyTick()
        {
            double progressBarMaximum = maximumFN(safetyStart.Text, safetyTimePicker.Value.Ticks);
            double progressBarValue = valueFN(safetyStart.Text, currentTime.Text);
            safetyProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= safetyProgressBar.Maximum && safetyProgressBar.Value <= safetyProgressBar.Maximum) safetyProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            safetyProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = safetyProgressValue.Text;
            if (progressBarValue > yellowTriger) safetyProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) safetyProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void qualityTick()
        {
            double progressBarMaximum = maximumFN(qualityStart.Text, qualityTimePicker.Value.Ticks);
            double progressBarValue = valueFN(qualityStart.Text, currentTime.Text);
            qualityProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= qualityProgressBar.Maximum && qualityProgressBar.Value <= qualityProgressBar.Maximum) qualityProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = (int)progressBarMaximum;
            double percentTNow = (int)((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            qualityProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = qualityProgressValue.Text;
            if (progressBarValue > yellowTriger) qualityProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) qualityProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void customerServiceTick()
        {
            double progressBarMaximum = maximumFN(customerServiceStart.Text, customerServiceTimePicker.Value.Ticks);
            double progressBarValue = valueFN(customerServiceStart.Text, currentTime.Text);
            customerServiceProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= customerServiceProgressBar.Maximum && customerServiceProgressBar.Value <= customerServiceProgressBar.Maximum) customerServiceProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            customerServiceProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = customerServiceProgressValue.Text;
            if (progressBarValue > yellowTriger) customerServiceProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) customerServiceProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void performanceTick()
        {
            double progressBarMaximum = maximumFN(performanceStart.Text, performanceTimePicker.Value.Ticks);
            double progressBarValue = valueFN(performanceStart.Text, currentTime.Text);
            performanceProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= performanceProgressBar.Maximum && performanceProgressBar.Value <= performanceProgressBar.Maximum) performanceProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            performanceProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = performanceProgressValue.Text;
            if (progressBarValue > yellowTriger) performanceProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) performanceProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void peopleTick()
        {
            double progressBarMaximum = maximumFN(peopleStart.Text, peopleTimePicker.Value.Ticks);
            double progressBarValue = valueFN(peopleStart.Text, currentTime.Text);
            peopleProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= peopleProgressBar.Maximum && peopleProgressBar.Value <= peopleProgressBar.Maximum) peopleProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = (int)progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            peopleProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = peopleProgressValue.Text;
            if (progressBarValue > yellowTriger) peopleProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) peopleProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void projectsTick()
        {
            double progressBarMaximum = maximumFN(projectsStart.Text, projectsTimePicker.Value.Ticks);
            double progressBarValue = valueFN(projectsStart.Text, currentTime.Text);
            projectsProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= projectsProgressBar.Maximum && projectsProgressBar.Value <= projectsProgressBar.Maximum) projectsProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            projectsProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = projectsProgressValue.Text;
            if (progressBarValue > yellowTriger) projectsProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) projectsProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void priorityTick()
        {
            double progressBarMaximum = maximumFN(priorityStart.Text, priorityTimePicker.Value.Ticks);
            double progressBarValue = valueFN(priorityStart.Text, currentTime.Text);
            priorityProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= priorityProgressBar.Maximum && priorityProgressBar.Value <= priorityProgressBar.Maximum) priorityProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            priorityProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = priorityProgressValue.Text;
            if (progressBarValue > yellowTriger) priorityProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) priorityProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void visitsTick()
        {
            double progressBarMaximum = maximumFN(visitsStart.Text, visitsTimePicker.Value.Ticks);
            double progressBarValue = valueFN(visitsStart.Text, currentTime.Text);
            visitsProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= visitsProgressBar.Maximum && visitsProgressBar.Value <= visitsProgressBar.Maximum) visitsProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            visitsProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = visitsProgressValue.Text;
            if (progressBarValue > yellowTriger) visitsProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) visitsProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private void feedbackTick()
        {
            double progressBarMaximum = maximumFN(feedbackStart.Text, feedbackTimePicker.Value.Ticks);
            double progressBarValue = valueFN(feedbackStart.Text, currentTime.Text);
            feedbackProgressBar.Maximum = (int)progressBarMaximum;
            if (progressBarValue <= feedbackProgressBar.Maximum && feedbackProgressBar.Value <= feedbackProgressBar.Maximum) feedbackProgressBar.Value = (int)progressBarValue;
            currentBar = (int)progressBarValue;
            maxiBar = (int)progressBarMaximum;
            double yellowTriger = (progressBarMaximum * 0.8);
            double redTriger = progressBarMaximum;
            double percentTNow = ((progressBarValue / progressBarMaximum) * 100);
            Console.WriteLine("procentTNow " + percentTNow);
            feedbackProgressValue.Text = percentTNow.ToString("N0") + "%";
            procentBar = feedbackProgressValue.Text;
            if (progressBarValue > yellowTriger) feedbackProgressBar.ForeColor = Color.Yellow;
            if (progressBarValue > redTriger) feedbackProgressBar.ForeColor = Color.Red;
            progressSound(progressBarValue, progressBarMaximum);
        }
        private double valueFN(string startTime, string currentTime)
        {
            DateTime timeStart = DateTime.Parse(startTime);
            DateTime timeNow = DateTime.Parse(currentTime);
            double tStart = ConvertToUnixTimestamp(timeStart);
            double tNow = ConvertToUnixTimestamp(timeNow);
            double result = (tNow - tStart);
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileName = @"C:\Timekeeper\settings1.txt";
            string[] lines = new string[7]; // = System.IO.File.ReadAllLines(fileName);
            lines[0] = (checkBoxServer.Checked) ? "true" : "false";
            lines[1] = locationSite.Text;
            lines[2] = hostInput.Text;
            lines[3] = loginInput.Text;
            lines[4] = passwordInput.Text;
            lines[5] = baseInput.Text;
            lines[6] = tableInput.Text;
            File.WriteAllLines(fileName, lines);
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
            status = "intro";
            introProgressBar.ForeColor = Color.LightGreen;
            introProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            status = "intro";

            // obiektowo - test

            //ItemObj.StartTime = DateTime.Parse(currentTime.Text);
            //ItemObj.Item1 = true;
            //introProgressBar.ForeColor = Color.LightGreen;
            //introProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            //Console.WriteLine(ItemObj.Item1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (intro)
            {
                intro = false; Sound = false; Sound1 = false; Sound2 = false;
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
                DateTime introTimeObjective = timeEnd.AddSeconds(introTimePicker.Value.TimeOfDay.Minutes * 60 + introTimePicker.Value.TimeOfDay.Seconds);
                double result1 = calcOfSpentTime(timeEnd, timeStart, introTimeObjective);
                Console.WriteLine("wynik " + (result1));
                safety = true;
                status = "safety";
                safetyProgressBar.ForeColor = Color.LightGreen;
                safetyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Wstęp", introTimePicker.Value.ToString(), introStart.Text, introEnd.Text, introResult.Text, introProgressValue.Text,locationSite.Text);

            }
            else
            {
                wrongSequenceWarning();
            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (safety)
            {
                safety = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "quality";
                qualityProgressBar.ForeColor = Color.LightGreen;
                qualityProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("BHP", safetyTimePicker.Value.ToString(), safetyStart.Text, safetyEnd.Text, safetyResult.Text, safetyProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (quality)
            {
                quality = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "customerService";
                customerServiceProgressBar.ForeColor = Color.LightGreen;
                customerServiceProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Jakość", qualityTimePicker.Value.ToString(), qualityStart.Text, qualityEnd.Text, qualityResult.Text, qualityProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (customerService)
            {
                customerService = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "performance";
                performanceProgressBar.ForeColor = Color.LightGreen;
                performanceProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Serwis", customerServiceTimePicker.Value.ToString(), customerServiceStart.Text, customerServiceEnd.Text, customerServiceResult.Text, customerServiceProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (performance)
            {
                performance = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "people";
                peopleProgressBar.ForeColor = Color.LightGreen;
                peopleProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Efektywność", performanceTimePicker.Value.ToString(), performanceStart.Text, performanceEnd.Text, performanceResult.Text, performanceProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (people)
            {
                people = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "projects";
                projectsProgressBar.ForeColor = Color.LightGreen;
                projectsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Eureka", peopleTimePicker.Value.ToString(), peopleStart.Text, peopleEnd.Text, peopleResult.Text, peopleProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (projects)
            {
                projects = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "priority";
                priorityProgressBar.ForeColor = Color.LightGreen;
                priorityProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Projekty", projectsTimePicker.Value.ToString(), projectsStart.Text, projectsEnd.Text, projectsResult.Text, projectsProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (priority)
            {
                priority = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "visits";
                visitsProgressBar.ForeColor = Color.LightGreen;
                visitsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Priorytety", priorityTimePicker.Value.ToString(), priorityStart.Text, priorityEnd.Text, priorityResult.Text, priorityProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (visits)
            {
                visits = false; Sound = false; Sound1 = false; Sound2 = false;
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
                status = "feedback";
                feedbackProgressBar.ForeColor = Color.LightGreen;
                feedbackProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                saveToDB("Wizyty", visitsTimePicker.Value.ToString(), visitsStart.Text, visitsEnd.Text, visitsResult.Text, visitsProgressValue.Text, locationSite.Text);
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (feedback)
            {
                feedback = false; Sound = false; Sound1 = false; Sound2 = false;
                feedbackEnd.Text = currentTime.Text;
                DateTime timeStart = DateTime.Parse(feedbackEnd.Text);
                DateTime timeEnd = DateTime.Parse(feedbackStart.Text);
                TimeSpan diff1 = timeStart.Subtract(timeEnd);
                feedbackResult.Text = diff1.ToString();
                status = "end";
                saveToDB("Feedback", feedbackTimePicker.Value.ToString(), feedbackStart.Text, feedbackEnd.Text, feedbackResult.Text, feedbackProgressValue.Text, locationSite.Text);
                clearChart();
                fillChart();
            }
            else
            {
                wrongSequenceWarning();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // czyszczenie, restart app
            System.Windows.Forms.Application.Restart();
            this.Visible = true;
            Sound = false; Sound1 = false; Sound2 = false;
        }
        private void screenShot_Click(object sender, EventArgs e)
        {
            //Creating a Method name CaptureMyScreen
            CaptureMyScreen();
        }
        private void saveToDB(string block, string timeSet, string timeStart, string timeEnd, string timeResult, string progressValue, string site)
        {

            if (checkBoxServer.Checked)
            {
                Console.WriteLine("zapis do DB");
                // db connection
                string connectionstring2 = "Server =" + hostInput.Text +
                    "; Database=" + baseInput.Text +
                    "; Uid=" + loginInput.Text +
                    "; Password= " + passwordInput.Text +
                    "; Port=3306;SSL Mode=None";

                Console.WriteLine("connectionstring2: " + connectionstring2);
                MySqlConnection conn2 = new MySqlConnection(connectionstring2);
                try
                {
                    conn2.Open();
                    string date2 = dateTimePicker1.Value.ToString().Substring(0, 10);
                    Console.WriteLine("data: " + date2);
                    string timeSet1 = timeSet.Substring(10, 9);
                    Console.WriteLine("timeSet1: " + timeSet1);
                    string sql = "insert into " + tableInput.Text + "(date,block,timeSet,timeStart,timeEnd,timeResult,progressValue,site)Values ("
                        + "\"" + date2 + "\""
                        + ",\"" + block + "\""
                        + ",\"" + timeSet1 + "\""
                        + ",\"" + timeStart + "\""
                        + ",\"" + timeEnd + "\""
                        + ",\"" + timeResult + "\""
                        + ",\"" + progressValue + "\""
                        + ",\"" + site + "\""
                        + ")";
                    Console.WriteLine(" sql: " + sql);
                    MySqlCommand cmd = new MySqlCommand(sql, conn2);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn2.Close();
            }


            //Console.WriteLine("zapis do DB");
            //// db connection
            //string connectionstring = "Server=localhost; Database=timedb ;Uid=root; Password=Klucze2021!1";
            //MySqlConnection conn = new MySqlConnection(connectionstring);
            //try
            //{
            //    conn.Open();
            //    //SQL Query to execute
            //    //insert Query
            //    // we are inserting actor_id, first_name, last_name, last_updated columns data
            //    //21:36:01	insert into timedb.timedb(date,block,timeSet,timeStart,timeEnd,timeResult,progressValue)Values ("2021-08-15","safety","3:00", "20:02:00","20:05:00","03:00","100%")	1 row(s) affected	0.000 sec

            //    string date = dateTimePicker1.Value.ToString().Substring(0, 10);
            //    Console.WriteLine("data: " + date);
            //    string timeSet1 = timeSet.Substring(10, 9);
            //    Console.WriteLine("timeSet1: " + timeSet1);
            //    string sql = "insert into timedb(date,block,timeSet,timeStart,timeEnd,timeResult,progressValue)Values ("
            //        + "\"" + date + "\""
            //        + ",\"" + block + "\""
            //        + ",\"" + timeSet1 + "\""
            //        + ",\"" + timeStart + "\""
            //        + ",\"" + timeEnd + "\""
            //        + ",\"" + timeResult + "\""
            //        + ",\"" + progressValue + "\""
            //        + ")";
            //    Console.WriteLine(" sql; " + sql);
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.ExecuteNonQuery();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //conn.Close();

            // cba.pl

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
            if (tabControl1.SelectedTab == tabControl1.TabPages[2])// Historia
            {

                // db connection
                string connectionstring = "Server =" + hostInput.Text +
                    "; Database=" + baseInput.Text +
                    "; Uid=" + loginInput.Text +
                    "; Password= " + passwordInput.Text +
                    "; Port=3306;SSL Mode=None";
                Console.WriteLine("connectionstring: " + connectionstring);
                MySqlConnection conn = new MySqlConnection(connectionstring);
                try
                {
                    string mysql = "Select * FROM " + tableInput.Text;
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
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages[3]) // server settings from file
            {
                if (checkBoxServer.Checked )
                {
                    location.Visible = true;
                    locationSite.Visible = true;
                    host.Visible = true;
                    hostInput.Visible = true;
                    login.Visible = true;
                    loginInput.Visible = true;
                    password.Visible = true;
                    passwordInput.Visible = true;
                    baseLabel.Visible = true;
                    baseInput.Visible = true;
                    tableLabel.Visible = true;
                    tableInput.Visible = true;
                    Console.WriteLine("checkBoxServer.Text =true");                }
                else
                {
                    location.Visible = false;
                    locationSite.Visible = false;
                    host.Visible = false;
                    hostInput.Visible = false;
                    login.Visible = false;
                    loginInput.Visible = false;
                    password.Visible = false;
                    passwordInput.Visible = false;
                    baseLabel.Visible = false;
                    baseInput.Visible = false;
                    tableLabel.Visible = false;
                    tableInput.Visible = false;
                    Console.WriteLine("checkBoxServer.Text = false");

                }
            }
        }
        private void introTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void safetyTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void checkBoxServer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxServer.Checked == true)
            {
                location.Visible = true;
                locationSite.Visible = true;
                host.Visible = true;
                hostInput.Visible = true;
                login.Visible = true;
                loginInput.Visible = true;
                password.Visible = true;
                passwordInput.Visible = true;
                baseLabel.Visible = true;
                baseInput.Visible = true;
                tableLabel.Visible = true;
                tableInput.Visible = true;
                Console.WriteLine("checkBoxServer.Text = true");
            }
            else
            {
                location.Visible = false;
                locationSite.Visible = false;
                host.Visible = false;
                hostInput.Visible = false;
                login.Visible = false;
                loginInput.Visible = false;
                password.Visible = false;
                passwordInput.Visible = false;
                baseLabel.Visible = false;
                baseInput.Visible = false;
                tableLabel.Visible = false;
                tableInput.Visible = false;
                Console.WriteLine("checkBoxServer.Text = false");
            }
        }
        private void qualityTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void customerServiceTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void performanceTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void peopleTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void projectsTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void priorityTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void visitsTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private void feedbackTimePicker_ValueChanged(object sender, EventArgs e)
        {
            sumValue.Text = calcSumOfTime().ToString();
        }
        private TimeSpan calcSumOfTime()
        {
            TimeSpan sumOftimeSet = introTimePicker.Value.TimeOfDay
                .Add(safetyTimePicker.Value.TimeOfDay)
                .Add(qualityTimePicker.Value.TimeOfDay)
                .Add(customerServiceTimePicker.Value.TimeOfDay)
                .Add(performanceTimePicker.Value.TimeOfDay)
                .Add(peopleTimePicker.Value.TimeOfDay)
                .Add(projectsTimePicker.Value.TimeOfDay)
                .Add(priorityTimePicker.Value.TimeOfDay)
                .Add(visitsTimePicker.Value.TimeOfDay)
                .Add(feedbackTimePicker.Value.TimeOfDay)
                ;
            return sumOftimeSet;
        }
        private double calcOfSpentTime(DateTime timeEnd, DateTime timeStart, DateTime introTimeObjective)
        {
            // real progress time calcul.
            double Start = (timeEnd.TimeOfDay.TotalHours / timeEnd.TimeOfDay.Hours - 1);
            double End = (timeStart.TimeOfDay.TotalHours / timeStart.TimeOfDay.Hours - 1);
            double Objective = (introTimeObjective.TimeOfDay.TotalHours / introTimeObjective.TimeOfDay.Hours - 1);

            Console.WriteLine("Start " + Start);
            Console.WriteLine("End " + End);
            Console.WriteLine("Obj " + Objective);
            double result1 = (End / Objective) * 100;
            return result1;
        }
        private void wrongSequenceWarning()
        {
            MessageBox.Show("Zła sekwencja ", "Uwaga!");
            Console.WriteLine("zła sekwencja " + status);
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }
        private void playSimpleSound1()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Unlock.wav");
            simpleSound.Play();
        }
        private void playSimpleSound2()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();
        }
        private void progressSound(double progressBarValue, double progressBarMaximum)
        {

            if (progressBarValue > progressBarMaximum * 0.8 && progressBarValue < progressBarMaximum * 0.85 && Sound == false)
            {
                playSimpleSound();
                Sound = true;
            }
            if (progressBarValue > progressBarMaximum * 0.9 && progressBarValue < progressBarMaximum * 0.95 && Sound1 == false)
            {
                playSimpleSound1();
                Sound1 = true;
            }

            if (progressBarValue > progressBarMaximum * 0.99 && progressBarValue < progressBarMaximum * 1.1 && Sound2 == false)
            {
                playSimpleSound2();
                Sound2 = true;
            }
        }
        private void clearChart()
        {  
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
        private void fillChart()
        {
            double meetingTime = 0;
            // chart intro
            double introResult1 = convertResult(introResult.Text);
            meetingTime = meetingTime + introResult1;
            chart1.Series["Series1"].Points.AddXY("Wstęp", introResult1);
            int valueOfColor = valueOfColorFN(introProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series1"].Points[0].Color = Color.Red;
                chart1.Series["Series1"].Points[0].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series1"].Points[0].Color = Color.LightGreen;
                chart1.Series["Series1"].Points[0].LabelForeColor = Color.Black;
            }
            chart1.Series["Series1"].Points[0].Label = Math.Round(introResult1, 1).ToString() + " \nmin";
            chart1.Series["Series1"].Points.AddXY("BHP", introResult1);
            chart1.Series["Series1"].Points[1].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Jakość", introResult1);
            chart1.Series["Series1"].Points[2].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Serwis", introResult1);
            chart1.Series["Series1"].Points[3].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Efektywność", introResult1);
            chart1.Series["Series1"].Points[4].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Eureka", introResult1);
            chart1.Series["Series1"].Points[5].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Projekty", introResult1);
            chart1.Series["Series1"].Points[6].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Priorytety", introResult1);
            chart1.Series["Series1"].Points[7].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Wizyty", introResult1);
            chart1.Series["Series1"].Points[8].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Feedback", introResult1);
            chart1.Series["Series1"].Points[9].Color = Color.White;
            chart1.Series["Series1"].Points.AddXY("Suma", introResult1);
            chart1.Series["Series1"].Points[10].Color = Color.White;

            // chart safety
            double saferyResult1 = convertResult(safetyResult.Text);
            meetingTime = meetingTime + saferyResult1;
            chart1.Series["Series2"].Points.AddXY("Wstęp", saferyResult1);
            chart1.Series["Series2"].Points[0].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("BHP", saferyResult1);
            valueOfColor = valueOfColorFN(safetyProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series2"].Points[1].Color = Color.Red;
                chart1.Series["Series2"].Points[1].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series2"].Points[1].Color = Color.LightGreen;
                chart1.Series["Series2"].Points[1].LabelForeColor = Color.Black;
            }

            chart1.Series["Series2"].Points[1].Label = Math.Round(saferyResult1, 1).ToString() + " \nmin";
            chart1.Series["Series2"].Points.AddXY("Jakość", saferyResult1);
            chart1.Series["Series2"].Points[2].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Serwis", saferyResult1);
            chart1.Series["Series2"].Points[3].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Efektywność", saferyResult1);
            chart1.Series["Series2"].Points[4].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Eureka", saferyResult1);
            chart1.Series["Series2"].Points[5].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Projekty", saferyResult1);
            chart1.Series["Series2"].Points[6].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Priorytety", saferyResult1);
            chart1.Series["Series2"].Points[7].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Wizyty", saferyResult1);
            chart1.Series["Series2"].Points[8].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Feedback", saferyResult1);
            chart1.Series["Series2"].Points[9].Color = Color.White;
            chart1.Series["Series2"].Points.AddXY("Suma", saferyResult1);
            chart1.Series["Series2"].Points[10].Color = Color.White;

            // chart quality 
            double qualityResult1 = convertResult(qualityResult.Text);
            meetingTime = meetingTime + qualityResult1;
            chart1.Series["Series3"].Points.AddXY("Wstęp", qualityResult1);
            chart1.Series["Series3"].Points[0].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("BHP", qualityResult1);
            chart1.Series["Series3"].Points[1].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Jakość", qualityResult1);
            valueOfColor = valueOfColorFN(qualityProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series3"].Points[2].Color = Color.Red;
                chart1.Series["Series3"].Points[2].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series3"].Points[2].Color = Color.LightGreen;
                chart1.Series["Series3"].Points[2].LabelForeColor = Color.Black;
            }
            chart1.Series["Series3"].Points[2].Label = Math.Round(qualityResult1, 1).ToString() + " \nmin";
            chart1.Series["Series3"].Points.AddXY("Serwis", qualityResult1);
            chart1.Series["Series3"].Points[3].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Efektywność", qualityResult1);
            chart1.Series["Series3"].Points[4].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Eureka", qualityResult1);
            chart1.Series["Series3"].Points[5].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Projekty", qualityResult1);
            chart1.Series["Series3"].Points[6].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Priorytety", qualityResult1);
            chart1.Series["Series3"].Points[7].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Wizyty", qualityResult1);
            chart1.Series["Series3"].Points[8].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Feedback", qualityResult1);
            chart1.Series["Series3"].Points[9].Color = Color.White;
            chart1.Series["Series3"].Points.AddXY("Suma", qualityResult1);
            chart1.Series["Series3"].Points[10].Color = Color.White;

            // chart servis
            double customerServiceResult1 = convertResult(customerServiceResult.Text);
            meetingTime = meetingTime + customerServiceResult1;
            chart1.Series["Series4"].Points.AddXY("Wstęp", customerServiceResult1);
            chart1.Series["Series4"].Points[0].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("BHP", customerServiceResult1);
            chart1.Series["Series4"].Points[1].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Jakość", customerServiceResult1);
            chart1.Series["Series4"].Points[2].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Serwis", customerServiceResult1);
            valueOfColor = valueOfColorFN(customerServiceProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series4"].Points[3].Color = Color.Red;
                chart1.Series["Series4"].Points[3].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series4"].Points[3].Color = Color.LightGreen;
                chart1.Series["Series4"].Points[3].LabelForeColor = Color.Black;
            }
            chart1.Series["Series4"].Points[3].Label = Math.Round(customerServiceResult1, 1).ToString() + " \nmin";
            chart1.Series["Series4"].Points.AddXY("Efektywność", customerServiceResult1);
            chart1.Series["Series4"].Points[4].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Eureka", customerServiceResult1);
            chart1.Series["Series4"].Points[5].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Projekty", customerServiceResult1);
            chart1.Series["Series4"].Points[6].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Priorytety", customerServiceResult1);
            chart1.Series["Series4"].Points[7].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Wizyty", customerServiceResult1);
            chart1.Series["Series4"].Points[8].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Feedback", customerServiceResult1);
            chart1.Series["Series4"].Points[9].Color = Color.White;
            chart1.Series["Series4"].Points.AddXY("Suma", customerServiceResult1);
            chart1.Series["Series4"].Points[10].Color = Color.White;

            // chart efficiency
            double performanceResult1 = convertResult(performanceResult.Text);
            meetingTime = meetingTime + performanceResult1;
            chart1.Series["Series5"].Points.AddXY("Wstęp", performanceResult1);
            chart1.Series["Series5"].Points[0].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("BHP", performanceResult1);
            chart1.Series["Series5"].Points[1].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Jakość", performanceResult1);
            chart1.Series["Series5"].Points[2].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Serwis", performanceResult1);
            chart1.Series["Series5"].Points[3].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Efektywność", performanceResult1);
            chart1.Series["Series5"].Points[4].Label = Math.Round(performanceResult1, 1).ToString() + " \nmin";
            valueOfColor = valueOfColorFN(performanceProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series5"].Points[4].Color = Color.Red;
                chart1.Series["Series5"].Points[4].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series5"].Points[4].Color = Color.LightGreen;
                chart1.Series["Series5"].Points[4].LabelForeColor = Color.Black;
            }
            chart1.Series["Series5"].Points.AddXY("Eureka", performanceResult1);
            chart1.Series["Series5"].Points[5].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Projekty", performanceResult1);
            chart1.Series["Series5"].Points[6].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Priorytety", performanceResult1);
            chart1.Series["Series5"].Points[7].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Wizyty", performanceResult1);
            chart1.Series["Series5"].Points[8].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Feedback", performanceResult1);
            chart1.Series["Series5"].Points[9].Color = Color.White;
            chart1.Series["Series5"].Points.AddXY("Suma", performanceResult1);
            chart1.Series["Series5"].Points[10].Color = Color.White;

            // chart people
            double peopleResult1 = convertResult(peopleResult.Text);
            meetingTime = meetingTime + peopleResult1;
            chart1.Series["Series6"].Points.AddXY("Wstęp", peopleResult1);
            chart1.Series["Series6"].Points[0].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("BHP", peopleResult1);
            chart1.Series["Series6"].Points[1].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Jakość", peopleResult1);
            chart1.Series["Series6"].Points[2].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Serwis", peopleResult1);
            chart1.Series["Series6"].Points[3].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Efektywność", peopleResult1);
            chart1.Series["Series6"].Points[4].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Eureka", peopleResult1);
            chart1.Series["Series6"].Points[5].Label = Math.Round(peopleResult1, 1).ToString() + " \nmin";
            valueOfColor = valueOfColorFN(peopleProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series6"].Points[5].Color = Color.Red;
                chart1.Series["Series6"].Points[5].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series6"].Points[5].Color = Color.LightGreen;
                chart1.Series["Series6"].Points[5].LabelForeColor = Color.Black;
            }
            chart1.Series["Series6"].Points.AddXY("Projekty", peopleResult1);
            chart1.Series["Series6"].Points[6].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Priorytety", peopleResult1);
            chart1.Series["Series6"].Points[7].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Wizyty", peopleResult1);
            chart1.Series["Series6"].Points[8].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Feedback", peopleResult1);
            chart1.Series["Series6"].Points[9].Color = Color.White;
            chart1.Series["Series6"].Points.AddXY("Suma", peopleResult1);
            chart1.Series["Series6"].Points[10].Color = Color.White;

            // chart projects
            double projectsResult1 = convertResult(projectsResult.Text);
            meetingTime = meetingTime + projectsResult1;
            chart1.Series["Series7"].Points.AddXY("Wstęp", projectsResult1);
            chart1.Series["Series7"].Points[0].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("BHP", projectsResult1);
            chart1.Series["Series7"].Points[1].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Jakość", projectsResult1);
            chart1.Series["Series7"].Points[2].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Serwis", projectsResult1);
            chart1.Series["Series7"].Points[3].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Efektywność", projectsResult1);
            chart1.Series["Series7"].Points[4].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Eureka", projectsResult1);
            chart1.Series["Series7"].Points[5].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Projekty", projectsResult1);
            chart1.Series["Series7"].Points[6].Label = Math.Round(projectsResult1, 1).ToString() + " \nmin";
            valueOfColor = valueOfColorFN(projectsProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series7"].Points[6].Color = Color.Red;
                chart1.Series["Series7"].Points[6].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series7"].Points[6].Color = Color.LightGreen;
                chart1.Series["Series7"].Points[6].LabelForeColor = Color.Black;
            }
            chart1.Series["Series7"].Points.AddXY("Priorytety", projectsResult1);
            chart1.Series["Series7"].Points[7].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Wizyty", projectsResult1);
            chart1.Series["Series7"].Points[8].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Feedback", projectsResult1);
            chart1.Series["Series7"].Points[9].Color = Color.White;
            chart1.Series["Series7"].Points.AddXY("Suma", projectsResult1);
            chart1.Series["Series7"].Points[10].Color = Color.White;

            // chart priority
            double priorityResult1 = convertResult(priorityResult.Text);
            meetingTime = meetingTime + priorityResult1;
            chart1.Series["Series8"].Points.AddXY("Wstęp", priorityResult1);
            chart1.Series["Series8"].Points[0].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("BHP", priorityResult1);
            chart1.Series["Series8"].Points[1].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Jakość", priorityResult1);
            chart1.Series["Series8"].Points[2].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Serwis", priorityResult1);
            chart1.Series["Series8"].Points[3].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Efektywność", priorityResult1);
            chart1.Series["Series8"].Points[4].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Eureka", priorityResult1);
            chart1.Series["Series8"].Points[5].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Projekty", priorityResult1);
            chart1.Series["Series8"].Points[6].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Priorytety", priorityResult1); ;
            chart1.Series["Series8"].Points[7].Label = Math.Round(priorityResult1, 1).ToString() + " \nmin";
            valueOfColor = valueOfColorFN(priorityProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series8"].Points[7].Color = Color.Red;
                chart1.Series["Series8"].Points[7].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series8"].Points[7].Color = Color.LightGreen;
                chart1.Series["Series8"].Points[7].LabelForeColor = Color.Black;
            }
            chart1.Series["Series8"].Points.AddXY("Wizyty", priorityResult1);
            chart1.Series["Series8"].Points[8].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Feedback", priorityResult1);
            chart1.Series["Series8"].Points[9].Color = Color.White;
            chart1.Series["Series8"].Points.AddXY("Suma", priorityResult1);
            chart1.Series["Series8"].Points[10].Color = Color.White;

            // chart visits
            double visitsResult1 = convertResult(visitsResult.Text);
            meetingTime = meetingTime + visitsResult1;
            chart1.Series["Series9"].Points.AddXY("Wstp", visitsResult1);
            chart1.Series["Series9"].Points[0].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("BHP", visitsResult1);
            chart1.Series["Series9"].Points[1].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Jakość", visitsResult1);
            chart1.Series["Series9"].Points[2].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Serwis", visitsResult1);
            chart1.Series["Series9"].Points[3].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Efektywność", visitsResult1);
            chart1.Series["Series9"].Points[4].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Eureka", visitsResult1);
            chart1.Series["Series9"].Points[5].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Projekty", visitsResult1);
            chart1.Series["Series9"].Points[6].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Priorytety", visitsResult1);
            chart1.Series["Series9"].Points[7].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Wizyty", visitsResult1);
            chart1.Series["Series9"].Points[8].Label = Math.Round(visitsResult1, 1).ToString() + " \nmin";
            valueOfColor = valueOfColorFN(visitsProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series9"].Points[8].Color = Color.Red;
                chart1.Series["Series9"].Points[8].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series9"].Points[8].Color = Color.LightGreen;
                chart1.Series["Series9"].Points[8].LabelForeColor = Color.Black;
            }
            chart1.Series["Series9"].Points.AddXY("feedback", visitsResult1);
            chart1.Series["Series9"].Points[9].Color = Color.White;
            chart1.Series["Series9"].Points.AddXY("Suma", visitsResult1);
            chart1.Series["Series9"].Points[10].Color = Color.White;

            // chart feedback
            double feedbackResult1 = convertResult(feedbackResult.Text);
            meetingTime = meetingTime + feedbackResult1;
            chart1.Series["Series10"].Points.AddXY("Wstp", feedbackResult1);
            chart1.Series["Series10"].Points[0].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("BHP", feedbackResult1);
            chart1.Series["Series10"].Points[1].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Jakość", feedbackResult1);
            chart1.Series["Series10"].Points[2].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Serwis", feedbackResult1);
            chart1.Series["Series10"].Points[3].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Efektywność", feedbackResult1);
            chart1.Series["Series10"].Points[4].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Eureka", feedbackResult1);
            chart1.Series["Series10"].Points[5].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Projekty", feedbackResult1);
            chart1.Series["Series10"].Points[6].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Priorytety", feedbackResult1);
            chart1.Series["Series10"].Points[7].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Wizyty", feedbackResult1);
            chart1.Series["Series10"].Points[8].Color = Color.White;
            chart1.Series["Series10"].Points.AddXY("Feedback", feedbackResult1);
            chart1.Series["Series10"].Points[9].Label = Math.Round(feedbackResult1, 1).ToString() + " \nmin";
            valueOfColor = valueOfColorFN(feedbackProgressValue.Text);
            if (valueOfColor > 100)
            {
                chart1.Series["Series10"].Points[9].Color = Color.Red;
                chart1.Series["Series10"].Points[9].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series10"].Points[9].Color = Color.LightGreen;
                chart1.Series["Series10"].Points[9].LabelForeColor = Color.Black;
            }
            chart1.Series["Series10"].Points.AddXY("Suma", feedbackResult1);
            chart1.Series["Series10"].Points[10].Color = Color.White;

            // suma
            chart1.Series["Series11"].Points.AddXY("Wstp", "0");
            chart1.Series["Series11"].Points[0].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("BHP", "0");
            chart1.Series["Series11"].Points[1].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Jakość", "0");
            chart1.Series["Series11"].Points[2].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Serwis", "0");
            chart1.Series["Series11"].Points[3].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Efektywność", "0");
            chart1.Series["Series11"].Points[4].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Eureka", "0");
            chart1.Series["Series11"].Points[5].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Projekty", "0");
            chart1.Series["Series11"].Points[6].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Priorytety", "0");
            chart1.Series["Series11"].Points[7].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Wizyty", "0");
            chart1.Series["Series11"].Points[8].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Feedback", "0");
            chart1.Series["Series11"].Points[9].Color = Color.Transparent;
            chart1.Series["Series11"].Points.AddXY("Suma", "0");
            chart1.Series["Series11"].Points[10].YValues[0] = meetingTime;
            TimeSpan sumOfSetTime = calcSumOfTime();
            Console.WriteLine("sumOfSetTime " + sumOfSetTime);
            double sumOfSetTimeMinute = sumOfSetTime.Minutes + (sumOfSetTime.Seconds / 60);
            Console.WriteLine("sumInMinute " + sumOfSetTimeMinute);
            Console.WriteLine("meetingTime " + meetingTime);
            if (meetingTime > sumOfSetTimeMinute)
            {
                chart1.Series["Series11"].Points[10].Color = Color.Red;
                chart1.Series["Series11"].Points[10].LabelForeColor = Color.White;
            }
            else
            {
                chart1.Series["Series11"].Points[10].Color = Color.LightGreen;
                chart1.Series["Series11"].Points[10].LabelForeColor = Color.Black;
            }
            chart1.Series["Series11"].Points[10].Label = Math.Round(meetingTime, 1).ToString() + " \nmin";


            chart1.ChartAreas[0].AxisY.Maximum = meetingTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
            chart1.Invalidate();

            //chart title  
            chart1.Titles.Add(
             new Title(
                dateTimePicker1.Value.ToString().Substring(0, 10),
                Docking.Top,
                new Font("Verdana", 16f, FontStyle.Bold),
                Color.Black
                )
            );
        }
        private int valueOfColorFN(string text)
        {
            char[] MyChar = { '%', '∞' };
            string NewString = text.TrimEnd(MyChar);
            string trimmed = String.Concat(NewString.Where(c => !Char.IsWhiteSpace(c)));
            Console.WriteLine("valueOfColor: " + trimmed);
            if (trimmed == "")
            {
                return 0;
            }
            else
            {
                return int.Parse(trimmed);
            }

        }
        private double convertResult(string text)
        {
            DateTime result = DateTime.Parse(text);
            Console.WriteLine("minute " + (int)result.Minute);
            Console.WriteLine("second " + (int)result.Second);
            float result2 = (int)result.Minute + ((float)result.Second / 60);
            Console.WriteLine("min/60 " + result2);
            return result2;
        }
        private void CaptureMyScreen()
        {
            try
            {
                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will  
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                captureRectangle.X = ActiveForm.Bounds.X;
                captureRectangle.Y = ActiveForm.Bounds.Y;
                captureRectangle.Width =ActiveForm.Bounds.Width;
                captureRectangle.Height = ActiveForm.Bounds.Height;
                Console.WriteLine("captureRectangle " + captureRectangle.ToString());
                Console.WriteLine("size " + captureRectangle.Size.ToString());
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.X, captureRectangle.Y, captureRectangle.X, captureRectangle.Y, captureRectangle.Size);
                //Saving the Image File (I am here Saving it in My E drive).
                string data = dateTimePicker1.Value.ToString();
                var cleanedFileName = CleanFileName(data).Replace(".","-").Replace(" ","-");
                Console.WriteLine("data " + cleanedFileName);
                captureBitmap.Save( $@"c:\Timekeeper\Capture{cleanedFileName}.jpg", ImageFormat.Jpeg);
                //Displaying the Successfull Result
                MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string CleanFileName(string fileName)
        {
            // return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
            return string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
        }
    }
};