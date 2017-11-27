/*
 * Сделано в SharpDevelop.
 * Пользователь: Oleg
 * Дата: 22.11.2017
 * Время: 21:39
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7_3
{
	/// <summary>
	/// Description of Turn_form.
	/// </summary>
	public partial class Turn_form : Form
	{
		public Turn_form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
