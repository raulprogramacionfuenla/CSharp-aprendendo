using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private void picLogo_Click(object sender, EventArgs e) {
            MessageBox.Show("Lista de Contatos 1.0\nEscrito por: Walter Gandarella", "Sobre");
        }
    }
}
