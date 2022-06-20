using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Кликер.Classes;

namespace Кликер
{
	public partial class Achievements : Form
	{
		public Achievements()
		{
			InitializeComponent();
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

			Saver.SaveAll(); //сохранение значений.
			Application.Exit(); //выход из программы.
		}
		/// <summary>
		/// Кнопка перехода в форму кликер
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TransitionMain(object sender, EventArgs e)
		{
			Hide();
			Saver.GetForm("Form1").Show();
		}
	}
}
