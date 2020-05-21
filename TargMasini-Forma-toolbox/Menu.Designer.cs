namespace TargMasini_Forma_toolbox
{
    partial class Menu
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
            this.btnAdministrare = new System.Windows.Forms.Button();
            this.btnAdministrareOferte = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrare
            // 
            this.btnAdministrare.Location = new System.Drawing.Point(68, 43);
            this.btnAdministrare.Name = "btnAdministrare";
            this.btnAdministrare.Size = new System.Drawing.Size(145, 23);
            this.btnAdministrare.TabIndex = 0;
            this.btnAdministrare.Text = "Administrare";
            this.btnAdministrare.UseVisualStyleBackColor = true;
            this.btnAdministrare.Click += new System.EventHandler(this.btnAdministrare_Click);
            // 
            // btnAdministrareOferte
            // 
            this.btnAdministrareOferte.Location = new System.Drawing.Point(68, 93);
            this.btnAdministrareOferte.Name = "btnAdministrareOferte";
            this.btnAdministrareOferte.Size = new System.Drawing.Size(145, 23);
            this.btnAdministrareOferte.TabIndex = 1;
            this.btnAdministrareOferte.Text = "VizualizeazaOferte";
            this.btnAdministrareOferte.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(68, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(68, 133);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(145, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "InfoAutor";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdministrareOferte);
            this.Controls.Add(this.btnAdministrare);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrare;
        private System.Windows.Forms.Button btnAdministrareOferte;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInfo;
    }
}