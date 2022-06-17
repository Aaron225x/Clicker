using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Кликер
{
    public partial class Form1 : Form
    {
        private int money = 0; //Деньги

        private int numberTool = 0; //Номер обилки инструмента
        private int numberWorker = 0; //Номер обилки рабочего
                                      
        private int sumTool = 10; //Сумма стоимости обилки инструмента
        private int sumWorker = 100; //Сумма стоимости обилки рабочего

        private int incomeTool = 0; //Доход от обилки инструмент
        private int incomeWorker = 0; //Доход от обилки рабочий

        public Form1()
        {
            InitializeComponent();
        }
        private void Point_Click(object sender, EventArgs e)
        {
            money += incomeTool;
            money++;
            points.Text = $"{money}$"; //Обновляет статистику

        }
        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обилка инструмента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImproveToolButton_Click(object sender, EventArgs e)
        {
            if (money >= sumTool)
            {
                money -= sumTool; //Деньги тратятся
                sumTool *= 2; //Цена на обилку умножается на два
                numberTool++; //Сколько раз улучшил
                incomeTool += 4; //+ 4 клика
                points.Text = $"{money}$"; //Обновляет статистику
                int number = numberTool;
                int sum = sumTool;
                improveTool.Text = $"{number}x   {sum}$";
            }
        }

        private void ImproveWorkerButton_Click(object sender, EventArgs e)
        {
            if (money >= sumWorker)
            {
                money -= sumWorker; //Деньги тратятся
                sumWorker *= 2; //Цена на обилку умнодается на два
                numberWorker++; //Сколько раз улучшил
                incomeWorker += 2; //+ 2 клика
                points.Text = $"{money}$"; //Обновляет статистику
                int number = numberWorker;
                int sum = sumWorker;
                improveWorker.Text = $"{number}x   {sum}$";

            }
        }
        /// <summary>
        /// Таймер для рабочего. Работает раз 1 секунду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            money += incomeWorker;
            points.Text = $"{money}$"; //Обновляет статистику
        }
    }
}
