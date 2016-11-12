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
	public partial class MainForm : Form
	{
		DBContext context = new DBContext();
		public MainForm()
		{
			InitializeComponent();
			context.GoodCategories.Load();
			goodCategoryBindingSource.DataSource = context.GoodCategories.Local.ToBindingList();
		}

		private void goodCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			goodCategoryBindingSource.EndEdit();
			Validate();
			context.SaveChanges();
		}
	}
}
