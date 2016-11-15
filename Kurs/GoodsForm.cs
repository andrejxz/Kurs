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
			DBContext.Remake();
			DBContext.Goods.Load();
			DBContext.GoodCategories.Load();
			goodBindingSource.DataSource = DBContext.Goods.Local.ToBindingList();
			goodCategoryBindingSource.DataSource = DBContext.GoodCategories.Local.ToBindingList();
		}

		private void goodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			FormHelper.Execute(() => {
				goodBindingSource.EndEdit();
				Validate();
				DBContext.Save();
			}, "Ошибка сохранения");			
		}
	}
}
