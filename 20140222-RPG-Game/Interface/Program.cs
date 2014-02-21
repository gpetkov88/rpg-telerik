using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Knight player = new Knight(20, 20, 500, 25, 1000, 1000);
            Console.Write("player1: {0}, attack {1}, defence {2}, health {3}, damage {4}, gold {5}, experiance {6}", player.GetType().ToString(), player.Attack, player.Defence, player.Health, player.Damage, player.Gold, player.Experiance);
        }
    }
}
