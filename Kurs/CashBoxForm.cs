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
	public partial class CashBoxForm : Form
	{
		/// <summary>
		/// хранит позицию продажи и количество сколько было элементов на складе изначально
		/// контролирует ввод количества
		/// </summary>
		public class SalePositionContainer
		{
			[Browsable(false)]
			public SaleItem SaleItem { get; set; }
			int StartStoreCount { get; set; }

			public SalePositionContainer(StoreItem storeItem)
			{
				SaleItem = new SaleItem {
					StoreItem = storeItem,
					Price = storeItem.Price,
					Count = 1
				};
				StartStoreCount = storeItem.Count;
			}

			/// <summary>
			/// название товара
			/// </summary>
			[DisplayName("Позиция")]
			public string Name
			{
				get
				{
					return SaleItem.StoreItem.Good.Name;
				}
			}
			/// <summary>
			/// количество подаваемых элементов
			/// </summary>
			[DisplayName("Количество")]
			public int Count
			{
				get
				{
					return SaleItem == null ? 0 : SaleItem.Count;
				}
				set
				{
					if (value > StartStoreCount) {
						MessageBox.Show(null, "Нельзя задать количество элементов больше чем их есть на складе\nВсего на складе: " + StartStoreCount, 
							"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}
			/// <summary>
			/// ена за штуру
			/// </summary>
			[DisplayName("цена шт.")]
			public double? Price
			{
				get
				{
					return SaleItem.Price;
				}
				set
				{
					SaleItem.Price = value;
				}
			}
			/// <summary>
			///суммарная стоимость по позиции
			/// </summary>
			[DisplayName("Сум.")]
			public double? SummPrice
			{
				get
				{
					return SaleItem.SumPrice;
				}
			}
		}
		BindingList<StoreItem> storeItems;
		BindingList<SalePositionContainer> saleItems = new BindingList<SalePositionContainer>();

		public CashBoxForm()
		{
			InitializeComponent();
			DBContext.Remake();
			DBContext.Goods.Load();
			DBContext.StoreItems.Load();
			storeItems = DBContext.StoreItems.Local.ToBindingList();
			storeItemBindingSource.DataSource = storeItems;
			//saleItemBindingSource.DataSource = saleItems;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveAllPositions();
			Close();
		}

		void SaveAllPositions()
		{

		}

		private void storeItemDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			// получаем текущий элемент склада
			if (storeItems == null || storeItems.Count == 0) return;
			var storeItem = storeItemBindingSource.Current as StoreItem;
			if (storeItem == null) return;
			// ограничитель по количеству элементов
			if (storeItem.Count <= 0) {
				MessageBox.Show(this, "На складе нет этого товара", "Оформление продажи", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// ищем элемент продажи на эту позицию
			var storePosition = saleItems.FirstOrDefault(x => x.SaleItem.StoreItem.Id == storeItem.Id);
			// вставка одного элемента в продажи
			if (storePosition == null)
				saleItems.Add(new SalePositionContainer(storeItem));
			else {
				++storePosition.Count;
				saleItems.ResetBindings();
			}
			// отнимаем количество со склада
			--storeItem.Count;
		}
	}
}
