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
		void Show<T>() where T: Form, new()
		{
			using (var f = new T()) {
				try {
					f.ShowDialog();
				}
				catch(Exception ex) {
					MessageBox.Show(this, ex.Message, "Ошибка формы", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		public MainForm()
		{
			InitializeComponent();
		}

		private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show<GoodCategoriasForm>();
		}

		private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show<GoodsForm>();
		}

		private void складToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show<StoreForm>();
		}

		private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show<SalesForm>();
		}

		private void кассирToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show<CashBoxForm>();
		}
	}
}
