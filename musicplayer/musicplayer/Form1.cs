using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackvolume.Value = 40;
            lblvolume.Text = trackvolume.Value + "%";
        }
        string[] path, file;
        
        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = path[track_list.SelectedIndex];
            player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(path[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pbArt.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {
                pbArt.Image = Properties.Resources._default;
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //if(track_list.SelectedIndex < track_list.Items.Count - 1)
            //{
                try
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
                catch
                {
                    track_list.SelectedIndex = 0;
                }

            //}
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            //if (track_list.SelectedIndex > 0)
            //{
                try
                {
                    track_list.SelectedIndex = track_list.SelectedIndex - 1;
                }
                catch
                {
                    track_list.SelectedIndex = track_list.Items.Count - 1;
                }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                pBar.Value = (int)player.Ctlcontrols.currentPosition;
                try
                {
                    lbltimestart.Text = player.Ctlcontrols.currentPositionString;
                    lbltimesum.Text = player.Ctlcontrols.currentItem.durationString;
                }
                catch
                {

                }
                if(pBar.Value == pBar.Maximum)
                {
                    try
                    {
                        track_list.SelectedIndex = track_list.SelectedIndex + 1;
                    }
                    catch
                    {
                        track_list.SelectedIndex = 0;
                    }
                }
            }
        }

        private void trackvolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackvolume.Value;
            lblvolume.Text = trackvolume.Value + "%";
        }

        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / pBar.Width;
        }

        private void pbArt_Click(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect= true;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = open.FileNames;

                path = open.FileNames;
                for (int x = 0; x < file.Length; x++)
                {
                    track_list.Items.Add(file[x]);
                }
            }
        }
    }
}
