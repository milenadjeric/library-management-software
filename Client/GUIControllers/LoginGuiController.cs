using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    internal class LoginGuiController
    {
        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private FrmLogin frmLogin;
        private bool isClan;

        public void ShowForm()
        {
            try
            {
                Communication.Instance.Connect();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmLogin = new FrmLogin();
                isClan = true;
                frmLogin.BtnChangeRole.Click += (s,e) => ChangeRole();
                frmLogin.BtnLogin.Click += (s,e) => Login();
                frmLogin.FormClosed += (s, e) => Environment.Exit(0);

                Application.Run(frmLogin);
            }
            catch (Exception)
            {

                MessageBox.Show("Nije uspostavljena konekcija sa serverom.");

            }
        }

        private void ChangeRole()
        {
            if (isClan)
            {
                isClan = false;
                frmLogin.LblTitle.Text = "Prijava za bibliotekare";
                frmLogin.LblTitle.Location = new System.Drawing.Point(114, 13);
                frmLogin.LblUsername.Text = "Korisničko ime:";
                frmLogin.LblUsername.Location = new System.Drawing.Point(64, 82);
                frmLogin.LblText.Text = "Unesite korisničko ime i lozinku:";
                frmLogin.LblText.Location = new System.Drawing.Point(64, 57);
                frmLogin.BtnChangeRole.Text = "Član log- in";
            }
            else
            {
                isClan = true;               
                frmLogin.LblTitle.Text = "Prijava za članove";
                frmLogin.LblTitle.Location = new System.Drawing.Point(144, 13);
                frmLogin.LblUsername.Text = "Broj članske karte:";
                frmLogin.LblUsername.Location = new System.Drawing.Point(44, 82);
                frmLogin.LblText.Text = "Unesite broj članske karte i lozinku:";
                frmLogin.LblText.Location = new System.Drawing.Point(44, 57);
                frmLogin.BtnChangeRole.Text = "Admin log- in";
            }
        }

        internal void Login()
        {
            if (IsValid())
            {
                if (!isClan)
                {
                    Bibliotekar user = Communication.Instance.LoginAdmin(frmLogin.TxtUsername.Text, frmLogin.TxtPassword.Text);

                    if (user != null)
                    {
                        if (user.Username == null)
                        {
                            MessageBox.Show("Ovaj korisnik je već ulogovan.");
                            ResetLogin();
                            return;
                        }
                        ResetLogin();
                        frmLogin.Hide();
                        MainGuiController.Instance.ShowForm(frmLogin,user);
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji admin sa ovim kredencijalima!");
                        ResetLogin();
                    }
                }
                else
                {
                    Clan user = Communication.Instance.LoginClan(frmLogin.TxtUsername.Text, frmLogin.TxtPassword.Text);
                    
                    if (user != null && user.SifraNaloga== frmLogin.TxtPassword.Text)
                    {
                        if (user.BrojClanskeKarte == 0)
                        {
                            MessageBox.Show("Ovaj korisnik je već ulogovan.");
                            ResetLogin();
                            return;
                        }
                        ResetLogin();
                        frmLogin.Hide();
                        MainGuiController.Instance.ShowForm(frmLogin,user);
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji korisnik sa ovim kredencijalima!");
                        ResetLogin();
                    }
                }
            }
            else
            {
                    MessageBox.Show("Korisničko ime i/ili šifra nisu ispravni!");
                    ResetLogin();
            }            

        }

        private void ResetLogin()
        {
                        
            frmLogin.TxtUsername.Text = "";
            frmLogin.TxtPassword.Text = "";
            frmLogin.TxtUsername.Focus();
            frmLogin.BtnLogin.Enabled = true;
        }

        private bool IsValid()
        {
            frmLogin.TxtUsername.BackColor = Color.White;
            frmLogin.TxtPassword.BackColor = Color.White;
            frmLogin.LblMsgUsername.Text = "";
            frmLogin.LblMsgPassword.Text = "";
            bool valid = true;

            if(!isClan && (string.IsNullOrEmpty(frmLogin.TxtUsername.Text) || frmLogin.TxtUsername.Text.Length < 5))
            {
                valid = false;
                frmLogin.TxtUsername.BackColor = Color.Coral;
                frmLogin.LblMsgUsername.ForeColor = Color.Coral;
                frmLogin.LblMsgUsername.Text = "Korisničko ime treba da ima najmanje 5 karaktera.";
            }
            if(isClan && (string.IsNullOrEmpty(frmLogin.TxtUsername.Text) || !frmLogin.TxtUsername.Text.All(char.IsNumber)))
            {
                valid = false;
                frmLogin.TxtUsername.BackColor = Color.Coral;
                frmLogin.LblMsgUsername.ForeColor = Color.Coral;
                frmLogin.LblMsgUsername.Text = "Broj članske karte treba da ima samo cifre.";
            }
            if (string.IsNullOrEmpty(frmLogin.TxtPassword.Text) || frmLogin.TxtPassword.Text.Length < 5)
            {
                valid = false;
                frmLogin.TxtPassword.BackColor = Color.Coral;
                frmLogin.LblMsgPassword.ForeColor = Color.Coral;
                frmLogin.LblMsgPassword.Text = "Šifra treba da ima najmanje 5 karaktera.";
            }

            if (!valid)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
