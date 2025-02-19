using System.Runtime.InteropServices;

namespace paintdemo
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        int size = 5 ;
        bool stat = false;
        string locate;
        

        List<PSize> sizes = new List<PSize>()
        {
            new PSize(){Name = "Small", Sizes = 5},
            new PSize(){Name = "Medium", Sizes= 15},
            new PSize(){Name = "Large", Sizes = 30}
        };
        public Form1()
        {
            InitializeComponent();
            graphics = panel2.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black,size);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            colorChange.BackColor = Color.Black;
        }



        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pen.Color = pictureBox.BackColor;
            colorChange.BackColor = pictureBox.BackColor;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panel2.Cursor = Cursor.Current;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel2.Cursor = Cursor.Current;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if(comboBox.SelectedValue != null)
            {
                PSize? s = comboBox.SelectedValue as PSize;
                if(s.Name.ToString() == "Small")
                {
                    size = 5;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    pen = new Pen(Color.Black, size);
                    pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                }
                else if(s.Name.ToString() == "Medium")
                {
                    size = 10;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    pen = new Pen(Color.Black, size);
                    pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                }
                else if(s.Name.ToString() == "Large")
                {
                    size = 25;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    pen = new Pen(Color.Black, size);
                    pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                panel2.BackgroundImage = Image.FromFile(dialog.FileName); 
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog(); if (dialog.ShowDialog() == DialogResult.OK)
            {
                Graphics gr1 = panel2.CreateGraphics();
                Bitmap bmp1 = new Bitmap(panel2.Width, panel2.Height);
                panel2.DrawToBitmap(bmp1, new Rectangle(0, 0, panel2.Width, panel2.Height));
                bmp1.Save(dialog.FileName);
            }
        }
        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var re = MessageBox.Show("Bạn phải lưu trước khi set Background", "Bạn có chắc chưa", MessageBoxButtons.YesNoCancel);
            if (re == DialogResult.Yes)
            {
                SaveFileDialog dialog = new SaveFileDialog(); if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Graphics gr1 = panel2.CreateGraphics();
                    Bitmap bmp1 = new Bitmap(panel2.Width, panel2.Height);
                    panel2.DrawToBitmap(bmp1, new Rectangle(0, 0, panel2.Width, panel2.Height));
                    bmp1.Save(dialog.FileName);
                }
                DisplayPicture(dialog.FileName);
            }
        }
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);

        private const uint SPI_SETDESKWALLPAPER = 0x14;
        private const uint SPIF_UPDATEINIFILE = 0x1;
        private const uint SPIF_SENDWININICHANGE = 0x2;
        private static void DisplayPicture(string file_name)
        {
            uint flags = 0;
            if (!SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0, file_name, flags))
            {
                MessageBox.Show("error");
            }
        }
        public class PSize
        {
            public string Name { get; set; }
            public int Sizes { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = sizes;
            comboBox1.DisplayMember = "Name";
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                graphics.DrawEllipse(pen, e.X, e.Y, 100, 100);

            }
            if (checkBox3.Checked == true)
            {

                Rectangle re = new Rectangle();
                re.X = e.X;
                re.Y = e.Y;
                re.Height = 100;
                re.Width = 100;
                graphics.DrawRectangle(pen, re);

            }

            if (checkBox4.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\star-32.png";
                Image image = Image.FromFile(path);
                graphics.DrawImage(image, e.Location);
            }
            if (checkBox6.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\triangle-32.png";
                Image image = Image.FromFile(path);
                graphics.DrawImage(image, e.Location);
            }
            if (checkBox7.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\pentagon-32.png";
                Image image = Image.FromFile(path);

                graphics.DrawImage(image, e.Location);
            }
            if (checkBox8.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\hexagon-32.png";
                Image image = Image.FromFile(path);

                graphics.DrawImage(image, e.Location);
            }
            if (checkBox5.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\fire-heart-32.png";
                Image image = Image.FromFile(path);

                graphics.DrawImage(image, e.Location);
            }
            if (checkBox9.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\lightning-32.png";
                Image image = Image.FromFile(path);

                graphics.DrawImage(image, e.Location);
            }
            if (checkBox10.Checked == true)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Resources\\cat-32.png";
                Image image = Image.FromFile(path);

                graphics.DrawImage(image, e.Location);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filename = data as String[];
                if (filename.Length > 0)
                {
                    panel2.BackgroundImage = Image.FromFile(filename[0]);
                    locate = filename[0];
                }
            }
        }
        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Refresh();
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stat = false;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.White, size);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            panel2.Cursor = new Cursor(Application.StartupPath + "\\eraser.cur");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stat = false;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(pen.Color, size);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            panel2.Cursor = new Cursor(Application.StartupPath + "\\pencil.cur");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stat = true;
        }
        private void panel2_Click(object sender, EventArgs e)
        {

            if (stat)
            {
                panel2.BackColor = colorChange.BackColor;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image img = panel2.BackgroundImage;
            Bitmap thismap = new Bitmap(img, new Size(img.Width + 500, img.Height + 500));
            panel2.BackgroundImage = thismap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Lưu ý: Đừng bấm 3 lần :v
            Image img = panel2.BackgroundImage;
            Bitmap thismap = new Bitmap(img, new Size(img.Width - 500, img.Height - 500));
            panel2.BackgroundImage = thismap;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel5.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel5.Visible = true;
        }

        private void imagePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Location{locate}\nWidth:{panel2.BackgroundImage.Width}\nHeight:{panel2.BackgroundImage.Height}");

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RotateFlipType rotateFlip = RotateFlipType.Rotate90FlipNone;
            panel2.BackgroundImage.RotateFlip(rotateFlip);
            panel2.Refresh();
        }

        private void aboutPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }
    }
}