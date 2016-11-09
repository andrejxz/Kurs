using System.ComponentModel;


namespace Model
{
	/// <summary>
	/// описывает строку таблицы
	/// </summary>
	public class TableRow
	{
		/// <summary>
		/// идентификатор строки таблицы
		/// </summary>
		[Description("идентификатор строки таблицы")]
		[DisplayName("ID")]
		[Browsable(false)]
		public long? Id { get; set; }
	}
}
