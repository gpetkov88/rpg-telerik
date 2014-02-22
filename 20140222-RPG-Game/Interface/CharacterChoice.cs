using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace Interface
{

     
    public partial class CharacterChoice : Form
    {
        private SoundPlayer soundPlayer;
        public CharacterChoice(SoundPlayer soundPlayer)
        {
            InitializeComponent();
            this.soundPlayer = soundPlayer;
            cbMage.Checked = true;
        }

        private void CharacterChoice_Load(object sender, EventArgs e)
        {

        }

        private void Knight_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKnight.Checked)
            {
                cbMage.Checked = false;
                cbArcher.Checked = false;
                cbAmazon.Checked = false;
            }
        }
        private void PicMage_Click(object sender, EventArgs e)
        {
            cbMage.Checked = true;
            if (cbMage.Checked)
            {
                cbKnight.Checked = false;
                cbArcher.Checked = false;
                cbAmazon.Checked = false;
            }
        }

        private void PicKnight_Click(object sender, EventArgs e)
        {
            cbKnight.Checked = true;
            if (cbKnight.Checked)
            {
                cbMage.Checked = false;
                cbArcher.Checked = false;
                cbAmazon.Checked = false;
            }
        }

        private void Mage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMage.Checked)
            {
                cbKnight.Checked = false;
                cbArcher.Checked = false;
                cbAmazon.Checked = false;
            }
        }

        private void Archer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArcher.Checked)
            {
                cbMage.Checked = false;
                cbKnight.Checked = false;
                cbAmazon.Checked = false;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            GameMap game = new GameMap();
            game.ShowDialog();
        }

        private void PicArcher_Click(object sender, EventArgs e)
        {
            cbArcher.Checked = true;
            if (cbArcher.Checked)
            {
                cbMage.Checked = false;
                cbKnight.Checked = false;
                cbAmazon.Checked = false;
            }
        }

        private void Amazon_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbAmazon.Checked)
            {
                cbMage.Checked = false;
                cbKnight.Checked = false;
                cbArcher.Checked = false;
            }
        }

        private void PicAmazon_Click(object sender, EventArgs e)
        {
            cbAmazon.Checked = true;
            if (cbArcher.Checked)
            {
                cbMage.Checked = false;
                cbKnight.Checked = false;
                cbArcher.Checked = false;
            }
        }

        private void MusicChoice_CheckedChanged(object sender, EventArgs e)
        {
            cbMage.BackColor = Color.DarkGray;
            if (cbMage.Checked)
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
