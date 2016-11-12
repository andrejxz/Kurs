using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Kurs
{
	public partial class GoodsForm : Form
	{
		public GoodsForm()
		{
			InitializeComponent();
			DBContext.Goods.Load();
			DBContext.GoodCategories.Load();
			goodBindingSource.DataSource = DBContext.Goods.Local.ToBindingList();
			goodCategoryBindingSource.DataSource = DBContext.GoodCategories.Local.ToBindingList();
		}

		private void goodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			try {
				goodBindingSource.EndEdit();
				Validate();
				DBContext.Save();
			}
			catch(System.Data.Entity.Validation.DbEntityValidationException ex) {
				MessageBox.Show(this, 
					string.Format("Сообщение: {0}\nОшибки валидации: {1}",ex.Message,ex.EntityValidationErrors),
					"Ошибка сохранения",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex) {
				MessageBox.Show(this, ex.Message, "Ошибка сохранения",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
