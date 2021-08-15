
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.feedbackTimePicker = new System.Windows.Forms.DateTimePicker();
            this.visitsTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectsTimePicker = new System.Windows.Forms.DateTimePicker();
            this.peopleTimePicker = new System.Windows.Forms.DateTimePicker();
            this.performanceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerServiceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qualityTimePicker = new System.Windows.Forms.DateTimePicker();
            this.safetyTimePicker = new System.Windows.Forms.DateTimePicker();
            this.introTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button12 = new System.Windows.Forms.Button();
            this.feedbackProgressValue = new System.Windows.Forms.Label();
            this.visitsProgressValue = new System.Windows.Forms.Label();
            this.priorityProgressValue = new System.Windows.Forms.Label();
            this.projectsProgressValue = new System.Windows.Forms.Label();
            this.peopleProgressValue = new System.Windows.Forms.Label();
            this.performanceProgressValue = new System.Windows.Forms.Label();
            this.customerServiceProgressValue = new System.Windows.Forms.Label();
            this.qualityProgressValue = new System.Windows.Forms.Label();
            this.feedbackResult = new System.Windows.Forms.Label();
            this.feedbackEnd = new System.Windows.Forms.Label();
            this.feedbackStart = new System.Windows.Forms.Label();
            this.visitsResult = new System.Windows.Forms.Label();
            this.visitsEnd = new System.Windows.Forms.Label();
            this.visitsStart = new System.Windows.Forms.Label();
            this.priorityResult = new System.Windows.Forms.Label();
            this.priorityEnd = new System.Windows.Forms.Label();
            this.priorityStart = new System.Windows.Forms.Label();
            this.projectsResult = new System.Windows.Forms.Label();
            this.projectsEnd = new System.Windows.Forms.Label();
            this.projectsStart = new System.Windows.Forms.Label();
            this.peopleResult = new System.Windows.Forms.Label();
            this.peopleEnd = new System.Windows.Forms.Label();
            this.peopleStart = new System.Windows.Forms.Label();
            this.performanceResult = new System.Windows.Forms.Label();
            this.performanceEnd = new System.Windows.Forms.Label();
            this.performanceStart = new System.Windows.Forms.Label();
            this.customerServiceResult = new System.Windows.Forms.Label();
            this.customerServiceEnd = new System.Windows.Forms.Label();
            this.customerServiceStart = new System.Windows.Forms.Label();
            this.qualityResult = new System.Windows.Forms.Label();
            this.qualityEnd = new System.Windows.Forms.Label();
            this.qualityStart = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.safetyProgressValue = new System.Windows.Forms.Label();
            this.introProgressValue = new System.Windows.Forms.Label();
            this.safetyResult = new System.Windows.Forms.Label();
            this.safetyEnd = new System.Windows.Forms.Label();
            this.safetyStart = new System.Windows.Forms.Label();
            this.introStart = new System.Windows.Forms.Label();
            this.feedbackProgressBar = new System.Windows.Forms.ProgressBar();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.visitsProgressBar = new System.Windows.Forms.ProgressBar();
            this.visitsButton = new System.Windows.Forms.Button();
            this.priorityProgressBar = new System.Windows.Forms.ProgressBar();
            this.priorityButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.feedbackTitle = new System.Windows.Forms.Label();
            this.visitsTitle = new System.Windows.Forms.Label();
            this.priorityTitle = new System.Windows.Forms.Label();
            this.projectsProgressBar = new System.Windows.Forms.ProgressBar();
            this.projectsButton = new System.Windows.Forms.Button();
            this.projectsTitle = new System.Windows.Forms.Label();
            this.peopleProgressBar = new System.Windows.Forms.ProgressBar();
            this.peopleButton = new System.Windows.Forms.Button();
            this.peopleTitle = new System.Windows.Forms.Label();
            this.performanceProgressBar = new System.Windows.Forms.ProgressBar();
            this.performanceButton = new System.Windows.Forms.Button();
            this.performanceTitle = new System.Windows.Forms.Label();
            this.customerServiceProgressBar = new System.Windows.Forms.ProgressBar();
            this.customerServiceButton = new System.Windows.Forms.Button();
            this.customerServiceTitle = new System.Windows.Forms.Label();
            this.qualityProgressBar = new System.Windows.Forms.ProgressBar();
            this.qualityButton = new System.Windows.Forms.Button();
            this.qualityTitle = new System.Windows.Forms.Label();
            this.safetyProgressBar = new System.Windows.Forms.ProgressBar();
            this.safetButton = new System.Windows.Forms.Button();
            this.introProgressBar = new System.Windows.Forms.ProgressBar();
            this.safetyTitle = new System.Windows.Forms.Label();
            this.introResult = new System.Windows.Forms.Label();
            this.introEnd = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.introButton = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.introTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 610);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);

            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.feedbackTimePicker);
            this.tabPage1.Controls.Add(this.visitsTimePicker);
            this.tabPage1.Controls.Add(this.priorityTimePicker);
            this.tabPage1.Controls.Add(this.projectsTimePicker);
            this.tabPage1.Controls.Add(this.peopleTimePicker);
            this.tabPage1.Controls.Add(this.performanceTimePicker);
            this.tabPage1.Controls.Add(this.customerServiceTimePicker);
            this.tabPage1.Controls.Add(this.qualityTimePicker);
            this.tabPage1.Controls.Add(this.safetyTimePicker);
            this.tabPage1.Controls.Add(this.introTimePicker);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.feedbackProgressValue);
            this.tabPage1.Controls.Add(this.visitsProgressValue);
            this.tabPage1.Controls.Add(this.priorityProgressValue);
            this.tabPage1.Controls.Add(this.projectsProgressValue);
            this.tabPage1.Controls.Add(this.peopleProgressValue);
            this.tabPage1.Controls.Add(this.performanceProgressValue);
            this.tabPage1.Controls.Add(this.customerServiceProgressValue);
            this.tabPage1.Controls.Add(this.qualityProgressValue);
            this.tabPage1.Controls.Add(this.feedbackResult);
            this.tabPage1.Controls.Add(this.feedbackEnd);
            this.tabPage1.Controls.Add(this.feedbackStart);
            this.tabPage1.Controls.Add(this.visitsResult);
            this.tabPage1.Controls.Add(this.visitsEnd);
            this.tabPage1.Controls.Add(this.visitsStart);
            this.tabPage1.Controls.Add(this.priorityResult);
            this.tabPage1.Controls.Add(this.priorityEnd);
            this.tabPage1.Controls.Add(this.priorityStart);
            this.tabPage1.Controls.Add(this.projectsResult);
            this.tabPage1.Controls.Add(this.projectsEnd);
            this.tabPage1.Controls.Add(this.projectsStart);
            this.tabPage1.Controls.Add(this.peopleResult);
            this.tabPage1.Controls.Add(this.peopleEnd);
            this.tabPage1.Controls.Add(this.peopleStart);
            this.tabPage1.Controls.Add(this.performanceResult);
            this.tabPage1.Controls.Add(this.performanceEnd);
            this.tabPage1.Controls.Add(this.performanceStart);
            this.tabPage1.Controls.Add(this.customerServiceResult);
            this.tabPage1.Controls.Add(this.customerServiceEnd);
            this.tabPage1.Controls.Add(this.customerServiceStart);
            this.tabPage1.Controls.Add(this.qualityResult);
            this.tabPage1.Controls.Add(this.qualityEnd);
            this.tabPage1.Controls.Add(this.qualityStart);
            this.tabPage1.Controls.Add(this.stopButton);
            this.tabPage1.Controls.Add(this.safetyProgressValue);
            this.tabPage1.Controls.Add(this.introProgressValue);
            this.tabPage1.Controls.Add(this.safetyResult);
            this.tabPage1.Controls.Add(this.safetyEnd);
            this.tabPage1.Controls.Add(this.safetyStart);
            this.tabPage1.Controls.Add(this.introStart);
            this.tabPage1.Controls.Add(this.feedbackProgressBar);
            this.tabPage1.Controls.Add(this.feedbackButton);
            this.tabPage1.Controls.Add(this.visitsProgressBar);
            this.tabPage1.Controls.Add(this.visitsButton);
            this.tabPage1.Controls.Add(this.priorityProgressBar);
            this.tabPage1.Controls.Add(this.priorityButton);
            this.tabPage1.Controls.Add(this.timeLabel);
            this.tabPage1.Controls.Add(this.feedbackTitle);
            this.tabPage1.Controls.Add(this.visitsTitle);
            this.tabPage1.Controls.Add(this.priorityTitle);
            this.tabPage1.Controls.Add(this.projectsProgressBar);
            this.tabPage1.Controls.Add(this.projectsButton);
            this.tabPage1.Controls.Add(this.projectsTitle);
            this.tabPage1.Controls.Add(this.peopleProgressBar);
            this.tabPage1.Controls.Add(this.peopleButton);
            this.tabPage1.Controls.Add(this.peopleTitle);
            this.tabPage1.Controls.Add(this.performanceProgressBar);
            this.tabPage1.Controls.Add(this.performanceButton);
            this.tabPage1.Controls.Add(this.performanceTitle);
            this.tabPage1.Controls.Add(this.customerServiceProgressBar);
            this.tabPage1.Controls.Add(this.customerServiceButton);
            this.tabPage1.Controls.Add(this.customerServiceTitle);
            this.tabPage1.Controls.Add(this.qualityProgressBar);
            this.tabPage1.Controls.Add(this.qualityButton);
            this.tabPage1.Controls.Add(this.qualityTitle);
            this.tabPage1.Controls.Add(this.safetyProgressBar);
            this.tabPage1.Controls.Add(this.safetButton);
            this.tabPage1.Controls.Add(this.introProgressBar);
            this.tabPage1.Controls.Add(this.safetyTitle);
            this.tabPage1.Controls.Add(this.introResult);
            this.tabPage1.Controls.Add(this.introEnd);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.endLabel);
            this.tabPage1.Controls.Add(this.startLabel);
            this.tabPage1.Controls.Add(this.dataLabel);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.introButton);
            this.tabPage1.Controls.Add(this.currentTime);
            this.tabPage1.Controls.Add(this.introTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(927, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pomiary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // feedbackTimePicker
            // 
            this.feedbackTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.feedbackTimePicker.CustomFormat = "mm:ss";
            this.feedbackTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.feedbackTimePicker.Location = new System.Drawing.Point(180, 458);
            this.feedbackTimePicker.Name = "feedbackTimePicker";
            this.feedbackTimePicker.ShowUpDown = true;
            this.feedbackTimePicker.Size = new System.Drawing.Size(90, 29);
            this.feedbackTimePicker.TabIndex = 109;
            this.feedbackTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 1, 0, 0);
            // 
            // visitsTimePicker
            // 
            this.visitsTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.visitsTimePicker.CustomFormat = "mm:ss";
            this.visitsTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.visitsTimePicker.Location = new System.Drawing.Point(180, 421);
            this.visitsTimePicker.Name = "visitsTimePicker";
            this.visitsTimePicker.ShowUpDown = true;
            this.visitsTimePicker.Size = new System.Drawing.Size(90, 29);
            this.visitsTimePicker.TabIndex = 108;
            this.visitsTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 2, 0, 0);
            // 
            // priorityTimePicker
            // 
            this.priorityTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.priorityTimePicker.CustomFormat = "mm:ss";
            this.priorityTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.priorityTimePicker.Location = new System.Drawing.Point(180, 381);
            this.priorityTimePicker.Name = "priorityTimePicker";
            this.priorityTimePicker.ShowUpDown = true;
            this.priorityTimePicker.Size = new System.Drawing.Size(90, 29);
            this.priorityTimePicker.TabIndex = 107;
            this.priorityTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 3, 0, 0);
            // 
            // projectsTimePicker
            // 
            this.projectsTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.projectsTimePicker.CustomFormat = "mm:ss";
            this.projectsTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.projectsTimePicker.Location = new System.Drawing.Point(180, 339);
            this.projectsTimePicker.Name = "projectsTimePicker";
            this.projectsTimePicker.ShowUpDown = true;
            this.projectsTimePicker.Size = new System.Drawing.Size(90, 29);
            this.projectsTimePicker.TabIndex = 106;
            this.projectsTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 3, 0, 0);
            // 
            // peopleTimePicker
            // 
            this.peopleTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.peopleTimePicker.CustomFormat = "mm:ss";
            this.peopleTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.peopleTimePicker.Location = new System.Drawing.Point(180, 297);
            this.peopleTimePicker.Name = "peopleTimePicker";
            this.peopleTimePicker.ShowUpDown = true;
            this.peopleTimePicker.Size = new System.Drawing.Size(90, 29);
            this.peopleTimePicker.TabIndex = 105;
            this.peopleTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 2, 0, 0);
            // 
            // performanceTimePicker
            // 
            this.performanceTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.performanceTimePicker.CustomFormat = "mm:ss";
            this.performanceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.performanceTimePicker.Location = new System.Drawing.Point(180, 258);
            this.performanceTimePicker.Name = "performanceTimePicker";
            this.performanceTimePicker.ShowUpDown = true;
            this.performanceTimePicker.Size = new System.Drawing.Size(90, 29);
            this.performanceTimePicker.TabIndex = 104;
            this.performanceTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 5, 0, 0);
            // 
            // customerServiceTimePicker
            // 
            this.customerServiceTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.customerServiceTimePicker.CustomFormat = "mm:ss";
            this.customerServiceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customerServiceTimePicker.Location = new System.Drawing.Point(180, 218);
            this.customerServiceTimePicker.Name = "customerServiceTimePicker";
            this.customerServiceTimePicker.ShowUpDown = true;
            this.customerServiceTimePicker.Size = new System.Drawing.Size(90, 29);
            this.customerServiceTimePicker.TabIndex = 103;
            this.customerServiceTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 3, 0, 0);
            // 
            // qualityTimePicker
            // 
            this.qualityTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.qualityTimePicker.CustomFormat = "mm:ss";
            this.qualityTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qualityTimePicker.Location = new System.Drawing.Point(180, 177);
            this.qualityTimePicker.Name = "qualityTimePicker";
            this.qualityTimePicker.ShowUpDown = true;
            this.qualityTimePicker.Size = new System.Drawing.Size(90, 29);
            this.qualityTimePicker.TabIndex = 102;
            this.qualityTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 3, 0, 0);
            // 
            // safetyTimePicker
            // 
            this.safetyTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.safetyTimePicker.CustomFormat = "mm:ss";
            this.safetyTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.safetyTimePicker.Location = new System.Drawing.Point(180, 140);
            this.safetyTimePicker.Name = "safetyTimePicker";
            this.safetyTimePicker.ShowUpDown = true;
            this.safetyTimePicker.Size = new System.Drawing.Size(90, 29);
            this.safetyTimePicker.TabIndex = 101;
            this.safetyTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 3, 0, 0);
            // 
            // introTimePicker
            // 
            this.introTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.introTimePicker.CustomFormat = "mm:ss";
            this.introTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.introTimePicker.Location = new System.Drawing.Point(180, 97);
            this.introTimePicker.Name = "introTimePicker";
            this.introTimePicker.ShowUpDown = true;
            this.introTimePicker.Size = new System.Drawing.Size(90, 29);
            this.introTimePicker.TabIndex = 100;
            this.introTimePicker.Value = new System.DateTime(2021, 8, 8, 0, 1, 0, 0);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(798, 528);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(113, 33);
            this.button12.TabIndex = 99;
            this.button12.Text = "Wyczyść";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // feedbackProgressValue
            // 
            this.feedbackProgressValue.AutoSize = true;
            this.feedbackProgressValue.BackColor = System.Drawing.Color.White;
            this.feedbackProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feedbackProgressValue.Location = new System.Drawing.Point(429, 458);
            this.feedbackProgressValue.Name = "feedbackProgressValue";
            this.feedbackProgressValue.Size = new System.Drawing.Size(0, 20);
            this.feedbackProgressValue.TabIndex = 98;
            // 
            // visitsProgressValue
            // 
            this.visitsProgressValue.AutoSize = true;
            this.visitsProgressValue.BackColor = System.Drawing.Color.White;
            this.visitsProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visitsProgressValue.Location = new System.Drawing.Point(429, 421);
            this.visitsProgressValue.Name = "visitsProgressValue";
            this.visitsProgressValue.Size = new System.Drawing.Size(0, 20);
            this.visitsProgressValue.TabIndex = 97;
            // 
            // priorityProgressValue
            // 
            this.priorityProgressValue.AutoSize = true;
            this.priorityProgressValue.BackColor = System.Drawing.Color.White;
            this.priorityProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priorityProgressValue.Location = new System.Drawing.Point(429, 387);
            this.priorityProgressValue.Name = "priorityProgressValue";
            this.priorityProgressValue.Size = new System.Drawing.Size(0, 20);
            this.priorityProgressValue.TabIndex = 96;
            // 
            // projectsProgressValue
            // 
            this.projectsProgressValue.AutoSize = true;
            this.projectsProgressValue.BackColor = System.Drawing.Color.White;
            this.projectsProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectsProgressValue.Location = new System.Drawing.Point(429, 343);
            this.projectsProgressValue.Name = "projectsProgressValue";
            this.projectsProgressValue.Size = new System.Drawing.Size(0, 20);
            this.projectsProgressValue.TabIndex = 95;
            // 
            // peopleProgressValue
            // 
            this.peopleProgressValue.AutoSize = true;
            this.peopleProgressValue.BackColor = System.Drawing.Color.White;
            this.peopleProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleProgressValue.Location = new System.Drawing.Point(429, 303);
            this.peopleProgressValue.Name = "peopleProgressValue";
            this.peopleProgressValue.Size = new System.Drawing.Size(0, 20);
            this.peopleProgressValue.TabIndex = 94;
            // 
            // performanceProgressValue
            // 
            this.performanceProgressValue.AutoSize = true;
            this.performanceProgressValue.BackColor = System.Drawing.Color.White;
            this.performanceProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.performanceProgressValue.Location = new System.Drawing.Point(429, 262);
            this.performanceProgressValue.Name = "performanceProgressValue";
            this.performanceProgressValue.Size = new System.Drawing.Size(0, 20);
            this.performanceProgressValue.TabIndex = 93;
            // 
            // customerServiceProgressValue
            // 
            this.customerServiceProgressValue.AutoSize = true;
            this.customerServiceProgressValue.BackColor = System.Drawing.Color.White;
            this.customerServiceProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customerServiceProgressValue.Location = new System.Drawing.Point(429, 219);
            this.customerServiceProgressValue.Name = "customerServiceProgressValue";
            this.customerServiceProgressValue.Size = new System.Drawing.Size(0, 20);
            this.customerServiceProgressValue.TabIndex = 92;
            // 
            // qualityProgressValue
            // 
            this.qualityProgressValue.AutoSize = true;
            this.qualityProgressValue.BackColor = System.Drawing.Color.White;
            this.qualityProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.qualityProgressValue.Location = new System.Drawing.Point(429, 181);
            this.qualityProgressValue.Name = "qualityProgressValue";
            this.qualityProgressValue.Size = new System.Drawing.Size(0, 20);
            this.qualityProgressValue.TabIndex = 91;
            // 
            // feedbackResult
            // 
            this.feedbackResult.AutoSize = true;
            this.feedbackResult.Location = new System.Drawing.Point(820, 454);
            this.feedbackResult.Name = "feedbackResult";
            this.feedbackResult.Size = new System.Drawing.Size(0, 24);
            this.feedbackResult.TabIndex = 90;
            // 
            // feedbackEnd
            // 
            this.feedbackEnd.AutoSize = true;
            this.feedbackEnd.Location = new System.Drawing.Point(688, 454);
            this.feedbackEnd.Name = "feedbackEnd";
            this.feedbackEnd.Size = new System.Drawing.Size(0, 24);
            this.feedbackEnd.TabIndex = 89;
            // 
            // feedbackStart
            // 
            this.feedbackStart.AutoSize = true;
            this.feedbackStart.Location = new System.Drawing.Point(551, 454);
            this.feedbackStart.Name = "feedbackStart";
            this.feedbackStart.Size = new System.Drawing.Size(0, 24);
            this.feedbackStart.TabIndex = 88;
            // 
            // visitsResult
            // 
            this.visitsResult.AutoSize = true;
            this.visitsResult.Location = new System.Drawing.Point(820, 418);
            this.visitsResult.Name = "visitsResult";
            this.visitsResult.Size = new System.Drawing.Size(0, 24);
            this.visitsResult.TabIndex = 87;
            // 
            // visitsEnd
            // 
            this.visitsEnd.AutoSize = true;
            this.visitsEnd.Location = new System.Drawing.Point(688, 421);
            this.visitsEnd.Name = "visitsEnd";
            this.visitsEnd.Size = new System.Drawing.Size(0, 24);
            this.visitsEnd.TabIndex = 86;
            // 
            // visitsStart
            // 
            this.visitsStart.AutoSize = true;
            this.visitsStart.Location = new System.Drawing.Point(551, 420);
            this.visitsStart.Name = "visitsStart";
            this.visitsStart.Size = new System.Drawing.Size(0, 24);
            this.visitsStart.TabIndex = 85;
            // 
            // priorityResult
            // 
            this.priorityResult.AutoSize = true;
            this.priorityResult.Location = new System.Drawing.Point(820, 380);
            this.priorityResult.Name = "priorityResult";
            this.priorityResult.Size = new System.Drawing.Size(0, 24);
            this.priorityResult.TabIndex = 84;
            // 
            // priorityEnd
            // 
            this.priorityEnd.AutoSize = true;
            this.priorityEnd.Location = new System.Drawing.Point(688, 384);
            this.priorityEnd.Name = "priorityEnd";
            this.priorityEnd.Size = new System.Drawing.Size(0, 24);
            this.priorityEnd.TabIndex = 83;
            // 
            // priorityStart
            // 
            this.priorityStart.AutoSize = true;
            this.priorityStart.Location = new System.Drawing.Point(551, 381);
            this.priorityStart.Name = "priorityStart";
            this.priorityStart.Size = new System.Drawing.Size(0, 24);
            this.priorityStart.TabIndex = 82;
            // 
            // projectsResult
            // 
            this.projectsResult.AutoSize = true;
            this.projectsResult.Location = new System.Drawing.Point(820, 339);
            this.projectsResult.Name = "projectsResult";
            this.projectsResult.Size = new System.Drawing.Size(0, 24);
            this.projectsResult.TabIndex = 81;
            // 
            // projectsEnd
            // 
            this.projectsEnd.AutoSize = true;
            this.projectsEnd.Location = new System.Drawing.Point(688, 343);
            this.projectsEnd.Name = "projectsEnd";
            this.projectsEnd.Size = new System.Drawing.Size(0, 24);
            this.projectsEnd.TabIndex = 80;
            // 
            // projectsStart
            // 
            this.projectsStart.AutoSize = true;
            this.projectsStart.Location = new System.Drawing.Point(551, 339);
            this.projectsStart.Name = "projectsStart";
            this.projectsStart.Size = new System.Drawing.Size(0, 24);
            this.projectsStart.TabIndex = 79;
            // 
            // peopleResult
            // 
            this.peopleResult.AutoSize = true;
            this.peopleResult.Location = new System.Drawing.Point(820, 297);
            this.peopleResult.Name = "peopleResult";
            this.peopleResult.Size = new System.Drawing.Size(0, 24);
            this.peopleResult.TabIndex = 78;
            // 
            // peopleEnd
            // 
            this.peopleEnd.AutoSize = true;
            this.peopleEnd.Location = new System.Drawing.Point(688, 300);
            this.peopleEnd.Name = "peopleEnd";
            this.peopleEnd.Size = new System.Drawing.Size(0, 24);
            this.peopleEnd.TabIndex = 77;
            // 
            // peopleStart
            // 
            this.peopleStart.AutoSize = true;
            this.peopleStart.Location = new System.Drawing.Point(551, 297);
            this.peopleStart.Name = "peopleStart";
            this.peopleStart.Size = new System.Drawing.Size(0, 24);
            this.peopleStart.TabIndex = 76;
            // 
            // performanceResult
            // 
            this.performanceResult.AutoSize = true;
            this.performanceResult.Location = new System.Drawing.Point(820, 258);
            this.performanceResult.Name = "performanceResult";
            this.performanceResult.Size = new System.Drawing.Size(0, 24);
            this.performanceResult.TabIndex = 75;
            // 
            // performanceEnd
            // 
            this.performanceEnd.AutoSize = true;
            this.performanceEnd.Location = new System.Drawing.Point(688, 258);
            this.performanceEnd.Name = "performanceEnd";
            this.performanceEnd.Size = new System.Drawing.Size(0, 24);
            this.performanceEnd.TabIndex = 74;
            // 
            // performanceStart
            // 
            this.performanceStart.AutoSize = true;
            this.performanceStart.Location = new System.Drawing.Point(551, 259);
            this.performanceStart.Name = "performanceStart";
            this.performanceStart.Size = new System.Drawing.Size(0, 24);
            this.performanceStart.TabIndex = 73;
            // 
            // customerServiceResult
            // 
            this.customerServiceResult.AutoSize = true;
            this.customerServiceResult.Location = new System.Drawing.Point(820, 219);
            this.customerServiceResult.Name = "customerServiceResult";
            this.customerServiceResult.Size = new System.Drawing.Size(0, 24);
            this.customerServiceResult.TabIndex = 72;
            // 
            // customerServiceEnd
            // 
            this.customerServiceEnd.AutoSize = true;
            this.customerServiceEnd.Location = new System.Drawing.Point(688, 218);
            this.customerServiceEnd.Name = "customerServiceEnd";
            this.customerServiceEnd.Size = new System.Drawing.Size(0, 24);
            this.customerServiceEnd.TabIndex = 71;
            // 
            // customerServiceStart
            // 
            this.customerServiceStart.AutoSize = true;
            this.customerServiceStart.Location = new System.Drawing.Point(551, 219);
            this.customerServiceStart.Name = "customerServiceStart";
            this.customerServiceStart.Size = new System.Drawing.Size(0, 24);
            this.customerServiceStart.TabIndex = 70;
            // 
            // qualityResult
            // 
            this.qualityResult.AutoSize = true;
            this.qualityResult.Location = new System.Drawing.Point(820, 179);
            this.qualityResult.Name = "qualityResult";
            this.qualityResult.Size = new System.Drawing.Size(0, 24);
            this.qualityResult.TabIndex = 69;
            // 
            // qualityEnd
            // 
            this.qualityEnd.AutoSize = true;
            this.qualityEnd.Location = new System.Drawing.Point(688, 179);
            this.qualityEnd.Name = "qualityEnd";
            this.qualityEnd.Size = new System.Drawing.Size(0, 24);
            this.qualityEnd.TabIndex = 68;
            // 
            // qualityStart
            // 
            this.qualityStart.AutoSize = true;
            this.qualityStart.Location = new System.Drawing.Point(551, 179);
            this.qualityStart.Name = "qualityStart";
            this.qualityStart.Size = new System.Drawing.Size(0, 24);
            this.qualityStart.TabIndex = 67;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(302, 493);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(89, 32);
            this.stopButton.TabIndex = 66;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // safetyProgressValue
            // 
            this.safetyProgressValue.AutoSize = true;
            this.safetyProgressValue.BackColor = System.Drawing.Color.White;
            this.safetyProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.safetyProgressValue.Location = new System.Drawing.Point(429, 145);
            this.safetyProgressValue.Name = "safetyProgressValue";
            this.safetyProgressValue.Size = new System.Drawing.Size(0, 20);
            this.safetyProgressValue.TabIndex = 65;
            // 
            // introProgressValue
            // 
            this.introProgressValue.AutoSize = true;
            this.introProgressValue.BackColor = System.Drawing.Color.White;
            this.introProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.introProgressValue.Location = new System.Drawing.Point(429, 102);
            this.introProgressValue.Name = "introProgressValue";
            this.introProgressValue.Size = new System.Drawing.Size(0, 20);
            this.introProgressValue.TabIndex = 65;
            // 
            // safetyResult
            // 
            this.safetyResult.AutoSize = true;
            this.safetyResult.Location = new System.Drawing.Point(820, 142);
            this.safetyResult.Name = "safetyResult";
            this.safetyResult.Size = new System.Drawing.Size(0, 24);
            this.safetyResult.TabIndex = 64;
            // 
            // safetyEnd
            // 
            this.safetyEnd.AutoSize = true;
            this.safetyEnd.Location = new System.Drawing.Point(688, 142);
            this.safetyEnd.Name = "safetyEnd";
            this.safetyEnd.Size = new System.Drawing.Size(0, 24);
            this.safetyEnd.TabIndex = 63;
            // 
            // safetyStart
            // 
            this.safetyStart.AutoSize = true;
            this.safetyStart.Location = new System.Drawing.Point(551, 141);
            this.safetyStart.Name = "safetyStart";
            this.safetyStart.Size = new System.Drawing.Size(0, 24);
            this.safetyStart.TabIndex = 62;
            // 
            // introStart
            // 
            this.introStart.AutoSize = true;
            this.introStart.Location = new System.Drawing.Point(551, 101);
            this.introStart.Name = "introStart";
            this.introStart.Size = new System.Drawing.Size(0, 24);
            this.introStart.TabIndex = 61;
            // 
            // feedbackProgressBar
            // 
            this.feedbackProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.feedbackProgressBar.Location = new System.Drawing.Point(401, 454);
            this.feedbackProgressBar.Name = "feedbackProgressBar";
            this.feedbackProgressBar.Size = new System.Drawing.Size(103, 31);
            this.feedbackProgressBar.TabIndex = 59;
            // 
            // feedbackButton
            // 
            this.feedbackButton.Location = new System.Drawing.Point(302, 454);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(89, 31);
            this.feedbackButton.TabIndex = 58;
            this.feedbackButton.Text = "Start";
            this.feedbackButton.UseVisualStyleBackColor = true;
            this.feedbackButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // visitsProgressBar
            // 
            this.visitsProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.visitsProgressBar.Location = new System.Drawing.Point(401, 417);
            this.visitsProgressBar.Name = "visitsProgressBar";
            this.visitsProgressBar.Size = new System.Drawing.Size(103, 31);
            this.visitsProgressBar.TabIndex = 55;
            // 
            // visitsButton
            // 
            this.visitsButton.Location = new System.Drawing.Point(302, 417);
            this.visitsButton.Name = "visitsButton";
            this.visitsButton.Size = new System.Drawing.Size(89, 31);
            this.visitsButton.TabIndex = 54;
            this.visitsButton.Text = "Start";
            this.visitsButton.UseVisualStyleBackColor = true;
            this.visitsButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // priorityProgressBar
            // 
            this.priorityProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.priorityProgressBar.Location = new System.Drawing.Point(401, 380);
            this.priorityProgressBar.Name = "priorityProgressBar";
            this.priorityProgressBar.Size = new System.Drawing.Size(103, 31);
            this.priorityProgressBar.TabIndex = 51;
            // 
            // priorityButton
            // 
            this.priorityButton.Location = new System.Drawing.Point(302, 380);
            this.priorityButton.Name = "priorityButton";
            this.priorityButton.Size = new System.Drawing.Size(89, 31);
            this.priorityButton.TabIndex = 50;
            this.priorityButton.Text = "Start";
            this.priorityButton.UseVisualStyleBackColor = true;
            this.priorityButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(166, 60);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(97, 24);
            this.timeLabel.TabIndex = 41;
            this.timeLabel.Text = "Czas [min]";
            // 
            // feedbackTitle
            // 
            this.feedbackTitle.AutoSize = true;
            this.feedbackTitle.Location = new System.Drawing.Point(20, 464);
            this.feedbackTitle.Name = "feedbackTitle";
            this.feedbackTitle.Size = new System.Drawing.Size(100, 24);
            this.feedbackTitle.TabIndex = 40;
            this.feedbackTitle.Text = "Feedback ";
            // 
            // visitsTitle
            // 
            this.visitsTitle.AutoSize = true;
            this.visitsTitle.Location = new System.Drawing.Point(22, 421);
            this.visitsTitle.Name = "visitsTitle";
            this.visitsTitle.Size = new System.Drawing.Size(63, 24);
            this.visitsTitle.TabIndex = 39;
            this.visitsTitle.Text = "Wizyty";
            // 
            // priorityTitle
            // 
            this.priorityTitle.AutoSize = true;
            this.priorityTitle.Location = new System.Drawing.Point(20, 384);
            this.priorityTitle.Name = "priorityTitle";
            this.priorityTitle.Size = new System.Drawing.Size(86, 24);
            this.priorityTitle.TabIndex = 38;
            this.priorityTitle.Text = "Priorytety";
            // 
            // projectsProgressBar
            // 
            this.projectsProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectsProgressBar.Location = new System.Drawing.Point(401, 339);
            this.projectsProgressBar.Name = "projectsProgressBar";
            this.projectsProgressBar.Size = new System.Drawing.Size(103, 31);
            this.projectsProgressBar.TabIndex = 37;
            // 
            // projectsButton
            // 
            this.projectsButton.Location = new System.Drawing.Point(302, 339);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Size = new System.Drawing.Size(89, 31);
            this.projectsButton.TabIndex = 36;
            this.projectsButton.Text = "Start";
            this.projectsButton.UseVisualStyleBackColor = true;
            this.projectsButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // projectsTitle
            // 
            this.projectsTitle.AutoSize = true;
            this.projectsTitle.Location = new System.Drawing.Point(22, 342);
            this.projectsTitle.Name = "projectsTitle";
            this.projectsTitle.Size = new System.Drawing.Size(76, 24);
            this.projectsTitle.TabIndex = 34;
            this.projectsTitle.Text = "Projekty";
            // 
            // peopleProgressBar
            // 
            this.peopleProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.peopleProgressBar.Location = new System.Drawing.Point(401, 297);
            this.peopleProgressBar.Name = "peopleProgressBar";
            this.peopleProgressBar.Size = new System.Drawing.Size(103, 30);
            this.peopleProgressBar.TabIndex = 33;
            // 
            // peopleButton
            // 
            this.peopleButton.Location = new System.Drawing.Point(302, 297);
            this.peopleButton.Name = "peopleButton";
            this.peopleButton.Size = new System.Drawing.Size(89, 30);
            this.peopleButton.TabIndex = 32;
            this.peopleButton.Text = "Start";
            this.peopleButton.UseVisualStyleBackColor = true;
            this.peopleButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // peopleTitle
            // 
            this.peopleTitle.AutoSize = true;
            this.peopleTitle.Location = new System.Drawing.Point(20, 299);
            this.peopleTitle.Name = "peopleTitle";
            this.peopleTitle.Size = new System.Drawing.Size(70, 24);
            this.peopleTitle.TabIndex = 30;
            this.peopleTitle.Text = "Eureka";
            // 
            // performanceProgressBar
            // 
            this.performanceProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.performanceProgressBar.Location = new System.Drawing.Point(401, 256);
            this.performanceProgressBar.Name = "performanceProgressBar";
            this.performanceProgressBar.Size = new System.Drawing.Size(103, 30);
            this.performanceProgressBar.TabIndex = 29;
            // 
            // performanceButton
            // 
            this.performanceButton.Location = new System.Drawing.Point(302, 255);
            this.performanceButton.Name = "performanceButton";
            this.performanceButton.Size = new System.Drawing.Size(89, 30);
            this.performanceButton.TabIndex = 28;
            this.performanceButton.Text = "Start";
            this.performanceButton.UseVisualStyleBackColor = true;
            this.performanceButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // performanceTitle
            // 
            this.performanceTitle.AutoSize = true;
            this.performanceTitle.Location = new System.Drawing.Point(22, 258);
            this.performanceTitle.Name = "performanceTitle";
            this.performanceTitle.Size = new System.Drawing.Size(115, 24);
            this.performanceTitle.TabIndex = 26;
            this.performanceTitle.Text = "Efektywność";
            // 
            // customerServiceProgressBar
            // 
            this.customerServiceProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerServiceProgressBar.Location = new System.Drawing.Point(401, 214);
            this.customerServiceProgressBar.Name = "customerServiceProgressBar";
            this.customerServiceProgressBar.Size = new System.Drawing.Size(103, 30);
            this.customerServiceProgressBar.TabIndex = 25;
            // 
            // customerServiceButton
            // 
            this.customerServiceButton.Location = new System.Drawing.Point(302, 215);
            this.customerServiceButton.Name = "customerServiceButton";
            this.customerServiceButton.Size = new System.Drawing.Size(89, 30);
            this.customerServiceButton.TabIndex = 24;
            this.customerServiceButton.Text = "Start";
            this.customerServiceButton.UseVisualStyleBackColor = true;
            this.customerServiceButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // customerServiceTitle
            // 
            this.customerServiceTitle.AutoSize = true;
            this.customerServiceTitle.Location = new System.Drawing.Point(20, 218);
            this.customerServiceTitle.Name = "customerServiceTitle";
            this.customerServiceTitle.Size = new System.Drawing.Size(66, 24);
            this.customerServiceTitle.TabIndex = 22;
            this.customerServiceTitle.Text = "Serwis";
            // 
            // qualityProgressBar
            // 
            this.qualityProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qualityProgressBar.Location = new System.Drawing.Point(401, 176);
            this.qualityProgressBar.Name = "qualityProgressBar";
            this.qualityProgressBar.Size = new System.Drawing.Size(103, 30);
            this.qualityProgressBar.TabIndex = 21;
            // 
            // qualityButton
            // 
            this.qualityButton.Location = new System.Drawing.Point(302, 176);
            this.qualityButton.Name = "qualityButton";
            this.qualityButton.Size = new System.Drawing.Size(89, 30);
            this.qualityButton.TabIndex = 20;
            this.qualityButton.Text = "Start";
            this.qualityButton.UseVisualStyleBackColor = true;
            this.qualityButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // qualityTitle
            // 
            this.qualityTitle.AutoSize = true;
            this.qualityTitle.Location = new System.Drawing.Point(20, 176);
            this.qualityTitle.Name = "qualityTitle";
            this.qualityTitle.Size = new System.Drawing.Size(68, 24);
            this.qualityTitle.TabIndex = 18;
            this.qualityTitle.Text = "Jakoćś";
            // 
            // safetyProgressBar
            // 
            this.safetyProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.safetyProgressBar.Location = new System.Drawing.Point(401, 138);
            this.safetyProgressBar.Name = "safetyProgressBar";
            this.safetyProgressBar.Size = new System.Drawing.Size(103, 30);
            this.safetyProgressBar.TabIndex = 17;
            // 
            // safetButton
            // 
            this.safetButton.Location = new System.Drawing.Point(302, 138);
            this.safetButton.Name = "safetButton";
            this.safetButton.Size = new System.Drawing.Size(89, 30);
            this.safetButton.TabIndex = 16;
            this.safetButton.Text = "Start";
            this.safetButton.UseVisualStyleBackColor = true;
            this.safetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // introProgressBar
            // 
            this.introProgressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.introProgressBar.ForeColor = System.Drawing.Color.Red;
            this.introProgressBar.Location = new System.Drawing.Point(401, 96);
            this.introProgressBar.Name = "introProgressBar";
            this.introProgressBar.Size = new System.Drawing.Size(103, 30);
            this.introProgressBar.TabIndex = 15;
            // 
            // safetyTitle
            // 
            this.safetyTitle.AutoSize = true;
            this.safetyTitle.Location = new System.Drawing.Point(20, 140);
            this.safetyTitle.Name = "safetyTitle";
            this.safetyTitle.Size = new System.Drawing.Size(48, 24);
            this.safetyTitle.TabIndex = 13;
            this.safetyTitle.Text = "BHP";
            // 
            // introResult
            // 
            this.introResult.AutoSize = true;
            this.introResult.Location = new System.Drawing.Point(820, 100);
            this.introResult.Name = "introResult";
            this.introResult.Size = new System.Drawing.Size(0, 24);
            this.introResult.TabIndex = 11;
            // 
            // introEnd
            // 
            this.introEnd.AutoSize = true;
            this.introEnd.Location = new System.Drawing.Point(688, 100);
            this.introEnd.Name = "introEnd";
            this.introEnd.Size = new System.Drawing.Size(0, 24);
            this.introEnd.TabIndex = 10;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(820, 60);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(76, 24);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Rezultat";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(674, 60);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(119, 24);
            this.endLabel.TabIndex = 8;
            this.endLabel.Text = "Zakończenie";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(522, 60);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(120, 24);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Rozpoczęcie";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataLabel.Location = new System.Drawing.Point(20, 20);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(57, 25);
            this.dataLabel.TabIndex = 6;
            this.dataLabel.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // introButton
            // 
            this.introButton.Location = new System.Drawing.Point(302, 97);
            this.introButton.Name = "introButton";
            this.introButton.Size = new System.Drawing.Size(89, 30);
            this.introButton.TabIndex = 3;
            this.introButton.Text = "Start";
            this.introButton.UseVisualStyleBackColor = true;
            this.introButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(279, 20);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(0, 24);
            this.currentTime.TabIndex = 5;
            // 
            // introTitle
            // 
            this.introTitle.AutoSize = true;
            this.introTitle.Location = new System.Drawing.Point(22, 101);
            this.introTitle.Name = "introTitle";
            this.introTitle.Size = new System.Drawing.Size(63, 24);
            this.introTitle.TabIndex = 1;
            this.introTitle.Text = "Wstęp";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wykresy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(68, 82);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Label = "text";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            dataPoint4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series7.Points.Add(dataPoint4);
            series7.XValueMember = "1";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series7.YValueMembers = "1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(782, 313);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title10.Name = "Title1";
            title11.Name = "Title2";
            title12.Name = "Title3";
            this.chart1.Titles.Add(title10);
            this.chart1.Titles.Add(title11);
            this.chart1.Titles.Add(title12);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bindingNavigator1);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(927, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Baza danych";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(921, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(927, 573);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(30, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(873, 442);
            this.dataGridView1.TabIndex = 0;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Time keeper support for SIM5 time management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker feedbackTimePicker;
        private System.Windows.Forms.DateTimePicker visitsTimePicker;
        private System.Windows.Forms.DateTimePicker priorityTimePicker;
        private System.Windows.Forms.DateTimePicker projectsTimePicker;
        private System.Windows.Forms.DateTimePicker peopleTimePicker;
        private System.Windows.Forms.DateTimePicker performanceTimePicker;
        private System.Windows.Forms.DateTimePicker customerServiceTimePicker;
        private System.Windows.Forms.DateTimePicker qualityTimePicker;
        private System.Windows.Forms.DateTimePicker safetyTimePicker;
        private System.Windows.Forms.DateTimePicker introTimePicker;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label feedbackProgressValue;
        private System.Windows.Forms.Label visitsProgressValue;
        private System.Windows.Forms.Label priorityProgressValue;
        private System.Windows.Forms.Label projectsProgressValue;
        private System.Windows.Forms.Label peopleProgressValue;
        private System.Windows.Forms.Label performanceProgressValue;
        private System.Windows.Forms.Label customerServiceProgressValue;
        private System.Windows.Forms.Label qualityProgressValue;
        private System.Windows.Forms.Label feedbackResult;
        private System.Windows.Forms.Label feedbackEnd;
        private System.Windows.Forms.Label feedbackStart;
        private System.Windows.Forms.Label visitsResult;
        private System.Windows.Forms.Label visitsEnd;
        private System.Windows.Forms.Label visitsStart;
        private System.Windows.Forms.Label priorityResult;
        private System.Windows.Forms.Label priorityEnd;
        private System.Windows.Forms.Label priorityStart;
        private System.Windows.Forms.Label projectsResult;
        private System.Windows.Forms.Label projectsEnd;
        private System.Windows.Forms.Label projectsStart;
        private System.Windows.Forms.Label peopleResult;
        private System.Windows.Forms.Label peopleEnd;
        private System.Windows.Forms.Label peopleStart;
        private System.Windows.Forms.Label performanceResult;
        private System.Windows.Forms.Label performanceEnd;
        private System.Windows.Forms.Label performanceStart;
        private System.Windows.Forms.Label customerServiceResult;
        private System.Windows.Forms.Label customerServiceEnd;
        private System.Windows.Forms.Label customerServiceStart;
        private System.Windows.Forms.Label qualityResult;
        private System.Windows.Forms.Label qualityEnd;
        private System.Windows.Forms.Label qualityStart;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label safetyProgressValue;
        private System.Windows.Forms.Label introProgressValue;
        private System.Windows.Forms.Label safetyResult;
        private System.Windows.Forms.Label safetyEnd;
        private System.Windows.Forms.Label safetyStart;
        private System.Windows.Forms.Label introStart;
        private System.Windows.Forms.ProgressBar feedbackProgressBar;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.ProgressBar visitsProgressBar;
        private System.Windows.Forms.Button visitsButton;
        private System.Windows.Forms.ProgressBar priorityProgressBar;
        private System.Windows.Forms.Button priorityButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label feedbackTitle;
        private System.Windows.Forms.Label visitsTitle;
        private System.Windows.Forms.Label priorityTitle;
        private System.Windows.Forms.ProgressBar projectsProgressBar;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Label projectsTitle;
        private System.Windows.Forms.ProgressBar peopleProgressBar;
        private System.Windows.Forms.Button peopleButton;
        private System.Windows.Forms.Label peopleTitle;
        private System.Windows.Forms.ProgressBar performanceProgressBar;
        private System.Windows.Forms.Button performanceButton;
        private System.Windows.Forms.Label performanceTitle;
        private System.Windows.Forms.ProgressBar customerServiceProgressBar;
        private System.Windows.Forms.Button customerServiceButton;
        private System.Windows.Forms.Label customerServiceTitle;
        private System.Windows.Forms.ProgressBar qualityProgressBar;
        private System.Windows.Forms.Button qualityButton;
        private System.Windows.Forms.Label qualityTitle;
        private System.Windows.Forms.ProgressBar safetyProgressBar;
        private System.Windows.Forms.Button safetButton;
        private System.Windows.Forms.ProgressBar introProgressBar;
        private System.Windows.Forms.Label safetyTitle;
        private System.Windows.Forms.Label introResult;
        private System.Windows.Forms.Label introEnd;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button introButton;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label introTitle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

