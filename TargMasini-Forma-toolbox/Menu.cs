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
    public partial class Menu : Form
    {
        IStocareData adminMasini;
        //VerificareParola verpas = new VerificareParola();
        //Form1 frm1 = new Form1();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAdministrare_Click(object sender, EventArgs e)
        {
            VerificareParola verpas = new VerificareParola();
            verpas.ReftoMenu = this;
            //frm1.ReftoMenu = verpas.ReftoMenu;
            this.Hide();
            verpas.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
