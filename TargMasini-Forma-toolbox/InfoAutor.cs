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
    public partial class InfoAutor : Form
    {
        public InfoAutor()
        {
            InitializeComponent();
        }
        public Form ReftoMenu { get; set; }

        private void InfoAutor_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Realizat de Horomnea Tudor\n     Grupa 3122A";
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ReftoMenu.Show();
        }
    }
}
