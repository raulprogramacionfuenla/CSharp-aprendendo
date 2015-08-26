using System;

namespace PC_Desafio_Lendo_E_Criando_Arquivos {

    class ItemPedido {

        private short codigo;
        private String item;
        private Double valor;
        private Double qtde;

        public ItemPedido(String _item) {
            if (_item.Length >= 63) {
                this.codigo = Convert.ToInt16(_item.Substring(0, 3));
                this.item = _item.Substring(3, 49);
                this.Valor = Convert.ToDouble(_item.Substring(52, 11));
                this.Qtde = Convert.ToDouble(_item.Substring(63, 9));
            }
        }

        public String ToString() {
            return "Item - Codigo: " + this.codigo.ToString().PadLeft(3, '0') +
                    ", Item: " + this.item.TrimEnd() +
                    ", Valor: " + this.Valor.ToString() +
                    ", Qtde: " + this.Qtde.ToString();
        }

        /*
        * Getters e Setters
        */
        public double Valor {
            get {
                return valor;
            }

            set {
                this.valor = value;
            }
        }

        public double Qtde {
            get {
                return qtde;
            }

            set {
                this.qtde = value;
            }
        }
    }

}
