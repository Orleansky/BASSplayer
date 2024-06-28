namespace Player
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new Guna.UI2.WinForms.Guna2Button();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.effectImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.effects = new Guna.UI2.WinForms.Guna2ComboBox();
            this.freqBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.min = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.freqButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.audioVis = new CSAudioVisualization.AudioVisualization();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 27);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGO";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // minimize
            // 
            this.minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimize.FillColor = System.Drawing.SystemColors.InfoText;
            this.minimize.FocusedColor = System.Drawing.SystemColors.GrayText;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimize.Location = new System.Drawing.Point(644, 0);
            this.minimize.Name = "minimize";
            this.minimize.PressedColor = System.Drawing.SystemColors.GrayText;
            this.minimize.Size = new System.Drawing.Size(30, 27);
            this.minimize.TabIndex = 1;
            this.minimize.Text = "—";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close.FillColor = System.Drawing.SystemColors.InfoText;
            this.close.FocusedColor = System.Drawing.Color.Red;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.Gainsboro;
            this.close.Location = new System.Drawing.Point(680, 0);
            this.close.Name = "close";
            this.close.PressedColor = System.Drawing.Color.Red;
            this.close.Size = new System.Drawing.Size(30, 27);
            this.close.TabIndex = 0;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // effectImage
            // 
            this.effectImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("effectImage.BackgroundImage")));
            this.effectImage.Image = ((System.Drawing.Image)(resources.GetObject("effectImage.Image")));
            this.effectImage.ImageRotate = 0F;
            this.effectImage.Location = new System.Drawing.Point(397, 40);
            this.effectImage.Name = "effectImage";
            this.effectImage.Size = new System.Drawing.Size(49, 45);
            this.effectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.effectImage.TabIndex = 6;
            this.effectImage.TabStop = false;
            // 
            // effects
            // 
            this.effects.BackColor = System.Drawing.Color.DarkGray;
            this.effects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.effects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.effects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.effects.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.effects.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.effects.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.effects.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.effects.ForeColor = System.Drawing.Color.Silver;
            this.effects.ItemHeight = 27;
            this.effects.Items.AddRange(new object[] {
            "Не выбрано...",
            "Эхо",
            "Ревербация"});
            this.effects.Location = new System.Drawing.Point(452, 46);
            this.effects.Name = "effects";
            this.effects.Size = new System.Drawing.Size(221, 33);
            this.effects.TabIndex = 7;
            this.effects.SelectedIndexChanged += new System.EventHandler(this.effects_SelectedIndexChanged);
            // 
            // freqBar
            // 
            this.freqBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("freqBar.BackgroundImage")));
            this.freqBar.Location = new System.Drawing.Point(94, 50);
            this.freqBar.Maximum = 78200;
            this.freqBar.Minimum = 10000;
            this.freqBar.Name = "freqBar";
            this.freqBar.Size = new System.Drawing.Size(221, 23);
            this.freqBar.TabIndex = 8;
            this.freqBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.freqBar.Value = 44100;
            this.freqBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.freqBar_Scroll);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.ForeColor = System.Drawing.Color.Silver;
            this.min.Location = new System.Drawing.Point(91, 72);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(42, 15);
            this.min.TabIndex = 9;
            this.min.Text = "10kHz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(263, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "78.2kHz";
            // 
            // freqButton
            // 
            this.freqButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("freqButton.BackgroundImage")));
            this.freqButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.freqButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.freqButton.HoverState.ImageSize = new System.Drawing.Size(45, 48);
            this.freqButton.Image = ((System.Drawing.Image)(resources.GetObject("freqButton.Image")));
            this.freqButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.freqButton.ImageRotate = 0F;
            this.freqButton.ImageSize = new System.Drawing.Size(45, 48);
            this.freqButton.Location = new System.Drawing.Point(40, 35);
            this.freqButton.Name = "freqButton";
            this.freqButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.freqButton.PressedState.ImageSize = new System.Drawing.Size(45, 48);
            this.freqButton.Size = new System.Drawing.Size(45, 48);
            this.freqButton.TabIndex = 11;
            this.freqButton.Click += new System.EventHandler(this.freqButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // audioVis
            // 
            this.audioVis.AudioSource = null;
            this.audioVis.BarCount = 50;
            this.audioVis.BarSpacing = 2;
            this.audioVis.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.audioVis.ColorMax = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(72)))), ((int)(((byte)(163)))));
            this.audioVis.DeviceIndex = 0;
            this.audioVis.FileName = null;
            this.audioVis.HighQuality = true;
            this.audioVis.Interval = 40;
            this.audioVis.IsXLogScale = true;
            this.audioVis.Location = new System.Drawing.Point(16, 151);
            this.audioVis.MaximumFrequency = 10000;
            this.audioVis.MessageArgs = null;
            this.audioVis.Name = "audioVis";
            this.audioVis.pic3DGraph = null;
            this.audioVis.Size = new System.Drawing.Size(657, 254);
            this.audioVis.TabIndex = 12;
            this.audioVis.UseAverage = true;
            this.audioVis.UserKey = "Your registration key";
            this.audioVis.UserName = "Your email";
            this.audioVis.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            this.audioVis.Load += new System.EventHandler(this.audioVis_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.audioVis);
            this.Controls.Add(this.freqButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min);
            this.Controls.Add(this.freqBar);
            this.Controls.Add(this.effects);
            this.Controls.Add(this.effectImage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button minimize;
        private Guna.UI2.WinForms.Guna2Button close;
        private Guna.UI2.WinForms.Guna2PictureBox effectImage;
        private Guna.UI2.WinForms.Guna2ComboBox effects;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TrackBar freqBar;
        private Guna.UI2.WinForms.Guna2ImageButton freqButton;
        private System.Windows.Forms.Timer timer1;
        private CSAudioVisualization.AudioVisualization audioVis;
    }
}