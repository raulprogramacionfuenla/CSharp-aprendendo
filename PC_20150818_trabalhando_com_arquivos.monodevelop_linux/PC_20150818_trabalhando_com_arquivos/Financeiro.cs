using System;
using System.Collections.Generic;

namespace PC_Desafio_Lendo_E_Criando_Arquivos {

    class Financeiro {

        private short codigo;
        private DateTime data;
        private string docCliente;
        private char tipo = 'R';
        private double valor;
        private string conta;
        private List<ItemPedido> itens = new List<ItemPedido>();

        public Financeiro(short _codigo, string _data, string _cliente, char _tipo, double _valor, string _conta) {
            this.Codigo = _codigo;
            this.Data = new DateTime(Convert.ToInt16(_data.Substring(4, 4)), Convert.ToInt16(_data.Substring(2, 2)), Convert.ToInt16(_data.Substring(0, 2))); ;
            this.DocCliente = _cliente;
            this.Tipo = _tipo;
            this.Valor = _valor;
            this.Conta = _conta;
        }

        public Financeiro(Pedido _pedido, string _conta) {
            this.Codigo = _pedido.Codigo;
            this.Data = _pedido.Data;
            this.DocCliente = _pedido.Cliente.Documento;
            this.Conta = _conta;
            this.itens = _pedido.Itens;
            this.Valor = this.calculaValor();
        }

        private double calculaValor() {
            double val = 0;

            foreach(ItemPedido item in this.itens) {
                val += (item.Valor * item.Qtde);
            }

            return val;
        }

        public String ToLinha() {
            return this.Codigo.ToString().PadLeft(6, '0') + ";" +
                this.Data.Day.ToString() + this.Data.Month.ToString() + this.Data.Year.ToString() + ";" +
                this.DocCliente + ";" +
                this.Tipo + ";" +
                this.Valor.ToString() + ";" +
                this.Conta;
        }

        /*
        * Getters e Setters
        */
        public short Codigo {
            get {
                return codigo;
            }

            set {
                this.codigo = value;
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

        public string DocCliente {
            get {
                return docCliente;
            }

            set {
                this.docCliente = value;
            }
        }

        public char Tipo {
            get {
                return tipo;
            }

            set {
                this.tipo = value;
            }
        }

        public double Valor {
            get {
                return valor;
            }

            set {
                this.valor = value;
            }
        }

        public string Conta {
            get {
                return conta;
            }

            set {
                this.conta = value;
            }
        }
    }

}
