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
using Кликер.Properties;

namespace Кликер.Forms
{
	public partial class Settingers : Form
	{
		internal bool HideForms
		{
			get => Settings.HideForms;
			set => Settings.HideForms = value;
		}
		public Settingers()
		{
			InitializeComponent();
		}
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
		/// переопределение метода вызываемого при закрытии формы.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			e.Cancel = true;
		}
		private void Settingers_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			((Form1)ActiveForms.GetForm("Form1")).Show();
		}
		private void trying(object sender, EventArgs e)
		{
			checkBox1.Checked = Settings.HideForms;
		}
	}
}
