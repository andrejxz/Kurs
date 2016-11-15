using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
	public static class FormHelper
	{
		/// <summary>
		/// выполняет действие, оборачивая его в try catch
		/// </summary>
		/// <param name="action">выполняемое действие</param>
		public static void Execute(Action action, string errorCaption="Ошибка")
		{
			try {
				action();
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException ex) {
				MessageBox.Show(null,
					string.Format("Сообщение: {0}\nОшибки валидации: {1}", ex.Message, ex.EntityValidationErrors),
					errorCaption,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex) {
				MessageBox.Show(null, ex.Message, errorCaption,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
