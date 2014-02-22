using System;
using System.Windows.Forms;

namespace Interface
{
    static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            Knight player = new Knight(20, 20, 500, 25, 1000, 1000);
            Console.Write("player1: {0}, attack {1}, defense {2}, health {3}, damage {4}, gold {5}, experience {6}", player.GetType().ToString(), player.Attack, player.Defense, player.Health, player.Damage, player.Gold, player.Experience);
        }
    }
}
