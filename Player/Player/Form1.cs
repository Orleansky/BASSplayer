using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form1 : Form
    {
        public static bool IsShown = false;

        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            BassL.InitBass(BassL.SampleRate);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Vars.Files.Add(tmp[i]);
                TagModel TM = new TagModel(tmp[i], null);
                playlist.Items.Add(TM.Artist + " - " + TM.Title);
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (playlist.Items.Count != 0 && playlist.SelectedIndex != -1)
            {
                (play.Image, pause.Image) = (pause.Image, play.Image);
                (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                if (!timer1.Enabled)
                {
                    string current = Vars.Files[playlist.SelectedIndex];
                    BassL.Play(current, null, BassL.Volume);

                    TagModel TM = new TagModel(current, null);
                    trackName.Text = TM.Title;
                    authorName.Text = TM.Artist;
                    picture.Image = TM.Image;

                    timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                    trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                    rewinding.Maximum = BassL.GetTimeOfStream(BassL.Stream);
                    rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                    timer1.Enabled = true;
                }
                else
                {
                    BassL.Stop();
                    timer1.Enabled = false;
                }
            }
            else if (urlList.Items.Count != 0 && urlList.SelectedIndex != -1)
            {
                (play.Image, pause.Image) = (pause.Image, play.Image);
                (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                if (!timer1.Enabled)
                {
                    string current = Vars.URLs[urlList.SelectedIndex];
                    BassL.Play(null, current, BassL.Volume);

                    TagModel TM = new TagModel(null, current);
                    trackName.Text = TM.Title;
                    authorName.Text = TM.Artist;

                    timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                    trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                    if (rewinding.Maximum > 0)
                {
                    rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                }
                    timer1.Enabled = true;
                } else
                {
                    BassL.Stop();
                    timer1.Enabled = false;
                }
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
            if (rewinding.Maximum == BassL.GetTimeOfStream(BassL.Stream))
            {
                rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
            } else
            {
                rewinding.Value = rewinding.Maximum;
            }

                if (rewinding.Value == rewinding.Maximum && rewinding.Maximum == BassL.GetTimeOfStream(BassL.Stream))
            {
                next_Click(sender, e);
            }
        }

        private void rewinding_Scroll(object sender, ScrollEventArgs e)
        {
            BassL.SetPosOfScroll(BassL.Stream, rewinding.Value);
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            if (!playlist.Visible)
            {
                playlist.Visible = true;
            }
            else
            {
                playlist.Visible = false;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (playlist.Items.Count != 0 && playlist.SelectedIndex != -1)
            {
                if (playlist.SelectedIndex < playlist.Items.Count - 1)
                {
                    playlist.SelectedIndex++;
                }
                else
                {
                    playlist.SelectedIndex = 0;
                }
                if (!timer1.Enabled)
                {
                    (play.Image, pause.Image) = (pause.Image, play.Image);
                    (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                }

                string current = Vars.Files[playlist.SelectedIndex];
                BassL.Play(current, null, BassL.Volume);

                TagModel TM = new TagModel(current, null);
                trackName.Text = TM.Title;
                authorName.Text = TM.Artist;
                picture.Image = TM.Image;

                timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                rewinding.Maximum = BassL.GetTimeOfStream(BassL.Stream);
                rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                timer1.Enabled = true;

            } else if (urlList.Items.Count != 0 && urlList.SelectedIndex != -1)
            {
                if (urlList.SelectedIndex < urlList.Items.Count - 1)
                {
                    urlList.SelectedIndex++;
                }
                else
                {
                    urlList.SelectedIndex = 0;
                }
                if (!timer1.Enabled)
                {
                    (play.Image, pause.Image) = (pause.Image, play.Image);
                    (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                }

                string current = Vars.URLs[urlList.SelectedIndex];
                BassL.Play(null, current, BassL.Volume);

                TagModel TM = new TagModel(null, current);
                trackName.Text = TM.Title;
                authorName.Text = TM.Artist;

                timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                if (rewinding.Maximum > 0)
                {
                    rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                }
                timer1.Enabled = true;

                BassL.SetSampleRate(BassL.Stream, 44100);
                BassL.RemoveEffects();
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (playlist.SelectedIndex > 0)
            {
                playlist.SelectedIndex--;
                if (!timer1.Enabled)
                {
                    (play.Image, pause.Image) = (pause.Image, play.Image);
                    (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                }
                
                string current = Vars.Files[playlist.SelectedIndex];
                BassL.Play(current, null, BassL.Volume);

                TagModel TM = new TagModel(current, null);
                trackName.Text = TM.Title;
                authorName.Text = TM.Artist;
                picture.Image = TM.Image;

                timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                rewinding.Maximum = BassL.GetTimeOfStream(BassL.Stream);
                rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                timer1.Enabled = true;
            } else if (urlList.SelectedIndex > 0)
            {
                urlList.SelectedIndex--;

                if (!timer1.Enabled)
                {
                    (play.Image, pause.Image) = (pause.Image, play.Image);
                    (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                }

                string current = Vars.URLs[urlList.SelectedIndex];
                BassL.Play(null, current, BassL.Volume);

                TagModel TM = new TagModel(null, current);
                trackName.Text = TM.Title;
                authorName.Text = TM.Artist;

                timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                if (rewinding.Maximum > 0)
                {
                    rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                }
                timer1.Enabled = true;

                BassL.SetSampleRate(BassL.Stream, 44100);
                BassL.RemoveEffects();
            }
        }
        private void playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playlist.SelectedIndex >= 0 && playlist.SelectedIndex < playlist.Items.Count)
            {
                if (!timer1.Enabled)
                {
                    (play.Image, pause.Image) = (pause.Image, play.Image);
                    (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                }

                string current = Vars.Files[playlist.SelectedIndex];
                BassL.Play(current, null, BassL.Volume);

                BassL.SetDefaultSampleRate();
                BassL.RemoveEffects();

                TagModel TM = new TagModel(current, null);
                trackName.Text = TM.Title;
                authorName.Text = TM.Artist;
                picture.Image = TM.Image;

                timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");
                rewinding.Maximum = BassL.GetTimeOfStream(BassL.Stream);
                rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                timer1.Enabled = true;

                urlList.SelectedIndex = -1;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (buttonGroup.Visible)
            {
                buttonGroup.Visible = false;
            }
            else
            {
                buttonGroup.Visible = true;
            }
        }

        private void equalizer_Click(object sender, EventArgs e)
        {
            if (!IsShown)
            {
                Form2 settingsForm = new Form2();
                settingsForm.Show();
                IsShown = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BassL.Stop();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (urlList.Visible)
            {
                addUrl.Visible = false;
                urlList.Visible = false;
            }
            else
            {
                addUrl.Visible = true;
                urlList.Visible = true;
            }
        }

        private void urlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urlList.SelectedIndex >= 0 && urlList.SelectedIndex < urlList.Items.Count)
            {
                if (!timer1.Enabled)
                {
                    (play.Image, pause.Image) = (pause.Image, play.Image);
                    (play.ImageSize, pause.ImageSize) = (pause.ImageSize, play.ImageSize);
                }

                string current = Vars.URLs[urlList.SelectedIndex];
                BassL.Play(null, current, BassL.Volume);

                TagModel TM = new TagModel(null, current);

                trackName.Text = TM.Title;
                authorName.Text = TM.Artist;

                timeLastedNow.Text = TimeSpan.FromSeconds(BassL.GetPosOfStream(BassL.Stream)).ToString(@"m\:ss");
                trackDuration.Text = TimeSpan.FromSeconds(BassL.GetTimeOfStream(BassL.Stream)).ToString(@"m\:ss");

                if (BassL.GetTimeOfStream(BassL.Stream) > 0)
                {
                    rewinding.Maximum = BassL.GetTimeOfStream(BassL.Stream);
                }
                
                rewinding.Value = BassL.GetPosOfStream(BassL.Stream);
                timer1.Enabled = true;

                playlist.SelectedIndex = -1;

                BassL.SetSampleRate(BassL.Stream, 44100);
                BassL.RemoveEffects();
            }
        }

        private void addUrl_Click(object sender, EventArgs e)
        {
            if (!labelUrl.Visible)
            {
                labelUrl.Visible = true;
                textBox.Visible = true;
                okButton.Visible = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            labelUrl.Visible = false;
            textBox.Visible = false;
            okButton.Visible = false;

            string url = textBox.Text;

            Vars.URLs.Add(url);
            TagModel TM = new TagModel(null, url);
            urlList.Items.Add(TM.Artist + " - " + TM.Title);
        }
    }
}