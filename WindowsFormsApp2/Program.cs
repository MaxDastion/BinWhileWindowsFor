using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\Студент\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\Music\\Motivtion.wav";
            player.PlayLooping();
            Application.Run(new Form1());
        }
    }
}
