using Client.UserControls;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    internal class ZaduzenjeGUIController
    {
        private static ZaduzenjeGUIController instance;
        private ZaduzenjeGUIController()
        {

        }
        public static ZaduzenjeGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZaduzenjeGUIController();
                }
                return instance;
            }
        }

        private UCZaduzivanje ucCreate;
        private UCRazduzivanje ucUpdate;
        private List<Zaduzenje> zaduzenja;
        private Clan clan;
        private List<Clan> clanovi;
        private List<PrimerakKnjige> primerci;
        List<PrimerakKnjige> razduzivanje;
        private List<Knjiga> knjige;
        private bool isClicked = false;

        internal Control ShowPanel(Mode mode)
        {
            Control control;
            switch (mode)
            {
                case Mode.Create:
                    ucCreate = new UCZaduzivanje();
                    control = ucCreate;
                    LoadPanels();
                    zaduzenja = new List<Zaduzenje>();
                    primerci = Communication.Instance.VratiSvePrimerkeKnjiga();
                    ucCreate.BtnSave.Click += (s, e) => DodajZaduzenje();
                    ucCreate.BtnRemove.Click += (s, e) => IzbaciKnjiguIzListe();
                    break;
                case Mode.Edit:
                    ucUpdate = new UCRazduzivanje();
                    control = ucUpdate;
                    LoadLists(mode);
                    PrepareDGV();
                    ucUpdate.BtnSearchClan.Click += (s, e) => PretraziClana();
                    ucUpdate.BtnOdaberi.Click += (s, e) => OdaberiClana();
                    ucUpdate.TxtClan.TextChanged += (s, e) => LoadComboBox();
                    ucUpdate.BtnAddKnjiga.Click += (s, e) => DodajURazduzivanje();
                    ucUpdate.BtnIzbaci.Click += (s, e) => IzbaciKnjiguRazduzivanje();
                    ucUpdate.CmbKnjiga.SelectedValueChanged += (s, e) => OmoguciDugme();
                    ucUpdate.BtnZaduzi.Click += (s, e) => RazduziKnjige();
                    break;                
                default:
                    control = null;
                    break;
            }

            return control;
        }

        private void LoadPanels()
        {
            ucCreate.ChangePanel(KnjigaGUIController.Instance.ShowPanel(Mode.Zaduzi), ucCreate.PnlKnjige);
            ucCreate.ChangePanel(ClanGUIController.Instance.ShowPanel(Mode.Zaduzi), ucCreate.PnlClan);
        }

        private void OmoguciDugme()
        {
            ucUpdate.BtnAddKnjiga.Enabled = true;
        }

        private void RazduziKnjige()
        {
            if (clan != null && razduzivanje != null && razduzivanje.Count > 0)
            {
                List<Zaduzenje> zaRazduzivanje = new List<Zaduzenje>();
                foreach (PrimerakKnjige pk in razduzivanje)
                {
                    foreach (Zaduzenje z in zaduzenja)
                    {
                        if (pk.PrimerakID == z.Knjiga.PrimerakID)
                        {
                            zaRazduzivanje.Add(z);
                            break;
                        }
                    }
                }
                foreach (Zaduzenje z in zaRazduzivanje)
                {
                    z.DatumDo = ucUpdate.DtpDateDo.Value;
                    z.Vraceno = true;
                }
                bool result = Communication.Instance.RazduziKnjige(zaRazduzivanje);
                if (!result)
                {
                    MessageBox.Show("Pamćenje razduživanja nije uspelo.");
                }
                MessageBox.Show("Knjige su vraćene.");
                MainGuiController.Instance.ShowUCRazduziKnjigu();
            }
            else
            {
                MessageBox.Show("Popuni sva polja.");
            }

        }

        private void IzbaciKnjiguRazduzivanje()
        {
            if (razduzivanje == null || ucUpdate.DgvRazduzivanje.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Nije odabrana knjiga.");
                return;
            }

            PrimerakKnjige selected = (PrimerakKnjige)ucUpdate.DgvRazduzivanje.SelectedRows[0].DataBoundItem;
            foreach (PrimerakKnjige k in razduzivanje)
            {
                if (k == selected)
                {
                    razduzivanje.Remove(k);
                    RefreshDGV(Mode.Edit);
                    return;
                }
            }
        }

        private void DodajURazduzivanje()
        {
            if (ucUpdate.CmbKnjiga.Enabled!=false && ucUpdate.CmbKnjiga.SelectedItem!=null)
            {
                if (razduzivanje == null)
                {
                    razduzivanje = new List<PrimerakKnjige>();
                }
                foreach (PrimerakKnjige item in primerci)
                {
                    if ((((Knjiga)ucUpdate.CmbKnjiga.SelectedItem).ISBN == item.Knjiga.ISBN) && !IsInList(item.PrimaryKey, razduzivanje.Cast<IEntity>().ToList()))
                    {
                        razduzivanje.Add(item);
                    }
                }
                RefreshDGV(Mode.Edit);
                ucUpdate.BtnAddKnjiga.Enabled = false;
            }
        }

        private void FormatDGVRazduzenjeColumns(DataGridViewCellFormattingEventArgs e)
        {
            if (ucUpdate.DgvRazduzivanje.Columns[e.ColumnIndex].Name == "Knjiga")
            {
                var pk = ucUpdate.DgvRazduzivanje.Rows[e.RowIndex].DataBoundItem as PrimerakKnjige;
                if (pk != null)
                {
                    e.Value = pk.Knjiga.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
        }

        private void OdaberiClana()
        {
            clan = (Clan)ucUpdate.DgvSearch.SelectedRows[0].DataBoundItem;
            ucUpdate.TxtClan.Text = clan.DisplayValues;
        }

        private void LoadComboBox()
        {
           if(ucUpdate.TxtClan != null)
            {
                zaduzenja.Clear();
                knjige.Clear();
                primerci.Clear();
                zaduzenja = NisuVracena(Communication.Instance.PretraziZaduzenja(clan.BrojClanskeKarte.ToString()));
                if (razduzivanje!=null)
                {
                    razduzivanje.Clear();
                    RefreshDGV(Mode.Edit); 
                }
                foreach (Zaduzenje item in zaduzenja)
                {
                    primerci.Add(item.Knjiga);
                    if (!IsInList(item.Knjiga.Knjiga.ISBN, knjige.Cast<IEntity>().ToList()))
                    {
                        knjige.Add(item.Knjiga.Knjiga);
                    }
                }
                ucUpdate.CmbKnjiga.DataSource = null;
                ucUpdate.CmbKnjiga.DataSource = knjige;
                ucUpdate.CmbKnjiga.Enabled = true;
                ucUpdate.BtnAddKnjiga.Enabled = true;
                ucUpdate.CmbKnjiga.DisplayMember = "DisplayValues";
            }
        }

        private void PretraziClana()
        {
            ucUpdate.DgvSearch.DataSource = null;
            ucUpdate.BtnOdaberi.Enabled = true;
            ucUpdate.LblMsgClan.Text = "";
            ucUpdate.TxtSearchClan.BackColor = Color.White;
            if (string.IsNullOrEmpty(ucUpdate.TxtSearchClan.Text) || !ucUpdate.TxtSearchClan.Text.All(char.IsDigit))
            {
                ucUpdate.LblMsgClan.Text = "Parametar pretrage je ceo broj članske karte";
                ucUpdate.LblMsgClan.BackColor = Color.Coral;
                ucUpdate.TxtSearchClan.BackColor = Color.Coral;
                ucUpdate.BtnOdaberi.Enabled = false;
                return;
            }

            LoadLists(Mode.Search);
            
            if (clanovi == null || clanovi.Count == 0)
            {
                ucUpdate.LblMessage.Text = "Sistem ne može da nađe zaduzene članove po zadatoj vrednosti";
                ucUpdate.DgvSearch.DataSource = null;
                ucUpdate.BtnOdaberi.Enabled = false;
            }
            else
            {                
                PrepareDGV();
                ucUpdate.LblMessage.Text = "Sistem je pronašao zaduzene članove po zadatoj vrednosti.";
            }
            ucUpdate.TxtSearchClan.Text = "";
        }

        private void PrepareDGV()
        {
            
            ucUpdate.DgvSearch.DataSource = clanovi;
            ucUpdate.DgvSearch.Columns[7].Visible = false;
            ucUpdate.DgvSearch.Columns[8].Visible = false;
            ucUpdate.DgvSearch.Columns[9].Visible = false;
            ucUpdate.DgvSearch.Columns[10].Visible = false;
        }

        private void LoadLists(Mode mode)
        {
            
            if (mode == Mode.Edit)
            {
                zaduzenja = new List<Zaduzenje>();
                zaduzenja = NisuVracena(Communication.Instance.VratiSvaZaduzenja());
                clanovi = new List<Clan>();
                primerci = new List<PrimerakKnjige>();
                knjige = new List<Knjiga>();
            }
            else
            {
                zaduzenja.Clear();
                clanovi.Clear();
                knjige.Clear();
                zaduzenja = NisuVracena(Communication.Instance.PretraziZaduzenja(ucUpdate.TxtSearchClan.Text)); 
            }            

            if(zaduzenja.Count > 0)
            {
                foreach (Zaduzenje z in zaduzenja)
                {
                    if (!IsInList(z.Clan.BrojClanskeKarte,clanovi.Cast<IEntity>().ToList())) 
                    {
                        clanovi.Add(z.Clan);
                    }
                    if(mode == Mode.Edit)
                    {
                        primerci.Add(z.Knjiga);
                    }
                    if (!IsInList(z.Knjiga.Knjiga.ISBN, knjige.Cast<IEntity>().ToList()))
                    {
                        knjige.Add(z.Knjiga.Knjiga);
                    }                
                }
            }
        }

        private List<Zaduzenje> NisuVracena(List<Zaduzenje> list)
        {
            List<Zaduzenje> zad = new List<Zaduzenje>();
            foreach (Zaduzenje item in list)
            {
                if (item.Vraceno == false)
                {
                    zad.Add(item);
                }
            }
            return zad;
        }

        private bool IsInList(object primaryKey, List<IEntity> list)
        {
            foreach (var item in list)
            {
                if (item.PrimaryKey==primaryKey.ToString())
                {
                    return true;
                }
            }

            return false;
        }



        #region Zaduzi
        private void IzbaciKnjiguIzListe()
        {
            if (knjige == null || ucCreate.DgvZaduzenje.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Nije odabrana knjiga.");
                return;
            }

            Knjiga selected = (Knjiga)ucCreate.DgvZaduzenje.SelectedRows[0].DataBoundItem;
            foreach (Knjiga k in knjige)
            {
                if (k == selected)
                {
                    knjige.Remove(k);
                    RefreshDGV(Mode.Create,knjige);
                    return;
                }
            }
        }

        private void DodajZaduzenje()
        {
            if (!isClicked)
            {
                if (isValid() && primerci != null && primerci.Count != 0)
                {
                    foreach (Knjiga k in knjige)
                    {
                        Zaduzenje novo = new Zaduzenje()
                        {
                            DatumOd = ucCreate.DtpDateOd.Value,
                            DatumDo = ucCreate.DtpDateOd.Value.AddDays(15),
                            Clan = clan,
                            Knjiga = PronadjiPrimerak(k),
                            Vraceno = false
                        };

                        if (novo.Knjiga != null)
                        {
                            zaduzenja.Add(novo);
                        }
                        else
                        {
                            ucCreate.LblMessage.Text = "Dodavanje knjige na listu zaduženja nije uspelo.";
                            return;
                        }
                    }
                    List<int> result = Communication.Instance.KreirajZaduzenja(zaduzenja);
                    if (result != null && result.Count > 0)
                    {
                        UpdateZaduzenja(result);
                        ucCreate.DgvZaduzenje.DataSource = zaduzenja;
                        ucCreate.DgvZaduzenje.Columns[4].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                        ucCreate.DgvZaduzenje.Columns[5].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                        LockUC();
                        ucCreate.LblMessage.Text = "Knjige su zadužene.";

                    }
                    else
                    {
                        MessageBox.Show("Pamćenje zaduženja nije uspelo.");
                        MainGuiController.Instance.ShowUCZaduziKnjigu();
                    }

                }
                else
                {
                    MessageBox.Show("Član i bar jedna knjiga moraju da budu izabrani.");
                }
            }
            else
            {

                LockUC();
                ResetDGV();
                LoadPanels();
                ucCreate.TxtClan.Text = null;
                ucCreate.DtpDateOd.Value = DateTime.Now;
            }

        }

        private void LockUC()
        {
            if (isClicked == true)
            {
                ucCreate.BtnRemove.Enabled = true;
                ucCreate.BtnSave.Text = "Sacuvaj";
                ucCreate.DtpDateOd.Enabled = true;
                ucCreate.PnlClan.Enabled = true;
                ucCreate.PnlKnjige.Enabled = true;
                isClicked = false;
            }
            else
            {
                ucCreate.BtnRemove.Enabled = false;
                ucCreate.BtnSave.Text = "Napravi nova zaduzenja";
                ucCreate.DtpDateOd.Enabled = false;
                ucCreate.PnlClan.Enabled = false;
                ucCreate.PnlKnjige.Enabled = false;
                isClicked = true;
            }
        }

        private void UpdateZaduzenja(List<int> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                zaduzenja[i].ZaduzenjeID = result[i];
                Debug.WriteLine(">>>" + zaduzenja[i].ZaduzenjeID);
            }
        }

        private void ResetDGV()
        {
            ucCreate.DgvZaduzenje.DataSource = null;
            knjige.Clear();
            zaduzenja.Clear();
        }

        private PrimerakKnjige PronadjiPrimerak(Knjiga k)
        {
            foreach (PrimerakKnjige pk in primerci)
            {
                if (k.ISBN == pk.Knjiga.ISBN && pk.Status == false)
                {
                    return pk;
                }
            }

            return null;

        }

        private bool isValid()
        {
            bool valid = true;

            ucCreate.TxtClan.BackColor = Color.White;

            if (knjige == null || knjige.Count == 0)
            {
                valid = false;
            }
            if (clan == null)
            {
                valid = false;
                ucCreate.TxtClan.BackColor = Color.LightCoral;
            }

            return valid;
        }

        internal void ShowClanPrikazPanel()
        {
            ucCreate.ChangePanel(ClanGUIController.Instance.ShowPanel(Mode.ZaduziPrikaz), ucCreate.PnlClan);

        }

        internal void ShowClanoviPanel()
        {
            ucCreate.ChangePanel(ClanGUIController.Instance.ShowPanel(Mode.Zaduzi), ucCreate.PnlClan);

        }

        internal void ShowKnjigePrikazPanel()
        {
            ucCreate.ChangePanel(KnjigaGUIController.Instance.ShowPanel(Mode.ZaduziPrikaz), ucCreate.PnlKnjige);
        }

        internal void ShowKnjigePanel()
        {
            ucCreate.ChangePanel(KnjigaGUIController.Instance.ShowPanel(Mode.Zaduzi), ucCreate.PnlKnjige);

        }

        internal void RefreshDGV(Mode mode, List<Knjiga> knjigeZaZad = null)
        {
            if (mode==Mode.Create)
            {
                ucCreate.DgvZaduzenje.DataSource = null;
                ucCreate.DgvZaduzenje.DataSource = knjigeZaZad;

                ucCreate.DgvZaduzenje.Columns[2].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucCreate.DgvZaduzenje.Columns[5].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucCreate.DgvZaduzenje.Columns[7].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);

                ucCreate.DgvZaduzenje.Columns[9].Visible = false;
                ucCreate.DgvZaduzenje.Columns[10].Visible = false;
                ucCreate.DgvZaduzenje.Columns[11].Visible = false;

                knjige = knjigeZaZad;
                ucCreate.LblMessage.Text = "Knjiga je dodata u listu za zaduživanje.";
            }
            else
            {
                ucUpdate.DgvRazduzivanje.DataSource = null;
                ucUpdate.DgvRazduzivanje.DataSource = razduzivanje;

                ucUpdate.DgvRazduzivanje.Columns[2].DataGridView.CellFormatting += (s, e) => FormatDGVRazduzenjeColumns(e);

                ucUpdate.DgvRazduzivanje.Columns[3].Visible = false;
                ucUpdate.DgvRazduzivanje.Columns[4].Visible = false;
                ucUpdate.DgvRazduzivanje.Columns[5].Visible = false;
                ucUpdate.LblMessage.Text = "Knjiga je dodata u listu za razduživanje.";
            }
        }

        private void FormatDGVColumns(DataGridViewCellFormattingEventArgs e)
        {
            if (ucCreate.DgvZaduzenje.Columns[e.ColumnIndex].Name == "Autor")
            {
                var knjiga = ucCreate.DgvZaduzenje.Rows[e.RowIndex].DataBoundItem as Knjiga;
                if (knjiga != null)
                {
                    e.Value = knjiga.Autor.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
            if (ucCreate.DgvZaduzenje.Columns[e.ColumnIndex].Name == "Izdavac")
            {
                var knjiga = ucCreate.DgvZaduzenje.Rows[e.RowIndex].DataBoundItem as Knjiga;
                if (knjiga != null)
                {
                    e.Value = knjiga.Izdavac.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
            if (ucCreate.DgvZaduzenje.Columns[e.ColumnIndex].Name == "Zanr")
            {
                var knjiga = ucCreate.DgvZaduzenje.Rows[e.RowIndex].DataBoundItem as Knjiga;
                if (knjiga != null)
                {
                    e.Value = knjiga.Zanr.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
            if (ucCreate.DgvZaduzenje.Columns[e.ColumnIndex].Name == "Clan")
            {
                var z = ucCreate.DgvZaduzenje.Rows[e.RowIndex].DataBoundItem as Zaduzenje;
                if (z != null)
                {
                    e.Value = z.Clan.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
            if (ucCreate.DgvZaduzenje.Columns[e.ColumnIndex].Name == "Knjiga")
            {
                var z = ucCreate.DgvZaduzenje.Rows[e.RowIndex].DataBoundItem as Zaduzenje;
                if (z != null)
                {
                    e.Value = z.Knjiga.DisplayValues;
                    e.FormattingApplied = true;
                }
            }
        }

        internal void RefreshTxt(Clan selected)
        {
            clan = selected;
            ucCreate.TxtClan.Text = selected.DisplayValues;
        } 
        #endregion
    }
}
