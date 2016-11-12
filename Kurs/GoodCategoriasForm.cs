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
	public partial class GoodCategoriasForm : Form
	{
		public GoodCategoriasForm()
		{
			InitializeComponent();
			DBContext.GoodCategories.Load();
			goodCategoryBindingSource.DataSource = DBContext.GoodCategories.Local.ToBindingList();
		}

		private void goodCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			goodCategoryBindingSource.EndEdit();
			Validate();
			DBContext.Save();
		}
	}
}
