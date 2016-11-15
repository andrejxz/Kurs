using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
		StoreItem _storeItem;
		/// <summary>
		/// проданная позиция склада
		/// </summary>
		[Description("проданная позиция склада")]
		[DisplayName("Позиция")]
		public StoreItem StoreItem
		{
			get { return _storeItem; }
			set
			{
				if (value == _storeItem) return;
				_storeItem = value;
				if (_storeItem == null || _storeItem.Good == null) return;
				if (Price == null) Price = _storeItem.Good.Price;
			}
		}
		/// <summary>
		/// количество по позиции склада
		/// </summary>
		[Description("количество по позиции склада")]
		[DisplayName("Количество")]
		public int Count { get; set; }
		/// <summary>
		/// цена за штуку
		/// </summary>
		[Description("цена за штуку")]
		[DisplayName("цена шт.")]
		[Required]
		public double? Price { get; set; }
		[Description("суммарная цена")]
		[DisplayName("Сум.")]
		public double? SumPrice
		{
			get
			{
				if (Price == null) return null;
				return Price.Value * Count;
			}
		}
	}
}
