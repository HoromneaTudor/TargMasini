//Horomnea Tudor Grupa 3122A
namespace TargMasini_Forma_toolbox
{
    partial class FormaEditare
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
            this.btnModifica = new System.Windows.Forms.Button();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.gpbOptiuni = new System.Windows.Forms.GroupBox();
            this.ckbABS = new System.Windows.Forms.CheckBox();
            this.ckbAerConditionat = new System.Windows.Forms.CheckBox();
            this.ckbScaunePiele = new System.Windows.Forms.CheckBox();
            this.ckbLuminiCeata = new System.Windows.Forms.CheckBox();
            this.gpbCuloar = new System.Windows.Forms.GroupBox();
            this.rdbPortocaliu = new System.Windows.Forms.RadioButton();
            this.rdbAlb = new System.Windows.Forms.RadioButton();
            this.rdbGri = new System.Windows.Forms.RadioButton();
            this.lblAdauga = new System.Windows.Forms.Label();
            this.rdbRosu = new System.Windows.Forms.RadioButton();
            this.rdbAlbastru = new System.Windows.Forms.RadioButton();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume1 = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.gpbOptiuni.SuspendLayout();
            this.gpbCuloar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(96, 407);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Motocicleta",
            "Masina",
            "Camion"});
            this.cmbTip.Location = new System.Drawing.Point(152, 127);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 21);
            this.cmbTip.TabIndex = 47;
            // 
            // gpbOptiuni
            // 
            this.gpbOptiuni.Controls.Add(this.ckbABS);
            this.gpbOptiuni.Controls.Add(this.ckbAerConditionat);
            this.gpbOptiuni.Controls.Add(this.ckbScaunePiele);
            this.gpbOptiuni.Controls.Add(this.ckbLuminiCeata);
            this.gpbOptiuni.Location = new System.Drawing.Point(394, 127);
            this.gpbOptiuni.Name = "gpbOptiuni";
            this.gpbOptiuni.Size = new System.Drawing.Size(244, 100);
            this.gpbOptiuni.TabIndex = 46;
            this.gpbOptiuni.TabStop = false;
            this.gpbOptiuni.Text = "Optiuni";
            // 
            // ckbABS
            // 
            this.ckbABS.AutoSize = true;
            this.ckbABS.Location = new System.Drawing.Point(13, 43);
            this.ckbABS.Name = "ckbABS";
            this.ckbABS.Size = new System.Drawing.Size(47, 17);
            this.ckbABS.TabIndex = 2;
            this.ckbABS.Text = "ABS";
            this.ckbABS.UseVisualStyleBackColor = true;
            this.ckbABS.CheckedChanged += new System.EventHandler(this.ckbOptiuni_CheckedChanged);
            // 
            // ckbAerConditionat
            // 
            this.ckbAerConditionat.AutoSize = true;
            this.ckbAerConditionat.Location = new System.Drawing.Point(13, 19);
            this.ckbAerConditionat.Name = "ckbAerConditionat";
            this.ckbAerConditionat.Size = new System.Drawing.Size(95, 17);
            this.ckbAerConditionat.TabIndex = 0;
            this.ckbAerConditionat.Text = "AerConditionat";
            this.ckbAerConditionat.UseVisualStyleBackColor = true;
            this.ckbAerConditionat.CheckedChanged += new System.EventHandler(this.ckbOptiuni_CheckedChanged);
            // 
            // ckbScaunePiele
            // 
            this.ckbScaunePiele.AutoSize = true;
            this.ckbScaunePiele.Location = new System.Drawing.Point(114, 20);
            this.ckbScaunePiele.Name = "ckbScaunePiele";
            this.ckbScaunePiele.Size = new System.Drawing.Size(86, 17);
            this.ckbScaunePiele.TabIndex = 1;
            this.ckbScaunePiele.Text = "ScaunePiele";
            this.ckbScaunePiele.UseVisualStyleBackColor = true;
            this.ckbScaunePiele.CheckedChanged += new System.EventHandler(this.ckbOptiuni_CheckedChanged);
            // 
            // ckbLuminiCeata
            // 
            this.ckbLuminiCeata.AutoSize = true;
            this.ckbLuminiCeata.Location = new System.Drawing.Point(114, 43);
            this.ckbLuminiCeata.Name = "ckbLuminiCeata";
            this.ckbLuminiCeata.Size = new System.Drawing.Size(98, 17);
            this.ckbLuminiCeata.TabIndex = 3;
            this.ckbLuminiCeata.Text = "LuminiDeCeata";
            this.ckbLuminiCeata.UseVisualStyleBackColor = true;
            this.ckbLuminiCeata.CheckedChanged += new System.EventHandler(this.ckbOptiuni_CheckedChanged);
            // 
            // gpbCuloar
            // 
            this.gpbCuloar.Controls.Add(this.rdbPortocaliu);
            this.gpbCuloar.Controls.Add(this.rdbAlb);
            this.gpbCuloar.Controls.Add(this.rdbGri);
            this.gpbCuloar.Controls.Add(this.lblAdauga);
            this.gpbCuloar.Controls.Add(this.rdbRosu);
            this.gpbCuloar.Controls.Add(this.rdbAlbastru);
            this.gpbCuloar.Location = new System.Drawing.Point(394, 22);
            this.gpbCuloar.Name = "gpbCuloar";
            this.gpbCuloar.Size = new System.Drawing.Size(244, 100);
            this.gpbCuloar.TabIndex = 45;
            this.gpbCuloar.TabStop = false;
            this.gpbCuloar.Text = "Culoare";
            // 
            // rdbPortocaliu
            // 
            this.rdbPortocaliu.AutoSize = true;
            this.rdbPortocaliu.Location = new System.Drawing.Point(9, 66);
            this.rdbPortocaliu.Name = "rdbPortocaliu";
            this.rdbPortocaliu.Size = new System.Drawing.Size(72, 17);
            this.rdbPortocaliu.TabIndex = 26;
            this.rdbPortocaliu.TabStop = true;
            this.rdbPortocaliu.Text = "Portocaliu";
            this.rdbPortocaliu.UseVisualStyleBackColor = true;
            // 
            // rdbAlb
            // 
            this.rdbAlb.AutoSize = true;
            this.rdbAlb.Location = new System.Drawing.Point(101, 43);
            this.rdbAlb.Name = "rdbAlb";
            this.rdbAlb.Size = new System.Drawing.Size(40, 17);
            this.rdbAlb.TabIndex = 3;
            this.rdbAlb.TabStop = true;
            this.rdbAlb.Text = "Alb";
            this.rdbAlb.UseVisualStyleBackColor = true;
            // 
            // rdbGri
            // 
            this.rdbGri.AutoSize = true;
            this.rdbGri.Location = new System.Drawing.Point(9, 43);
            this.rdbGri.Name = "rdbGri";
            this.rdbGri.Size = new System.Drawing.Size(38, 17);
            this.rdbGri.TabIndex = 2;
            this.rdbGri.TabStop = true;
            this.rdbGri.Text = "Gri";
            this.rdbGri.UseVisualStyleBackColor = true;
            // 
            // lblAdauga
            // 
            this.lblAdauga.AutoSize = true;
            this.lblAdauga.Location = new System.Drawing.Point(34, 3);
            this.lblAdauga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdauga.Name = "lblAdauga";
            this.lblAdauga.Size = new System.Drawing.Size(0, 13);
            this.lblAdauga.TabIndex = 25;
            // 
            // rdbRosu
            // 
            this.rdbRosu.AutoSize = true;
            this.rdbRosu.Location = new System.Drawing.Point(9, 19);
            this.rdbRosu.Name = "rdbRosu";
            this.rdbRosu.Size = new System.Drawing.Size(50, 17);
            this.rdbRosu.TabIndex = 0;
            this.rdbRosu.TabStop = true;
            this.rdbRosu.Text = "Rosu";
            this.rdbRosu.UseVisualStyleBackColor = true;
            // 
            // rdbAlbastru
            // 
            this.rdbAlbastru.AutoSize = true;
            this.rdbAlbastru.Location = new System.Drawing.Point(101, 19);
            this.rdbAlbastru.Name = "rdbAlbastru";
            this.rdbAlbastru.Size = new System.Drawing.Size(63, 17);
            this.rdbAlbastru.TabIndex = 1;
            this.rdbAlbastru.TabStop = true;
            this.rdbAlbastru.Text = "Albastru";
            this.rdbAlbastru.UseVisualStyleBackColor = true;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(294, 80);
            this.txtPret.Margin = new System.Windows.Forms.Padding(2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(76, 20);
            this.txtPret.TabIndex = 59;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(294, 46);
            this.txtAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(76, 20);
            this.txtAn.TabIndex = 58;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(294, 18);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(76, 20);
            this.txtModel.TabIndex = 57;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(231, 80);
            this.lblPret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 56;
            this.lblPret.Text = "Pret";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(231, 51);
            this.lblAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(20, 13);
            this.lblAn.TabIndex = 55;
            this.lblAn.Text = "An";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(231, 22);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 54;
            this.lblModel.Text = "Model";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(123, 80);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(76, 20);
            this.txtMarca.TabIndex = 53;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(123, 50);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(76, 20);
            this.txtPrenume.TabIndex = 52;
            // 
            // txtNume1
            // 
            this.txtNume1.Location = new System.Drawing.Point(123, 18);
            this.txtNume1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume1.Name = "txtNume1";
            this.txtNume1.Size = new System.Drawing.Size(76, 20);
            this.txtNume1.TabIndex = 51;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(60, 80);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 50;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(60, 53);
            this.lblPrenume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 49;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(60, 22);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 48;
            this.lblNume.Text = "Nume";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(120, 127);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 60;
            this.lblTip.Text = "Tip";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(762, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 63;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconSize = 16;
            this.btnMaximize.Location = new System.Drawing.Point(731, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 62;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconSize = 16;
            this.btnMinimize.Location = new System.Drawing.Point(700, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 61;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // FormaEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::TargMasini_Forma_toolbox.Properties.Resources.saasdas;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume1);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.gpbOptiuni);
            this.Controls.Add(this.gpbCuloar);
            this.Controls.Add(this.btnModifica);
            this.Name = "FormaEditare";
            this.Text = "FormaEditare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaEditare_FormClosing);
            this.Load += new System.EventHandler(this.FormaEditare_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormaEditare_MouseDown);
            this.gpbOptiuni.ResumeLayout(false);
            this.gpbOptiuni.PerformLayout();
            this.gpbCuloar.ResumeLayout(false);
            this.gpbCuloar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.GroupBox gpbOptiuni;
        private System.Windows.Forms.CheckBox ckbABS;
        private System.Windows.Forms.CheckBox ckbAerConditionat;
        private System.Windows.Forms.CheckBox ckbScaunePiele;
        private System.Windows.Forms.CheckBox ckbLuminiCeata;
        private System.Windows.Forms.GroupBox gpbCuloar;
        private System.Windows.Forms.RadioButton rdbPortocaliu;
        private System.Windows.Forms.RadioButton rdbAlb;
        private System.Windows.Forms.RadioButton rdbGri;
        private System.Windows.Forms.Label lblAdauga;
        private System.Windows.Forms.RadioButton rdbRosu;
        private System.Windows.Forms.RadioButton rdbAlbastru;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblTip;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
    }
}