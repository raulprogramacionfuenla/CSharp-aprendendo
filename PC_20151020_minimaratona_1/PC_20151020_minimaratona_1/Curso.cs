using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_20151020_minimaratona_1 {

    class Curso {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public bool Status { get; set; }

        public Curso() { }

        public Curso(int _cod, String _nome, String _sts) {
            this.Codigo = _cod;
            this.Nome = _nome;
            this.Status = _sts == "ATIVO" ? true : false;
        }

        public Curso(String _cod, String _nome, String _sts):this(Convert.ToInt32(_cod), _nome, _sts) { }

        public String IsAtivo() {
            return this.Status ? "ATIVO" : "INATIVO";
        }
    }
}
