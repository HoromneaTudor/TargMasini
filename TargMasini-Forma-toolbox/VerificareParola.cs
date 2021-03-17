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
using System.IO;

namespace TargMasini_Forma_toolbox
{
    public delegate void DataSentHandler(string msg);
    public partial class VerificareParola : Form
    {
        string parola;
        //private bool correct = false;
        //public bool Correct
        //{
        //    get { return correct; }
        //    set { correct = value; }
        //}
        public event DataSentHandler DataSent;
        //public string MyVal { get; set; }
        public VerificareParola()
        {
            InitializeComponent();
            if (File.Exists(@"C:\Users\Tudor\source\repos\TargMasini\TargMasini-Forma-toolbox\bin\Debug\parola.txt"))
            {
                parola = File.ReadAllText(@"C:\Users\Tudor\source\repos\TargMasini\TargMasini-Forma-toolbox\bin\Debug\parola.txt");
            }
        }
        public Form ReftoMenu { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void btnVerificare_Click(object sender, EventArgs e)
        {
            
            if (txtParola.Text == parola)
            {
                //this.Close();
                //MyVal = "1";
                //correct = true;
                if(this.DataSent!=null)
                {
                    this.DataSent("1");
                }
                
                
                //this.Close();
                
            }
            else
            {
                lblTextParola.ForeColor = Color.Red;
                lblTextParola.Text = "Parola introdusa este gresita";
                //MyVal = "2";
                //this.DataSent("2");
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            //MyVal = "2";
            //this.DataSent(2);
            //this.ReftoMenu.Show();
            
        }

        private void VerificareParola_FormClosing(object sender, FormClosingEventArgs e)
        {
            // this.ReftoMenu.Show();
            //MyVal = "2";
            //this.DataSent(2);
        }

        private void btnSchimbareParola_Click(object sender, EventArgs e)
        {
            txtParola.Enabled = false;
            btnVerificare.Enabled = false;
            txtParolaActuala.Enabled = true;
            txtParolaNoua.Enabled = true;
            btnConfirmare.Enabled = true;
            btnSchimbareParola.Enabled = false;


        }

        private void VerificareParola_Load(object sender, EventArgs e)
        {
            txtParolaActuala.Enabled = false;
            txtParolaNoua.Enabled = false;
            btnConfirmare.Enabled = false;
           
                //txtParola.Text = parola;
            
        }
        private int Validare()
        {
            lblConfirmare.ForeColor = Color.Black;
            lblConfirmare.Text = "";
            if (txtParolaActuala.Text!=parola)
            {
                return 1;
            }
            if(txtParolaNoua.Text == string.Empty)
            { 
                return 2; 
            }
            return 0;
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            int validare = Validare();
            if(validare==0)
            {      if (File.Exists(@"C:\Users\Tudor\source\repos\TargMasini\TargMasini-Forma-toolbox\bin\Debug\parola.txt"))
                    {
                        File.WriteAllText(@"C:\Users\Tudor\source\repos\TargMasini\TargMasini-Forma-toolbox\bin\Debug\parola.txt", txtParolaNoua.Text);
                        parola = txtParolaNoua.Text;
                    }
                txtParola.Enabled = true;
                btnVerificare.Enabled = true;
                txtParolaActuala.Enabled = false;
                txtParolaNoua.Enabled = false;
                btnConfirmare.Enabled = false;
            }
            else
            {
                switch(validare)
                {
                    case 1 :
                        lblConfirmare.ForeColor = Color.Red;
                        lblConfirmare.Text = "Parola actuala introdusa este gresita!!!";
                        break;
                    case 2:
                        lblConfirmare.ForeColor = Color.Red;
                        lblConfirmare.Text = "Va rog introduceti o noua parola!!!";
                        break;

                }
                
            }
            
        }
    }
}
