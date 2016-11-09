using System.ComponentModel;

namespace Model
{
	/// <summary>
	/// описывает товар
	/// </summary>
	public class Good : TableRow
	{
		/// <summary>
		/// категория товара
		/// </summary>
		[Description("категория товара")]
		[DisplayName("Категория")]
		public GoodCategory Categiry { get; set; }
		/// <summary>
		/// название товара
		/// </summary>
		[Description("название товара")]
		[DisplayName("Название")]
		public string Name { get; set; }
		/// <summary>
		/// розничная цена товара
		/// </summary>
		[Description("розничная цена товара")]
		[DisplayName("Цена")]
		public double Price { get; set; }
	}
}