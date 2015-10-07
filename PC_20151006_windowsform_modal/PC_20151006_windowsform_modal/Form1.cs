using System.Windows.Forms;

namespace PC_20151006_windowsform_modal {
    public partial class frmPrincipal : Form {

        private frmOutra outra = null;
        private Arquivo input = null;

        public frmPrincipal() {
            InitializeComponent();

            btnClica.Click += delegate {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult res = dialog.ShowDialog();
                if (res.ToString() == "OK") {
                    txtBox.Text = dialog.FileName.ToString();
                    input = new Arquivo(dialog.FileName.ToString());
                    txtResult.Text = input.LerArquivo();
                }
            };
        }
    }
}
