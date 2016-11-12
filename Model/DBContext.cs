using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	/// <summary>
	/// контекст БД
	/// </summary>
	public class DBContext : DbContext
	{
		public DbSet<GoodCategory> GoodCategories { get; set; }
		public DbSet<Good> Goods { get; set; }
		public DbSet<StoreItem> StoreItems { get; set; }
		public DbSet<SaleItem> SaleItem { get; set; }

		public DBContext() : base("ConnectionString")
		{
		}
	}
}
