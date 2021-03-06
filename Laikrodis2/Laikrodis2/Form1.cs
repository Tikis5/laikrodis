﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace Laikrodis2
{
    public partial class Form1 : Form
    {
        int val, min, sek;
        int valanda, minute, sekunde;
        int mov, movX, movY;

        int kontrolesSekunde = 0;
        int kontrolesMinute = 0;
        int kontrolesValanda = 0;

        int darboLaik = 0;
        int trumposLaik = 0;
        int ilgosLaik = 0;
        int intervalas = 0;
        int pomoMin = 0;
        int pomoSek = 0;
        SoundPlayer chime = new SoundPlayer(@"C:\Users\tikis\source\repos\NewRepo\Laikrodis2\Laikrodis2\chime.wav");
        //Kompiuterio uzrakinimas
        [DllImport("user32")]
        public static extern void LockWorkStation();
        public Form1()
        {
            InitializeComponent();
        }
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
            laikVal.Text = valanda.ToString("00");
            laikMin.Text = minute.ToString("00");
            laikSek.Text = sekunde.ToString("00");
            sekunde++;
            if (sekunde > 59)
            {
                sekunde = 0;
                minute++;
                if (minute > 59)
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
        private void textBoxKontroleSekunde_TextChanged(object sender, EventArgs e)
        {

        }
        private void panelPriminimas_Paint(object sender, PaintEventArgs e)
        {

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
        private void textBoxKontroleValanda_TextChanged(object sender, EventArgs e)
        {
        }
        //Kontroles tabas
        private void timerKontrole_Tick(object sender, EventArgs e)
        {
            if ((kontrolesMinute == 0) && (kontrolesValanda == 0) && (kontrolesSekunde == 0))
            {
                timerKontrole.Stop();
                MessageBox.Show("Laikas miegoti! \nPaspaudus mygtuka OK kompiuteris uzsirakins!",
                    "Ispejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                textBoxKontroleValanda.Enabled = true;
                textBoxKontroleMinute.Enabled = true;
                textBoxKontroleSekunde.Enabled = true;
                kontrVal.Text = "00";
                kontrMin.Text = "00";
                kontrSek.Text = "00";

                //LockWorkStation();
            }
            else
            {
                if (kontrolesSekunde < 1)
                {
                    kontrolesSekunde = 59;
                    if (kontrolesMinute < 1)
                    {
                        kontrolesMinute = 59;
                        if (kontrolesValanda != 0)
                        {
                            kontrolesValanda--;
                        }
                    }
                    else kontrolesMinute--;
                }
                else kontrolesSekunde--;
                if (kontrolesValanda > 9)
                {
                    kontrVal.Text = kontrolesValanda.ToString();
                }
                else kontrVal.Text = "0" + kontrolesValanda.ToString();
                if (kontrolesMinute > 9)
                {
                    kontrMin.Text = kontrolesMinute.ToString();
                }
                else kontrMin.Text = "0" + kontrolesMinute.ToString();
                if (kontrolesSekunde > 9)
                {
                    kontrSek.Text = kontrolesSekunde.ToString();
                }
                else kontrSek.Text = "0" + kontrolesSekunde.ToString();
            }
        }
        private void buttonKontrStart_Click(object sender, EventArgs e)
        {
            if (textBoxKontroleSekunde.Text == "" || textBoxKontroleMinute.Text == "" || textBoxKontroleValanda.Text == "")
            {
                MessageBox.Show("Ivedete neteisinga laika");
            }
            else if (textBoxKontroleSekunde.Text == "00" && textBoxKontroleMinute.Text == "00" && textBoxKontroleValanda.Text == "00")
            {
                MessageBox.Show("Iveskite laika");
            }
            
            else
            {
                kontrolesSekunde = Convert.ToInt32(textBoxKontroleSekunde.Text);
                kontrolesMinute = Convert.ToInt32(textBoxKontroleMinute.Text);
                kontrolesValanda = Convert.ToInt32(textBoxKontroleValanda.Text);
                textBoxKontroleValanda.Enabled = false;
                textBoxKontroleMinute.Enabled = false;
                textBoxKontroleSekunde.Enabled = false;
                timerKontrole.Enabled = true;
                timerKontrole.Start();
                
            }
            if ((kontrolesMinute < 0) || (kontrolesMinute > 60) || (kontrolesValanda < 0) || (kontrolesSekunde > 60))
            {
                timerKontrole.Stop();
                MessageBox.Show("Ivedete neteisinga laika");
                textBoxKontroleValanda.Enabled = true;
                textBoxKontroleMinute.Enabled = true;
                textBoxKontroleSekunde.Enabled = true;
            }
        }
        //kontroles laiko ivedimo validacija
        private void textBoxKontroleSekunde_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxKontroleMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxKontroleValanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonKontrStop_Click(object sender, EventArgs e)
        {
            timerKontrole.Stop();
            textBoxKontroleValanda.Enabled = true;
            textBoxKontroleMinute.Enabled = true;
            textBoxKontroleSekunde.Enabled = true;
        }
        //Pomodoro techinka
        private void timerPomodoro_Tick(object sender, EventArgs e)
        {
            pomodoroNurodymas.Text = "Dirbk: " + darboLaik.ToString() + "min.";
            labelPomoMin.Text = pomoMin.ToString("00");
            labelPomoSek.Text = pomoSek.ToString("00");
            pomoSek++;
            if (pomoSek > 59)
            {
                pomoMin++;
                pomoSek = 0;
                if (pomoMin == darboLaik)
                {
                    timerPomodoro.Stop();
                    pomoSek = 0;
                    pomoMin = 0;
                    timerPertrauka.Start();
                }
            }
        }
        private void timerTrumpa_Tick(object sender, EventArgs e)
        {
            if (intervalas > 0)
            {
                pomodoroNurodymas.Text = "Ilsekis: " + trumposLaik.ToString() + "min.";
                labelPomoMin.Text = pomoMin.ToString("00");
                labelPomoSek.Text = pomoSek.ToString("00");
                pomoSek++;
                if (pomoSek > 59)
                {
                    pomoMin++;
                    pomoSek = 0;
                    if (pomoMin == trumposLaik)
                    {
                        pomoSek = 0;
                        pomoMin = 0;
                        intervalas--;
                        timerPertrauka.Stop();
                        timerPomodoro.Start();
                    }
                }
            }
            else
            {
                pomodoroNurodymas.Text = "Ilsekis: " + ilgosLaik.ToString() + "min.";
                labelPomoMin.Text = pomoMin.ToString("00");
                labelPomoSek.Text = pomoSek.ToString("00");
                pomoSek++;
                if (pomoSek > 59)
                {
                    pomoMin++;
                    pomoSek = 0;
                    if (pomoMin == ilgosLaik)
                    {
                        pomoSek = 0;
                        pomoMin = 0;
                        intervalas = Convert.ToInt32(textBoxIntervalas.Text);
                        timerPertrauka.Stop();
                        timerPomodoro.Start();
                    }
                }
            }
        }
        private void buttonPomodoroStart_Click(object sender, EventArgs e)
        {
            darboLaik = Convert.ToInt32(textBoxDarboLaik.Text);
            trumposLaik = Convert.ToInt32(textBoxTrumposLaik.Text);
            ilgosLaik = Convert.ToInt32(textBoxIlgosLaik.Text);
            intervalas = Convert.ToInt32(textBoxIntervalas.Text);
            timerPomodoro.Start();
        }
        private void buttonPomodoroStop_Click(object sender, EventArgs e)
        {
            pomoSek = 0;
            pomoMin = 0;
            labelPomoMin.Text = pomoMin.ToString("00");
            labelPomoSek.Text = pomoSek.ToString("00");
            timerPomodoro.Stop();
            timerPertrauka.Stop();
        }
    }
}
