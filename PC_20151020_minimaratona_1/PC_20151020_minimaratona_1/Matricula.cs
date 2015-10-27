using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_20151020_minimaratona_1 {
    class Matricula {

        public int Cod { get; set; }
        public String Nome { get; set; }
        public int CursoId { get; set; }
        public bool Bolsista { get; set; }

        public Matricula() { }

        public Matricula(int _cod, String _nome, int _cursoid, bool _bolsista) {
            this.Cod = _cod;
            this.Nome = _nome;
            this.CursoId = _cursoid;
            this.Bolsista = _bolsista;
        }

        public Matricula(String _cod, String _nome, String _cursoid, String _bolsista):this(Convert.ToInt32(_cod), _nome, Convert.ToInt32(_cursoid), _bolsista == "SIM" ? true : false) { }

        public String IsBolsista() {
            return this.Bolsista ? "SIM" : "NÂO";
        }

    }
}
