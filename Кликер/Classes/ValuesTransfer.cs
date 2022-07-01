using Кликер.Forms;

namespace Кликер.Classes
{
	/// <summary>
	/// класс для передачи значений между формами.
	/// </summary>
	internal static class ValuesTransfer
	{
		internal static int Money { get; set; } //если что, это называется "автосвойство".

		internal static int NumberTool { get; set; }
		internal static int NumberWorker { get; set; }

		internal static int SumTool { get; set; }
		internal static int SumWorker { get; set; }

		internal static int IncomeTool { get; set; }
		internal static int IncomeWorker { get; set; }


		/// <summary>
		/// получение значений с первой формы в поля этого класса (<see cref="ValuesTransfer"/>).
		/// </summary>
		/// <remarks>
		/// обновление полей класса.
		/// </remarks>
		internal static void GetValues()
		{
			Money = ((Form1)ActiveForms.GetForm("Form1")).Money;

			NumberTool = ((Form1)ActiveForms.GetForm("Form1")).NumberTool;
			NumberWorker = ((Form1)ActiveForms.GetForm("Form1")).NumberWorker;

			SumTool = ((Form1)ActiveForms.GetForm("Form1")).SumTool;
			SumWorker = ((Form1)ActiveForms.GetForm("Form1")).SumWorker;

			IncomeTool = ((Form1)ActiveForms.GetForm("Form1")).IncomeTool;
			IncomeWorker = ((Form1)ActiveForms.GetForm("Form1")).IncomeWorker;

			//если нужны другие поля с первой формы, то надо добавить автосвойство в класс, и значение для этого автосвойства здесь.
		}
	}
}