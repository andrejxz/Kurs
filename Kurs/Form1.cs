using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Product = new Form2();
            Product.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Login = new Form3();
            Login.Show();
        }

        private void WorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Worker = new Form4();
            Worker.Show();
        }
    }
}
