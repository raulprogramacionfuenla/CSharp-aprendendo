using System;
using System.Collections.Generic;
using System.Linq;

namespace PC_Desafio_Lendo_E_Criando_Arquivos {

    class Arquivo {

        private String[] arquivo;
        private List<Pedido> pedidos = new List<Pedido>();
        private string nomeArquivo;

        public Arquivo(String _arquivo) {
            if (System.IO.File.Exists(_arquivo)) {
                this.arquivo = System.IO.File.ReadAllLines(_arquivo);
                this.nomeArquivo = _arquivo;
                this.lerPedidos();
            } else {
                Console.WriteLine("O arquivo " + _arquivo + " não existe. Tente novamente.");
            }
        }

        private void lerPedidos() {
            bool cabecalho = false;
            bool item = false;

            foreach (string linha in this.arquivo) {

                if (cabecalho && linha.Length >= 45) {
                    this.pedidos.Add(new Pedido(linha));
                    cabecalho = false;
                }

                if (item && linha.Length >= 63)
                    this.pedidos.Last<Pedido>().addItemPedido(linha);

                if (linha == "CABEC:") {
                    cabecalho = true;
                    item = false;
                }

                if (linha == "ITENS:") {
                    cabecalho = false;
                    item = true;
                }
            }
        }

        public void converteParaFinanceiro() {
            string arq = this.nomeArquivo.Split('.')[0] + "-financeiro.txt";
            this.geraArquivo(arq);
        }

        public void converteParaFinanceiro(string _arq) {
            this.geraArquivo(_arq);
        }

        private void geraArquivo(string _arquivo) {
            String[] linhas = new String[this.pedidos.Count()];

            for (int i = 0; i < this.pedidos.Count(); i++) {
                Financeiro fin = new Financeiro(this.pedidos[i], "0101");
                linhas[i] = fin.ToLinha();
            }

            if (linhas.Length > 0) {
                System.IO.File.WriteAllLines(_arquivo, linhas);
                Console.WriteLine("Arquivo gerado com sucesso");
            }
        }

        public int getQtdePedidos() {
            return this.pedidos.Count();
        }
    }
}
