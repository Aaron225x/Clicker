using System;
using System.Windows.Forms;

//подключение библиотек проекта в точку входа.
using Кликер;
using Кликер.Classes;
using Кликер.Forms;

namespace Кликер
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
            Application.Run(new Form1());
        }
    }
}