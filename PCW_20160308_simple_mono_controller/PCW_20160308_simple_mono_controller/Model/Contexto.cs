using System;
using System.Data.Entity;
using SQLite.CodeFirst;

namespace PCW_20160308_simple_mono_controller {

	public class Contexto : DbContext {

		public Contexto () : base("name = DbSqlite") {
			
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<Contexto>(modelBuilder);
			Database.SetInitializer(sqliteConnectionInitializer);
		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Categoria> Categorias { get; set; }

	}

}

