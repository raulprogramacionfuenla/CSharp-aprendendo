using System;

namespace PC_20150915_prova_linux {
	public class ItemPedido {

		public int Id { get; set; }
		public int PedidoId { get; set; }
		public String Descricao { get; set; }
		public Double ValorUnitario { get; set; }
		public Double QtdePedida { get; set; }

		public ItemPedido () {
		}
	}
}

