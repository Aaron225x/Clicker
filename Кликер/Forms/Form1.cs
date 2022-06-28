using System;
using System.Windows.Forms;

//подключение пространств проекта.
using Кликер;
using Кликер.Classes; 

namespace Кликер.Forms
{
	/// <summary>
	/// класс главной формы.
	/// </summary>
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

		public static Form1 frm;
		public static Achievements frm1;
		#endregion
		#region properties
		//свойства для доступа к полям. нужно для других форм или сохранений значений на диске.

		internal int Money 
		{
			get => money;
			set => money = value;
		}

		internal int NumberTool
		{
			get => numberTool;
			set => numberTool = value;
		}
		internal int NumberWorker
		{
			get => numberWorker;
			set => numberWorker = value;
		}

		internal int SumTool
		{
			get => sumTool;
			set => sumTool = value;
		}
		internal int SumWorker
		{
			get => sumWorker;
			set => sumWorker = value;
		}

		internal int IncomeTool
		{
			get => incomeTool; 
			set => incomeTool = value;
		}
		internal int IncomeWorker
		{
			get => incomeWorker; 
			set => incomeWorker = value;
		}
		#endregion
		#region constructors
		/// <summary>
		/// конструктор главной формы.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			frm = this; //установка в поле с формой вызванную форму.
			frm1 = new Achievements(); //установка в поле со второй формой конструктор второй формы.
		}
		#endregion
		#region methods

		/// <summary>
		/// метод обновления значений в форме.
		/// </summary>
		public void Updater()
		{
			points.Text = $"{money}$"; //Обновляет статистику
			
			improveTool.Text = $"{numberTool}x   {sumTool}$"; // строка149 --> поэтому я так и сделаю.

			improveWorker.Text = $"{numberWorker}x   {sumWorker}$";


			//установка значений для остальных форм.
			ValuesTransfer.GetValues();
		}

		//регион с обработчиками событий.
		#region event handlers

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
				//int number = numberTool;
				//int sum = sumTool;
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
				//int number = numberWorker;
				//int sum = sumWorker;
				//improveWorker.Text = $"{number}x   {sum}$";

				Updater();

			}
		}
		/// <summary>
		/// Таймер для рабочего. Работает раз 1 секунду
		/// </summary>
		/// <remarks>
		/// обновление значений на экране перенесено на отдельный таймер. <br/><br/>
		/// обработчик таймера: <see cref="updatechecker_Tick(object, EventArgs)"/>
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			money += incomeWorker;
			//points.Text = $"{money}$"; //Обновляет статистику

			//Updater(); //обновление информации перенесено в отдельный таймер.
		}
		/// <summary>
		/// таймер для обновления значений.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void updatechecker_Tick(object sender, EventArgs e)
		{
			Updater();
		}


		//регион с закрытием, или сменой формы.
		#region form close
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
			Saver.AppClose();
		}
		/// <summary>
		/// Кнопка выхода из программы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_Click(object sender, EventArgs e)
		{
			Saver.AppClose();
		}
		#endregion forms

		#endregion events

		#endregion methods
	}
}