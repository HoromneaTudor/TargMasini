//Horomnea Tudor 3122A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace TargMasini_Forma_toolbox
{
    public partial class MainMenu : Form
    {
        Timer t = new Timer();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //private string myValue="";
        //private string ok = "1";
        
        public MainMenu()
        {
            InitializeComponent();
            hideSubMenuHelp();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pannelMenu.Controls.Add(leftBorderBtn);
            //form (remove windows bar)
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ShowSubMenuHelp()
        {
            panelHelp.Visible = true;
        }
        private void hideSubMenuHelp()
        {
            panelHelp.Visible = false;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,116,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
        }

        private void ActiveButton(object senderBtn,Color color)
        {
            if(senderBtn!=null)
            {
                disableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0,112,204);
                panel1.BackColor = Color.FromArgb(0, 112, 204);
                //panel2.BackColor = Color.FromArgb(0, 112, 204);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = currentBtn.IconColor;
            }
        }
        private void disableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(45,45,48);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            VerificareParola verificareParola = new VerificareParola();
            OpenChildForm(verificareParola);
            verificareParola.DataSent += VerificareParola_DataSent;
            //label1.Text = myValue;
            
            //verificareParola.DataSent+=
            //var dr = verificareParola.ShowDialog();
            //if(dr==DialogResult.OK)
            //{
            //    OpenChildForm(new Form1());
            //}


        }

        private void VerificareParola_DataSent(string msg)
        {
            if(msg=="1")
            {
                Form1 form1 = new Form1();
                OpenChildForm(form1);
            }
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)  //btnClient
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new client());
            hideSubMenuHelp();
        }

        private void iconButton2_Click(object sender, EventArgs e)  //btnInfoAutor
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new InfoAutor());
            hideSubMenuHelp();
        }

        private void iconButton3_Click(object sender, EventArgs e)  //btnHelp
        {
            if(panelHelp.Visible==true)
            {
                btnHelp.BackColor = Color.FromArgb(45, 45, 48);
                btnHelpAdministrator.BackColor = Color.FromArgb(45, 45, 48);
                btnHelpClient.BackColor = Color.FromArgb(45, 45, 48);
                btnHelpInfoAutor.BackColor = Color.FromArgb(45, 45, 48);
                currentChildForm.Close();
                hideSubMenuHelp();
            }
            else
            {
                ShowSubMenuHelp();
                ActiveButton(sender, RGBColors.color4);
                OpenChildForm(new FormHelp());
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)  //btnExit
        {
            ActiveButton(sender, RGBColors.color5);
            this.Close();
            hideSubMenuHelp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //"btnHome"
        {
            currentChildForm.Close();
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            Reset();
        }
        private void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Home";
            hideSubMenuHelp();
        }
        //drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pannelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;//in milisec
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyy");
        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if(hh<10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if(mm<10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if(ss<10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            clock.Text = time;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(0, 112, 204);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void button1_Click(object sender, EventArgs e)  //butonul Administrator ?
        {
            OpenChildForm(new HelpFormAdministrator());
            btnHelpAdministrator.BackColor = Color.FromArgb(0, 112, 204);
            btnHelp.BackColor = Color.FromArgb(45, 45, 48);
            btnHelpInfoAutor.BackColor = Color.FromArgb(45,45,48);
            btnHelpClient.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnHelpClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HelpFormClient());
            btnHelpClient.BackColor = Color.FromArgb(0, 112, 204);
            btnHelp.BackColor = Color.FromArgb(45, 45, 48);
            btnHelpAdministrator.BackColor = Color.FromArgb(45,45,48);
            btnHelpInfoAutor.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnHelpInfoAutor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HelpFormInfoAutor());
            btnHelpInfoAutor.BackColor = Color.FromArgb(0, 112, 204);
            btnHelpAdministrator.BackColor = Color.FromArgb(45, 45, 48);
            btnHelpClient.BackColor = Color.FromArgb(45, 45, 48);
            btnHelp.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(45, 45, 48);
        }
    }
}
