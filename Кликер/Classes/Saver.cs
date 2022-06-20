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
		/// <summary>
		/// метод сохранения всех полей в формах.
		/// </summary>
		/// <remarks>
		/// сохраняет в Properties.Settings
		/// </remarks>
		public static void SaveAll()
		{
			Form1 main = (Form1)GetForm("Form1");
			if (main == null) { } //затычка на случай если нужная форма окажется закрыта.
			//main.Money
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