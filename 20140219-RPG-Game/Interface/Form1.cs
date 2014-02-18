using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Interface
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Talpa - Away.wav");
            checkBox1.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(soundPlayer);
            f2.ShowDialog();
            //f2.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.DarkGray;
            if (checkBox1.Checked)
            {
                //checkBox1.Text = "Music Off";
                soundPlayer.Play();
            }
            else
            {
                //checkBox1.Text = "Music On";
                soundPlayer.Stop();
            }
        }
    }
}
