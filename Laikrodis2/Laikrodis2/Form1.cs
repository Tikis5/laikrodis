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
        int valanda, minute, sekunde;
        int mov;
        int movX;
        int movY;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // Pagrindinis laikrodis
        private void timer1_Tick(object sender, EventArgs e)
        {
            sek = DateTime.Now.Second;
            min = DateTime.Now.Minute;
            val = DateTime.Now.Hour;
            label2.Text = val.ToString("00");
            label4.Text = min.ToString("00");
            label6.Text = sek.ToString("00");
        }
        // Mygtukas iseiti
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Mygtukas sumazinti
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        //Lango kilinojimas
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //Stulpelis prie mygtuku
        private void buttonLaikmatis_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonLaikmatis.Height;
            panelLeft.Top = buttonLaikmatis.Top;
            panelLaikmatis.Visible = true;
            panelKontrole.Visible = false;
        }
        private void buttonKontrole_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonKontrole.Height;
            panelLeft.Top = buttonKontrole.Top;
            panelLaikmatis.Visible = false;
            panelKontrole.Visible = true;
        }
        private void buttonPriminimas_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonPriminimas.Height;
            panelLeft.Top = buttonPriminimas.Top;
        }

        //Laikmacio skaiciavimas
        private void timer2_Tick(object sender, EventArgs e)
        {
            sekunde++;
            laikVal.Text = valanda.ToString("00");
            laikMin.Text = minute.ToString("00");
            laikSek.Text = sekunde.ToString("00");
            if (sekunde >= 59)
            {
                sekunde = -1;
                minute++;
                 if (minute == 60)
                {
                    minute = 0;
                    valanda++;
                }
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            sekunde = 0;
            minute = 0;
            valanda = 0;
            laikVal.Text = valanda.ToString("00");
            laikMin.Text = minute.ToString("00");
            laikSek.Text = sekunde.ToString("00");
            timer2.Stop();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        
        
    }
}
