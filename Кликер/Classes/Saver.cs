using System.Windows.Forms;

using Кликер;
using Кликер.Forms;

using static Кликер.Properties.Settings; //сокращение для Settings.Default
namespace Кликер.Classes
{
	static class Saver
	{
		private static readonly Form1 main = (Form1)ActiveForms.GetForm("Form1"); //поле со значением первой формы.
		private static readonly Achievements achiv = (Achievements)ActiveForms.GetForm("Achievements"); //поле со значением второй формы.

		/// <summary>
		/// метод установки значений из настроек.
		/// </summary>
		internal static void SetAll()
		{
			if (main is null) { return; } //если главная форма не открыта - выход из метода.
			GetMain(); //установка полям 
		}
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
			Default.Save(); //сохранение в память.
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
	}
}