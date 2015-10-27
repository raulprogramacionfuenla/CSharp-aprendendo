using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_20151020_minimaratona_1 {
    class Arquivo {

        private String[] arquivo;
        private string nomeArquivo;

        public Arquivo(String _arquivo) {
            if (System.IO.File.Exists(_arquivo)) {
                this.arquivo = System.IO.File.ReadAllLines(_arquivo);
                this.nomeArquivo = _arquivo;
            } else {
                MessageBox.Show("O arquivo " + _arquivo + " não existe. Tente novamente.", "Atenção");
            }
        }

        public String[] GetArquivo {
            get {
                return arquivo;
            }
        }

        public void GravaMatriculas(List<Matricula> _matriculas) {
            String[] linhas = new string[_matriculas.Count()];

            for (int i = 0; i < _matriculas.Count(); i++) {
                linhas[i] = _matriculas[i].Cod.ToString().PadLeft(4, '0').ToString() + ";" + _matriculas[i].Nome.ToString() + ";" + _matriculas[i].CursoId.ToString() + ";" + _matriculas[i].IsBolsista();
            }

            if (linhas.Length > 0) {
                System.IO.File.WriteAllLines(this.nomeArquivo, linhas);
                MessageBox.Show("Arquivo gerado com sucesso!", "Atenção");
            }
        }

    }
}
