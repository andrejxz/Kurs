using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
		[Required]
		[Description("категория товара")]
		[DisplayName("Категория")]
		public GoodCategory Categiry { get; set; }
		/// <summary>
		/// название товара
		/// </summary>
		[Required]
		[Description("название товара")]
		[DisplayName("Название")]
		public string Name { get; set; }
		/// <summary>
		/// розничная цена товара
		/// </summary>
		[Required]
		[Description("розничная цена товара")]
		[DisplayName("Цена")]
		public double Price { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}