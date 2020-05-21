namespace TargMasini_Forma_toolbox
{
    partial class Form1
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
            this.lblModifica = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblCauta = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lblAdauga = new System.Windows.Forms.Label();
            this.btnMedie = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblVechime = new System.Windows.Forms.Label();
            this.gpbCuloar = new System.Windows.Forms.GroupBox();
            this.rdbPortocaliu = new System.Windows.Forms.RadioButton();
            this.rdbAlb = new System.Windows.Forms.RadioButton();
            this.rdbGri = new System.Windows.Forms.RadioButton();
            this.rdbRosu = new System.Windows.Forms.RadioButton();
            this.rdbAlbastru = new System.Windows.Forms.RadioButton();
            this.ckbLuminiCeata = new System.Windows.Forms.CheckBox();
            this.ckbABS = new System.Windows.Forms.CheckBox();
            this.ckbScaunePiele = new System.Windows.Forms.CheckBox();
            this.ckbAerConditionat = new System.Windows.Forms.CheckBox();
            this.gpbOptiuni = new System.Windows.Forms.GroupBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.dataGridMasini = new System.Windows.Forms.DataGridView();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtrareVehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareMasiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.gpbCuloar.SuspendLayout();
            this.gpbOptiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasini)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Location = new System.Drawing.Point(160, 516);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(0, 13);
            this.lblModifica.TabIndex = 31;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(64, 513);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(56, 19);
            this.btnModifica.TabIndex = 30;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Location = new System.Drawing.Point(397, 43);
            this.lblCauta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(0, 13);
            this.lblCauta.TabIndex = 29;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(64, 480);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(56, 19);
            this.btnCauta.TabIndex = 28;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(64, 214);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(56, 19);
            this.btnAfiseaza.TabIndex = 26;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
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
            // btnMedie
            // 
            this.btnMedie.Location = new System.Drawing.Point(64, 149);
            this.btnMedie.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedie.Name = "btnMedie";
            this.btnMedie.Size = new System.Drawing.Size(56, 19);
            this.btnMedie.TabIndex = 23;
            this.btnMedie.Text = "Vechime";
            this.btnMedie.UseVisualStyleBackColor = true;
            this.btnMedie.Click += new System.EventHandler(this.btnMedie_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(124, 110);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(76, 20);
            this.txtMarca.TabIndex = 22;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(124, 76);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(76, 20);
            this.txtPrenume.TabIndex = 21;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(124, 48);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(76, 20);
            this.txtNume.TabIndex = 20;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(64, 176);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(56, 23);
            this.btnAdauga.TabIndex = 19;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(61, 110);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(61, 81);
            this.lblPrenume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 17;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(61, 52);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 16;
            this.lblNume.Text = "Nume";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(295, 110);
            this.txtPret.Margin = new System.Windows.Forms.Padding(2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(76, 20);
            this.txtPret.TabIndex = 37;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(295, 76);
            this.txtAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(76, 20);
            this.txtAn.TabIndex = 36;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(295, 48);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(76, 20);
            this.txtModel.TabIndex = 35;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(232, 110);
            this.lblPret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 34;
            this.lblPret.Text = "Pret";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(232, 81);
            this.lblAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(20, 13);
            this.lblAn.TabIndex = 33;
            this.lblAn.Text = "An";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(232, 52);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 32;
            this.lblModel.Text = "Model";
            // 
            // lblVechime
            // 
            this.lblVechime.AutoSize = true;
            this.lblVechime.Location = new System.Drawing.Point(160, 155);
            this.lblVechime.Name = "lblVechime";
            this.lblVechime.Size = new System.Drawing.Size(0, 13);
            this.lblVechime.TabIndex = 38;
            this.lblVechime.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbCuloar
            // 
            this.gpbCuloar.Controls.Add(this.rdbPortocaliu);
            this.gpbCuloar.Controls.Add(this.rdbAlb);
            this.gpbCuloar.Controls.Add(this.rdbGri);
            this.gpbCuloar.Controls.Add(this.lblAdauga);
            this.gpbCuloar.Controls.Add(this.rdbRosu);
            this.gpbCuloar.Controls.Add(this.rdbAlbastru);
            this.gpbCuloar.Location = new System.Drawing.Point(64, 265);
            this.gpbCuloar.Name = "gpbCuloar";
            this.gpbCuloar.Size = new System.Drawing.Size(244, 100);
            this.gpbCuloar.TabIndex = 39;
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
            // gpbOptiuni
            // 
            this.gpbOptiuni.Controls.Add(this.ckbABS);
            this.gpbOptiuni.Controls.Add(this.ckbAerConditionat);
            this.gpbOptiuni.Controls.Add(this.ckbScaunePiele);
            this.gpbOptiuni.Controls.Add(this.ckbLuminiCeata);
            this.gpbOptiuni.Location = new System.Drawing.Point(64, 371);
            this.gpbOptiuni.Name = "gpbOptiuni";
            this.gpbOptiuni.Size = new System.Drawing.Size(244, 100);
            this.gpbOptiuni.TabIndex = 40;
            this.gpbOptiuni.TabStop = false;
            this.gpbOptiuni.Text = "Optiuni";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(184, 563);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 41;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(448, 179);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(544, 316);
            this.lstAfisare.TabIndex = 42;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // dataGridMasini
            // 
            this.dataGridMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMasini.Location = new System.Drawing.Point(998, 179);
            this.dataGridMasini.Name = "dataGridMasini";
            this.dataGridMasini.Size = new System.Drawing.Size(551, 316);
            this.dataGridMasini.TabIndex = 43;
            this.dataGridMasini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMasini_CellContentClick);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Motocicleta",
            "Masina",
            "Camion"});
            this.cmbTip.Location = new System.Drawing.Point(64, 238);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 21);
            this.cmbTip.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(445, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 45;
            this.lblID.Text = "ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(209, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrareVehiculeToolStripMenuItem,
            this.salvareMasiniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1549, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "FiltrareVehiculeMenuStrip";
            // 
            // filtrareVehiculeToolStripMenuItem
            // 
            this.filtrareVehiculeToolStripMenuItem.Name = "filtrareVehiculeToolStripMenuItem";
            this.filtrareVehiculeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.filtrareVehiculeToolStripMenuItem.Text = "Filtrare Vehicule";
            this.filtrareVehiculeToolStripMenuItem.Click += new System.EventHandler(this.filtrareVehiculeToolStripMenuItem_Click);
            // 
            // salvareMasiniToolStripMenuItem
            // 
            this.salvareMasiniToolStripMenuItem.Name = "salvareMasiniToolStripMenuItem";
            this.salvareMasiniToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.salvareMasiniToolStripMenuItem.Text = "Salvare Masini";
            this.salvareMasiniToolStripMenuItem.Click += new System.EventHandler(this.salvareMasiniToolStripMenuItem_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(64, 552);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 49;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1549, 588);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.dataGridMasini);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.gpbOptiuni);
            this.Controls.Add(this.gpbCuloar);
            this.Controls.Add(this.lblVechime);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblModifica);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnMedie);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCuloar.ResumeLayout(false);
            this.gpbCuloar.PerformLayout();
            this.gpbOptiuni.ResumeLayout(false);
            this.gpbOptiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasini)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifica;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Label lblAdauga;
        private System.Windows.Forms.Button btnMedie;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblVechime;
        private System.Windows.Forms.GroupBox gpbCuloar;
        private System.Windows.Forms.CheckBox ckbLuminiCeata;
        private System.Windows.Forms.CheckBox ckbABS;
        private System.Windows.Forms.CheckBox ckbScaunePiele;
        private System.Windows.Forms.CheckBox ckbAerConditionat;
        private System.Windows.Forms.GroupBox gpbOptiuni;
        private System.Windows.Forms.RadioButton rdbAlb;
        private System.Windows.Forms.RadioButton rdbGri;
        private System.Windows.Forms.RadioButton rdbAlbastru;
        private System.Windows.Forms.RadioButton rdbRosu;
        private System.Windows.Forms.RadioButton rdbPortocaliu;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.DataGridView dataGridMasini;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtrareVehiculeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem salvareMasiniToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnInapoi;
    }
}

