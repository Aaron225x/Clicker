using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//использование папки с формами.
using Кликер.Forms;

namespace Кликер.Classes
{
	/// <summary>
	/// класс для передачи значений между формами.
	/// </summary>
	internal static class ValuesTransfer
	{
		/// <summary>
		/// значение денег в первой форме.
		/// </summary>
		internal static int money;

		internal static void GetValues()
		{
			money = ((Form1)ActiveForms.GetForm("Form1")).Money;
		}
	}
}