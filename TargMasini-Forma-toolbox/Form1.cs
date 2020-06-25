//Horomnea Tudor Grupa 3122A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using Masina;
using System.Collections;
using System.IO;

namespace TargMasini_Forma_toolbox
{
    public partial class Form1 : Form
    {
        IStocareData adminMasini;
        List<string> optiuniSelectate = new List<string>();
        public Form1()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
            this.Width = 440;
        
        }
        public Form ReftoMenu { get; set; }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            masina m;
            lblMarca.ForeColor = Color.Black;
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblAn.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
            lblTip.ForeColor = Color.Black;
            CodEroare validarea = Validare(txtNume.Text, txtPrenume.Text, txtMarca.Text, txtMarca.Text, txtAn.Text, txtPret.Text);
            if (validarea!=CodEroare.CORECT)
            {
                switch(validarea)
                {
                    case CodEroare.NUME_INCORECT:
                        lblNume.ForeColor = Color.Red;
                    break;
                    case CodEroare.PRENUME_INCORECT:
                        lblPrenume.ForeColor = Color.Red;
                    break;
                    case CodEroare.MARCA_INCORECT:
                        lblMarca.ForeColor = Color.Red;
                    break;
                    case CodEroare.MODEL_INCORECT:
                        lblModel.ForeColor = Color.Red;
                    break;
                    case CodEroare.AN_INCORECT:
                        lblAn.ForeColor = Color.Red;
                    break;
                    case CodEroare.PRET_INCORECT:
                        lblPret.ForeColor = Color.Red;
                        break;
                    case CodEroare.TIP_INCORECT:
                        lblTip.ForeColor = Color.Red;
                    break;
                }
            }
            else 
            {
                m = new masina(txtNume.Text, txtPrenume.Text, txtMarca.Text, txtModel.Text);
                int pret = Int32.Parse(txtPret.Text);
                int an = Int32.Parse(txtAn.Text);
                m.SetAnPret(an,pret);
                m.Culoare = GetCuloareMasina();
                m.Optiuni = new List<string>();
                m.Optiuni.AddRange(optiuniSelectate);
                if(cmbTip.Text!="")
                {
                    m.tip = cmbTip.Text;
                }
                m.DataActualizare = DateTime.Now;
                adminMasini.AddMasina(m);
                lblAdauga.Text = "Masina a fost adaugata cu succes";
                ResetareControale();
            }

        }
        private CodEroare Validare(string nume,string prenume,string marca,string model,string an,string pret)
        {
            int ign;
            if (nume == string.Empty)
                return CodEroare.NUME_INCORECT;
            if (prenume == string.Empty)
                return CodEroare.PRENUME_INCORECT;
            if (marca == string.Empty)
                return CodEroare.MARCA_INCORECT;
            if (model == string.Empty)
                return CodEroare.MODEL_INCORECT;
            if (an == string.Empty)
                return CodEroare.AN_INCORECT;
            bool succes = false;
            succes = Int32.TryParse(an, out ign);
            if (succes == false)
                return CodEroare.AN_INCORECT;
            if (pret == string.Empty)
               return CodEroare.PRET_INCORECT;
            succes = false;
            succes = Int32.TryParse(pret, out ign);
            if (succes == false)
                return CodEroare.PRET_INCORECT;
            if (cmbTip.Text == string.Empty)
                return CodEroare.TIP_INCORECT;

            return CodEroare.CORECT;
        }

        private void btnMedie_Click(object sender, EventArgs e)
        {
            masina m;
            //ResetareControale();
            lblMarca.ForeColor = Color.Black;
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblAn.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
            lblTip.ForeColor = Color.Black;
            CodEroare validarea = Validare(txtNume.Text, txtPrenume.Text, txtMarca.Text, txtMarca.Text, txtAn.Text, txtPret.Text);
            if (validarea != CodEroare.CORECT)
            {
                switch (validarea)
                {
                    case CodEroare.NUME_INCORECT:
                        lblNume.ForeColor = Color.Red;
                        break;
                    case CodEroare.PRENUME_INCORECT:
                        lblPrenume.ForeColor = Color.Red;
                        break;
                    case CodEroare.MARCA_INCORECT:
                        lblMarca.ForeColor = Color.Red;
                        break;
                    case CodEroare.MODEL_INCORECT:
                        lblModel.ForeColor = Color.Red;
                        break;
                    case CodEroare.AN_INCORECT:
                        lblAn.ForeColor = Color.Red;
                        break;
                    case CodEroare.PRET_INCORECT:
                        lblPret.ForeColor = Color.Red;
                        break;
                    case CodEroare.TIP_INCORECT:
                        lblTip.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                m = new masina(txtNume.Text, txtPrenume.Text, txtMarca.Text, txtModel.Text);
                int pret = Int32.Parse(txtPret.Text);
                int an = Int32.Parse(txtAn.Text);
                m.SetAnPret(an, pret);
                lblVechime.Text = m.Vechime.ToString();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            //rtbAfisare.Clear();
            this.Width = 1590;
            List<masina> masini = adminMasini.GetMasini();
            //foreach (masina m in masini)
            //{
            //    rtbAfisare.AppendText(m.IdMasina.ToString());
            //    rtbAfisare.AppendText(" ");
            //    rtbAfisare.AppendText(m.afisare());
            //    rtbAfisare.AppendText(Environment.NewLine);
            //}
            AdaugaMasinaInControlListbox(masini);
            AdaugaMasiniInControlDataGridView(masini);
        }

        private void AdaugaMasinaInControlListbox(List<masina> masini)
        {
            //rtbAfisare.Clear();
            //var antetTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", "Id", "Nume Prenume", "ProgramStudiu", "Medie");
            //rtbAfisare.AppendText(antetTabel);
            lstAfisare.Items.Clear();

           
            foreach (masina m in masini)
            {
                lstAfisare.Items.Add(m);
                //var linieTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", m.IdMasina, m.nume_vanzator,m.prenume_vanzator,m.model);
                //rtbAfisare.AppendText(linieTabel);
            }
        }
        private void AdaugaMasiniInControlDataGridView(List<masina> masini)
        {
            dataGridMasini.DataSource = null;
            dataGridMasini.DataSource = masini.Select(m => new { m.IdMasina,m.firma,m.model,m.pret,m.an, m.nume_vanzator, m.prenume_vanzator , m.tip , m.DataActualizare , Optiuni=string.Join(",",m.Optiuni),m.Culoare,}).ToList();
            
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            masina m = adminMasini.GetMasina(txtNume.Text, txtPrenume.Text, txtModel.Text);
            if (m != null)
            {
                lblCauta.Text = m.ConversieLaSir();
                lblModifica.Text = "Introduceti noul pretsau optiuni si apasati modificaPret in cazul in care doriti modificarea acestuia";
            }
            else
            {
                lblCauta.Text = "Nu sa gasit masina";
               
            }
            if (txtNume.Enabled == true && txtPrenume.Enabled == true)
            {
                txtNume.Enabled = false;
                txtPrenume.Enabled = false;
                txtAn.Enabled = false;
                txtMarca.Enabled = false;
                txtModel.Enabled = false;

            }
            else
            {
                txtNume.Enabled = true;
                txtPrenume.Enabled = true;
                txtAn.Enabled = true;
                txtMarca.Enabled = true;
                txtModel.Enabled = true;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            lblModifica.Text = "";
            lblCauta.Text = "";
            masina m = adminMasini.GetMasina(txtNume.Text, txtPrenume.Text, txtModel.Text);
            if(m!=null)
            {

                //if (txtPret.Text != string.Empty)
                //{
                //    int prett = Int32.Parse(txtPret.Text);
                //    m.pret = prett;
                //}
                //m.Culoare = GetCuloareMasina();
                //m.OptiuniMasina = GetOptiuni();
                //adminMasini.UpdateMasina(m);
                using (FormaEditare formEdit = new FormaEditare(m)) 
                {
                    //formEdit.ReftoForm1 = this;
                    var dr = formEdit.ShowDialog(this);
                    if(dr==DialogResult.OK)
                    {
                        lblModifica.Text = "Schimbare efectuata cu succes";
                    }
                    formEdit.Close();
                }
            }

            else
            {
                lblModifica.Text = "Masina inexistent";
            }
        }
        //private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        //{
        //    CheckBox checkBoxControl = sender as CheckBox;
        //    string optiuneSelectata = checkBoxControl.Text;
        //    if (checkBoxControl.Checked == true)
        //        optiuniSelectate.Add(optiuneSelectata);
        //    else
        //        optiuniSelectate.Remove(optiuneSelectata);

        //}

        //private Optiuni GetOptiuni()    //modificat
        //{
        //    int i = 0;
        //    if (ckbAerConditionat.Checked)
        //        i++;                    //i=i | optiuni.aerconditionat ideie
        //    if (ckbScaunePiele.Checked)
        //        i += 2;
        //    if (ckbABS.Checked)
        //        i += 4;
        //    if (ckbLuminiCeata.Checked)
        //        i += 8;
        //    return (Optiuni)i;
        //}
        private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string optiuneSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(optiuneSelectata);
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtAn.Text = txtMarca.Text = txtModel.Text = txtPret.Text = string.Empty;
            rdbRosu.Checked = false;
            rdbAlbastru.Checked = false;
            rdbGri.Checked = false;
            rdbAlb.Checked = false;
            rdbPortocaliu.Checked = false;
            ckbABS.Checked = false;
            ckbScaunePiele.Checked = false;
            ckbAerConditionat.Checked = false;
            ckbLuminiCeata.Checked = false;
            
            optiuniSelectate.Clear();
            lblMesaj.Text = string.Empty;
        }
        private CuloareMasina GetCuloareMasina()
        {
            if (rdbAlb.Checked)
                return CuloareMasina.Alb;
            if (rdbAlbastru.Checked)
                return CuloareMasina.Albastru;
            if (rdbGri.Checked)
                return CuloareMasina.Gri;
            if (rdbRosu.Checked)
                return CuloareMasina.Rosu;
            if (rdbPortocaliu.Checked)
                return CuloareMasina.Portocaliu;
            return CuloareMasina.Inexistenta;

        }

        private void dataGridMasini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            masina m = null;
            try
            {
                m = adminMasini.GetMasinaByIndex(lstAfisare.SelectedIndex);
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Eroare: " + ex.Message;
            }

            if (m != null)
            {
                lblID.Text = m.IdMasina.ToString();

                txtNume.Text = m.nume_vanzator;
                txtPrenume.Text = m.prenume_vanzator;
                txtModel.Text = m.model;
                txtMarca.Text = m.firma;
                txtAn.Text = m.an.ToString();
                txtPret.Text = m.pret.ToString();
                cmbTip.Text = m.tip;

                foreach (var prgstd in gpbCuloar.Controls)
                {
                    if (prgstd is RadioButton)
                    {
                        var prgstdBox = prgstd as RadioButton;
                        if (prgstdBox.Text == m.Culoare.ToString())
                        {
                            prgstdBox.Checked = true;
                        }
                    }
                }

                foreach (var optiune in gpbOptiuni.Controls)
                {
                    if (optiune is CheckBox)
                    {
                        var optiuneBox = optiune as CheckBox;
                        foreach (string dis in m.Optiuni)
                            if (optiuneBox.Text.Equals(dis))
                                optiuneBox.Checked = true;
                    }
                }

                cmbTip.Text = m.tip.ToString();
                //txtNote.Text = String.Join(" ", s.GetNote());
            }
        }

        private void filtrareVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<masina> filtrate = adminMasini.GetMasiniFiltrare(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridMasini.DataSource=filtrate.Select(m => new { m.IdMasina, m.nume_vanzator, m.prenume_vanzator, m.tip, m.DataActualizare, Optiuni = string.Join(",", m.Optiuni) }).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salvareMasiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<masina> masini = adminMasini.GetMasiniFiltrare(dateTimePicker1.Value, dateTimePicker2.Value);
            sfd.ShowDialog();
            salvareFiltrare(masini,sfd.FileName);
        }
        public void salvareFiltrare(List<masina>masini,string numeFisier)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (masina m in masini)
                    {
                        swFisierText.WriteLine(m.ConversieLaSir());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

       

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ReftoMenu.Show();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ReftoMenu.Show();
        }

        private void btnModificaPret_Click(object sender, EventArgs e)
        {
            masina m = adminMasini.GetMasina(txtNume.Text, txtPrenume.Text, txtModel.Text);
            if (txtPret.Text != string.Empty)
                {
                    int prett = Int32.Parse(txtPret.Text);
                    m.pret = prett;
                }
                //m.Culoare = GetCuloareMasina();
                //m.OptiuniMasina = GetOptiuni();
                adminMasini.UpdateMasina(m);
            txtNume.Enabled = true;
            txtPrenume.Enabled = true;
            txtAn.Enabled = true;
            txtMarca.Enabled = true;
            txtModel.Enabled = true;
            ResetareControale();
            lblModifica.Text = "Modificare realizata cu scucess!";
        }




        //private string getTip(masina m)
        //{
        //    return m.tip;
        //}
    }
}
