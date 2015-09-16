using System;
using System.Linq;
using System.Collections.Generic;

namespace PC_20150915_prova_linux {
	class MainClass {
		public static void Main (string[] args) {
			List<Pedido> pedidos = new List<Pedido> ();
			List<ItemPedido> itens = new List<ItemPedido> ();

			pedidos.Add (new Pedido (){ Id = 1, Data = "20150908", Cpf = "809.166.605-59" });
			pedidos.Add (new Pedido (){ Id = 2, Data = "20150910", Cpf = "809.166.605-59" });
			pedidos.Add (new Pedido (){ Id = 3, Data = "20150915", Cpf = "809.166.605-59" });

			itens.Add (new ItemPedido(){ Id = 1, PedidoId = 1, Descricao = "TV LCD", ValorUnitario = 1500, QtdePedida = 1 });
			itens.Add (new ItemPedido(){ Id = 2, PedidoId = 3, Descricao = "Panelas", ValorUnitario = 80.5, QtdePedida = 1 });
			itens.Add (new ItemPedido(){ Id = 3, PedidoId = 2, Descricao = "Pratos", ValorUnitario = 6.99, QtdePedida = 5 });
			itens.Add (new ItemPedido(){ Id = 4, PedidoId = 3, Descricao = "Copos", ValorUnitario = 2.19, QtdePedida = 8 });
			itens.Add (new ItemPedido(){ Id = 5, PedidoId = 3, Descricao = "Jarra dagua", ValorUnitario = 12.3, QtdePedida = 2 });
			itens.Add (new ItemPedido(){ Id = 6, PedidoId = 2, Descricao = "Camisinha", ValorUnitario = 3.7, QtdePedida = 9 });
			itens.Add (new ItemPedido(){ Id = 7, PedidoId = 1, Descricao = "DVD Player", ValorUnitario = 630, QtdePedida = 1 });

			ExibeTotais (pedidos, itens);
		}

		private static void ExibeTotais(List<Pedido> pedidos, List<ItemPedido> itens){
			foreach(Pedido prop in pedidos){
				var itensPedido = from i in itens where i.PedidoId == prop.Id select i;
				var total = 0.0;

				foreach(ItemPedido x in itensPedido){
					total += x.ValorUnitario * x.QtdePedida;
				}

				Console.WriteLine("Pedido {0} total: {1}", prop.Id, total);
			}
		}
	}
}
