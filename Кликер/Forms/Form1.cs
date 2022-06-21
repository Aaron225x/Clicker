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
		private int money; //Деньги

		private int numberTool; //Номер обилки инструмента
		private int numberWorker; //Номер обилки рабочего
									  
		private int sumTool; //Сумма стоимости обилки инструмента
		private int sumWorker; //Сумма стоимости обилки рабочего

		private int incomeTool; //Доход от обилки инструмент
		private int incomeWorker; //Доход от обилки рабочий

		public static Form1 frm = new Form1();
		public static Achievements frm1 = new Achievements();
		#endregion
		#region properties
		public int Money 
		{
			get => money;
			set => money = value;
		}
		
		public int NumberTool
		{
			get => numberTool;
			set => numberTool = value;
		}
		public int NumberWorker
		{
			get => numberWorker;
			set => numberWorker = value;
		}

		public int SumTool
		{
			get => sumTool;
			set => sumTool = value;
		}
		public int SumWorker
		{
			get => sumWorker;
			set => sumWorker = value;
		}

		public int IncomeTool
		{
			get => incomeTool; 
			set => incomeTool = value;
		}
		public int IncomeWorker
		{
			get => incomeWorker; 
			set => incomeWorker = value;
		}
		#endregion
		#region constructors
		public Form1()
		{
			InitializeComponent();
			frm = this;
		}
		#endregion
		#region methods

		/// <summary>
		/// метод обновления значений в форме.
		/// </summary>
		public void Updater()
		{
			frm.points.Text = $"{money}$"; //Обновляет статистику
			
			improveTool.Text = $"{numberTool}x   {sumTool}$"; // строка123 --> поэтому я так и сделаю.

			improveWorker.Text = $"{numberWorker}x   {sumWorker}$";
		}

		#region event handlers

		/// <summary>
		/// таймер для обновления значений.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void updatechecker_Tick(object sender, EventArgs e)
		{
			Updater();
		}
		/// <summary>
		/// событие загрузки формы.
		/// </summary>
		/// <remarks>
		/// нужно для получения сохранений с памяти компа.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			Saver.SetAll(); //получение значений из памяти.
			Updater(); //обновление значений в форме.
		}
		/// <summary>
		/// обработчик события нажатия на главную кнопку.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Point_Click(object sender, EventArgs e)
		{
			money += incomeTool;
			money++;
			//points.Text = $"{money}$"; //Обновляет статистику
			Updater();
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
				//points.Text = $"{money}$"; //Обновляет статистику
				int number = numberTool;
				int sum = sumTool;
				//improveTool.Text = $"{number}x   {sum}$"; // (вдм) я не очень понял зачем тут переносить переменные, если можно сразу запихать поля.

				Updater();
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
				//points.Text = $"{money}$"; //Обновляет статистику
				int number = numberWorker;
				int sum = sumWorker;
				//improveWorker.Text = $"{number}x   {sum}$";

				Updater();

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
			//points.Text = $"{money}$"; //Обновляет статистику

			//Updater();
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
			Exit_Click(sender, e);
		}
		/// <summary>
		/// Кнопка выхода из программы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_Click(object sender, EventArgs e)
		{
			Saver.SaveAll();
			Application.Exit();
		}
		#endregion events

		#endregion methods

	}
}