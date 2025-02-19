namespace musicplayer
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
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.trackvolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.lbltimestart = new System.Windows.Forms.Label();
            this.lbltimesum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackvolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnprev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnprev.Location = new System.Drawing.Point(12, 614);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(185, 50);
            this.btnprev.TabIndex = 0;
            this.btnprev.Text = "Previous";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnnext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnnext.Location = new System.Drawing.Point(203, 614);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(185, 50);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnplay
            // 
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnplay.Location = new System.Drawing.Point(394, 614);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(185, 50);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnpause
            // 
            this.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnpause.Location = new System.Drawing.Point(585, 614);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(185, 50);
            this.btnpause.TabIndex = 3;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnstop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnstop.Location = new System.Drawing.Point(776, 614);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(185, 50);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnopen
            // 
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnopen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnopen.Location = new System.Drawing.Point(967, 614);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(303, 50);
            this.btnopen.TabIndex = 5;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 567);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(1258, 22);
            this.pBar.TabIndex = 6;
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 29;
            this.track_list.Location = new System.Drawing.Point(404, 133);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(753, 406);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pbArt
            // 
            this.pbArt.Image = global::musicplayer.Properties.Resources._default;
            this.pbArt.Location = new System.Drawing.Point(12, 155);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(376, 364);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 8;
            this.pbArt.TabStop = false;
            this.pbArt.Click += new System.EventHandler(this.pbArt_Click);
            // 
            // trackvolume
            // 
            this.trackvolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trackvolume.Location = new System.Drawing.Point(1197, 164);
            this.trackvolume.Maximum = 100;
            this.trackvolume.Name = "trackvolume";
            this.trackvolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackvolume.Size = new System.Drawing.Size(56, 341);
            this.trackvolume.TabIndex = 10;
            this.trackvolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackvolume.Scroll += new System.EventHandler(this.trackvolume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1185, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblvolume.ForeColor = System.Drawing.Color.Black;
            this.lblvolume.Location = new System.Drawing.Point(1189, 133);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(67, 25);
            this.lblvolume.TabIndex = 12;
            this.lblvolume.Text = "100%";
            // 
            // lbltimestart
            // 
            this.lbltimestart.AutoSize = true;
            this.lbltimestart.Font = new System.Drawing.Font("Dubai", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbltimestart.Location = new System.Drawing.Point(0, 11);
            this.lbltimestart.Name = "lbltimestart";
            this.lbltimestart.Size = new System.Drawing.Size(153, 84);
            this.lbltimestart.TabIndex = 13;
            this.lbltimestart.Text = "00:00";
            // 
            // lbltimesum
            // 
            this.lbltimesum.AutoSize = true;
            this.lbltimesum.Font = new System.Drawing.Font("Dubai", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimesum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbltimesum.Location = new System.Drawing.Point(1125, 11);
            this.lbltimesum.Name = "lbltimesum";
            this.lbltimesum.Size = new System.Drawing.Size(153, 84);
            this.lbltimesum.TabIndex = 14;
            this.lbltimesum.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 429);
            this.panel1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1282, 158);
            this.player.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1282, 713);
            this.Controls.Add(this.lbltimesum);
            this.Controls.Add(this.lbltimestart);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackvolume);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music player";
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackvolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.TrackBar trackvolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.Label lbltimestart;
        private System.Windows.Forms.Label lbltimesum;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
    }
}

