using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	/// <summary>
	/// описывает элемент склада
	/// </summary>
	public class StoreItem : TableRow
	{
		/// <summary>
		/// товар на складе
		/// </summary>
		[Description("товар на складе")]
		[DisplayName("Товар")]
		public Good Good { get; set; }
		/// <summary>
		/// количество товара на складе
		/// </summary>
		[Description("количество товара на складе")]
		[DisplayName("Количество")]
		public uint Count { get; set; }
		/// <summary>
		/// цена, по которой купили данный товар
		/// </summary>
		[Description("цена, по которой купили данный товар")]
		[DisplayName("Закуп цена")]
		public double PurchasePrice { get; set; }
	}
}
