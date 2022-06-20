﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			for (int i = 0; i < Application.OpenForms.Count; i++) //проход по всем открытм формам.
			{
				if (Application.OpenForms[i].Name == "Form1") //если нашли нужную открытую форму
				{
					Application.OpenForms[i].Show(); //показываем её.
					return; //сворачиваем выполнение метода от лишних нагрузок.
				}
			}
		}
	}
}
