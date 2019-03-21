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
        // Pagrindinis laikrodis
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
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
        //Programos kilinojimas
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
        //Stulpelis prie mygtuku ir tabu rodymas
        private void buttonLaikmatis_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonLaikmatis.Height;
            panelLeft.Top = buttonLaikmatis.Top;
            panelLaikmatis.Visible = true;
            panelKontrole.Visible = false;
            panelPriminimas.Visible = false;
        }
        private void buttonKontrole_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonKontrole.Height;
            panelLeft.Top = buttonKontrole.Top;
            panelLaikmatis.Visible = false;
            panelKontrole.Visible = true;
            panelPriminimas.Visible = false;
        }
        private void buttonPriminimas_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonPriminimas.Height;
            panelLeft.Top = buttonPriminimas.Top;
            panelLaikmatis.Visible = false;
            panelKontrole.Visible = false;
            panelPriminimas.Visible = true;
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

        

        //Pauze
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        //Resetinimas
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
        //startas
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }
        //Kontroles tabas
        int kontrolesSekunde;
        private void textBoxKontroleValanda_TextChanged(object sender, EventArgs e)
        {
            //kontrolesSekunde = textBoxKontroleValanda.Text.ToString();
            //kontrolesSekunde = (Convert.ToDateTime.(textBoxKontroleValanda));
        }
        private void textBoxKontroleMinute_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxKontroleSekunde_TextChanged(object sender, EventArgs e)
        {

        }
        //padaryti kad veiktu laikas atgal is ivesto teksto.
        private void timerKontrole_Tick(object sender, EventArgs e)
        {
            kontrolesSekunde--;
            kontrVal.Text = valanda.ToString("00");
            kontrMin.Text = minute.ToString("00");
            kontrSek.Text = kontrolesSekunde.ToString("00");
            if (kontrolesSekunde <= 0)
            {
                kontrolesSekunde = 60;
                minute--;
                if (minute == -1)
                {
                    minute = 59;
                    valanda--;
                    if (valanda == 0 && minute == 0 && sekunde == 0)
                    {
                        timerKontrole.Stop();
                    }
                }
            }
        }
        private void buttonKontrStart_Click(object sender, EventArgs e)
        {
            timerKontrole.Enabled = true;
            timerKontrole.Start();
        }
        private void buttonKontrStop_Click(object sender, EventArgs e)
        {
            timerKontrole.Stop();
        }

    }
}
