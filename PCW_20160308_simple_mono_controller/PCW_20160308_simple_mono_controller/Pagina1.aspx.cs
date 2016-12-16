using System;
using System.Web;
using System.Web.UI;

namespace PCW_20160308_simple_mono_controller {
	
	public partial class Pagina1 : MyPageController {

		protected void Page_Load(object sender, EventArgs e){
			using (var context = new Contexto ()) {
				var categoria = new Categoria { 
					Nome = "Livros"
				};

				var produto1 = new Produto {
					Nome = "Harry potter",
					Preco = 24,
					Quantidade = 150,
					Categoria = categoria
				};

				context.Categorias.Add(categoria);
				context.Produtos.Add(produto1);
				context.SaveChanges();
			}
		}

	}
}

