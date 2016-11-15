using System.ComponentModel;

namespace Model
{
	/// <summary>
	/// описывает категорию товара
	/// </summary>
	public class GoodCategory : TableRow
	{
		/// <summary>
		/// название категории товаров
		/// </summary>
		[Description("название категории товаров")]
		[DisplayName("Название")]
		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}