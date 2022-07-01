using System;
using System.ComponentModel;
using System.Windows.Forms;

using Кликер.Classes;
using Кликер.Properties;

namespace Кликер.Forms
{
	/// <summary>
	/// класс формы с настройками.
	/// </summary>
	public partial class Settingers : Form
	{
		#region props
		/// <summary>
		/// свойство с настройкой "скрывать окна".
		/// </summary>
		/// <remarks>
		/// доступ к <see cref="Settings.HideForms"/>.
		/// </remarks>
		internal bool HideForms
		{
			get => Settings.HideForms;
			set => Settings.HideForms = value;
		}
		#endregion
		#region ctors
		/// <summary>
		/// конструктор формы.
		/// </summary>
		public Settingers()
		{
			InitializeComponent();
		}
		#endregion
		#region methods

		#region event handlers
		/// <summary>
		/// обработчик изменения чекбокса.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Form opend;
			HideForms = checkBox1.Checked;
			if (!HideForms)
			{
				for (int i = 0; i < Application.OpenForms.Count; i++)
				{
					opend = ActiveForms.GetForm(Application.OpenForms[i].Name);
					opend.Show();
				}
			}
			else
			{
				for (int i = 0; i < Application.OpenForms.Count; i++)
				{
					if (Application.OpenForms[i].Name != this.Name)
					{
						opend = ActiveForms.GetForm(Application.OpenForms[i].Name);
						opend.Hide();
					}
				}
			}
		}
		/// <summary>
		/// обработчик закрытия формы.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Settingers_FormClosing(object sender, FormClosingEventArgs e)
		{
			//так как метод закрытия переопределён, нам достаточно просто скрыть форму, и открыть главную.
			Hide(); //скрытие формы.
			((Form1)ActiveForms.GetForm("Form1")).Show(); //открытие главной формы.
		}
		/// <summary>
		/// обработчик события загрузки формы.
		/// </summary>
		/// <remarks>
		/// получение настроек из файла, и установка соответствующего значения в чекбокс.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GetSets(object sender, EventArgs e)
		{
			checkBox1.Checked = Settings.HideForms; //чекбокс равен значению из файла.
		}
		#endregion events
		#region overrides
		/// <summary>
		/// переопределение метода вызываемого при закрытии формы.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e); //вызов базового метода.
			e.Cancel = true; //изменение свойства, для того чтобы форма не закрывалась.
		}
		#endregion over
		
		#endregion methds
	}
}