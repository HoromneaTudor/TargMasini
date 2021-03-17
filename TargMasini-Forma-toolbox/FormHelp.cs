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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            label1.Text = "Acest meniu si submeniurile sale au ca scop explicarea functionalitatilor meniurilor principale din stanga (Administrator,Client,Info Autor).\n\n" +
                "Pentru mai multe detalii este incurajata consultarea documentatiei.\n\n" +
                "Programul are ca scop gestionarea autovehiculelor unui broker auto de asemenea afisarea pe calculatoarelor brokerului rezervate clientilor al \n" +
                "autovehiculelor si persoanelor ce le detin";
        }
    }
}
