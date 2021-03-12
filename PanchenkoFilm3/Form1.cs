using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanchenkoFilm
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.fon2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            pictureBox1.Size = new Size(160, 326);
            pictureBox2.Size = new Size(160, 326);
            pictureBox3.Size = new Size(160, 326);
            pictureBox4.Size = new Size(160, 326);
            pictureBox5.Size = new Size(160, 326);

            pictureBox1.Image = Properties.Resources.avengers;
            pictureBox2.Image = Properties.Resources.sherlock;
            pictureBox3.Image = Properties.Resources.spiderman;
            pictureBox4.Image = Properties.Resources.terminator;
            pictureBox5.Image = Properties.Resources.thor;

            pictureBox1.Location = new Point(173, 57);
            pictureBox2.Location = new Point(333, 57);
            pictureBox3.Location = new Point(493, 57);
            pictureBox4.Location = new Point(653, 57);
            pictureBox5.Location = new Point(813, 57);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox5);

            pictureBox1.Click += PictureBox1_Click;
            pictureBox2.Click += PictureBox2_Click;
            pictureBox3.Click += PictureBox3_Click;
            pictureBox4.Click += PictureBox4_Click;
            pictureBox5.Click += PictureBox5_Click;

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

            Saalid s = new Saalid(5, 5);
            s.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Saalid s = new Saalid(6, 6);
            s.Show();

        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Saalid s = new Saalid(7, 7);
            s.Show();

        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Saalid s = new Saalid(8, 8);
            s.Show();

        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Saalid s = new Saalid(9, 9);
            s.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
