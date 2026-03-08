using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    internal class AktorAdminGUIController
    {
        private static AktorAdminGUIController instance;

        public AktorAdminGUIController()
        {
        }

        public static AktorAdminGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AktorAdminGUIController();
                }
                return instance;
            }
        }

        private Bibliotekar ulogovan;
        private UCDefaultMain ucMain;
        public bool searchedFromMain { get; set; }
        public string searchText { get; set; }
        internal Control ShowPanel(Mode mode, Bibliotekar b = null)
        {

            Control control;
            switch (mode)
            {
                case Mode.Main:                    
                    ulogovan = b;
                    ucMain = new UCDefaultMain();
                    control = ucMain;
                    ucMain.CmbSearch.Items.AddRange(new object[] { "Clan", "Knjiga" });
                    ucMain.CmbSearch.SelectedIndex = 0;
                    LoadClanInfo();
                    searchedFromMain = false;
                    searchText = null;
                    ucMain.BtnSearch.Click += (s, e) => Pretrazi();
                    ucMain.BtnAddClana.Click += (s, e) =>MainGuiController.Instance.ShowUCKreirajClana();
                    ucMain.BtnAddKnjiga.Click += (s, e) =>MainGuiController.Instance.ShowUCDodajKnjigu();
                    ucMain.BtnZaduzi.Click += (s, e) =>MainGuiController.Instance.ShowUCZaduziKnjigu();
                    ucMain.BtnRazduzi.Click += (s, e) =>MainGuiController.Instance.ShowUCRazduziKnjigu();
                    break;
                default:
                    control = null;
                    break;
            }
            return control;
        }

        private void Pretrazi()
        {
            ucMain.TxtSearch.BackColor = Color.White;
            ucMain.TxtSearch.Focus();
            if (!string.IsNullOrEmpty(ucMain.TxtSearch.Text) && ucMain.CmbSearch.SelectedItem!=null)
            {
                searchedFromMain = true;
                searchText = ucMain.TxtSearch.Text;
                if (ucMain.CmbSearch.SelectedIndex==0)
                {
                    MainGuiController.Instance.ShowUCPretraziClana();
                }
                if(ucMain.CmbSearch.SelectedIndex == 1)
                {
                    MainGuiController.Instance.ShowUCPretraziKnjigu();
                }
            }
            else
            {
                MessageBox.Show("Tekst za pretrazivanje ne sme biti prazan.\nIzaberite iz padajuceg menija sta trazite.");
                ucMain.TxtSearch.BackColor = Color.Coral;
            }
        }

        private void LoadClanInfo()
        {
            ucMain.LblUser.Text = ulogovan.Username + "\nIme:   " + ulogovan.Ime + "\nPrezime:   " + ulogovan.Prezime;
        }
    }
}
