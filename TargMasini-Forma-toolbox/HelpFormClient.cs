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
    public partial class HelpFormClient : Form
    {
        public HelpFormClient()
        {
            InitializeComponent();
            label1.Text = "Acest meniu are ca scop prezentarea clientilor din incinta brokerului a masinilor disponibile.";
        }
    }
}
