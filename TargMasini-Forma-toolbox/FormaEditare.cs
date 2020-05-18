using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Masina;
using NivelAccesDate;


namespace TargMasini_Forma_toolbox
{
    public partial class FormaEditare : Form
    {
        public masina masinaForma1;
        IStocareData adminMasini;
        public FormaEditare()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
        }
        public FormaEditare(masina mas):this()
        {
            masinaForma1 = mas;
        }
        private void FormaEditare_Load(object sender,EventArgs e)
        {
            //lblAfisare.Text = masinaForma1.nume_vanzator;
            lblAfisare.Text = masinaForma1.model;
            txtNume1.Text = masinaForma1.nume_vanzator;
            txtPrenume.Text = masinaForma1.prenume_vanzator;
            txtMarca.Text = masinaForma1.firma;
            txtModel.Text = masinaForma1.model;
            txtAn.Text = masinaForma1.an.ToString();
            txtPret.Text = masinaForma1.pret.ToString();
            cmbTip.Text = masinaForma1.tip;

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            
            if (txtPret.Text != string.Empty)
            {
                int prett = Int32.Parse(txtPret.Text);
                masinaForma1.pret = prett;
            }
            masinaForma1.Culoare = GetCuloareMasina();
            masinaForma1.OptiuniMasina = GetOptiuni();
            masinaForma1.nume_vanzator = txtNume1.Text;
            masinaForma1.prenume_vanzator = txtPrenume.Text;
            masinaForma1.firma = txtMarca.Text;
            masinaForma1.model = txtModel.Text;

            masinaForma1.an = Int32.Parse(txtAn.Text);
            masinaForma1.pret = Int32.Parse(txtPret.Text);
            adminMasini.UpdateMasina(masinaForma1);
            masinaForma1.DataActualizare = DateTime.Now;
            DialogResult = DialogResult.OK;
        }
        private Optiuni GetOptiuni()    //modificat
        {
            int i = 0;
            if (ckbAerConditionat.Checked)
                i++;                    //i=i | optiuni.aerconditionat ideie
            if (ckbScaunePiele.Checked)
                i += 2;
            if (ckbABS.Checked)
                i += 4;
            if (ckbLuminiCeata.Checked)
                i += 8;
            return (Optiuni)i;
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
