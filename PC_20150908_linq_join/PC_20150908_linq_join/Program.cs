using System;
using System.Linq;

namespace PC_20150908_linq_join {
	
	class MainClass {

		private static Carro[] carros;
		private static Fabrica[] fabricas;

		public static void Main (string[] args) {
			carros = new Carro[]{
				new Carro(){ Modelo = "Uno", IdFabrica = 1 },
				new Carro(){ Modelo = "Fusca", IdFabrica = 2 },
				new Carro(){ Modelo = "Palio", IdFabrica = 1 },
				new Carro(){ Modelo = "HB20", IdFabrica = 3 },
				new Carro(){ Modelo = "Kombi", IdFabrica = 2 }
			};

			fabricas = new Fabrica[] {
				new Fabrica (){ Nome = "Fiat", Id = 1 },
				new Fabrica (){ Nome = "Wolks", Id = 2 },
				new Fabrica (){ Nome = "Hiunday", Id = 3 }
			};

			var consulta = from carrinho in carros
				join fabriquinha in fabricas 
				on carrinho.IdFabrica equals fabriquinha.Id 
				select new { carrinho.Modelo, fabriquinha.Nome };

			foreach (var item in consulta) {
				Console.WriteLine ("{0} fabricado por {1}", item.Modelo, item.Nome);
			}
		}
	}

}
