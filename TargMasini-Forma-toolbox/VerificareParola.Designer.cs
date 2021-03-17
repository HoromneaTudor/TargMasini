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
            this.lblParolaActuala = new System.Windows.Forms.Label();
            this.txtParolaActuala = new System.Windows.Forms.TextBox();
            this.lblParolaNoua = new System.Windows.Forms.Label();
            this.txtParolaNoua = new System.Windows.Forms.TextBox();
            this.btnSchimbareParola = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.lblConfirmare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParola.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtParola.Location = new System.Drawing.Point(66, 24);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 0;
            this.txtParola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblParola.Location = new System.Drawing.Point(20, 24);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(40, 13);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola:";
            // 
            // lblTextParola
            // 
            this.lblTextParola.AutoSize = true;
            this.lblTextParola.Location = new System.Drawing.Point(20, 70);
            this.lblTextParola.Name = "lblTextParola";
            this.lblTextParola.Size = new System.Drawing.Size(0, 13);
            this.lblTextParola.TabIndex = 2;
            // 
            // btnVerificare
            // 
            this.btnVerificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerificare.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerificare.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificare.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVerificare.Location = new System.Drawing.Point(33, 141);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(75, 23);
            this.btnVerificare.TabIndex = 3;
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.UseVisualStyleBackColor = false;
            this.btnVerificare.Click += new System.EventHandler(this.btnVerificare_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInapoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInapoi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInapoi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInapoi.Location = new System.Drawing.Point(139, 141);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Inspoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblParolaActuala
            // 
            this.lblParolaActuala.AutoSize = true;
            this.lblParolaActuala.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblParolaActuala.Location = new System.Drawing.Point(259, 26);
            this.lblParolaActuala.Name = "lblParolaActuala";
            this.lblParolaActuala.Size = new System.Drawing.Size(78, 13);
            this.lblParolaActuala.TabIndex = 6;
            this.lblParolaActuala.Text = "Parola actuala:";
            // 
            // txtParolaActuala
            // 
            this.txtParolaActuala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParolaActuala.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtParolaActuala.Location = new System.Drawing.Point(340, 23);
            this.txtParolaActuala.Name = "txtParolaActuala";
            this.txtParolaActuala.PasswordChar = '*';
            this.txtParolaActuala.Size = new System.Drawing.Size(100, 20);
            this.txtParolaActuala.TabIndex = 5;
            // 
            // lblParolaNoua
            // 
            this.lblParolaNoua.AutoSize = true;
            this.lblParolaNoua.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblParolaNoua.Location = new System.Drawing.Point(259, 52);
            this.lblParolaNoua.Name = "lblParolaNoua";
            this.lblParolaNoua.Size = new System.Drawing.Size(67, 13);
            this.lblParolaNoua.TabIndex = 8;
            this.lblParolaNoua.Text = "Parola noua:";
            // 
            // txtParolaNoua
            // 
            this.txtParolaNoua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParolaNoua.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtParolaNoua.Location = new System.Drawing.Point(340, 49);
            this.txtParolaNoua.Name = "txtParolaNoua";
            this.txtParolaNoua.PasswordChar = '*';
            this.txtParolaNoua.Size = new System.Drawing.Size(100, 20);
            this.txtParolaNoua.TabIndex = 7;
            // 
            // btnSchimbareParola
            // 
            this.btnSchimbareParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSchimbareParola.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSchimbareParola.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSchimbareParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchimbareParola.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSchimbareParola.Location = new System.Drawing.Point(271, 141);
            this.btnSchimbareParola.Name = "btnSchimbareParola";
            this.btnSchimbareParola.Size = new System.Drawing.Size(127, 23);
            this.btnSchimbareParola.TabIndex = 9;
            this.btnSchimbareParola.Text = "Schimbare parola";
            this.btnSchimbareParola.UseVisualStyleBackColor = false;
            this.btnSchimbareParola.Click += new System.EventHandler(this.btnSchimbareParola_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmare.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmare.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmare.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfirmare.Location = new System.Drawing.Point(416, 140);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(129, 23);
            this.btnConfirmare.TabIndex = 10;
            this.btnConfirmare.Text = "Confirmare parola";
            this.btnConfirmare.UseVisualStyleBackColor = false;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // lblConfirmare
            // 
            this.lblConfirmare.AutoSize = true;
            this.lblConfirmare.Location = new System.Drawing.Point(271, 93);
            this.lblConfirmare.Name = "lblConfirmare";
            this.lblConfirmare.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmare.TabIndex = 11;
            // 
            // VerificareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(548, 244);
            this.Controls.Add(this.lblConfirmare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnSchimbareParola);
            this.Controls.Add(this.lblParolaNoua);
            this.Controls.Add(this.txtParolaNoua);
            this.Controls.Add(this.lblParolaActuala);
            this.Controls.Add(this.txtParolaActuala);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.lblTextParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtParola);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "VerificareParola";
            this.Text = "VerificareParola";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerificareParola_FormClosing);
            this.Load += new System.EventHandler(this.VerificareParola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblTextParola;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblParolaActuala;
        private System.Windows.Forms.TextBox txtParolaActuala;
        private System.Windows.Forms.Label lblParolaNoua;
        private System.Windows.Forms.TextBox txtParolaNoua;
        private System.Windows.Forms.Button btnSchimbareParola;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Label lblConfirmare;
    }
}