namespace PC_20151006_windowsform_modal {
    partial class frmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnClica = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(13, 13);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(103, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Escolha um arquivo:";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(16, 30);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(256, 20);
            this.txtBox.TabIndex = 1;
            // 
            // btnClica
            // 
            this.btnClica.Location = new System.Drawing.Point(16, 57);
            this.btnClica.Name = "btnClica";
            this.btnClica.Size = new System.Drawing.Size(109, 23);
            this.btnClica.TabIndex = 2;
            this.btnClica.Text = "Abrir essa buceta";
            this.btnClica.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 96);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(256, 244);
            this.txtResult.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 352);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClica);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblLabel);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnClica;
        private System.Windows.Forms.TextBox txtResult;
    }
}

