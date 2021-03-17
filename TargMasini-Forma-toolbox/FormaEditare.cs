//Horomnea Tudor Grupa 3122A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
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
        List<string> optiuniSelectate = new List<string>();
        public FormaEditare()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public Form ReftoForm1 { get; set; }
        public FormaEditare(masina mas):this()
        {
            masinaForma1 = mas;
        }
        private void FormaEditare_Load(object sender,EventArgs e)
        {
            //lblAfisare.Text = masinaForma1.nume_vanzator;
            //lblAfisare.Text = masinaForma1.model;
            txtNume1.Text = masinaForma1.nume_vanzator;
            txtPrenume.Text = masinaForma1.prenume_vanzator;
            txtMarca.Text = masinaForma1.firma;
            txtModel.Text = masinaForma1.model;
            txtAn.Text = masinaForma1.an.ToString();
            txtPret.Text = masinaForma1.pret.ToString();
            cmbTip.Text = masinaForma1.tip;
            foreach (var prgstd in gpbCuloar.Controls)
            {
                if (prgstd is RadioButton)
                {
                    var prgstdBox = prgstd as RadioButton;
                    if (prgstdBox.Text == masinaForma1.Culoare.ToString())
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
                    foreach (string dis in masinaForma1.Optiuni)
                        if (optiuneBox.Text.Equals(dis))
                            optiuneBox.Checked = true;
                }
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            
            lblMarca.ForeColor = Color.Black;
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblAn.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblModel.ForeColor = Color.Black;
            lblTip.ForeColor = Color.Black;
            CodEroare validarea = Validare(txtNume1.Text, txtPrenume.Text, txtMarca.Text, txtMarca.Text, txtAn.Text, txtPret.Text);
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
                masinaForma1.Culoare = GetCuloareMasina();
                masinaForma1.Optiuni = new List<string>();
                masinaForma1.Optiuni.AddRange(optiuniSelectate);
                masinaForma1.nume_vanzator = txtNume1.Text;
                masinaForma1.prenume_vanzator = txtPrenume.Text;
                masinaForma1.firma = txtMarca.Text;
                masinaForma1.model = txtModel.Text;

                masinaForma1.an = Int32.Parse(txtAn.Text);
                masinaForma1.pret = Int32.Parse(txtPret.Text);
                if (cmbTip.Text != "")
                {
                    masinaForma1.tip = cmbTip.Text;
                }
                adminMasini.UpdateMasina(masinaForma1);
                masinaForma1.DataActualizare = DateTime.Now;
                DialogResult = DialogResult.OK;
            }
        }
        private CodEroare Validare(string nume, string prenume, string marca, string model, string an, string pret)
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
        private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string disciplinaSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(disciplinaSelectata);
            else
                optiuniSelectate.Remove(disciplinaSelectata);
        }

        private void FormaEditare_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.ReftoForm1.Show();
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormaEditare_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(0, 112, 204);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }
    }
}
