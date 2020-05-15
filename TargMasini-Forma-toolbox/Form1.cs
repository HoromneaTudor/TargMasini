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

namespace TargMasini_Forma_toolbox
{
    public partial class Form1 : Form
    {
        IStocareData adminMasini;
        ArrayList optiuniSelectate = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
        
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            masina m;
            lblMarca.ForeColor = Color.Black;
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblAn.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
            CodEroare validarea = Validare(txtNume.Text, txtPrenume.Text, txtMarca.Text, txtMarca.Text, txtAn.Text, txtPret.Text);
            if(validarea!=CodEroare.CORECT)
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
                }
            }
            else 
            {
                m = new masina(txtNume.Text, txtPrenume.Text, txtMarca.Text, txtModel.Text);
                int pret = Int32.Parse(txtPret.Text);
                int an = Int32.Parse(txtAn.Text);
                m.SetAnPret(an,pret);
                m.Culoare = GetCuloareMasina();
                m.OptiuniMasina = GetOptiuni();
                adminMasini.AddMasina(m);
                lblAdauga.Text = "Masina a fost adaugata cu succes";
            }

        }
        private CodEroare Validare(string nume,string prenume,string marca,string model,string an,string pret)
        {
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
            if (pret == string.Empty)
                return CodEroare.PRET_INCORECT;
            return CodEroare.CORECT;
        }

        private void btnMedie_Click(object sender, EventArgs e)
        {
            masina m;
            lblMarca.ForeColor = Color.Black;
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblAn.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
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
            rtbAfisare.Clear();
            ArrayList masini = adminMasini.GetMasini();
            foreach(masina m in masini)
            {
                rtbAfisare.AppendText(m.IdMasina.ToString());
                rtbAfisare.AppendText(" ");
                rtbAfisare.AppendText(m.ConversieLaSir());
                rtbAfisare.AppendText(Environment.NewLine);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            masina m = adminMasini.GetMasina(txtNume.Text, txtPrenume.Text, txtModel.Text);
            if (m != null)
            {
                lblCauta.Text = m.ConversieLaSir();
                lblModifica.Text = "Introduceti noul pretsau optiuni si apasati modifica in cazul in care doriti modificarea acestuia";
            }
            else
            {
                lblCauta.Text = "Nu sa gasit masina";
               
            }
            if (txtNume.Enabled == true && txtPrenume.Enabled == true)
            {
                txtNume.Enabled = false;
                txtPrenume.Enabled = false;

            }
            else
            {
                txtNume.Enabled = true;
                txtPrenume.Enabled = true;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            lblModifica.Text = "";
            lblCauta.Text = "";
            masina m = adminMasini.GetMasina(txtNume.Text, txtPrenume.Text, txtModel.Text);
            if(m!=null)
            {

                if (txtPret.Text != string.Empty)
                {
                    int prett = Int32.Parse(txtPret.Text);
                    m.pret = prett;
                }
                m.Culoare = GetCuloareMasina();
                m.OptiuniMasina = GetOptiuni();
                adminMasini.UpdateMasina(m);

            }
            else
            {
                lblModifica.Text = "Student inexistent";
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

        private Optiuni GetOptiuni()
        {
            int i = 0;
            if (ckbAerConditionat.Checked)
                i++;
            if (ckbScaunePiele.Checked)
                i += 2;
            if (ckbABS.Checked)
                i += 4;
            if (ckbLuminiCeata.Checked)
                i += 8;
            return (Optiuni)i;
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
    }
}
