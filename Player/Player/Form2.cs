using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Player
{
    public partial class Form2 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form2()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.IsShown = false;
            audioVis.Stop();
            audioVis.Dispose();
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

        private void effects_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (effects.SelectedIndex)
            {
                case 0: BassL.RemoveEffects(); break;

                case 1: BassL.AddEcho(); break;

                case 2: BassL.AddReverb(); break;
            }
        }

        private void freqBar_Scroll(object sender, ScrollEventArgs e)
        {
            int sampleRate = freqBar.Value;
            BassL.SetSampleRate(BassL.Stream, sampleRate);
        }

        private void freqButton_Click(object sender, EventArgs e)
        {
            int sampleRate = 44200;
            BassL.SetSampleRate(BassL.Stream, sampleRate);
            freqBar.Value = sampleRate;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (freqBar.Value != BassL.GetSampleRate(BassL.Stream))
            {
                freqBar.Value = BassL.GetSampleRate(BassL.Stream);
                effects.SelectedIndex = 0;
            }
        }

        private void audioVis_Load(object sender, EventArgs e)
        {
            audioVis.Mode = CSAudioVisualization.Mode.WasapiCapture;
            audioVis.DeviceIndex = 0;
            audioVis.HighQuality = true;
            audioVis.BackColor = Color.Black;
            audioVis.ColorBase = Color.BlueViolet;
            audioVis.ColorMax = Color.Violet;
            audioVis.BarCount = 20;
            audioVis.BarSpacing = 5;
            audioVis.Interval = 40;
            audioVis.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            audioVis.Stop();
            audioVis.Dispose();
        }
    }
}
