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
		/// Закрывает все формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClosingForms(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
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
