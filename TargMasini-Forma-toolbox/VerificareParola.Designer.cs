//Horomnea Tudor Grupa 3122A
namespace TargMasini_Forma_toolbox
{
    partial class VerificareParola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblTextParola = new System.Windows.Forms.Label();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(92, 38);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 0;
            this.txtParola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(38, 38);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(40, 13);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola:";
            // 
            // lblTextParola
            // 
            this.lblTextParola.AutoSize = true;
            this.lblTextParola.Location = new System.Drawing.Point(222, 45);
            this.lblTextParola.Name = "lblTextParola";
            this.lblTextParola.Size = new System.Drawing.Size(0, 13);
            this.lblTextParola.TabIndex = 2;
            // 
            // btnVerificare
            // 
            this.btnVerificare.Location = new System.Drawing.Point(41, 92);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(75, 23);
            this.btnVerificare.TabIndex = 3;
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.UseVisualStyleBackColor = true;
            this.btnVerificare.Click += new System.EventHandler(this.btnVerificare_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(147, 92);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Inspoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // VerificareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 135);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.lblTextParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtParola);
            this.Name = "VerificareParola";
            this.Text = "VerificareParola";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerificareParola_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblTextParola;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.Button btnInapoi;
    }
}