using Client.GUIControllers;
using Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        private string ulogovan;
        private FrmLogin frmLogin;
        public FrmMain(string ulogovan, FrmLogin frmLogin)
        {
            InitializeComponent();
            this.ulogovan = ulogovan;
            this.frmLogin = frmLogin;

            kreiranjeClanaItem.Click += (s, e) => MainGuiController.Instance.ShowUCKreirajClana();
            pretragaClanaItem.Click += (s, e) => MainGuiController.Instance.ShowUCPretraziClana();
            dodajKnjiguItem.Click += (s, e) => MainGuiController.Instance.ShowUCDodajKnjigu();
            pretraziKnjiguItem.Click += (s, e) => MainGuiController.Instance.ShowUCPretraziKnjigu();
            zaduziKnjiguItem.Click += (s, e) => MainGuiController.Instance.ShowUCZaduziKnjigu();
            razduziKnjiguItem.Click += (s, e) => MainGuiController.Instance.ShowUCRazduziKnjigu();
            btnLogout.Click += (s, e) => btnLogout_Click();
            this.FormClosed += (s, e) => FrmMain_FormClosed();
        }

        internal void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void FrmMain_FormClosed()
        {
            Communication.Instance.Logout(ulogovan);
            frmLogin.Dispose();
        }
        private void btnLogout_Click()
        {
            Communication.Instance.Logout(ulogovan);
            //frmLogin.Show();
            this.Dispose();
        }
    }
}