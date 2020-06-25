namespace TargMasini_Forma_toolbox
{
    partial class client
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
            this.DataGridMasini = new System.Windows.Forms.DataGridView();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.cmbCautare = new System.Windows.Forms.ComboBox();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.lblCautare = new System.Windows.Forms.Label();
            this.btnAfisareToate = new System.Windows.Forms.Button();
            this.lblEroare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMasini)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMasini
            // 
            this.DataGridMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMasini.Location = new System.Drawing.Point(314, 24);
            this.DataGridMasini.Name = "DataGridMasini";
            this.DataGridMasini.Size = new System.Drawing.Size(750, 327);
            this.DataGridMasini.TabIndex = 0;
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(12, 328);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 1;
            this.btnInapoi.Text = "inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(12, 53);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.TabIndex = 2;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // cmbCautare
            // 
            this.cmbCautare.FormattingEnabled = true;
            this.cmbCautare.Items.AddRange(new object[] {
            "nume",
            "prenume",
            "pret",
            "an"});
            this.cmbCautare.Location = new System.Drawing.Point(112, 55);
            this.cmbCautare.Name = "cmbCautare";
            this.cmbCautare.Size = new System.Drawing.Size(121, 21);
            this.cmbCautare.TabIndex = 3;
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(112, 100);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(100, 20);
            this.txtCautare.TabIndex = 4;
            // 
            // lblCautare
            // 
            this.lblCautare.AutoSize = true;
            this.lblCautare.Location = new System.Drawing.Point(9, 103);
            this.lblCautare.Name = "lblCautare";
            this.lblCautare.Size = new System.Drawing.Size(84, 13);
            this.lblCautare.TabIndex = 5;
            this.lblCautare.Text = "Criteriul selectat:";
            // 
            // btnAfisareToate
            // 
            this.btnAfisareToate.Location = new System.Drawing.Point(13, 183);
            this.btnAfisareToate.Name = "btnAfisareToate";
            this.btnAfisareToate.Size = new System.Drawing.Size(75, 23);
            this.btnAfisareToate.TabIndex = 6;
            this.btnAfisareToate.Text = "Afisare toate";
            this.btnAfisareToate.UseVisualStyleBackColor = true;
            this.btnAfisareToate.Click += new System.EventHandler(this.btnAfisareToate_Click);
            // 
            // lblEroare
            // 
            this.lblEroare.AutoSize = true;
            this.lblEroare.Location = new System.Drawing.Point(13, 248);
            this.lblEroare.Name = "lblEroare";
            this.lblEroare.Size = new System.Drawing.Size(0, 13);
            this.lblEroare.TabIndex = 7;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.lblEroare);
            this.Controls.Add(this.btnAfisareToate);
            this.Controls.Add(this.lblCautare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.cmbCautare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.DataGridMasini);
            this.Name = "client";
            this.Text = "client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.client_FormClosing);
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMasini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridMasini;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.ComboBox cmbCautare;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label lblCautare;
        private System.Windows.Forms.Button btnAfisareToate;
        private System.Windows.Forms.Label lblEroare;
    }
}