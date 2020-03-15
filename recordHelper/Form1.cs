using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace recordHelper
{
    public partial class Form1 : Form
    {
        int index = 0;

        System.DateTime TimeNow = new DateTime();
        TimeSpan TimeCount = new TimeSpan();

        public Form1()
        {
            InitializeComponent();
            index = 0;
        }

        

        void click()
        {
            if(!timer1.Enabled)
            {
                timer1.Start();
                TimeNow = DateTime.Now;
            }

            normal.BackColor = Control.DefaultBackColor;
            speed.BackColor = Control.DefaultBackColor;
            cut.BackColor = Control.DefaultBackColor;
            index += 1;
            num.Text = index.ToString();

        }

        private void normal_Click(object sender, EventArgs e)
        {
            click();
                normal.BackColor = Color.Green;
        }

        private void speed_Click(object sender, EventArgs e)
        {
            click();
            speed.BackColor = Color.Yellow;

        }

        private void cut_Click(object sender, EventArgs e)
        {
            click();
            cut.BackColor = Color.Red;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            click();
            index = 0;
            timer1.Stop();
            num.Text = index.ToString();
            mytime.Text = "00:00:00";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeCount = DateTime.Now - TimeNow;
            mytime.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:0}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds,TimeCount.Milliseconds/100);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.Control && e.KeyCode == Keys.S)
            {
                MessageBox.Show("我按了Control +Shift +Alt +S");
            }
        }
    }
}
