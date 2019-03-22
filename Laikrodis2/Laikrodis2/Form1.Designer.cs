namespace Laikrodis2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonKontrole = new System.Windows.Forms.Button();
            this.buttonPriminimas = new System.Windows.Forms.Button();
            this.laikSek = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.laikMin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.laikVal = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonLaikmatis = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelKontrole = new System.Windows.Forms.Panel();
            this.textBoxKontroleMinute = new System.Windows.Forms.TextBox();
            this.textBoxKontroleValanda = new System.Windows.Forms.TextBox();
            this.kontrole = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kontrVal = new System.Windows.Forms.Label();
            this.kontrSek = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kontrMin = new System.Windows.Forms.Label();
            this.buttonKontrStop = new System.Windows.Forms.Button();
            this.buttonKontrStart = new System.Windows.Forms.Button();
            this.panelLaikmatis = new System.Windows.Forms.Panel();
            this.laikmatis = new System.Windows.Forms.Label();
            this.panelPriminimas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timerKontrole = new System.Windows.Forms.Timer(this.components);
            this.textBoxKontroleSekunde = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelKontrole.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelLaikmatis.SuspendLayout();
            this.panelPriminimas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 9);
            this.label1.TabIndex = 0;
            this.label1.Text = "LAIKAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 9);
            this.label2.TabIndex = 1;
            this.label2.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 9);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 9);
            this.label4.TabIndex = 3;
            this.label4.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(8, 9);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 9);
            this.label6.TabIndex = 5;
            this.label6.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(25, 146);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonKontrole
            // 
            this.buttonKontrole.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonKontrole.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonKontrole.FlatAppearance.BorderSize = 0;
            this.buttonKontrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKontrole.Location = new System.Drawing.Point(0, 110);
            this.buttonKontrole.Name = "buttonKontrole";
            this.buttonKontrole.Size = new System.Drawing.Size(117, 47);
            this.buttonKontrole.TabIndex = 8;
            this.buttonKontrole.Text = "Kontrolė";
            this.buttonKontrole.UseVisualStyleBackColor = false;
            this.buttonKontrole.Click += new System.EventHandler(this.buttonKontrole_Click);
            // 
            // buttonPriminimas
            // 
            this.buttonPriminimas.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonPriminimas.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonPriminimas.FlatAppearance.BorderSize = 0;
            this.buttonPriminimas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPriminimas.Location = new System.Drawing.Point(0, 195);
            this.buttonPriminimas.Name = "buttonPriminimas";
            this.buttonPriminimas.Size = new System.Drawing.Size(117, 47);
            this.buttonPriminimas.TabIndex = 9;
            this.buttonPriminimas.Text = "Priminimas";
            this.buttonPriminimas.UseVisualStyleBackColor = false;
            this.buttonPriminimas.Click += new System.EventHandler(this.buttonPriminimas_Click);
            // 
            // laikSek
            // 
            this.laikSek.AutoSize = true;
            this.laikSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laikSek.Location = new System.Drawing.Point(113, 13);
            this.laikSek.Name = "laikSek";
            this.laikSek.Size = new System.Drawing.Size(29, 20);
            this.laikSek.TabIndex = 16;
            this.laikSek.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = ":";
            // 
            // laikMin
            // 
            this.laikMin.AutoSize = true;
            this.laikMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laikMin.Location = new System.Drawing.Point(58, 13);
            this.laikMin.Name = "laikMin";
            this.laikMin.Size = new System.Drawing.Size(29, 20);
            this.laikMin.TabIndex = 14;
            this.laikMin.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = ":";
            // 
            // laikVal
            // 
            this.laikVal.AutoSize = true;
            this.laikVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laikVal.Location = new System.Drawing.Point(3, 13);
            this.laikVal.Name = "laikVal";
            this.laikVal.Size = new System.Drawing.Size(29, 20);
            this.laikVal.TabIndex = 12;
            this.laikVal.Text = "00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(106, 146);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "PAUSE";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(66, 175);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laikVal);
            this.groupBox2.Controls.Add(this.laikSek);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.laikMin);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(29, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(148, 41);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.buttonLaikmatis);
            this.panel1.Controls.Add(this.buttonPriminimas);
            this.panel1.Controls.Add(this.buttonKontrole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 428);
            this.panel1.TabIndex = 22;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 25);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 47);
            this.panelLeft.TabIndex = 27;
            // 
            // buttonLaikmatis
            // 
            this.buttonLaikmatis.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonLaikmatis.FlatAppearance.BorderSize = 0;
            this.buttonLaikmatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaikmatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaikmatis.Location = new System.Drawing.Point(0, 25);
            this.buttonLaikmatis.Name = "buttonLaikmatis";
            this.buttonLaikmatis.Size = new System.Drawing.Size(117, 47);
            this.buttonLaikmatis.TabIndex = 23;
            this.buttonLaikmatis.Text = "Laikmatis";
            this.buttonLaikmatis.UseVisualStyleBackColor = false;
            this.buttonLaikmatis.Click += new System.EventHandler(this.buttonLaikmatis_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(294, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(28, 21);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "X";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(269, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 21);
            this.button2.TabIndex = 25;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 21);
            this.panel2.TabIndex = 26;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panelKontrole
            // 
            this.panelKontrole.Controls.Add(this.textBoxKontroleSekunde);
            this.panelKontrole.Controls.Add(this.textBoxKontroleMinute);
            this.panelKontrole.Controls.Add(this.textBoxKontroleValanda);
            this.panelKontrole.Controls.Add(this.kontrole);
            this.panelKontrole.Controls.Add(this.groupBox1);
            this.panelKontrole.Controls.Add(this.buttonKontrStop);
            this.panelKontrole.Controls.Add(this.buttonKontrStart);
            this.panelKontrole.Location = new System.Drawing.Point(123, 27);
            this.panelKontrole.Name = "panelKontrole";
            this.panelKontrole.Size = new System.Drawing.Size(203, 272);
            this.panelKontrole.TabIndex = 28;
            this.panelKontrole.Visible = false;
            // 
            // textBoxKontroleMinute
            // 
            this.textBoxKontroleMinute.Location = new System.Drawing.Point(89, 84);
            this.textBoxKontroleMinute.Name = "textBoxKontroleMinute";
            this.textBoxKontroleMinute.Size = new System.Drawing.Size(32, 20);
            this.textBoxKontroleMinute.TabIndex = 33;
            this.textBoxKontroleMinute.Text = "00";
            // 
            // textBoxKontroleValanda
            // 
            this.textBoxKontroleValanda.Location = new System.Drawing.Point(51, 84);
            this.textBoxKontroleValanda.Name = "textBoxKontroleValanda";
            this.textBoxKontroleValanda.Size = new System.Drawing.Size(32, 20);
            this.textBoxKontroleValanda.TabIndex = 32;
            this.textBoxKontroleValanda.Text = "00";
            // 
            // kontrole
            // 
            this.kontrole.AutoSize = true;
            this.kontrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrole.Location = new System.Drawing.Point(53, 36);
            this.kontrole.Name = "kontrole";
            this.kontrole.Size = new System.Drawing.Size(103, 20);
            this.kontrole.TabIndex = 28;
            this.kontrole.Text = "KONTROLĖ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kontrVal);
            this.groupBox1.Controls.Add(this.kontrSek);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.kontrMin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(29, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(148, 41);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // kontrVal
            // 
            this.kontrVal.AutoSize = true;
            this.kontrVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrVal.Location = new System.Drawing.Point(3, 13);
            this.kontrVal.Name = "kontrVal";
            this.kontrVal.Size = new System.Drawing.Size(29, 20);
            this.kontrVal.TabIndex = 12;
            this.kontrVal.Text = "00";
            // 
            // kontrSek
            // 
            this.kontrSek.AutoSize = true;
            this.kontrSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrSek.Location = new System.Drawing.Point(113, 13);
            this.kontrSek.Name = "kontrSek";
            this.kontrSek.Size = new System.Drawing.Size(29, 20);
            this.kontrSek.TabIndex = 16;
            this.kontrSek.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(93, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = ":";
            // 
            // kontrMin
            // 
            this.kontrMin.AutoSize = true;
            this.kontrMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrMin.Location = new System.Drawing.Point(58, 13);
            this.kontrMin.Name = "kontrMin";
            this.kontrMin.Size = new System.Drawing.Size(29, 20);
            this.kontrMin.TabIndex = 14;
            this.kontrMin.Text = "00";
            // 
            // buttonKontrStop
            // 
            this.buttonKontrStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKontrStop.Location = new System.Drawing.Point(105, 169);
            this.buttonKontrStop.Name = "buttonKontrStop";
            this.buttonKontrStop.Size = new System.Drawing.Size(75, 23);
            this.buttonKontrStop.TabIndex = 1;
            this.buttonKontrStop.Text = "STOP";
            this.buttonKontrStop.UseVisualStyleBackColor = true;
            this.buttonKontrStop.Click += new System.EventHandler(this.buttonKontrStop_Click);
            // 
            // buttonKontrStart
            // 
            this.buttonKontrStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKontrStart.Location = new System.Drawing.Point(24, 169);
            this.buttonKontrStart.Name = "buttonKontrStart";
            this.buttonKontrStart.Size = new System.Drawing.Size(75, 23);
            this.buttonKontrStart.TabIndex = 0;
            this.buttonKontrStart.Text = "START";
            this.buttonKontrStart.UseVisualStyleBackColor = true;
            this.buttonKontrStart.Click += new System.EventHandler(this.buttonKontrStart_Click);
            // 
            // panelLaikmatis
            // 
            this.panelLaikmatis.Controls.Add(this.laikmatis);
            this.panelLaikmatis.Controls.Add(this.groupBox2);
            this.panelLaikmatis.Controls.Add(this.buttonStart);
            this.panelLaikmatis.Controls.Add(this.buttonStop);
            this.panelLaikmatis.Controls.Add(this.buttonReset);
            this.panelLaikmatis.Location = new System.Drawing.Point(365, 46);
            this.panelLaikmatis.Name = "panelLaikmatis";
            this.panelLaikmatis.Size = new System.Drawing.Size(202, 272);
            this.panelLaikmatis.TabIndex = 28;
            // 
            // laikmatis
            // 
            this.laikmatis.AutoSize = true;
            this.laikmatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laikmatis.Location = new System.Drawing.Point(53, 37);
            this.laikmatis.Name = "laikmatis";
            this.laikmatis.Size = new System.Drawing.Size(102, 20);
            this.laikmatis.TabIndex = 27;
            this.laikmatis.Text = "LAIKMATIS";
            // 
            // panelPriminimas
            // 
            this.panelPriminimas.Controls.Add(this.button1);
            this.panelPriminimas.Location = new System.Drawing.Point(340, 250);
            this.panelPriminimas.Name = "panelPriminimas";
            this.panelPriminimas.Size = new System.Drawing.Size(202, 272);
            this.panelPriminimas.TabIndex = 29;
            this.panelPriminimas.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timerKontrole
            // 
            this.timerKontrole.Interval = 1000;
            this.timerKontrole.Tick += new System.EventHandler(this.timerKontrole_Tick);
            // 
            // textBoxKontroleSekunde
            // 
            this.textBoxKontroleSekunde.Location = new System.Drawing.Point(127, 84);
            this.textBoxKontroleSekunde.Name = "textBoxKontroleSekunde";
            this.textBoxKontroleSekunde.Size = new System.Drawing.Size(32, 20);
            this.textBoxKontroleSekunde.TabIndex = 35;
            this.textBoxKontroleSekunde.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(570, 449);
            this.Controls.Add(this.panelPriminimas);
            this.Controls.Add(this.panelKontrole);
            this.Controls.Add(this.panelLaikmatis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LAIKRODIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelKontrole.ResumeLayout(false);
            this.panelKontrole.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLaikmatis.ResumeLayout(false);
            this.panelLaikmatis.PerformLayout();
            this.panelPriminimas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonKontrole;
        private System.Windows.Forms.Button buttonPriminimas;
        private System.Windows.Forms.Label laikSek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laikMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label laikVal;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLaikmatis;
        private System.Windows.Forms.Panel panelKontrole;
        private System.Windows.Forms.Panel panelPriminimas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerKontrole;
        private System.Windows.Forms.Label kontrole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kontrVal;
        private System.Windows.Forms.Label kontrSek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label kontrMin;
        private System.Windows.Forms.Button buttonKontrStop;
        private System.Windows.Forms.Button buttonKontrStart;
        private System.Windows.Forms.Label laikmatis;
        private System.Windows.Forms.Button buttonLaikmatis;
        private System.Windows.Forms.TextBox textBoxKontroleMinute;
        public System.Windows.Forms.TextBox textBoxKontroleValanda;
        private System.Windows.Forms.TextBox textBoxKontroleSekunde;
    }
}

