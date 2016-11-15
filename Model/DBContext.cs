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
		public DbSet<GoodCategory> _GoodCategories { get; set; }
		public DbSet<Good> _Goods { get; set; }
		public DbSet<StoreItem> _StoreItems { get; set; }
		public DbSet<SaleItem> _SaleItems { get; set; }

		DBContext() : base("ConnectionString")
		{
		}

		#region реализация одиночки
		static DBContext _instace;
		/// <summary>
		/// глобальная инстанция текущего класса
		/// паттерн Singleton (одиночка)
		/// </summary>
		public static DBContext Instace
		{
			get
			{
				if (_instace == null) _instace = new DBContext();
				return _instace;
			}
		}
		/// <summary>
		/// пересоздает контекст БД
		/// </summary>
		public static void Remake()
		{
			_instace = new DBContext();
		}

		public static DbSet<GoodCategory> GoodCategories
		{
			get
			{
				return Instace._GoodCategories;
			}
		}
		public static DbSet<Good> Goods
		{
			get
			{
				return Instace._Goods;
			}
		}
		public static DbSet<StoreItem> StoreItems
		{
			get
			{
				return Instace._StoreItems;
			}
		}
		public static DbSet<SaleItem> SaleItems
		{
			get
			{
				return Instace._SaleItems;
			}
		}

		public static void Save()
		{
			Instace.SaveChanges();
		}
		#endregion
	}
}
