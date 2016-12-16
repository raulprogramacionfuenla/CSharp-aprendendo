using System;

namespace PCW_20160308_simple_mono_controller {

	public class Produto {
		
		public int Id { get; set; }

		public string Nome { get; set; }       

		public decimal Preco { get; set; }

		public int Quantidade { get; set; }      

		public virtual Categoria Categoria { get; set; }

	}

}

