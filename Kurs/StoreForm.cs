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
	public partial class StoreForm : Form
	{
		public StoreForm()
		{
			InitializeComponent();
			DBContext.Remake();
			DBContext.Goods.Load();
			DBContext.StoreItems.Load();
			goodBindingSource.DataSource = DBContext.Goods.Local.ToBindingList();
			storeItemBindingSource.DataSource = DBContext.StoreItems.Local.ToBindingList();
		}

		private void storeItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			FormHelper.Execute(() => {
				storeItemBindingSource.EndEdit();
				Validate();
				DBContext.Save();
			}, "Ошибка сохранения");
		}
	}
}
