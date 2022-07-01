using System.Windows.Forms;

using Кликер.Forms;
using static Кликер.Properties.Settings; //сокращение для Кликер.Properties.Settings.Default

namespace Кликер.Classes
{
	static class Saver
	{
		#region fields
		/// <summary>
		/// поле со значением первой формы.
		/// </summary>
		/// <remarks>
		/// главная форма.
		/// </remarks>
		private static readonly Form1 main = (Form1)ActiveForms.GetForm("Form1");
		/// <summary>
		/// поле со значением второй формы.
		/// </summary>
		/// <remarks>
		/// форма с достижениями.
		/// </remarks>
		private static readonly Achievements achiv = (Achievements)ActiveForms.GetForm("Achievements");
		/// <summary>
		/// поле со значением третьей формы.
		/// </summary>
		/// <remarks>
		/// форма с настройками.
		/// </remarks>
		private static readonly Settingers sttns = (Settingers)ActiveForms.GetForm("Settingers");
		#endregion
		#region methods

		#region Save
		/// <summary>
		/// метод сохранения всех полей во всех формах.
		/// </summary>
		/// <remarks>
		/// сохраняет в Properties.Settings
		/// </remarks>
		internal static void SaveAll()
		{
			if (main == null) { return; } //затычка на случай если нужная форма окажется закрыта.
			SaveMain(); //сохранения полей.
			SaveSettings(); //сохранение значений настроек.
			Default.Save(); //сохранение в память.
		}
		/// <summary>
		/// сохранение значений полей в третьей форме.
		/// </summary>
		internal static void SaveSettings()
		{
			Default.Hider = HideForms;
		}
		/// <summary>
		/// сохранение значений полей в первой форме.
		/// </summary>
		internal static void SaveMain()
		{
			Default.money = main.Money;

			Default.numberTool = main.NumberTool;
			Default.numberWorker = main.NumberWorker;

			Default.sumTool = main.SumTool;
			Default.sumWorker = main.SumWorker;

			Default.incomeTool = main.IncomeTool;
			Default.incomeWorker = main.IncomeWorker;
		}
		#endregion sv
		#region Get
		/// <summary>
		/// метод установки значений из настроек.
		/// </summary>
		internal static void SetAll()
		{
			if (main is null) { return; } //если главная форма не открыта - выход из метода.
			GetSettings(); //установка значений для формы с настройками.
			GetMain(); //установка полям в главной форме.
		}
		/// <summary>
		/// установка значений из третьей формы.
		/// </summary>
		internal static void GetSettings()
		{
			HideForms = Default.Hider;
		}
		/// <summary>
		/// метод установки всем полям в главной форме значений из настроек.
		/// </summary>
		internal static void GetMain()
		{
			main.Money = Default.money;

			main.NumberTool = Default.numberTool;
			main.NumberWorker = Default.numberWorker;

			main.SumTool = Default.sumTool;
			main.SumWorker = Default.sumWorker;

			main.IncomeTool = Default.incomeTool;
			main.IncomeWorker = Default.incomeWorker;
		}
		#endregion gt

		/// <summary>
		/// метод закрытия всей программы.
		/// </summary>
		/// <remarks>
		/// нужно для определённой последовательности действий перед закрытием программы.
		/// </remarks>
		internal static void AppClose()
		{
			Saver.SaveAll();
			Application.Exit();
		}

		#endregion mtds
	}
}