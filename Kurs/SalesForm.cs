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
	public partial class SalesForm : Form
	{
		public SalesForm()
		{
			InitializeComponent();
			DBContext.Remake();
			DBContext.Goods.Load();
			DBContext.StoreItems.Load();
			DBContext.SaleItems.Load();
			storeItemBindingSource.DataSource = DBContext.StoreItems.Local.ToBindingList();
			saleItemBindingSource.DataSource = DBContext.SaleItems.Local.ToBindingList();
		}

		private void saleItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			FormHelper.Execute(() => {
				saleItemBindingSource.EndEdit();
				Validate();
				DBContext.Save();
			}, "Ошибка сохранения");
		}
	}
}
