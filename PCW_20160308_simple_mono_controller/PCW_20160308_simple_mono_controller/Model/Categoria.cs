using System;
using System.Collections.Generic;

namespace PCW_20160308_simple_mono_controller {
	
	public class Categoria {
		
		public int Id { get; set; }

		public String Nome { get; set; }

		public virtual ICollection<Produto> Produtos { get; set; }

	}

}

