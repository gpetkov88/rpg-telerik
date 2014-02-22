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
    public partial class MainMenu : Form
    {
        private SoundPlayer soundPlayer;

        public MainMenu()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("../../Resources/Talpa - Away.wav");
            bMusicSwitch.Checked = true;
        }
        //deleted the label1_click event, because I don't think it will be needed  S.R.
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Options_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            CharacterChoice form = new CharacterChoice(soundPlayer);
            form.ShowDialog();
            //f2.Visible = true;
        }

        private void MusicSwitch_CheckedChanged(object sender, EventArgs e)
        {
            bMusicSwitch.BackColor = Color.DarkGray;
            if (bMusicSwitch.Checked)
            {
                bMusicSwitch.Text = "Music off";
                soundPlayer.Play();
            }
            else
            {
                bMusicSwitch.Text = "Music on";//better do this with pictures
                soundPlayer.Stop();
            }
        }
        private void LoadGame_Click(object sender, EventArgs e)
        {

        }
    }
}
