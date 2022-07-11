using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Кликер.Classes;
using Кликер.Properties;

namespace Кликер.Forms
{
	//сокращения лейблов.
	//FAML - First  Achivement Message Label
	//FARL - First  Achivement Reward  Label
	//SAML - Second Achivement Message Label
	//SARL - Second Achivement Reward  Label
	//
	// и т.д.

	/// <summary>
	/// форма с ачивками (достижениями).
	/// </summary>
	public partial class Achievements : Form
	{
		#region fields
		private readonly static string galochka = "✔";
		#endregion
		#region props
		/// <summary>
		/// значение денег с первой формы.
		/// </summary>
		internal int Money { get; set; }
		/// <summary>
		/// номер инструмента с первой формы.
		/// </summary>
		internal int NumberTool { get; set; }
		/// <summary>
		/// номер рабочих с первой формы.
		/// </summary>
		internal int NumberWorker { get; set; }
		#endregion
		#region constructors
		/// <summary>
		/// конструктор формы с ачивками.
		/// </summary>
		public Achievements()
		{
			InitializeComponent();
			moneyLabel.Text = ""; //очистка информации в лейбле.
		}
		#endregion
		#region methods
		/// <summary>
		/// проверка изменений в других формах.
		/// </summary>
		private void CheckUpdates()
		{
			Money = ValuesTransfer.Money;
			NumberTool = ValuesTransfer.NumberTool;
			NumberWorker = ValuesTransfer.NumberWorker;
		}
		/// <summary>
		/// установка обозначения успешного выполнения достижения.
		/// </summary>
		/// <remarks>
		/// при <paramref name="check"/> равном <see langword="true"/>
		/// устанавливается зелёный цвет текста указанным лейблам <paramref name="Message"/> и <paramref name="Reward"/>,
		/// также лейблу <paramref name="Reward"/> устанавливается "галочка". <br/><br/>
		/// <paramref name="GetReward"/> --> вызов метод получения вознаграждения. <br/>
		/// указываются методы, или лямбда-выражения с типом void и без параметров. <br/>
		/// пример метода: <c> void Reward() </c> <br/>
		/// пример ввода метода в параметры: <c> Reward </c>
		/// </remarks>
		/// <param name="check">условие достижения.</param>
		/// <param name="Message"><see cref="Label"/> с условием достижения.</param>
		/// <param name="Reward"><see cref="Label"/> с наградой достижения.</param>
		/// <param name="GetReward">метод получения вознаграждения при выполнении условия.</param>
		private void AchivementComplete(bool check, Label Message, Label Reward, Action GetReward)
		{
			if (check)
			{
				Message.ForeColor = Color.Green; //установка зелёного цвета текста для сообщения.
				Reward.ForeColor = Color.Green; //установка зелёного цвета для текста с наградой.
				Reward.Text = galochka; //замена текста лейбла с наградой на галочку.
				GetReward?.Invoke(); //вызов метода получения награды.
			}
		}

		#region event handler
		/// <summary>
		/// обновление значений на форме.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Updater(object sender, EventArgs e)
		{
			CheckUpdates(); //проверка изменений.
			AchivementComplete(NumberTool != 0, FAMLabel, FARLabel, () => { /* тело метода. например: Money += 100; , но так, чтобы это было известно во всей форме. */ }); //проверка и установка первого достижения.
			AchivementComplete(Money >= 10000, SAMLabel, SARLabel, () => { }/* или же вместо этой конструкции сюда можно вписать название отдельного метода. например: Reward*/); //проверка и установка второго достижения.
			moneyLabel.Text = $"{Money}$"; //обновление значений в этой форме.
		}
		/// <summary>
		/// закрывает эту форму, и открывает главную форму.
		/// </summary>
		/// <remarks>
		/// открытие главной формы нужно для того чтобы не было шансов обойти сохранение файла, так как сохранение файла происходит только в главной форме. <br/>
		/// не описывать же сохранение файлов в каждой форме, это не удобно при создании новой формы.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClosingForms(object sender, FormClosingEventArgs e) 
		{
			//при закрытии формы на крестик, эта форма не удаляется из списка открытых форм, а лишь скрывается.
			Hide(); //скрытие этой формы.
			((Form1)ActiveForms.GetForm("Form1")).Show(); //открытие основной формы.

		}
		/// <summary>
		/// Кнопка перехода в форму кликер
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TransitionMain(object sender, EventArgs e)
		{
			Hide(); //скрытие этого окна
			((Form1)ActiveForms.GetForm("Form1")).Show(); //открытие главной формы.
		}
		#endregion events
		#region overrides
		/// <summary>
		/// переопределение метода вызываемого при закрытии формы.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			//при нажатии на крестик в форме, перед её закрытием вызывается этот метод.
			//при помощи переопределния его, можно отменить закрытие формы, и, лишь, скрыть её.
			base.OnClosing(e);  //вызов базового метода Form.OnClosing()
			e.Cancel = true; //отмена закрытия формы.
		}
		#endregion over

		#endregion methds
	}
}