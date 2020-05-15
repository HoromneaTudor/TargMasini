using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Masina;
using NivelAccesDate;

namespace Aplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Formular form1 = new Formular();
            form1.Show();
            Application.Run();
        }
    }
    public class Formular : Form
    {
        IStocareData adminMasini = StocareFactory.GetAdministratorStocare();
        private Label lbNume;
        private Label lbPrenume;
        private Label lbMarca;
        private Label lbModel;
        private Label lbAn;
        private Label lbPret;
        //private Label lbCuloare;
        //private Label lbOptiuni;
        private Label lbInfo;
        //private TextBox txtDate;
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtMarca;
        private TextBox txtModel;
        private TextBox txtAn;
        private TextBox txtPret;
        //private TextBox txtCuloare;
        //private TextBox txtOptiuni;
        private Button btnAdaugare;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIMEMAXIMA = 20;

        public Formular()
        {
            this.Size = new System.Drawing.Size(1000, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Administrare Masina";

            lbNume = new Label();
            lbNume.Width = LATIME_CONTROL;
            lbNume.Text = "Nume:";
            lbNume.BackColor = Color.LightBlue;
            this.Controls.Add(lbNume);

            lbPrenume = new Label();
            lbPrenume.Width = LATIME_CONTROL;
            lbPrenume.Text = "Prenume:";
            lbPrenume.Top = DIMENSIUNE_PAS_Y;
            lbPrenume.BackColor = Color.LightBlue;
            this.Controls.Add(lbPrenume);

            lbMarca = new Label();
            lbMarca.Width = LATIME_CONTROL;
            lbMarca.Text = "Marca autovehicului:";
            lbMarca.Top = DIMENSIUNE_PAS_Y * 2;
            lbMarca.BackColor = Color.LightBlue;
            this.Controls.Add(lbMarca);

            lbModel = new Label();
            lbModel.Width = LATIME_CONTROL;
            lbModel.Text = "Modelul:";
            lbModel.Top = DIMENSIUNE_PAS_Y * 3;
            lbModel.BackColor = Color.LightBlue;
            this.Controls.Add(lbModel);

            lbAn = new Label();
            lbAn.Width = LATIME_CONTROL;
            lbAn.Text = "An:";
            lbAn.Top = DIMENSIUNE_PAS_Y * 4;
            lbAn.BackColor = Color.LightBlue;
            this.Controls.Add(lbAn);

            lbPret = new Label();
            lbPret.Width = LATIME_CONTROL;
            lbPret.Text = "Pret:";
            lbPret.Top = DIMENSIUNE_PAS_Y * 5;
            lbPret.BackColor = Color.LightBlue;
            this.Controls.Add(lbPret);

            //lbCuloare = new Label();
            //lbCuloare.Width = LATIME_CONTROL;
            //lbCuloare.Text = "Culoare:";
            //lbCuloare.Top = DIMENSIUNE_PAS_Y * 6;
            //lbCuloare.BackColor = Color.LightBlue;
            //this.Controls.Add(lbPret);

            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume);

            txtPrenume = new TextBox();
            txtPrenume.Width = LATIME_CONTROL;
            txtPrenume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPrenume);

            txtMarca = new TextBox();
            txtMarca.Width = LATIME_CONTROL;
            txtMarca.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(txtMarca);

            txtModel = new TextBox();
            txtModel.Width = LATIME_CONTROL;
            txtModel.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 3);
            this.Controls.Add(txtModel);

            txtAn = new TextBox();
            txtAn.Width = LATIME_CONTROL;
            txtAn.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 4);
            this.Controls.Add(txtAn);

            txtPret = new TextBox();
            txtPret.Width = LATIME_CONTROL;
            txtPret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 5);
            this.Controls.Add(txtPret);


            btnAdaugare = new Button();
            btnAdaugare.Width = LATIME_CONTROL;
            btnAdaugare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 6 * DIMENSIUNE_PAS_Y);
            btnAdaugare.Text = "Adaugati Masina";
            this.Controls.Add(btnAdaugare);

            lbInfo = new Label();
            lbInfo.Width = LATIME_CONTROL * 3;
            lbInfo.Height = DIMENSIUNE_PAS_X;
            lbInfo.Text = string.Empty;
            lbInfo.Top = DIMENSIUNE_PAS_Y * 7;
            lbInfo.BackColor = Color.LightBlue;
            this.Controls.Add(lbInfo);
            btnAdaugare.Click += OnButtonAdaugareClicked;

            this.Controls.Add(btnAdaugare);

        }

        private void OnButtonAdaugareClicked(object sender, EventArgs e)
        {
            //obiectul *sender* este butonul btnCalculeaza
            //*e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button catre subscriber-ul curent care este forma FormularGeometrie 
            int vali = Validare();
            lbNume.ForeColor = Color.LimeGreen;
            lbPrenume.ForeColor = Color.LimeGreen;
            lbMarca.ForeColor = Color.LimeGreen;
            lbModel.ForeColor = Color.LimeGreen;
            lbAn.ForeColor = Color.LimeGreen;
            lbPret.ForeColor = Color.LimeGreen;
            if (vali == 0)
            {


                string buf = string.Format("{0} {1}", txtNume.Text, txtPrenume.Text);
                masina m = new masina(buf, " ", txtMarca.Text, txtModel.Text);
                int bufan = Convert.ToInt32(txtAn.Text);
                int bufpret = Convert.ToInt32(txtPret.Text);
                m.SetAnPret(bufan, bufpret);
                m.Culoare = 0;
                m.OptiuniMasina = 0;
                lbInfo.Text = m.ConversieLaSir();
                adminMasini.AddMasina(m);

            }
            else
            {
                switch (vali)
                {
                    case 1:
                        lbNume.ForeColor = Color.Red;
                        break;
                    case 2:
                        lbPrenume.ForeColor = Color.Red;
                        break;
                    case 3:
                        lbMarca.ForeColor = Color.Red;
                        break;
                    case 4:
                        lbModel.ForeColor = Color.Red;
                        break;
                    case 5:
                        lbAn.ForeColor = Color.Red;
                        break;
                    case 6:
                        lbPret.ForeColor = Color.Red;
                        break;

                }

            }
        }
        private int Validare()
        {
            int i,j;
            bool success1 = int.TryParse(txtAn.Text, out i);
            bool success2 = int.TryParse(txtPret.Text, out j);
            if (txtNume.Text == string.Empty || txtNume.Text.Length > LUNGIMEMAXIMA)
            {
                return 1;

            }
            else if (txtPrenume.Text == string.Empty || txtPrenume.Text.Length > LUNGIMEMAXIMA)
            {
                return 2;
            }
            else if (txtMarca.Text == string.Empty)
                return 3;
            else if (txtModel.Text == string.Empty)
                return 4;
            else if(!success1)
                return 5;
            else if (!success2)
                return 6;
            return 0;

        }
    }
}

