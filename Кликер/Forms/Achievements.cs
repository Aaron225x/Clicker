using System;
using System.Drawing;
using System.Windows.Forms;

using Кликер;
using Кликер.Classes;

namespace Кликер.Forms
{
	//сокращения лейблов.
	//FAML - First  Achivement Message Label
	//FARL - First  Achivement Reward  Label
	//SAML - Second Achivement Message Label
	//SARL - Second Achivement Reward  Label
	//
	// и т.д.

	/// <summary>
	/// форма с ачивками (достижениями).
	/// </summary>
	public partial class Achievements : Form
	{
		#region fields
		private static string galochka = "✔";
		#endregion
		#region props
		/// <summary>
		/// значение денег с первой формы.
		/// </summary>
		internal int Money { get; set; }
		/// <summary>
		/// номер инструмента с первой формы.
		/// </summary>
		internal int NumberTool { get; set; }
		/// <summary>
		/// номер рабочих с первой формы.
		/// </summary>
		internal int NumberWorker { get; set; }
		#endregion
		#region constructors
		/// <summary>
		/// конструктор формы с ачивками.
		/// </summary>
		public Achievements()
		{
			InitializeComponent();
			moneyLabel.Text = ""; //очистка информации в лейбле.
		}
		#endregion
		#region methods
		/// <summary>
		/// проверка изменений в других формах.
		/// </summary>
		private void CheckUpdates()
		{
			Money = ValuesTransfer.Money;
			NumberTool = ValuesTransfer.NumberTool;
			NumberWorker = ValuesTransfer.NumberWorker;
		}
		//проверки достижений.
		/// <summary>
		/// проверка первого достижения.
		/// </summary>
		/// <returns>возвращается <see langword="true"/>, если условие для первого достижения выполнилось,
		/// иначе возвращается <see langword="false"/>.</returns>
		private bool CheckFirst()
		{
			if (NumberTool == 0 && NumberWorker == 0) return false;
			return true;
		}
		/// <summary>
		/// установка значений при для первого достижения.
		/// </summary>
		private void SetFirst()
		{
			if (CheckFirst())
			{
				FAMLabel.ForeColor = Color.Green;
				FARLabel.ForeColor = Color.Green;
				FARLabel.Text = galochka;
			}
		}
		#region event handler
		/// <summary>
		/// обновление значений на форме.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Updater(object sender, EventArgs e)
		{
			CheckUpdates(); //проверка изменений.
			SetFirst(); //проверка и установка первого достижения.
			moneyLabel.Text = $"{Money}$"; //обновление значений в этой форме.
		}
		/// <summary>
		/// закрывает эту форму, и открывает главную форму.
		/// </summary>
		/// <remarks>
		/// открытие главной формы нужно для того чтобы не было шансов обойти сохранение файла, так как сохранение файла происходит только в главной форме. <br/>
		/// не описывать же сохранение файлов в каждой форме, это не удобно при создании новой формы.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClosingForms(object sender, FormClosingEventArgs e) 
		{
					// // попытка сделать открытие главной формы, без потери этой формы в памяти открытых форм.
					//this.Hide(); //при закрытии формы, она больше не открывается.
					//Saver.GetForm("Form1").Show(); //так как при нажатии на крестик закрылась эта форма, её не надо скрывать. поэтому мы сразу открываем главную форму.

				//Application.Exit(); // Закрывает все формы // <--- комментарий оставленный на всякий случай

			Saver.AppClose(); //отдельный метод закрытия программы.
		}
		/// <summary>
		/// Кнопка перехода в форму кликер
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TransitionMain(object sender, EventArgs e)
		{
			Hide();
			ActiveForms.GetForm("Form1").Show();
		}
		#endregion
		#endregion
	}
}