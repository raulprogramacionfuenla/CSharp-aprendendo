using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_20150825_NetSimpleCripto {

    class Cripto {
        private char[,] tabelaCripto;
        private static Cripto self = null;
        private const int TAM = 53;

        private Cripto() {
            this.GeraTabela();
        }

        public static Cripto GetInstancia() {
            if (Cripto.self == null)
                Cripto.self = new Cripto();

            return Cripto.self;
        }

        private void GeraTabela() {
            this.tabelaCripto = new char[,] {
                {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','Y','X','Z',' ','À','Á','Ã','Â','Ä','È','É','Ê','Ë','Ì','Í','Î','Ï','Ò','Ó','Õ','Ô','Ö','Ù','Ú','Û','Ü','?','!',',','.'},
                {'0','0','0','0','0','0','0','0','0','1','1','1','1','1','1','1','1','1','1','2','2','2','2','2','2','2','2','2','2','3','3','3','3','3','3','3','3','3','3','4','4','4','4','4','4','4','4','4','4','5','5','5','5'},
                {'1','2','3','4','5','6','7','8','9','0','1','2','3','4','5','6','7','8','9','0','1','2','3','4','5','6','7','8','9','0','1','2','3','4','5','6','7','8','9','0','1','2','3','4','5','6','7','8','9','0','1','2','3'}
            };
        }

        public string ToCripto(string _texto) {
            string tmp = "";
             
            foreach(char c in _texto.ToUpper()) {
                for (int i = 0; i < TAM; i++) {
                    if (c == this.tabelaCripto[0, i]) {
                        tmp += this.tabelaCripto[1, i] +""+ this.tabelaCripto[2, i];
                    }
                }
            }
            return tmp;
        }

        public string ToDecripto(string _cripto) {
            string tmp = "";

            for(int i = 0; i < _cripto.Length; i+=2) {
                for(int j = 0; j < TAM; j++) {
                    if (_cripto[i] == this.tabelaCripto[1,j] && _cripto[i+1] == this.tabelaCripto[2, j]) {
                        tmp += this.tabelaCripto[0, j];
                    }
                }
            }

            return tmp;
        }

        public void PrintTabela() {
            for (int i = 0; i < TAM; i++) {
                Console.Write(this.tabelaCripto[0, i]);
            }
            Console.WriteLine();
            for (int i = 0; i < TAM; i++) {
                Console.Write(this.tabelaCripto[1, i]);
            }
            Console.WriteLine();
            for (int i = 0; i < TAM; i++) {
                Console.Write(this.tabelaCripto[2, i]);
            }
        }
    }

}