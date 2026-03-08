using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    internal class AktorClanGUIController
    {
        private static AktorClanGUIController instance;

        public AktorClanGUIController()
        {
        }

        public static AktorClanGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AktorClanGUIController();
                }
                return instance;
            }
        }
        private Clan ulogovan;
        private UCMainClan ucMain;
        private UCPretraziKnjigu ucSearch;
        private UCPrikazKnjige ucShow;
        private string searchText;
        private List<PrimerakKnjige> primerci;
       

        internal Control ShowPanel(Mode mode, Clan c=null, FrmMain frmMain = null)
        {
            frmMain.MainMenu.Visible = false;
            frmMain.MainMenu.Enabled = false;

            Control control;
            switch (mode)
            {
                case Mode.Main:
                    ulogovan = c;
                    ucMain = new UCMainClan();
                    control = ucMain;
                    LoadClanInfo();
                    LoadDGVZaduzenja();
                    ucMain.BtnSearch.Click += (s, e) => PretraziKnjige();
                    break;
                case Mode.Search:
                    ucSearch = new UCPretraziKnjigu();
                    control = ucSearch;
                    PrepareKnjigeDGV(searchText);
                    ucSearch.BtnSearch.Click += (s, e) => PrepareKnjigeDGV(ucSearch.TxtSearch.Text);
                    ucSearch.BtnLoad.Click += (s, e) => UcitajKnjigu((Knjiga)ucSearch.DgvKnjiga.SelectedRows[0].DataBoundItem);
                    break;
                case Mode.Edit:
                    ucShow = new UCPrikazKnjige();
                    control = ucShow;
                    ucShow.BtnCancel.Click += (s, e) => MainGuiController.Instance.ShowUCPretraziKnjiguClan();
                    break;
                default:
                    control = null;
                    break;
            }
            return control;
        }

        private void UcitajKnjigu(Knjiga selected)
        {
            if (selected != null)
            {
                MainGuiController.Instance.ShowUCUcitajKnjiguClan();
                primerci = Communication.Instance.VratiSvePrimerkeKnjiga();
                ResetUC(selected);
            }
            else
            {
                MessageBox.Show("Izaberite knjigu iz tabele");
                ucSearch.LblMessage.Text = "Sistem ne može da učita knjigu";
            }
        }



        private void PrepareKnjigeDGV(string searchText)
        {
            List<Knjiga> knjige = new List<Knjiga>();
            if (string.IsNullOrEmpty(searchText))
            {
                 knjige = Communication.Instance.VratiSveKnjige();
            }
            else
            {
                knjige = Communication.Instance.PretraziKnjigePoNazivu(searchText);

            }
            if (knjige == null || knjige.Count == 0)
            {
                ucSearch.LblMessage.Text = "Sistem ne može da nađe knjige po zadatoj vrednosti";
                ucSearch.DgvKnjiga.DataSource = knjige;
            }
            else
            {
                ucSearch.DgvKnjiga.DataSource = knjige;
                ucSearch.DgvKnjiga.Columns[2].DataGridView.CellFormatting += (s, e) => FormatDGVKnjigeColumns(e);
                ucSearch.DgvKnjiga.Columns[5].DataGridView.CellFormatting += (s, e) => FormatDGVKnjigeColumns(e);
                ucSearch.DgvKnjiga.Columns[7].DataGridView.CellFormatting += (s, e) => FormatDGVKnjigeColumns(e);
                ucSearch.DgvKnjiga.Columns[9].Visible = false;
                ucSearch.DgvKnjiga.Columns[10].Visible = false;
                ucSearch.DgvKnjiga.Columns[11].Visible = false;
                ucSearch.LblMessage.Text = "Sistem je pronašao knjige po zadatoj vrednosti.";
            }
            ucSearch.TxtSearch.Text = "";
        }

        private void FormatDGVKnjigeColumns(DataGridViewCellFormattingEventArgs e)
        {
            if (ucSearch.DgvKnjiga.Columns[e.ColumnIndex].Name == "Autor")
            {
                var knjiga = ucSearch.DgvKnjiga.Rows[e.RowIndex].DataBoundItem as Knjiga;
                if (knjiga != null)
                {
                    e.Value = knjiga.Autor.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
            if (ucSearch.DgvKnjiga.Columns[e.ColumnIndex].Name == "Izdavac")
            {
                var knjiga = ucSearch.DgvKnjiga.Rows[e.RowIndex].DataBoundItem as Knjiga;
                if (knjiga != null)
                {
                    e.Value = knjiga.Izdavac.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
            if (ucSearch.DgvKnjiga.Columns[e.ColumnIndex].Name == "Zanr")
            {
                var knjiga = ucSearch.DgvKnjiga.Rows[e.RowIndex].DataBoundItem as Knjiga;
                if (knjiga != null)
                {
                    e.Value = knjiga.Zanr.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
        }
       
        private void ResetUC(Knjiga knjiga)
        {
            UcitajComboBox();
            ucShow.TxtBrStrana.Enabled = false;
            ucShow.TxtGodinaIzdavanja.Enabled = false;
            ucShow.TxtISBN.Enabled = false;
            ucShow.TxtNaziv.Enabled = false;
            ucShow.CmbAutor.Enabled = false;
            ucShow.CmbIzdavac.Enabled = false;
            ucShow.CmbPovez.Enabled = false;
            ucShow.CmbZanr.Enabled = false;
            ucShow.NudBrPrimeraka.Enabled = false;
            ucShow.BtnAddAutor.Enabled = false;
            ucShow.BtnAddAutor.Visible = false;
            ucShow.BtnAddIzdavac.Enabled = false;
            ucShow.BtnAddIzdavac.Visible = false;
            ucShow.BtnSave.Enabled = false;
            ucShow.BtnSave.Visible = false;
            ucShow.BtnCancel.Text = "Vrati se";
            ucShow.TxtBrStrana.Text = knjiga.BrojStrana.ToString();
            ucShow.TxtISBN.Text = knjiga.ISBN;
            ucShow.TxtNaziv.Text = knjiga.Naziv;
            ucShow.TxtGodinaIzdavanja.Text = knjiga.GodinaIzdavanja.ToString();
            ucShow.CmbAutor.Text = knjiga.Autor.DisplayValues;
            ucShow.CmbIzdavac.Text = knjiga.Izdavac.DisplayValues;
            ucShow.CmbZanr.Text = knjiga.Zanr.NazivZanra;
            ucShow.CmbPovez.Text = knjiga.Povez.ToString();
            ucShow.NudBrPrimeraka.Value = knjiga.BrojPrimeraka;
            ucShow.BtnDelete.Visible = false;
            ucShow.BtnDelete.Enabled = false;
            ucShow.TxtDostupne.Enabled = false;
            ucShow.TxtDostupne.Visible = true;
            ucShow.LblBrDostupnih.Visible = true;
            ucShow.TxtDostupne.Text = BrojDostupnih(knjiga).ToString();
            ucShow.LblMessage.Text = "Sistem je ucitao knjigu.";
        }

        private object BrojDostupnih(Knjiga knjiga)
        {
            int brojDostupnih = 0;

            foreach (PrimerakKnjige pk in primerci)
            {
                if (pk.Knjiga.ISBN == knjiga.ISBN && pk.Status == false)
                {
                    brojDostupnih++;
                }
            }

            return brojDostupnih;
        }

        private void UcitajComboBox()
        {
            ucShow.CmbPovez.DataSource = Enum.GetValues(typeof(Povez));
            ucShow.CmbPovez.SelectedIndex = 0;
            ucShow.CmbIzdavac.DataSource = Communication.Instance.UcitajSveIzdavace();
            ucShow.CmbIzdavac.DisplayMember = "DisplayValues";
            ucShow.CmbIzdavac.SelectedItem = null;
            ucShow.CmbZanr.DataSource = Communication.Instance.UcitajSveZnarove();
            ucShow.CmbZanr.DisplayMember = "DisplayValues";
            ucShow.CmbZanr.SelectedItem = null;
            ucShow.CmbAutor.DataSource = Communication.Instance.UcitajAutore();
            ucShow.CmbAutor.DisplayMember = "DisplayValues";
            ucShow.CmbAutor.SelectedItem = null;
        }


        #region Main
        private void PretraziKnjige()
        {
            ucMain.TxtSearch.BackColor = Color.White;
            ucMain.TxtSearch.Focus();
            if (!string.IsNullOrEmpty(ucMain.TxtSearch.Text))
            {
                searchText = ucMain.TxtSearch.Text;
                MainGuiController.Instance.ShowUCPretraziKnjiguClan();
            }
            else
            {
                MessageBox.Show("Tekst za pretrazivanje ne sme biti prazan.");
                ucMain.TxtSearch.BackColor = Color.Coral;
            }
        }

        private void LoadDGVZaduzenja()
        {
                ucMain.DgvZaduzenja.DataSource = null;
                List<Zaduzenje> zaduzenja = new List<Zaduzenje>();
                zaduzenja = Communication.Instance.PretraziZaduzenja(ulogovan.BrojClanskeKarte.ToString());
                List<Zaduzenje> dgvSource = new List<Zaduzenje>();

                foreach (Zaduzenje z in zaduzenja)
                {
                    if (z.Vraceno == false)
                    {
                        dgvSource.Add(z);
                    }
                }

                ucMain.DgvZaduzenja.DataSource = dgvSource;

                #region Formatiranje DGV

                ucMain.DgvZaduzenja.Columns[0].Visible = false;
                ucMain.DgvZaduzenja.Columns[3].Visible = false;
                ucMain.DgvZaduzenja.Columns[4].Visible = false;
                ucMain.DgvZaduzenja.Columns[6].Visible = false;
                ucMain.DgvZaduzenja.Columns[7].Visible = false;
                ucMain.DgvZaduzenja.Columns[8].Visible = false;

                ucMain.DgvZaduzenja.Columns[5].DataGridView.CellFormatting += (s, e) => FormatDGVRazduzenjeColumns(e);
                ucMain.DgvZaduzenja.Columns[5].DisplayIndex = 0;

                ucMain.DgvZaduzenja.Columns[1].HeaderText = "Datum zaduzenja";
                ucMain.DgvZaduzenja.Columns[2].HeaderText = "Vratiti do";
                #endregion 

        }

        private void FormatDGVRazduzenjeColumns(DataGridViewCellFormattingEventArgs e)
        {
            if (ucMain.DgvZaduzenja.Columns[e.ColumnIndex].Name == "Knjiga")
            {
                var z = ucMain.DgvZaduzenja.Rows[e.RowIndex].DataBoundItem as Zaduzenje;
                if (z != null)
                {
                    e.Value = z.Knjiga.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
        }

        private void LoadClanInfo()
        {
            ucMain.LblClan.Text = ulogovan.DisplayValues + "\nBroj clanske karte:   " + ulogovan.BrojClanskeKarte +
                "\nAdresa:   " + ulogovan.Adresa + "\nTelefon:   " + ulogovan.Telefon +"\nE-mail:   "+ulogovan.Email;
        } 
        #endregion
    }
}
