using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form1 _form1;
        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
            timer1.Enabled = true;
            progressBar1.Visible = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = _form1.currentAction;
            progressBar1.Maximum = _form1.maxiBar;
            progressBar1.Value = _form1.currentBar;
            if (_form1.currentBar < progressBar1.Maximum * 0.8) progressBar1.ForeColor = Color.LightGreen;
            if (_form1.currentBar > progressBar1.Maximum * 0.8) progressBar1.ForeColor = Color.Yellow;
            if (_form1.currentBar > progressBar1.Maximum * 0.99) progressBar1.ForeColor = Color.Red;
            label2.Text = _form1.procentBar;
            
   
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.LightGreen;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        }

    }
}
