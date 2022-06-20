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

using Кликер.Classes; //подключение папки с классом.

namespace Кликер
{
	public partial class Form1 : Form
	{
		#region fields
		private int money = 0; //Деньги

		private int numberTool = 0; //Номер обилки инструмента
		private int numberWorker = 0; //Номер обилки рабочего
									  
		private int sumTool = 10; //Сумма стоимости обилки инструмента
		private int sumWorker = 100; //Сумма стоимости обилки рабочего

		private int incomeTool = 0; //Доход от обилки инструмент
		private int incomeWorker = 0; //Доход от обилки рабочий

		public static Form1 frm = new Form1();
		public static Achievements frm1 = new Achievements();
		#endregion
		#region properties
		public int Money { get => money; }
		
		public int NumberTool { get => numberTool; }
		public int NumberWorker { get => numberWorker; }

		public int SumTool { get => sumTool; }
		public int SumWorker { get => sumWorker; }

		public int IncomeTool { get => incomeTool; }
		public int IncomeWorker { get => incomeWorker; }
		#endregion
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
		/// Кнопка выхода из программы
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
		/// <summary>
		/// Обилка рабочего
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImproveWorkerButton_Click(object sender, EventArgs e)
		{
			if (money >= sumWorker)
			{
				money -= sumWorker; //Деньги тратятся
				sumWorker *= 2; //Цена на обилку умнодается на два
				numberWorker++; //Сколько раз улучшил
				incomeWorker += 4; //+ 4 клика
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
		/// <summary>
		/// Кнопка перехода в форму достижения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TransitionAchievements(object sender, EventArgs e)
		{
			Hide();
			frm1.Show();
		}
		/// <summary>
		/// Закрывает все формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClosingForms(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
