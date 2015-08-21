using System;

namespace PC_Desafio_Lendo_E_Criando_Arquivos {

    class Cliente {

        private String nome;
        private String documento;

        public Cliente(String _cliente) {
            if (_cliente.Length >= 45) {
                this.Nome = _cliente.Substring(14, 31);
                this.Documento = _cliente.Substring(45);
            }
        }

        public string ToString() {
            return "Cliente - Nome: "+this.Nome.TrimEnd()+", Documento: "+this.Documento.TrimEnd();
        }

        /*
        * Getters e Setters
        */
        public string Nome {
            get {
                return nome;
            }

            set {
                this.nome = value;
            }
        }

        public string Documento {
            get {
                return documento;
            }

            set {
                this.documento = value;
            }
        }
    }

}
