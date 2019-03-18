using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laikrodis2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int val, min, sek;
        int valLaikmatis, minLaikmatis, sekLaikmatis;

        private void buttonLaikmatis_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sekLaikmatis = DateTime.Now.Millisecond;
            minLaikmatis = DateTime.Now.Minute;
            valLaikmatis = DateTimeOffset.Now.Second;
            label12.Text = valLaikmatis.ToString();
            label10.Text = minLaikmatis.ToString();
            label8.Text = sekLaikmatis.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sek = DateTime.Now.Second;
            min = DateTime.Now.Minute;
            val = DateTime.Now.Hour;
            label2.Text = val.ToString();
            label4.Text = min.ToString();
            label6.Text = sek.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
