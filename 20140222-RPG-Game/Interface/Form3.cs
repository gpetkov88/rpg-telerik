using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form3 : Form
    {
        public static readonly int[,] Map = new int[,]
        {
            {9,9,1,1,1,0,0,0,0,0,1,0,0,0,0,0},
            {9,9,9,0,1,0,0,0,0,0,1,0,0,0,0,0},
            {0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0},
            {0,0,0,0,1,0,0,0,0,0,1,0,1,1,1,1},
            {0,0,0,0,1,0,0,0,0,0,1,0,1,0,0,1},
            {9,9,9,0,2,1,1,1,1,2,2,1,1,0,0,1},
            {1,9,9,0,1,0,0,0,0,1,0,0,0,0,0,1},
            {1,0,0,1,1,0,0,0,0,1,0,0,0,0,0,1},
            {1,0,0,1,0,0,0,0,0,1,3,3,3,3,3,2},
            {1,0,1,2,1,1,1,1,1,2,3,1,1,1,1,1},
            {1,0,1,0,0,0,0,0,0,2,3,0,0,0,0,0},
            {1,1,2,1,1,1,1,1,1,2,1,1,1,1,1,1},
        };
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 960;
            pictureBox1.Height = 720;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
