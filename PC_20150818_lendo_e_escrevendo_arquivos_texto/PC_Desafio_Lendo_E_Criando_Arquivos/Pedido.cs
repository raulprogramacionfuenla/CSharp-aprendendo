using System;
using System.Collections.Generic;

namespace PC_Desafio_Lendo_E_Criando_Arquivos {

    class Pedido {

        private Cliente cliente;
        private List<ItemPedido> itens = new List<ItemPedido>();
        private DateTime data;
        private short codigo;

        public Pedido(String _cabecalho) {
            this.Cliente = new Cliente(_cabecalho);
            this.Data = new DateTime(Convert.ToInt16(_cabecalho.Substring(10, 4)), Convert.ToInt16(_cabecalho.Substring(8, 2)), Convert.ToInt16(_cabecalho.Substring(6, 2)));
            this.Codigo = Convert.ToInt16(_cabecalho.Substring(0, 6));
        }

        private void setClienteDeStrig(String _cliente) {
            this.Cliente = new Cliente(_cliente);
        }

        public void addItemPedido(String _item) {
            this.Itens.Add(new ItemPedido(_item));
        }

        public string ToString() {
            return "Pedido\n\tCodigo: " + this.Codigo.ToString().PadLeft(6,'0') + "\n\tData: " + this.Data.ToShortDateString() + "\n\tPedidos: " + this.Itens.Count+"\n\t"+this.Cliente.ToString();
        }

        /*
        * Getters e Setters
        */
        public Cliente Cliente {
            get {
                return cliente;
            }

            set {
                this.cliente = value;
            }
        }

        public List<ItemPedido> Itens {
            get {
                return itens;
            }

            set {
                this.itens = value;
            }
        }

        public DateTime Data {
            get {
                return data;
            }

            set {
                this.data = value;
            }
        }

        public short Codigo {
            get {
                return codigo;
            }

            set {
                this.codigo = value;
            }
        }
    }

}
