using System;
using System.Collections.Generic;
using System.Linq;

namespace PC_20150901_ling {
	
	class Program {
		
		private static List<Carro> carros = new List<Carro>();

		public static void Main (string[] args) {
			Program.GeraLista ();

			var consulta = from carro in carros where carro.Ano == 2000 select carro;

			foreach(Carro c in consulta){
				Console.WriteLine(c.Modelo+" "+c.Marca+" "+c.Cor+" "+c.Ano);
			}

			Console.ReadKey();
		}

		private static void GeraLista(){
			carros.Add(new Carro ("Wolks", "preto", "GOL 1000", 1995));
			carros.Add(new Carro ("Fiat", "verde", "Uno Mille", 1999));
			carros.Add(new Carro ("Wolks","branco","Fusca", 2000));
			carros.Add(new Carro ("Fiat","branco","Palio", 1999));
			carros.Add(new Carro ("Renaut","preto","Picasso", 2000));
			carros.Add(new Carro ("Nissan","verde","Tucson", 2010));
		}

	}

}
