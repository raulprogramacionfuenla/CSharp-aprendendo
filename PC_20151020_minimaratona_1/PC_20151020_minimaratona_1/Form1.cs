using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_20151020_minimaratona_1 {
    public partial class frmMain : Form {

        private Arquivo cursos = null;
        private Arquivo matriculas = null;

        private List<Curso> listaCursos = new List<Curso>();
        private List<Matricula> listaMatriculas = new List<Matricula>();

        private Curso cursoSelecionado;
        private Matricula matriculaSelecionada;

        public frmMain() {
            InitializeComponent();

            cursos = new Arquivo("D:\\maratona\\Cursos.txt");
            matriculas = new Arquivo("D:\\maratona\\Matriculas.txt");

            this.LerAqruivoCursos();
            this.LerArquivoMatriculas();

            this.PreencheComboCursos();

            cboCursos.SelectedValueChanged += delegate {
                this.cursoSelecionado = this.listaCursos[cboCursos.SelectedIndex];
            };

            btnMatricular.Click += delegate {
                if (cboCursos.CanSelect && txtNome.Text.Length > 0) {
                    this.matriculaSelecionada = new Matricula() {
                        //Cod = this.GetUltimaMatricula().Cod++,
                        Cod = this.GetUltimaMatriculaId(),
                        Nome = txtNome.Text,
                        CursoId = this.cursoSelecionado.Codigo,
                        Bolsista = chkBolsista.Checked
                    };
                    listaMatriculas.Add(this.matriculaSelecionada);
                    this.matriculas.GravaMatriculas(this.listaMatriculas);

                    txtNome.Text = "";
                    txtMatricula.Text = "";
                    chkBolsista.Checked = false;
                } else {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção");
                }
            };

            btnExibirMatricula.Click += delegate {
                if (txtMatricula.Text.Length > 0) {
                    this.matriculaSelecionada = null;
                    var cod = Convert.ToInt32(txtMatricula.Text);
                    foreach (Matricula matricula in this.listaMatriculas) {
                        if (matricula.Cod == cod)
                            this.matriculaSelecionada = matricula;
                    }

                    if (this.matriculaSelecionada != null) {
                        txtNome.Text = this.matriculaSelecionada.Nome;
                        chkBolsista.Checked = this.matriculaSelecionada.Bolsista;
                        // não sei selecionar no combo
                    } else {
                        MessageBox.Show("A matrícula não existe.", "Atenção");
                    }
                } else {
                    MessageBox.Show("Digite a matrícula.", "Atenção");
                }
            };
        }

        private void LerAqruivoCursos() {
            foreach (string linha in this.cursos.GetArquivo) {
                var arrLinha = linha.Split('|');
                this.listaCursos.Add(new Curso(arrLinha[0], arrLinha[1], arrLinha[2]));
            }
        }

        private void LerArquivoMatriculas() {
            foreach (string linha in this.matriculas.GetArquivo) {
                var arrLinha = linha.Split(';');
                this.listaMatriculas.Add(new Matricula(arrLinha[0], arrLinha[1], arrLinha[2], arrLinha[3]));
            }
        }

        private void PreencheComboCursos() {
            foreach (Curso curso in this.listaCursos) {
                if (curso.Status)
                    cboCursos.Items.Add(curso.Nome);
            }
        }

        private Matricula GetUltimaMatricula() {
            return this.listaMatriculas.Last<Matricula>();
        }

        private int GetUltimaMatriculaId() {
            return this.listaMatriculas.Last<Matricula>().Cod + 1;
        }

    }
}
