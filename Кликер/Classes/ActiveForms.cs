using System.Windows.Forms;

namespace Кликер.Classes
{
	class ActiveForms
	{
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
		internal static Form GetForm(string name)
		{
			Form getter = null;
			for (int i = 0; i < Application.OpenForms.Count; i++) //проход по всем открытм формам.
			{
				if (Application.OpenForms[i].Name == name) //если нашли нужную открытую форму
				{
					getter = Application.OpenForms[i]; //сохраняем в отдельную переменную.
					break; //сворачиваем выполнение цикла от лишних нагрузок.
				}
			}
			return getter;
		}
	}
}