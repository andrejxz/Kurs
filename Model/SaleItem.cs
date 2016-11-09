using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	/// <summary>
	/// описывает один пункт продажи
	/// </summary>
	public class SaleItem : TableRow
	{
		/// <summary>
		/// проданная позиция склада
		/// </summary>
		[Description("проданная позиция склада")]
		[DisplayName("Позиция")]
		public StoreItem StoreItem { get; set; }
		/// <summary>
		/// количество по позиции склада
		/// </summary>
		[Description("количество по позиции склада")]
		[DisplayName("Количество")]
		public uint Count { get; set; }
		/// <summary>
		/// цена за штуку
		/// </summary>
		[Description("цена за штуку")]
		[DisplayName("цена шт.")]
		public double Price { get; set; }
	}
}
