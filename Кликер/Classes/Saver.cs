using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Кликер;

namespace Кликер.Classes
{
	class Saver
	{
		public static void SaveAll()
		{
			Form1 main = (Form1)GetForm("Form1");
			if (main == null) { } //затычка на случай если нужная форма окажется закрыта.
			//main.Money
		}
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