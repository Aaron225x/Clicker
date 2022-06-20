using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Кликер;
using Кликер.Properties;
using System.Configuration;
using static Кликер.Properties.Settings; //сокращение для Settings.Default

namespace Кликер.Classes
{
	class Saver : ApplicationSettingsBase
	{
		private static readonly Form1 main = (Form1)GetForm("Form1"); //поле со значением первой формы.

		/// <summary>
		/// метод получения значений из настроек.
		/// </summary>
		public static void SetAll()
		{
			if (main is null) { return; }
			GetMain();
		}
		/// <summary>
		/// метод сохранения всех полей во всех формах.
		/// </summary>
		/// <remarks>
		/// сохраняет в Properties.Settings
		/// </remarks>
		public static void SaveAll()
		{
			if (main == null) { return; } //затычка на случай если нужная форма окажется закрыта.
			SaveMain(); //сохранения полей 
			Default.Save(); //сохранение.
			



			//Default.Initialize(Default.Context, Default.Properties, Default.Providers); //попытка создать файл с настройками (неудачно)
			////попытка сохранить саму форму в настройки программы.
			//Settings.Default.Form1 = main;
			//Settings.Default.Save();
		}
		/// <summary>
		/// сохранение значений полей в первой форме.
		/// </summary>
		public static void SaveMain()
		{
			//Form1 x = new Form1();
			//Binding binding = new Binding();
			//x.DataBindings.Add(,);
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
		public static void GetMain()
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
		/// поиск открытой формы по указанному имени в параметрах.
		/// </summary>
		/// <param name="name">имя формы, которую надо найти.</param>
		/// <returns>
		/// если открытая форма нашлась, <br/>
		/// то она возвращается типом <see cref="Form"/>, <br/>
		/// после чего можно её явно преобразовать. <br/>
		/// пример: (<see cref="Form1"/>)<see cref="GetForm"/>. <br/><br/>
		/// но если открытая форма не нашлась, то возвращается <see langword="null"/>.
		/// </returns>
		public static Form GetForm(string name)
		{
			Form getter = null;
			for (int i = 0; i < Application.OpenForms.Count; i++) //проход по всем открытм формам.
			{
				if (Application.OpenForms[i].Name == name) //если нашли нужную открытую форму
				{
					getter = (Form1)Application.OpenForms[i]; //сохраняем в отдельную переменную.
					break; //сворачиваем выполнение цикла от лишних нагрузок.
				}
			}
			return getter;
		}
	}
}