using System;
using System.Windows.Forms;

namespace PC_20151006_windowsform_modal {

    class Arquivo {

        private String[] arquivo;
        private string nomeArquivo;

        public Arquivo(String _arquivo) {
            if (System.IO.File.Exists(_arquivo)) {
                this.arquivo = System.IO.File.ReadAllLines(_arquivo);
                this.nomeArquivo = _arquivo;
            } else {
                //Console.WriteLine("O arquivo " + _arquivo + " não existe. Tente novamente.");
                MessageBox.Show("O arquivo " + _arquivo + " não existe. Tente novamente.", "Atenção");
            }
        }

        public String LerArquivo() {
            String saida = "";
            foreach (string linha in this.arquivo) {
                saida += linha + "\n";
            }
            return saida;
        }
    }
}
