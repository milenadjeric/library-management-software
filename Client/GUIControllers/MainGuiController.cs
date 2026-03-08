using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    internal class MainGuiController
    {
        private static MainGuiController instance;

        private MainGuiController()
        {
            
        }
        public static MainGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainGuiController();
                }
                return instance;
            }
        }
        private FrmMain frmMain;
        private UCDefaultMain ucMain;
        private FrmLogin frmLogin;
        public void ShowForm(FrmLogin frmLogin, Bibliotekar bibliotekar)
        {
            string ulogovan = bibliotekar.Username + bibliotekar.Password;
            frmMain = new FrmMain(ulogovan, frmLogin);
            ShowDefault(bibliotekar); 
            frmMain.ShowDialog();
        }
        public void ShowForm(FrmLogin frmLogin, Clan clan)
        {
            string ulogovan = clan.BrojClanskeKarte + clan.SifraNaloga;
            frmMain = new FrmMain(ulogovan, frmLogin);
            ShowDefault(null, clan); 
            frmMain.ShowDialog();
        }

        private void ShowDefault(Bibliotekar b = null, Clan c = null)
        {
            ucMain = new UCDefaultMain();
            if (b != null)
            {
                frmMain.ChangePanel(AktorAdminGUIController.Instance.ShowPanel(Mode.Main,b));
            }
            if(c!=null)
            {
                frmMain.ChangePanel(AktorClanGUIController.Instance.ShowPanel(Mode.Main,c,frmMain));
            }
        }

        internal void ShowUCKreirajClana()
        {
            frmMain.ChangePanel(ClanGUIController.Instance.ShowPanel(Mode.Create));           
        }

        internal void ShowUCPretraziClana()
        {
            frmMain.ChangePanel(ClanGUIController.Instance.ShowPanel(Mode.Search));
        }

        internal void ShowUCEditujClana()
        {
            frmMain.ChangePanel(ClanGUIController.Instance.ShowPanel(Mode.Edit));
        }

        internal void ShowUCDodajKnjigu()
        {
            frmMain.ChangePanel(KnjigaGUIController.Instance.ShowPanel(Mode.Create));
        }

        internal void ShowUCPretraziKnjigu()
        {
            frmMain.ChangePanel(KnjigaGUIController.Instance.ShowPanel(Mode.Search));
        }

        internal void ShowUCUcitajKnjigu()
        {
            frmMain.ChangePanel(KnjigaGUIController.Instance.ShowPanel(Mode.Edit));
        }

        internal void ShowUCZaduziKnjigu()
        {
            frmMain.ChangePanel(ZaduzenjeGUIController.Instance.ShowPanel(Mode.Create));
        }

        internal void ShowUCRazduziKnjigu()
        {
            frmMain.ChangePanel(ZaduzenjeGUIController.Instance.ShowPanel(Mode.Edit));
        }

        internal void ShowUCPretraziKnjiguClan()
        {
            frmMain.ChangePanel(AktorClanGUIController.Instance.ShowPanel(Mode.Search,null,frmMain));
        }

        internal void ShowUCUcitajKnjiguClan()
        {
            frmMain.ChangePanel(AktorClanGUIController.Instance.ShowPanel(Mode.Edit, null, frmMain));
        }

        
    }
}
