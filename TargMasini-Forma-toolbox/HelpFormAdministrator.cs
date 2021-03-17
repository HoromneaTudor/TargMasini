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

namespace TargMasini_Forma_toolbox
{
    public partial class HelpFormAdministrator : Form
    {
        public HelpFormAdministrator()
        {
            InitializeComponent();
            label1.Text = "Acest meniun are ca scop dupa introducerea parolei de utilizator setata de broker:\n" +
                "-Vizualizarea tuturor masinilor\n" +
                "-Editarea acestora\n" +
                "-Filtrarea lor\n" +
                "-Adaugarea unui vehicul nou\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
