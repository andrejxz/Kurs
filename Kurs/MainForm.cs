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
		public MainForm()
		{
			InitializeComponent();
		}

		private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new GoodCategoriasForm())  f.ShowDialog();
		}

		private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new GoodsForm())  f.ShowDialog();
		}
	}
}
