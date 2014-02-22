using System;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class GameMap : Form
    {
        public GameMap()
        {
            InitializeComponent();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            pbMap.Width = 960;
            pbMap.Height = 720;
        }

        private void GameMap_Load(object sender, EventArgs e)
        {

        }
    }
}
