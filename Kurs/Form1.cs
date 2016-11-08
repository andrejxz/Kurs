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

        /*   Добавление в таблицу

             ListViewItem lvi = new ListViewItem();
             // первая колонка
             lvi.Text = "1";
             // следующие колонки по порядку
             lvi.SubItems.Add("2");
             lvi.SubItems.Add("3");
             // вставка в таблицу
             listView1.Items.Add(lvi);
     */

        /*            Тест                    */
        struct Product
        {
            public int ID;
            public string Name;
            public double Price;
            public int count;
        }
        List<Product> list = new List<Product>();

        private void AddItemList()
        {
            Product s = new Product();
            s.ID = Convert.ToInt32(textBox1.Text);
            s.Name = "Name";
            s.Price = 0;
            s.count = Convert.ToInt32(numericUpDown1.Value);
            list.Add(s);
            textBox1.Clear();
            numericUpDown1.Value = 1;
            ShowAll();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "") return;
                AddItemList();
            }
        }
        private void ShowAll()
        {
            listView1.Items.Clear();
            foreach (var i in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = Convert.ToString(i.ID);
                lvi.SubItems.Add(i.Name);
                lvi.SubItems.Add(Convert.ToString(i.count));
                lvi.SubItems.Add(Convert.ToString(i.Price));
                listView1.Items.Add(lvi);
            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "") return;
                AddItemList();
            }
        }
    }
}
