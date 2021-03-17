//Horomnea Tudor 3122A
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
    public partial class client : Form
    {
        IStocareData adminMasini;
        public client()
        {
            InitializeComponent();
            adminMasini = StocareFactory.GetAdministratorStocare();
        }
        public Form ReftoMenu { get; set; }

        private void client_Load(object sender, EventArgs e)
        {
            List<masina> masini = adminMasini.GetMasini();
            DataGridMasini.DataSource = null;
            DataGridMasini.DataSource = masini.Select(m => new { m.IdMasina, m.firma, m.model, m.pret, m.an, m.nume_vanzator, m.prenume_vanzator, m.tip, m.DataActualizare, Optiuni = string.Join(",", m.Optiuni), m.Culoare, }).ToList();

            
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
           // this.ReftoMenu.Show();
        }

        

        private void btnCautare_Click(object sender, EventArgs e)
        {
            lblEroare.Text = "";
            bool succes;
            int ign;
            List<masina> cautate = new List<masina>();
            List<masina> masini = adminMasini.GetMasini();
            if (cmbCautare.Text=="nume")
            {
                //lblCautare.Text = cmbCautare.Text;
                foreach (masina m in masini)
                {
                    if (m.nume_vanzator == txtCautare.Text)
                    {
                        cautate.Add(m);
                    }
                }   }
            if (cmbCautare.Text == "prenume")
            {
               // lblCautare.Text = "Prenume";
                foreach (masina m in masini)
                {
                    if (m.prenume_vanzator == txtCautare.Text)
                    {
                        cautate.Add(m);
                    }
                }   }
            //string buff;
            
            if (cmbCautare.Text == "pret")
            {
                succes = Int32.TryParse(txtCautare.Text, out ign);
                if(succes)
                {
                    foreach (masina m in masini)
                    {
                        if (m.pret == Int32.Parse(txtCautare.Text))
                        {
                            cautate.Add(m);
                        }
                    }
                }
                else
                {
                    lblEroare.ForeColor = Color.Red;
                    lblEroare.Text = "Valoarea introdusa nu este valida!!!";
                }
                // lblCautare.Text = "Pret";
                   }
            if (cmbCautare.Text == "an")
            {
                succes = Int32.TryParse(txtCautare.Text, out ign);
                // lblCautare.Text = "An";
                if (succes)
                {
                    foreach (masina m in masini)
                    {
                        if (m.an == Int32.Parse(txtCautare.Text))
                        {
                            cautate.Add(m);
                        }
                    }
                }
                else
                {
                    lblEroare.ForeColor = Color.Red;
                    lblEroare.Text = "Valoarea introdusa nu este valida!!!";
                }
            }
            DataGridMasini.DataSource = cautate.Select(m => new { m.IdMasina, m.firma, m.model, m.pret, m.an, m.nume_vanzator, m.prenume_vanzator, m.tip, m.DataActualizare, Optiuni = string.Join(",", m.Optiuni), m.Culoare, }).ToList();
        }

        private void client_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.ReftoMenu.Show();
        }

        private void btnAfisareToate_Click(object sender, EventArgs e)
        {
            List<masina> masini = adminMasini.GetMasini();
            DataGridMasini.DataSource = null;
            DataGridMasini.DataSource = masini.Select(m => new { m.IdMasina, m.firma, m.model, m.pret, m.an, m.nume_vanzator, m.prenume_vanzator, m.tip, m.DataActualizare, Optiuni = string.Join(",", m.Optiuni), m.Culoare, }).ToList();

        }
    }
}
