using System;

namespace PC_20150901_ling {
	public class Carro {
		private string marca;
		private string cor;
		private string modelo;
		private int ano;

		public Carro(string _marca, string _cor, string _modelo, int _ano) {
			Marca = _marca;
			Cor = _cor;
			Modelo = _modelo;
			Ano = _ano;
		}

		public string Marca {
			get {
				return this.marca;
			}
			set {
				marca = value;
			}
		}

		public string Cor {
			get {
				return this.cor;
			}
			set {
				cor = value;
			}
		}

		public string Modelo {
			get {
				return this.modelo;
			}
			set {
				modelo = value;
			}
		}

		public int Ano {
			get {
				return this.ano;
			}
			set {
				ano = value;
			}
		}

	}
}

