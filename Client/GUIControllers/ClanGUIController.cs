using Client.UserControls;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.GUIControllers
{
    internal class ClanGUIController
    {
        private static ClanGUIController instance;
        private ClanGUIController()
        {
        }
        public static ClanGUIController Instance
        { 
            get 
            { 
                if (instance == null) 
                {
                    instance = new ClanGUIController();
                } 
                return instance;
            } 
        }

        private UCPrikazClana ucShow;
        private UCPretraziClana ucSearch;
        private bool isClicked;
        private Clan selected;

        internal Control ShowPanel(Mode mode)
        {
            Control control;
            switch (mode)
            {
                case Mode.Create:
                    ucShow = new UCPrikazClana();
                    control = ucShow;
                    ResetUC(mode);
                    ucShow.BtnZapamti.Click += (s, e) => KreirajNovogClana(); 
                    ucShow.BtnVrati.Click += (s, e) => ResetUC(mode); 
                    break;
                case Mode.Search:
                    ucSearch = new UCPretraziClana();
                    control = ucSearch;
                    ucSearch.DgvClanovi.DataSource=PrepareDataGridView();
                    FormatDGV();
                    ucSearch.BtnSearch.Click += (s, e) =>PretraziClanove();
                    ucSearch.BtnLoadClan.Click += (s, e) => UcitajClana((Clan)ucSearch.DgvClanovi.SelectedRows[0].DataBoundItem);                                 
                    break;
                case Mode.Edit:
                    ucShow = new UCPrikazClana();
                    control= ucShow;
                    ucShow.BtnVrati.Click += (s, e) => MainGuiController.Instance.ShowUCPretraziClana();
                    ucShow.BtnZapamti.Click += (s, e) => IzmeniClana();
                    ucShow.BtnDelete.Click += (s, e) => ObrisiClana();
                    break;
                case Mode.Zaduzi:
                    ucSearch = new UCPretraziClana();
                    control = ucSearch;
                    ModifyPanel(Mode.Search);
                    ucSearch.DgvClanovi.DataSource = PrepareDataGridView();
                    ucSearch.DgvClanovi.Columns[7].Visible = false;
                    ucSearch.DgvClanovi.Columns[8].Visible = false;
                    ucSearch.DgvClanovi.Columns[9].Visible = false;
                    ucSearch.DgvClanovi.Columns[10].Visible = false;
                    ucSearch.BtnSearch.Click += (s, e) => PretraziClanove();
                    ucSearch.TxtSearch.Text = string.Empty;
                    ucSearch.BtnLoadClan.Click += (s, e) => UcitajClanaNaPanelu((Clan)ucSearch.DgvClanovi.SelectedRows[0].DataBoundItem);
                    break;
                case Mode.ZaduziPrikaz:
                    ucShow = new UCPrikazClana();
                    control = ucShow;
                    ModifyPanel(Mode.Edit);
                    ucShow.BtnVrati.Click += (s, e) => ZaduzenjeGUIController.Instance.ShowClanoviPanel();
                    ucShow.BtnZapamti.Click += (s, e) => IzaberiClana();
                    break;
                default: 
                    control = null;
                    break;
            }

            return control;    
        }

        private void IzaberiClana()
        {
            ucShow.BtnZapamti.Enabled = false;            
            ZaduzenjeGUIController.Instance.RefreshTxt(selected);
        }

        private void UcitajClanaNaPanelu(Clan selected)
        {
            if (selected != null)
            {
                ZaduzenjeGUIController.Instance.ShowClanPrikazPanel();
                this.selected = selected;
                ResetUC(Mode.ZaduziPrikaz, selected);
  
            }
            else
            {
                MessageBox.Show("Izaberite člana iz tabele");
                ucSearch.LblMessage.Text = "Sistem ne može da učita člana";
            }
        }

        internal void ModifyPanel(Mode mode)
        {
            if(mode == Mode.Edit) 
            {
                ucShow.Size = new System.Drawing.Size(387, 278);
                
                ucShow.LblTitle.Location = new System.Drawing.Point(137, 7);
                ucShow.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucShow.LblTitle.Size = new System.Drawing.Size(104, 17);

                ucShow.LblMessage.Location = new System.Drawing.Point(130, 364); 
                ucShow.LblMessage.Size = new System.Drawing.Size(306, 13);

                ucShow.LblBrClanskeKarte.Location = new System.Drawing.Point(13, 34);
                ucShow.LblIme.Location = new System.Drawing.Point(13, 73);
                ucShow.LblPrezime.Location = new System.Drawing.Point(13, 112);
                ucShow.LblJMBG.Location = new System.Drawing.Point(13, 153);
                ucShow.LblAdresa.Location = new System.Drawing.Point(13, 195);
                ucShow.LblTelefon.Location = new System.Drawing.Point(13, 234);
                ucShow.LblEmail.Location = new System.Drawing.Point(13, 274);
                ucShow.LblSifra.Location = new System.Drawing.Point(13, 274);
                ucShow.LblMsgIme.Location = new System.Drawing.Point(128, 92);
                ucShow.LblMsgPrezime.Location = new System.Drawing.Point(128, 132);
                ucShow.LblMsgJMBG.Location = new System.Drawing.Point(128, 171);
                ucShow.LblMsgAdresa.Location = new System.Drawing.Point(128, 212);
                ucShow.LblMsgTelefon.Location = new System.Drawing.Point(128, 251);

                ucShow.TxtBrClanskeKarte.Location = new System.Drawing.Point(120, 31);
                ucShow.TxtIme.Location = new System.Drawing.Point(120, 70);
                ucShow.TxtPrezime.Location = new System.Drawing.Point(120, 109);
                ucShow.TxtJMBG.Location = new System.Drawing.Point(120, 150);
                ucShow.TxtAdresa.Location = new System.Drawing.Point(120, 192);
                ucShow.TxtTelefon.Location = new System.Drawing.Point(120, 231);
                ucShow.TxtEmail.Location = new System.Drawing.Point(120, 271);
                ucShow.TxtSifra.Location = new System.Drawing.Point(120, 311);

                ucShow.BtnDelete.Location = new System.Drawing.Point(503, 311);
                ucShow.BtnDelete.Visible=false;
                ucShow.BtnDelete.Enabled=false;

                ucShow.BtnVrati.Location = new System.Drawing.Point(215, 305);
                ucShow.BtnVrati.Size = new System.Drawing.Size(85, 37);
                ucShow.BtnZapamti.Location = new System.Drawing.Point(86, 305);
                ucShow.BtnZapamti.Size = new System.Drawing.Size(85, 37);
            }

            if (mode == Mode.Search)
            {
                ucSearch.Size = new System.Drawing.Size(387, 278);

                ucSearch.LblMessage.Location = new System.Drawing.Point(125, 251);
                ucSearch.LblMessage.Text = "Pretražite članove po broju članske karte," +
                    "\nimenu ili prezimenu.";

                ucSearch.DgvClanovi.Size = new System.Drawing.Size(355, 176);
                ucSearch.DgvClanovi.Location = new System.Drawing.Point(17, 65);

                ucSearch.LblTitle.Location = new System.Drawing.Point(137, 7);
                ucSearch.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucSearch.LblTitle.Size = new System.Drawing.Size(104, 17);

                ucSearch.LblSearch.Location = new System.Drawing.Point(35, 29);
                ucSearch.LblSearch.Text = "Broj karte:";

                ucSearch.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucSearch.TxtSearch.Location = new System.Drawing.Point(99, 27);
                ucSearch.TxtSearch.Size = new System.Drawing.Size(179, 18);

                ucSearch.BtnSearch.Location = new System.Drawing.Point(297, 27);
                ucSearch.BtnSearch.Size = new System.Drawing.Size(64, 25);

                ucSearch.BtnLoadClan.Location = new System.Drawing.Point(28, 246);
                ucSearch.BtnLoadClan.Size = new System.Drawing.Size(91, 22);

                ucSearch.LblSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucSearch.LblSearchText.Location = new System.Drawing.Point(82, 48);
                ucSearch.LblSearchText.Size = new System.Drawing.Size(116, 12);

            }
        }

        private void ObrisiClana()
        {
            Clan clan = new Clan()
            {
                Ime = ucShow.TxtIme.Text,
                Prezime = ucShow.TxtPrezime.Text,
                JMBG = ucShow.TxtJMBG.Text,
                Adresa = ucShow.TxtAdresa.Text,
                Telefon = ucShow.TxtTelefon.Text,
                Email = ucShow.TxtEmail.Text,
                BrojClanskeKarte = Convert.ToInt32(ucShow.TxtBrClanskeKarte.Text),
                SifraNaloga = ucShow.TxtSifra.Text,
            };

            Response rezultat = Communication.Instance.ObrisiClana(clan);
            if (rezultat.IsSuccessful)
            {
                MessageBox.Show("Sistem je obrisao člana.");
                MainGuiController.Instance.ShowUCPretraziClana();
            }
            else
            {
                MessageBox.Show(rezultat.Message);
                MainGuiController.Instance.ShowUCPretraziClana();
            }
        }

        private void IzmeniClana()
        {
            if (isClicked)
            {
                if (IsValid())
                {
                    Clan clan = new Clan()
                    {
                        Ime = ucShow.TxtIme.Text,
                        Prezime = ucShow.TxtPrezime.Text,
                        JMBG = ucShow.TxtJMBG.Text,
                        Adresa = ucShow.TxtAdresa.Text,
                        Telefon = ucShow.TxtTelefon.Text,
                        Email = ucShow.TxtEmail.Text,
                        BrojClanskeKarte = Convert.ToInt32(ucShow.TxtBrClanskeKarte.Text),
                        SifraNaloga = ucShow.TxtSifra.Text,
                    };

                    bool izmenjeno = Communication.Instance.IzmeniClana(clan);

                    if (izmenjeno)
                    {
                        MessageBox.Show("Sistem je zapamtio člana.");
                        UcitajClana(clan);
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne može da zapamti člana.");
                        MainGuiController.Instance.ShowUCPretraziClana();
                    }
                }
                else
                {
                    MessageBox.Show("Podaci nisu ispravno uneti!");
                } 
            }
            else
            {
                OtkljucajFormu();
                ucShow.LblMessage.Text = "Kliknite dugme sačuvaj da primenite promene.\nKliknite dugme odustani da prekinete izmenu.";
                ucShow.BtnZapamti.Text = "Sačuvaj";
                isClicked = true;
            }
        }

        private void OtkljucajFormu()
        {
            ucShow.TxtIme.Enabled = !ucShow.TxtIme.Enabled;
            ucShow.TxtPrezime.Enabled = !ucShow.TxtPrezime.Enabled;
            ucShow.TxtJMBG.Enabled = !ucShow.TxtJMBG.Enabled;
            ucShow.TxtAdresa.Enabled = !ucShow.TxtAdresa.Enabled;
            ucShow.TxtTelefon.Enabled = !ucShow.TxtTelefon.Enabled;
            ucShow.TxtEmail.Enabled = !ucShow.TxtEmail.Enabled;
            ucShow.BtnDelete.Enabled = !ucShow.BtnDelete.Enabled;
        }

        #region pretraziClana
        private List<Clan> PrepareDataGridView()
        {
            List<Clan> clanovi = new List<Clan>();
            if (AktorAdminGUIController.Instance.searchedFromMain)
            {
                string text = AktorAdminGUIController.Instance.searchText;
                clanovi = Communication.Instance.PretraziClanove(text);
            }
            else
            {
                clanovi = Communication.Instance.VratiSveClanove();
            }
            return clanovi;
        }
        private void PretraziClanove()
        {
            List<Clan> clanovi = new List<Clan>();

            if (string.IsNullOrEmpty(ucSearch.TxtSearch.Text))
            {
                clanovi = Communication.Instance.VratiSveClanove();
                ucSearch.DgvClanovi.DataSource = clanovi;
                FormatDGV();
                ucSearch.LblMessage.Text = "Sistem je vratio sve članove.";
                ucSearch.BtnLoadClan.Enabled = true;
            }
            else
            {
                clanovi = Communication.Instance.PretraziClanove(ucSearch.TxtSearch.Text);
                if (clanovi == null || clanovi.Count == 0)
                {
                    ucSearch.LblMessage.Text = "Sistem ne može da nađe članove po zadatoj vrednosti.";
                    ucSearch.DgvClanovi.DataSource = clanovi;
                    ucSearch.BtnLoadClan.Enabled = false;
                }
                else
                {
                    ucSearch.DgvClanovi.DataSource = clanovi;
                    FormatDGV();
                    ucSearch.LblMessage.Text = "Sistem je pronašao članove po zadatoj vrednosti.";
                    ucSearch.BtnLoadClan.Enabled = true;
                }
            }

            ucSearch.TxtSearch.Text = "";
        }
        private void FormatDGV()
        {
            ucSearch.DgvClanovi.Columns[7].Visible = false;
            ucSearch.DgvClanovi.Columns[8].Visible = false;
            ucSearch.DgvClanovi.Columns[9].Visible = false;
            ucSearch.DgvClanovi.Columns[10].Visible = false;
        }
        private void UcitajClana(Clan selected)
        {
            if (selected != null)
            {
                MainGuiController.Instance.ShowUCEditujClana();
                ResetUC(Mode.Edit, selected);
            }
            else
            {
                MessageBox.Show("Sistem ne može da učita člana.");
                MainGuiController.Instance.ShowUCPretraziClana();
            }
        } 
        #endregion

        #region KreirajClana

        internal void KreirajNovogClana()
        {
            if (IsValid())
            {
                if (isClicked)
                {
                    Clan clan = new Clan() 
                    {
                        JMBG = ucShow.TxtJMBG.Text,
                        Adresa = ucShow.TxtAdresa.Text,
                        Ime = ucShow.TxtIme.Text,
                        Prezime = ucShow.TxtPrezime.Text,
                        Telefon = ucShow.TxtTelefon.Text,
                        Email = ucShow.TxtEmail.Text,
                        SifraNaloga = RandomSifra()
                    };
                    int result = Communication.Instance.KreirajNovogClana(clan);
                    if (result == 0)
                    {
                        MessageBox.Show("Sistem ne može da zapamti novog člana.");
                        MainGuiController.Instance.ShowUCKreirajClana();                     
                    }
                    else
                    {
                        ucShow.LblMessage.Text = "Sistem je zapamtio novog člana.";
                        ucShow.TxtSifra.Text = clan.SifraNaloga;
                        ucShow.TxtBrClanskeKarte.Text = result.ToString();
                        ucShow.BtnVrati.Enabled = false;
                        ucShow.BtnZapamti.Enabled = false;                        
                    }
                }
                else
                {
                    ucShow.BtnVrati.Enabled = true;
                    ucShow.BtnVrati.Visible = true;
                    LockForm();
                    ucShow.LblMessage.Text = "Ukoliko ste sigurni da ste ispravno uneli podatke kliknite dugme 'Zapamti.'" +
                        "\nU suprotnom kliknite dugme 'Odustani.'";
                    ucShow.LblMessage.Location = new System.Drawing.Point(260, 393);
                    isClicked = true;
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
            }
        }

        private bool IsValid()
        {

            bool valid = true;

            ucShow.TxtIme.BackColor = Color.White;
            ucShow.LblMsgIme.Text = "";
            ucShow.TxtPrezime.BackColor = Color.White;
            ucShow.LblMsgPrezime.Text = "";
            ucShow.TxtAdresa.BackColor = Color.White;
            ucShow.LblMsgAdresa.Text = "";
            ucShow.TxtJMBG.BackColor = Color.White;
            ucShow.LblMsgJMBG.Text = "";
            ucShow.TxtTelefon.BackColor = Color.White;
            ucShow.LblMsgTelefon.Text = "";
            ucShow.TxtEmail.BackColor = Color.White;
            ucShow.LblMsgEmail.Text = "";

            if (string.IsNullOrEmpty(ucShow.TxtIme.Text) || ucShow.TxtIme.Text.Length > 30)
            {
                valid = false;
                ucShow.TxtIme.BackColor = Color.Coral;
                ucShow.LblMsgIme.ForeColor = Color.Coral;
                ucShow.LblMsgIme.Text = "Ime ne sme ostati prazno.";
            }
            if (string.IsNullOrEmpty(ucShow.TxtPrezime.Text) || ucShow.TxtPrezime.Text.Length > 30)
            {
                valid = false;
                ucShow.TxtPrezime.BackColor = Color.Coral;
                ucShow.LblMsgPrezime.ForeColor = Color.Coral;
                ucShow.LblMsgPrezime.Text = "Prezime ne sme ostati prazno.";
            }
            if (string.IsNullOrEmpty(ucShow.TxtAdresa.Text) || ucShow.TxtAdresa.Text.Length > 80)
            {
                valid = false;
                ucShow.TxtAdresa.BackColor = Color.Coral;
                ucShow.LblMsgAdresa.ForeColor = Color.Coral;
                ucShow.LblMsgAdresa.Text = "Adresa ne sme ostati prazna.";
            }
            if (string.IsNullOrEmpty(ucShow.TxtJMBG.Text) || ucShow.TxtJMBG.Text.Length != 13 || !ucShow.TxtJMBG.Text.All(char.IsNumber))
            {
                valid = false;
                ucShow.TxtJMBG.BackColor = Color.Coral;
                ucShow.LblMsgJMBG.ForeColor = Color.Coral;
                ucShow.LblMsgJMBG.Text = "JMBG treba da ima tačno 13 cifara.";
            }
            if (string.IsNullOrEmpty(ucShow.TxtTelefon.Text) || ucShow.TxtTelefon.Text.Length < 6 || ucShow.TxtTelefon.Text.Length > 15 || !ucShow.TxtTelefon.Text.All(char.IsNumber))
            {
                valid = false;
                ucShow.TxtTelefon.BackColor = Color.Coral;
                ucShow.LblMsgTelefon.ForeColor = Color.Coral;
                ucShow.LblMsgTelefon.Text = "Telefon treba da ima između 6 i 15 cifara.";
            }
            if (string.IsNullOrEmpty(ucShow.TxtEmail.Text) || !IsValidEmail(ucShow.TxtEmail.Text))
            {
                valid = false;
                ucShow.TxtEmail.BackColor = Color.Coral;
                ucShow.LblMsgEmail.ForeColor = Color.Coral;
                ucShow.LblMsgEmail.Text = "Unesite validnu email adresu.";
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

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private string RandomSifra()
        {
            StringBuilder sifra = new StringBuilder();
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                sifra.Append((char)r.Next(97, 123));
            }
            for (int i = 0; i < 4; i++)
            {
                sifra.Append(r.Next(0, 9));
            }

            return sifra.ToString();
        }
        #endregion
        private void LockForm()
        {
            ucShow.TxtIme.Enabled = !ucShow.TxtIme.Enabled;
            ucShow.TxtPrezime.Enabled = !ucShow.TxtPrezime.Enabled;
            ucShow.TxtJMBG.Enabled = !ucShow.TxtJMBG.Enabled;
            ucShow.TxtAdresa.Enabled = !ucShow.TxtAdresa.Enabled;
            ucShow.TxtTelefon.Enabled = !ucShow.TxtTelefon.Enabled;
            ucShow.TxtEmail.Enabled = !ucShow.TxtEmail.Enabled;
        }

        private void ResetUC(Mode mode,Clan clan=null)
        {
            switch (mode)
            {
                case Mode.Create:
                    isClicked = false;
                    ucShow.TxtIme.Text = null;
                    ucShow.TxtPrezime.Text = null;
                    ucShow.TxtJMBG.Text = null;
                    ucShow.TxtAdresa.Text = null;
                    ucShow.TxtTelefon.Text = null;
                    ucShow.TxtEmail.Text = null;
                    ucShow.BtnVrati.Enabled = false;
                    ucShow.BtnVrati.Visible = false;
                    ucShow.TxtIme.Enabled = true;
                    ucShow.TxtPrezime.Enabled = true;
                    ucShow.TxtJMBG.Enabled = true;
                    ucShow.TxtAdresa.Enabled = true;
                    ucShow.TxtTelefon.Enabled = true;
                    ucShow.TxtBrClanskeKarte.Enabled = false;
                    ucShow.TxtSifra.Enabled = false;
                    ucShow.TxtEmail.Enabled = true;
                    ucShow.BtnDelete.Enabled = false;
                    ucShow.BtnDelete.Visible = false;
                    ucShow.LblMessage.Text = "Unesite podatke o novom članu.";
                    break;
                    case Mode.Edit:
                    isClicked = false;
                    ucShow.TxtBrClanskeKarte.Text = clan.BrojClanskeKarte.ToString();
                    ucShow.TxtBrClanskeKarte.Enabled = false;
                    ucShow.TxtIme.Text = clan.Ime;
                    ucShow.TxtIme.Enabled = false;
                    ucShow.TxtPrezime.Text = clan.Prezime;
                    ucShow.TxtPrezime.Enabled = false;
                    ucShow.TxtJMBG.Text = clan.JMBG;
                    ucShow.TxtJMBG.Enabled = false;
                    ucShow.TxtAdresa.Text = clan.Adresa;
                    ucShow.TxtAdresa.Enabled = false;
                    ucShow.TxtTelefon.Text = clan.Telefon;
                    ucShow.TxtTelefon.Enabled = false;
                    ucShow.TxtEmail.Text = clan.Email;
                    ucShow.TxtEmail.Enabled = false;
                    ucShow.TxtSifra.Enabled = false;
                    ucShow.TxtSifra.Text = clan.SifraNaloga;
                    ucShow.TxtSifra.Visible = false;
                    ucShow.LblSifra.Visible=false;
                    ucShow.LblMessage.Text = "Sistem je učitao člana";
                    ucShow.LblMessage.Location = new System.Drawing.Point(297, 351);
                    ucShow.BtnZapamti.Text = "Izmeni";
                    ucShow.LblTitle.Text = "Učitan član";
                    break;
                case Mode.ZaduziPrikaz:
                    isClicked = false;
                    ucShow.TxtBrClanskeKarte.Text = clan.BrojClanskeKarte.ToString();
                    ucShow.TxtBrClanskeKarte.Enabled = false;
                    ucShow.TxtIme.Text = clan.Ime;
                    ucShow.TxtIme.Enabled = false;
                    ucShow.TxtPrezime.Text = clan.Prezime;
                    ucShow.TxtPrezime.Enabled = false;
                    ucShow.TxtJMBG.Text = clan.JMBG;
                    ucShow.TxtJMBG.Enabled = false;
                    ucShow.TxtAdresa.Text = clan.Adresa;
                    ucShow.TxtAdresa.Enabled = false;
                    ucShow.TxtTelefon.Text = clan.Telefon;
                    ucShow.TxtTelefon.Enabled = false;
                    ucShow.TxtEmail.Text = clan.Email;
                    ucShow.TxtEmail.Enabled = false;
                    ucShow.TxtSifra.Enabled = false;
                    ucShow.TxtSifra.Text = clan.SifraNaloga;
                    ucShow.TxtSifra.Visible = false;
                    ucShow.LblSifra.Visible = false;
                    ucShow.LblMessage.Text = "Sistem je učitao člana";
                    ucShow.BtnZapamti.Text = "Odaberi";
                    ucShow.LblTitle.Text = "Učitan član";
                    break;
                default:
                    break;
            }
        }
    }
}
