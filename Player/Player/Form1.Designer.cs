namespace Player
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.play = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new Guna.UI2.WinForms.Guna2Button();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.rewinding = new Guna.UI2.WinForms.Guna2TrackBar();
            this.next = new Guna.UI2.WinForms.Guna2ImageButton();
            this.previous = new Guna.UI2.WinForms.Guna2ImageButton();
            this.trackName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.authorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.trackDuration = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timeLastedNow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.upload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playlistButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playlist = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonGroup = new Guna.UI2.WinForms.Guna2GroupBox();
            this.search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.equalizer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.addUrl = new Guna.UI2.WinForms.Guna2Button();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.urlList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.buttonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.ImageRotate = 0F;
            this.picture.Location = new System.Drawing.Point(90, 49);
            this.picture.Name = "picture";
            this.picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picture.Size = new System.Drawing.Size(199, 203);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // play
            // 
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.play.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.play.FocusedColor = System.Drawing.Color.MediumSlateBlue;
            this.play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.ImageSize = new System.Drawing.Size(35, 35);
            this.play.Location = new System.Drawing.Point(163, 471);
            this.play.Name = "play";
            this.play.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.play.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.play.Size = new System.Drawing.Size(55, 55);
            this.play.TabIndex = 1;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 27);
            this.panel1.TabIndex = 2;
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
            this.minimize.Location = new System.Drawing.Point(316, 0);
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
            this.close.Location = new System.Drawing.Point(352, 0);
            this.close.Name = "close";
            this.close.PressedColor = System.Drawing.Color.Red;
            this.close.Size = new System.Drawing.Size(30, 27);
            this.close.TabIndex = 0;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // rewinding
            // 
            this.rewinding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rewinding.BackgroundImage")));
            this.rewinding.DisplayFocus = true;
            this.rewinding.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rewinding.IndicateFocus = true;
            this.rewinding.Location = new System.Drawing.Point(55, 555);
            this.rewinding.Name = "rewinding";
            this.rewinding.Size = new System.Drawing.Size(271, 23);
            this.rewinding.TabIndex = 3;
            this.rewinding.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rewinding.Value = 0;
            this.rewinding.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rewinding_Scroll);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.Menu;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.next.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.next.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.ImageOffset = new System.Drawing.Point(0, 0);
            this.next.ImageRotate = 0F;
            this.next.ImageSize = new System.Drawing.Size(25, 25);
            this.next.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.next.Location = new System.Drawing.Point(236, 481);
            this.next.Name = "next";
            this.next.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.next.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.next.Size = new System.Drawing.Size(35, 35);
            this.next.TabIndex = 4;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.SystemColors.Menu;
            this.previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous.BackgroundImage")));
            this.previous.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.previous.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.previous.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.previous.Image = ((System.Drawing.Image)(resources.GetObject("previous.Image")));
            this.previous.ImageOffset = new System.Drawing.Point(0, 0);
            this.previous.ImageRotate = 0F;
            this.previous.ImageSize = new System.Drawing.Size(25, 25);
            this.previous.Location = new System.Drawing.Point(107, 481);
            this.previous.Name = "previous";
            this.previous.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.previous.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.previous.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previous.Size = new System.Drawing.Size(35, 35);
            this.previous.TabIndex = 5;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // trackName
            // 
            this.trackName.AutoSize = false;
            this.trackName.BackColor = System.Drawing.Color.Transparent;
            this.trackName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackName.BackgroundImage")));
            this.trackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackName.ForeColor = System.Drawing.Color.White;
            this.trackName.IsSelectionEnabled = false;
            this.trackName.Location = new System.Drawing.Point(59, 291);
            this.trackName.Name = "trackName";
            this.trackName.Size = new System.Drawing.Size(262, 31);
            this.trackName.TabIndex = 6;
            this.trackName.Text = "Не воспроизводится";
            this.trackName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authorName
            // 
            this.authorName.AutoSize = false;
            this.authorName.BackColor = System.Drawing.Color.Transparent;
            this.authorName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("authorName.BackgroundImage")));
            this.authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorName.ForeColor = System.Drawing.Color.Silver;
            this.authorName.IsSelectionEnabled = false;
            this.authorName.Location = new System.Drawing.Point(59, 328);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(262, 26);
            this.authorName.TabIndex = 7;
            this.authorName.Text = "Не воспроизводится";
            this.authorName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackDuration
            // 
            this.trackDuration.BackColor = System.Drawing.Color.Transparent;
            this.trackDuration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackDuration.BackgroundImage")));
            this.trackDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackDuration.ForeColor = System.Drawing.Color.Silver;
            this.trackDuration.IsSelectionEnabled = false;
            this.trackDuration.Location = new System.Drawing.Point(335, 557);
            this.trackDuration.Name = "trackDuration";
            this.trackDuration.Size = new System.Drawing.Size(27, 18);
            this.trackDuration.TabIndex = 8;
            this.trackDuration.Text = "0:00";
            // 
            // timeLastedNow
            // 
            this.timeLastedNow.BackColor = System.Drawing.Color.Transparent;
            this.timeLastedNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timeLastedNow.BackgroundImage")));
            this.timeLastedNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLastedNow.ForeColor = System.Drawing.Color.Silver;
            this.timeLastedNow.IsSelectionEnabled = false;
            this.timeLastedNow.Location = new System.Drawing.Point(21, 557);
            this.timeLastedNow.Name = "timeLastedNow";
            this.timeLastedNow.Size = new System.Drawing.Size(27, 18);
            this.timeLastedNow.TabIndex = 9;
            this.timeLastedNow.Text = "0:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // upload
            // 
            this.upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload.BackgroundImage")));
            this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.upload.CheckedState.ImageSize = new System.Drawing.Size(40, 30);
            this.upload.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.upload.HoverState.ImageSize = new System.Drawing.Size(40, 30);
            this.upload.Image = ((System.Drawing.Image)(resources.GetObject("upload.Image")));
            this.upload.ImageOffset = new System.Drawing.Point(0, 0);
            this.upload.ImageRotate = 0F;
            this.upload.ImageSize = new System.Drawing.Size(40, 30);
            this.upload.Location = new System.Drawing.Point(0, 41);
            this.upload.Name = "upload";
            this.upload.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.upload.PressedState.ImageSize = new System.Drawing.Size(40, 30);
            this.upload.Size = new System.Drawing.Size(45, 40);
            this.upload.TabIndex = 10;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // playlistButton
            // 
            this.playlistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistButton.BackgroundImage")));
            this.playlistButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playlistButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.playlistButton.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.playlistButton.Image = ((System.Drawing.Image)(resources.GetObject("playlistButton.Image")));
            this.playlistButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.playlistButton.ImageRotate = 0F;
            this.playlistButton.ImageSize = new System.Drawing.Size(40, 40);
            this.playlistButton.Location = new System.Drawing.Point(54, 481);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.playlistButton.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.playlistButton.Size = new System.Drawing.Size(35, 35);
            this.playlistButton.TabIndex = 11;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlist.ForeColor = System.Drawing.Color.White;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 20;
            this.playlist.Location = new System.Drawing.Point(0, 30);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(382, 420);
            this.playlist.TabIndex = 12;
            this.playlist.Visible = false;
            this.playlist.SelectedIndexChanged += new System.EventHandler(this.playlist_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pause
            // 
            this.pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause.BackgroundImage")));
            this.pause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pause.Enabled = false;
            this.pause.FillColor = System.Drawing.Color.MediumPurple;
            this.pause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pause.ForeColor = System.Drawing.Color.White;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.ImageSize = new System.Drawing.Size(20, 30);
            this.pause.Location = new System.Drawing.Point(163, 471);
            this.pause.Name = "pause";
            this.pause.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pause.Size = new System.Drawing.Size(55, 55);
            this.pause.TabIndex = 13;
            this.pause.Visible = false;
            // 
            // buttonGroup
            // 
            this.buttonGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGroup.BackgroundImage")));
            this.buttonGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGroup.BorderColor = System.Drawing.Color.Empty;
            this.buttonGroup.BorderThickness = 0;
            this.buttonGroup.Controls.Add(this.search);
            this.buttonGroup.Controls.Add(this.equalizer);
            this.buttonGroup.Controls.Add(this.upload);
            this.buttonGroup.CustomBorderColor = System.Drawing.Color.Empty;
            this.buttonGroup.FillColor = System.Drawing.Color.Empty;
            this.buttonGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.buttonGroup.Location = new System.Drawing.Point(290, 352);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(45, 135);
            this.buttonGroup.TabIndex = 14;
            this.buttonGroup.Visible = false;
            // 
            // search
            // 
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.search.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.search.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageOffset = new System.Drawing.Point(0, 0);
            this.search.ImageRotate = 0F;
            this.search.ImageSize = new System.Drawing.Size(35, 35);
            this.search.Location = new System.Drawing.Point(5, 0);
            this.search.Name = "search";
            this.search.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            this.search.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.search.Size = new System.Drawing.Size(40, 40);
            this.search.TabIndex = 11;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // equalizer
            // 
            this.equalizer.BackColor = System.Drawing.Color.MediumPurple;
            this.equalizer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("equalizer.BackgroundImage")));
            this.equalizer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.equalizer.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            this.equalizer.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.equalizer.Image = ((System.Drawing.Image)(resources.GetObject("equalizer.Image")));
            this.equalizer.ImageOffset = new System.Drawing.Point(0, 0);
            this.equalizer.ImageRotate = 0F;
            this.equalizer.ImageSize = new System.Drawing.Size(35, 35);
            this.equalizer.Location = new System.Drawing.Point(0, 86);
            this.equalizer.Name = "equalizer";
            this.equalizer.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image11")));
            this.equalizer.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.equalizer.Size = new System.Drawing.Size(45, 40);
            this.equalizer.TabIndex = 0;
            this.equalizer.Click += new System.EventHandler(this.equalizer_Click);
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.menu.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image12")));
            this.menu.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageOffset = new System.Drawing.Point(0, 0);
            this.menu.ImageRotate = 0F;
            this.menu.ImageSize = new System.Drawing.Size(60, 60);
            this.menu.Location = new System.Drawing.Point(295, 481);
            this.menu.Name = "menu";
            this.menu.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image13")));
            this.menu.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.menu.Size = new System.Drawing.Size(35, 35);
            this.menu.TabIndex = 16;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // addUrl
            // 
            this.addUrl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUrl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUrl.FillColor = System.Drawing.Color.MediumPurple;
            this.addUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUrl.ForeColor = System.Drawing.Color.White;
            this.addUrl.Location = new System.Drawing.Point(107, 408);
            this.addUrl.Name = "addUrl";
            this.addUrl.Size = new System.Drawing.Size(164, 45);
            this.addUrl.TabIndex = 18;
            this.addUrl.Text = "Добавить трек/радио...";
            this.addUrl.Visible = false;
            this.addUrl.Click += new System.EventHandler(this.addUrl_Click);
            // 
            // labelUrl
            // 
            this.labelUrl.BackColor = System.Drawing.Color.White;
            this.labelUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUrl.Location = new System.Drawing.Point(55, 228);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(280, 24);
            this.labelUrl.TabIndex = 19;
            this.labelUrl.Text = "Введите URL:";
            this.labelUrl.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultText = "";
            this.textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Location = new System.Drawing.Point(55, 254);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderText = "";
            this.textBox.SelectedText = "";
            this.textBox.Size = new System.Drawing.Size(234, 44);
            this.textBox.TabIndex = 20;
            this.textBox.Visible = false;
            // 
            // okButton
            // 
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.FillColor = System.Drawing.Color.MediumPurple;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(290, 254);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(45, 44);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "OK";
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // urlList
            // 
            this.urlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.urlList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urlList.ForeColor = System.Drawing.Color.White;
            this.urlList.FormattingEnabled = true;
            this.urlList.ItemHeight = 20;
            this.urlList.Items.AddRange(new object[] {
            "Europa Plus",
            "Radio Record-Phonk",
            "Dance Radio",
            "RM FM - Rock",
            "RM FM - 90s",
            "Радио Maximum - Grunge"});
            this.urlList.Location = new System.Drawing.Point(0, 30);
            this.urlList.Name = "urlList";
            this.urlList.Size = new System.Drawing.Size(382, 420);
            this.urlList.TabIndex = 17;
            this.urlList.Visible = false;
            this.urlList.SelectedIndexChanged += new System.EventHandler(this.urlList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 612);
            this.Controls.Add(this.addUrl);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.playlistButton);
            this.Controls.Add(this.timeLastedNow);
            this.Controls.Add(this.trackDuration);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.rewinding);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.urlList);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.trackName);
            this.Controls.Add(this.authorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buttonGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picture;
        private Guna.UI2.WinForms.Guna2CircleButton play;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button close;
        private Guna.UI2.WinForms.Guna2Button minimize;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar rewinding;
        private Guna.UI2.WinForms.Guna2ImageButton next;
        private Guna.UI2.WinForms.Guna2ImageButton previous;
        private Guna.UI2.WinForms.Guna2HtmlLabel trackName;
        private Guna.UI2.WinForms.Guna2HtmlLabel authorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel trackDuration;
        private Guna.UI2.WinForms.Guna2HtmlLabel timeLastedNow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ImageButton upload;
        private Guna.UI2.WinForms.Guna2ImageButton playlistButton;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton pause;
        private Guna.UI2.WinForms.Guna2GroupBox buttonGroup;
        private Guna.UI2.WinForms.Guna2ImageButton equalizer;
        private Guna.UI2.WinForms.Guna2ImageButton menu;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton search;
        private System.Windows.Forms.ListBox urlList;
        private Guna.UI2.WinForms.Guna2Button addUrl;
        private System.Windows.Forms.Label labelUrl;
        private Guna.UI2.WinForms.Guna2TextBox textBox;
        private Guna.UI2.WinForms.Guna2Button okButton;
    }
}

