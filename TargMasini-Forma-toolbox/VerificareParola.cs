using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargMasini_Forma_toolbox
{
    public partial class VerificareParola : Form
    {
        public VerificareParola()
        {
            InitializeComponent();
        }
        public Form ReftoMenu { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            
            if (txtParola.Text == "parola")
            {
                this.Close();
                Form1 frm1 = new Form1();
                frm1.ReftoMenu = this.ReftoMenu;

                frm1.Show();
            }
            else
            {
                lblTextParola.ForeColor = Color.Red;
                lblTextParola.Text = "Parola introdusa este gresita";
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            
            this.ReftoMenu.Show();
            
        }
    }
}
