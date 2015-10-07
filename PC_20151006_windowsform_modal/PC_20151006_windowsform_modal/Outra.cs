using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_20151006_windowsform_modal {
    public partial class frmOutra : Form {

        public frmOutra() {
            InitializeComponent();
        }

        public void setLabel(String texto) {
            lblTexto.Text = texto;
        }
    }
}
