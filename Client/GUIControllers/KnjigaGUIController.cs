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
using static System.Net.Mime.MediaTypeNames;

namespace Client.GUIControllers
{
    internal class KnjigaGUIController
    {
        private static KnjigaGUIController instance;
        private KnjigaGUIController()
        {
                
        }
        public static KnjigaGUIController Instance 
        {
            get 
            { 
                if (instance == null)
                {
                    instance = new KnjigaGUIController(); 
                }
                return instance; 
            } 
        }

        private UCPrikazKnjige ucShow;
        private UCPretraziKnjigu ucSearch;
        private bool isClicked;
        private bool isSaved;
        private Knjiga selected;
        private List<Knjiga> zaduzivanje;
        private List<PrimerakKnjige> primerci;

        internal Control ShowPanel(Mode mode)
        {
            Control control;
            switch (mode)
            {
                case Mode.Create:
                    ucShow = new UCPrikazKnjige();
                    control = ucShow;
                    Knjiga nova = new Knjiga();
                    ResetUC(mode);
                    ucShow.BtnSave.Click += (s, e) => KreirajNovuKnjigu(nova);
                    ucShow.BtnCancel.Click += (s, e) => Odustani(mode);
                    ucShow.BtnAddAutor.Click += (s, e) => DodajAutora();
                    ucShow.BtnAddIzdavac.Click += (s, e) => DodajIzdavaca();
                    break;
                case Mode.Search:
                    ucSearch = new UCPretraziKnjigu();
                    control = ucSearch;
                    PrepareDataGridView(mode);
                    ucSearch.BtnSearch.Click += (s, e) => PretraziKnjige(ucSearch.TxtSearch.Text);
                    ucSearch.BtnLoad.Click += (s, e) => UcitajKnjigu((Knjiga)ucSearch.DgvKnjiga.SelectedRows[0].DataBoundItem);
                    break;
                case Mode.Edit:
                    ucShow = new UCPrikazKnjige();
                    control = ucShow;
                    ucShow.BtnDelete.Click += (s, e) => ObrisiKnjigu();
                    ucShow.BtnCancel.Click += (s, e) => MainGuiController.Instance.ShowUCPretraziKnjigu();
                    break;
                case Mode.Zaduzi:
                    ucSearch = new UCPretraziKnjigu();
                    control = ucSearch;
                    ModifyPanel(Mode.Search);
                    PrepareDataGridView(mode);
                    ucSearch.BtnSearch.Click += (s, e) => PretraziKnjige(ucSearch.TxtSearch.Text);                
                    ucSearch.BtnLoad.Click += (s, e) => UcitajKnjiguNaPanelu((Knjiga)ucSearch.DgvKnjiga.SelectedRows[0].DataBoundItem);
                    break;
                case Mode.ZaduziPrikaz:
                    ucShow = new UCPrikazKnjige();
                    control = ucShow;
                    ModifyPanel(Mode.Edit);
                    ucShow.BtnCancel.Click += (s, e) => ZaduzenjeGUIController.Instance.ShowKnjigePanel();
                    ucShow.BtnSave.Click += (s, e) => DodajUListu();
                    break;
                default:
                    control = null;
                    break;
            }

            return control;
        }

        private void DodajUListu()
        {
            ucShow.BtnSave.Enabled = false;
            if (zaduzivanje==null)
            {
                zaduzivanje = new List<Knjiga>();
            }
            foreach (Knjiga k in zaduzivanje)
            {
                if (selected.ISBN == k.ISBN)
                {
                    ucShow.LblMessage.Text = "Knjiga je vec dodata na listu.";
                    return;
                }
            }
            
            zaduzivanje.Add(selected);
            ZaduzenjeGUIController.Instance.RefreshDGV(Mode.Create,zaduzivanje);
            
        }

        private void UcitajKnjiguNaPanelu(Knjiga selected)
        {
            if (selected != null)
            {
             
                    ZaduzenjeGUIController.Instance.ShowKnjigePrikazPanel();
                    this.selected = selected;
                    ResetUC(Mode.ZaduziPrikaz, selected); 

            }
            else
            {
                MessageBox.Show("Izaberite člana iz tabele");
                ucSearch.LblMessage.Text = "Sistem ne može da učita člana";
            }
        }

        private int BrojDostupnih(Knjiga selected)
        {
            int brojDostupnih = 0;

            foreach (PrimerakKnjige pk in primerci)
            {
                if (pk.Knjiga.ISBN == selected.ISBN && pk.Status==false)
                {
                    brojDostupnih++;
                }
            }
            
            return brojDostupnih;
        }

        internal void ModifyPanel(Mode mode)
        {
            if (mode == Mode.Edit)
            {
                ucShow.Size = new System.Drawing.Size(387, 278);

                ucShow.LblTitle.Location = new System.Drawing.Point(137, 7);
                ucShow.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucShow.LblTitle.Size = new System.Drawing.Size(104, 17);

                ucShow.LblMessage.Location = new System.Drawing.Point(35, 475);
                ucShow.LblMessage.Size = new System.Drawing.Size(306, 13);

                ucShow.LblISBN.Location = new System.Drawing.Point(13, 34);
                ucShow.LblNaziv.Location = new System.Drawing.Point(13, 73);
                ucShow.LblAutor.Location = new System.Drawing.Point(13, 112);
                ucShow.LblIzdavac.Location = new System.Drawing.Point(13, 153);
                ucShow.LblGodinaIzdavanja.Location = new System.Drawing.Point(13, 195);
                ucShow.LblPovez.Location = new System.Drawing.Point(13, 234);
                ucShow.LblBrojPrimeraka.Location = new System.Drawing.Point(13, 274);
                ucShow.LblZanr.Location = new System.Drawing.Point(13, 314);
                ucShow.LblBrStrana.Location = new System.Drawing.Point(13, 354);
                ucShow.LblBrDostupnih.Location = new System.Drawing.Point(13, 394);
                ucShow.LblMsgISBN.Location = new System.Drawing.Point(128, 53);
                ucShow.LblMsgNaziv.Location = new System.Drawing.Point(128, 92);
                ucShow.LblMsgAutor.Location = new System.Drawing.Point(128, 132);
                ucShow.LblMsgIzdavac.Location = new System.Drawing.Point(128, 171);
                ucShow.LblMsgGodinaIzdavanja.Location = new System.Drawing.Point(128, 212);
                ucShow.LblMsgPovez.Location = new System.Drawing.Point(128, 251);
                ucShow.LblMsgBrPrimeraka.Location = new System.Drawing.Point(128, 73);
                ucShow.LblMsgZanr.Location = new System.Drawing.Point(128, 73);
                ucShow.LblMsgBrStrana.Location = new System.Drawing.Point(128, 73);

                ucShow.TxtISBN.Location = new System.Drawing.Point(120, 31);
                ucShow.TxtNaziv.Location = new System.Drawing.Point(120, 70);
                ucShow.CmbAutor.Location = new System.Drawing.Point(120, 109);
                ucShow.CmbIzdavac.Location = new System.Drawing.Point(120, 150);
                ucShow.TxtGodinaIzdavanja.Location = new System.Drawing.Point(120, 192);
                ucShow.CmbPovez.Location = new System.Drawing.Point(120, 231);
                ucShow.NudBrPrimeraka.Location = new System.Drawing.Point(120, 271);
                ucShow.CmbZanr.Location = new System.Drawing.Point(120, 314);
                ucShow.CmbZanr.Size = new System.Drawing.Size(228, 20);
                ucShow.TxtBrStrana.Location = new System.Drawing.Point(120, 354);
                ucShow.TxtBrStrana.Size = new System.Drawing.Size(228, 20);
                ucShow.TxtDostupne.Size = new System.Drawing.Size(228, 20);
                ucShow.TxtDostupne.Location = new System.Drawing.Point(120, 394);

                ucShow.BtnCancel.Location = new System.Drawing.Point(215, 425);
                ucShow.BtnCancel.Size = new System.Drawing.Size(85, 37);
                ucShow.BtnSave.Location = new System.Drawing.Point(86, 425);
                ucShow.BtnSave.Size = new System.Drawing.Size(85, 37);
            }
            if (mode==Mode.Search)
            {
                ucSearch.Size = new System.Drawing.Size(387, 278);

                ucSearch.LblMessage.Location = new System.Drawing.Point(136, 251);

                ucSearch.DgvKnjiga.Size = new System.Drawing.Size(355, 176);
                ucSearch.DgvKnjiga.Location = new System.Drawing.Point(17, 65);

                ucSearch.LblTitle.Location = new System.Drawing.Point(137, 7);
                ucSearch.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucSearch.LblTitle.Size = new System.Drawing.Size(104, 17);

                ucSearch.LblSearchParam.Location = new System.Drawing.Point(47, 29);

                ucSearch.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucSearch.TxtSearch.Location = new System.Drawing.Point(99, 27);
                ucSearch.TxtSearch.Size = new System.Drawing.Size(179, 18);

                ucSearch.BtnSearch.Location = new System.Drawing.Point(297, 27);
                ucSearch.BtnSearch.Size = new System.Drawing.Size(64, 25);

                ucSearch.BtnLoad.Location = new System.Drawing.Point(34, 246);
                ucSearch.BtnLoad.Size = new System.Drawing.Size(91, 22);

                ucSearch.LblMsgSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ucSearch.LblMsgSearch.Location = new System.Drawing.Point(99, 48);
                ucSearch.LblMsgSearch.Size = new System.Drawing.Size(116, 12); 
            }
        }

        private void ObrisiKnjigu()
        {
            Knjiga obrisi = new Knjiga();
            obrisi.ISBN = ucShow.TxtISBN.Text;
            obrisi.BrojPrimeraka = (int)ucShow.NudBrPrimeraka.Value;

            Response rezultat = Communication.Instance.ObrisiKnjigu(obrisi);
            if (rezultat.IsSuccessful)
            {
                MessageBox.Show("Sistem je obrisao knjigu.");
                MainGuiController.Instance.ShowUCPretraziKnjigu();
            }
            else
            {
                MessageBox.Show(rezultat.Message);
                MainGuiController.Instance.ShowUCPretraziKnjigu();
            }

        }

        private void UcitajKnjigu(Knjiga selected)
        {

            if (selected != null)
            {
                MainGuiController.Instance.ShowUCUcitajKnjigu();
                primerci = Communication.Instance.VratiSvePrimerkeKnjiga();
                ResetUC(Mode.Edit, selected);
            }
            else
            {
                MessageBox.Show("Sistem ne može da učita knjigu");
            MainGuiController.Instance.ShowUCPretraziKnjigu();
        }
    }

        private void PretraziKnjige(string text)
        {
            List<Knjiga> knjige = new List<Knjiga>();           

            if (string.IsNullOrEmpty(text))
            {
                knjige = Communication.Instance.VratiSveKnjige();
                ucSearch.DgvKnjiga.DataSource = knjige;
                FormatDGV(Mode.Search);
                ucSearch.LblMessage.Text = "Sistem je vratio sve knjige.";
                ucSearch.BtnLoad.Enabled = true;
            }
            else
            {
                knjige = Communication.Instance.PretraziKnjigePoNazivu(text);
                if (knjige == null || knjige.Count == 0)
                {
                    ucSearch.LblMessage.Text = "Sistem ne može da nađe knjige po zadatoj vrednosti";
                    ucSearch.DgvKnjiga.DataSource= knjige;
                    ucSearch.BtnLoad.Enabled = false;
                }
                else
                {
                    ucSearch.DgvKnjiga.DataSource = knjige;
                    FormatDGV(Mode.Search);
                    ucSearch.LblMessage.Text = "Sistem je pronašao knjige po zadatoj vrednosti.";
                    ucSearch.BtnLoad.Enabled = true;
                }
            }

            ucSearch.TxtSearch.Text = "";
        }

        private void PrepareDataGridView(Mode mode)
        {
            if (mode==Mode.Search)
            {
                List<Knjiga> knjige = new List<Knjiga>();
                if (AktorAdminGUIController.Instance.searchedFromMain)
                {
                    string text = AktorAdminGUIController.Instance.searchText;
                     knjige = Communication.Instance.PretraziKnjigePoNazivu(text);
                }
                else
                {
                    knjige = Communication.Instance.VratiSveKnjige();
                }
                ucSearch.DgvKnjiga.DataSource = knjige;                
                FormatDGV(mode); 
            }
            if (mode == Mode.Zaduzi)
            {
                List<Knjiga> sveKnjige = Communication.Instance.VratiSveKnjige();
                primerci = Communication.Instance.VratiSvePrimerkeKnjiga();
                ucSearch.DgvKnjiga.DataSource = sveKnjige;
                FormatDGV(mode);
                
            }    

        }

        private void FormatDGV(Mode mode)
        {
            if (mode==Mode.Search)
            {
                ucSearch.DgvKnjiga.Columns[2].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucSearch.DgvKnjiga.Columns[5].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucSearch.DgvKnjiga.Columns[7].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucSearch.DgvKnjiga.Columns[9].Visible = false;
                ucSearch.DgvKnjiga.Columns[10].Visible = false;
                ucSearch.DgvKnjiga.Columns[11].Visible = false; 
            }
            if (mode == Mode.Zaduzi)
            {
                //ucSearch.DgvKnjiga.AutoGenerateColumns = false;
                ucSearch.DgvKnjiga.Columns[2].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucSearch.DgvKnjiga.Columns[5].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucSearch.DgvKnjiga.Columns[7].DataGridView.CellFormatting += (s, e) => FormatDGVColumns(e);
                ucSearch.DgvKnjiga.Columns[9].Visible = false;
                ucSearch.DgvKnjiga.Columns[10].Visible = false;
                ucSearch.DgvKnjiga.Columns[11].Visible = false;

                //NE RADI, generalno mi se cini cim nece ni da bojini da dodaje vrednosti da mu fali refresh al nista ne radi ni on
                //Htela sam da dodam novu klonu koliko je knjiga dostupno
                #region Ne radi

                //DataGridViewTextBoxColumn novaKolona = new DataGridViewTextBoxColumn();
                //novaKolona.Name = "Status";
                //novaKolona.DataPropertyName = "Status";
                //novaKolona.HeaderText = "Dostupni primerci";
                //novaKolona.DisplayIndex = 2;
                //novaKolona.ValueType = typeof(int);
                //ucSearch.DgvKnjiga.Columns.Add(novaKolona);

                //foreach (DataGridViewRow row in ucSearch.DgvKnjiga.Rows)
                //{                    
                //    //row.Cells[columnName: "Status"].Value = BrojDostupnih((Knjiga)row.DataBoundItem);
                //    if (BrojDostupnih((Knjiga)row.DataBoundItem) == 0)
                //    {
                //        //row.Style.BackColor = Color.LightCoral;
                //        row.DefaultCellStyle.BackColor = Color.LightCoral;
                //    }
                //    else
                //    {
                //        //row.Cells[12].Style.BackColor = Color.LightBlue;
                //        row.DefaultCellStyle.BackColor = Color.LightCoral;
                //    }
                //}  
                #endregion
            }
        }
       

        private void FormatDGVColumns( DataGridViewCellFormattingEventArgs e)
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
        internal void DodajAutora()
        {
            FrmPopup popup = new FrmPopup();
            popup.ShowDialog();
        }

        internal void LoadAutori()
        {
            ucShow.CmbAutor.DataSource = null;
            ucShow.CmbAutor.DataSource = Communication.Instance.UcitajAutore();
            ucShow.CmbAutor.DisplayMember = "DisplayValues";
            ucShow.CmbAutor.SelectedItem = null;
        }

        internal void DodajNovogAutora(FrmPopup popup)
        {
            bool isValid = true;
            popup.TxtIme.BackColor = Color.White;
            popup.LblMsgIme.Text = "";
            popup.TxtPrezime.BackColor = Color.White;
            popup.LblMsgPrezime.Text = "";
            if (string.IsNullOrEmpty(popup.TxtIme.Text) || popup.TxtIme.Text.Length > 30)
            {
                popup.TxtIme.BackColor = Color.Coral;
                popup.LblMsgIme.Text = "Ime ne sme biti prazno.";
                popup.LblMsgIme.ForeColor = Color.Coral;
                isValid = false;
            }
            if(string.IsNullOrEmpty(popup.TxtPrezime.Text) || popup.TxtPrezime.Text.Length > 30)
            {
                popup.TxtPrezime.BackColor = Color.Coral;
                popup.LblMsgPrezime.Text = "Prezime ne sme biti prazno.";
                popup.LblMsgPrezime.ForeColor = Color.Coral;
                isValid = false;
            }
            if (isValid)
            {
                Autor novi = new Autor()
                {
                    ImeAutora = popup.TxtIme.Text,
                    PrezimeAutora = popup.TxtPrezime.Text
                };
                Communication.Instance.DodajAutora(novi);
                popup.Close();
            }
            else
            {
                return;
            }
            
        }

        private void DodajIzdavaca()
        {
            FrmPopup popup = new FrmPopup(new Izdavac());
            popup.TxtPrezime.Visible = false;
            popup.TxtPrezime.Enabled = false; 
            popup.LblPrezime.Visible = false;
            popup.LblPrezime.Enabled = false;
            popup.BtnDodaj.Location = new System.Drawing.Point(161, 90);
            popup.ClientSize = new System.Drawing.Size(407, 130);
            popup.Text = "Dodaj izdavaca";
            popup.LblIme.Text = "Naziv:";
            popup.ShowDialog();            
        }
        internal void DodajNovogIzdavaca(FrmPopup popup)
        {
            bool isValid = true;
            popup.TxtIme.BackColor = Color.White;
            popup.LblMsgIme.Text = "";
            if (string.IsNullOrEmpty(popup.TxtIme.Text) || popup.TxtIme.Text.Length > 50)
            {
                popup.TxtIme.BackColor = Color.Coral;
                popup.LblMsgIme.Text = "Naziv ne sme biti prazan.";
                popup.LblMsgIme.ForeColor = Color.Coral;
                isValid = false;
            }
            if (isValid)
            {
                Izdavac novi = new Izdavac()
                {
                    NazivIzdavaca = popup.TxtIme.Text,
                };
                Communication.Instance.DodajIzdavaca(novi);
                popup.Close();
            }
            else
            {
                return;
            }
        }
        internal void LoadIzdavaci()
        {
            ucShow.CmbIzdavac.DataSource = null;
            ucShow.CmbIzdavac.DataSource = Communication.Instance.UcitajSveIzdavace();
            ucShow.CmbIzdavac.DisplayMember = "DisplayValues";
            ucShow.CmbIzdavac.SelectedItem = null;
        }

        private void ZakljucajFormu()
        {
            ucShow.TxtISBN.Enabled = !ucShow.TxtISBN.Enabled;
            ucShow.TxtGodinaIzdavanja.Enabled = !ucShow.TxtGodinaIzdavanja.Enabled;
            ucShow.TxtNaziv.Enabled = !ucShow.TxtNaziv.Enabled;
            ucShow.CmbAutor.Enabled = !ucShow.CmbAutor.Enabled;
            ucShow.CmbIzdavac.Enabled = !ucShow.CmbIzdavac.Enabled;
            ucShow.CmbPovez.Enabled = !ucShow.CmbPovez.Enabled;
            ucShow.NudBrPrimeraka.Enabled = !ucShow.NudBrPrimeraka.Enabled;
            ucShow.CmbZanr.Enabled = !ucShow.CmbZanr.Enabled;
            ucShow.BtnAddAutor.Enabled = !ucShow.BtnAddAutor.Enabled;
            ucShow.BtnAddIzdavac.Enabled = !ucShow.BtnAddIzdavac.Enabled;
            ucShow.TxtBrStrana.Enabled = !ucShow.TxtBrStrana.Enabled;
        }
        #region DodajKnjigu

        private void KreirajNovuKnjigu(Knjiga nova)
        {
            if (IsValid())
            {
                if (isClicked)
                {
                    nova.ISBN = formatISBN(ucShow.TxtISBN.Text);
                    nova.Naziv = ucShow.TxtNaziv.Text;
                    nova.Autor = (Autor)ucShow.CmbAutor.SelectedItem;
                    nova.Izdavac = (Izdavac)ucShow.CmbIzdavac.SelectedItem;
                    nova.GodinaIzdavanja = int.Parse(ucShow.TxtGodinaIzdavanja.Text);
                    nova.Povez = (Povez)ucShow.CmbPovez.SelectedIndex;
                    nova.BrojPrimeraka = (int)ucShow.NudBrPrimeraka.Value;
                    nova.Zanr = (Zanr)ucShow.CmbZanr.SelectedItem;
                    nova.BrojStrana = int.Parse(ucShow.TxtBrStrana.Text);
                    string result = Communication.Instance.DodajNovuKnjigu(nova);
                    if (result == null)
                    {
                        MessageBox.Show("Sistem ne može da zapamti novu knjigu!");
                        ShowPanel(Mode.Create);
                    }
                    else
                    {
                        isSaved = true;
                        ResetUC(Mode.Edit, nova);
                        ucShow.LblMessage.Text = "Sistem je zapamtio novu knjigu";
                        ucShow.BtnSave.Enabled = false;
                        ucShow.BtnDelete.Enabled = false;
                        ucShow.BtnDelete.Visible = false;
                        ucShow.BtnCancel.Enabled = true;

                    }
                }
                else
                {
                    ZakljucajFormu();
                    ucShow.LblMessage.Text = "Ukoliko ste sigurni da ste ispravno uneli podatke kliknite dugme 'Sacuvaj'" +
                        "\nU suprotnom kliknite dugme 'Odustani'";
                    isClicked = true;
                    ucShow.BtnCancel.Enabled = true;
                    ucShow.BtnCancel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
            }
        }
        private void Odustani(Mode mode)
        {
            if (isClicked == true && isSaved==false)
            {
                ZakljucajFormu();
            }
            else
            {
                ResetUC(mode);
            }
        }

        private string formatISBN(string text)
        {
            int[] indexes = { 3, 6, 11, 15 };

            foreach (int i in indexes)
            {
                text = text.Insert(i, '-'.ToString());
            }

            return text.ToString();
        }

        private bool IsValid()
        {
            bool valid = true;

            ucShow.TxtISBN.BackColor = Color.White;
            ucShow.LblMsgISBN.Text = "";
            ucShow.TxtNaziv.BackColor = Color.White;
            ucShow.LblMsgNaziv.Text = "";
            ucShow.TxtGodinaIzdavanja.BackColor = Color.White;
            ucShow.LblMsgGodinaIzdavanja.Text = "";
            ucShow.CmbPovez.BackColor = Color.White;
            ucShow.LblMsgPovez.Text = "";
            ucShow.CmbAutor.BackColor = Color.White;
            ucShow.LblMsgAutor.Text = "";
            ucShow.CmbIzdavac.BackColor = Color.White;
            ucShow.LblMsgIzdavac.Text = "";
            ucShow.NudBrPrimeraka.BackColor = Color.White;
            ucShow.LblMsgBrPrimeraka.Text = "";
            ucShow.CmbZanr.BackColor = Color.White;
            ucShow.LblMsgZanr.Text = "";
            ucShow.TxtBrStrana.BackColor = Color.White;
            ucShow.LblMsgBrStrana.Text = "";

            if (string.IsNullOrEmpty(ucShow.TxtISBN.Text) || ucShow.TxtISBN.Text.Length != 13 || !ucShow.TxtISBN.Text.All(char.IsNumber))
            {
                valid = false;
                ucShow.TxtISBN.BackColor = Color.Coral;
                ucShow.LblMsgISBN.ForeColor = Color.Coral;
                ucShow.LblMsgISBN.Text = "ISBN treba da ima tačno 13 cifara";
            }
            if (string.IsNullOrEmpty(ucShow.TxtBrStrana.Text) || ucShow.TxtBrStrana.Text.Length < 1 || !ucShow.TxtISBN.Text.All(char.IsNumber))
            {
                valid = false;
                ucShow.TxtBrStrana.BackColor = Color.Coral;
                ucShow.LblMsgBrStrana.ForeColor = Color.Coral;
                ucShow.LblMsgBrStrana.Text = "Broj strana treba da sadrzi nenegativne brojeve.";
            }

            if (string.IsNullOrEmpty(ucShow.TxtNaziv.Text) || ucShow.TxtNaziv.Text.Length > 100)
            {
                valid = false;
                ucShow.TxtNaziv.BackColor = Color.Coral;
                ucShow.LblMsgNaziv.ForeColor = Color.Coral;
                ucShow.LblMsgNaziv.Text = "Naziv ne sme biti prazan";
            }

            if (string.IsNullOrEmpty(ucShow.TxtGodinaIzdavanja.Text) || !ucShow.TxtGodinaIzdavanja.Text.All(char.IsNumber)
                                    || DateTime.Parse(DateTime.Now.ToString()).Year < Convert.ToInt32(ucShow.TxtGodinaIzdavanja.Text) || Convert.ToInt32(ucShow.TxtGodinaIzdavanja.Text) < 0)
            {
                valid = false;
                ucShow.TxtGodinaIzdavanja.BackColor = Color.Coral;
                ucShow.LblMsgGodinaIzdavanja.ForeColor = Color.Coral;
                ucShow.LblMsgGodinaIzdavanja.Text = "Godina izdavanja treba da sadrzi samo cifre";
            }

            if (ucShow.CmbAutor.SelectedItem == null)
            {
                valid = false;
                ucShow.CmbAutor.BackColor = Color.Coral;
                ucShow.LblMsgAutor.ForeColor = Color.Coral;
                ucShow.LblMsgAutor.Text = "Autor treba da bude selektovan.";
            }
            if (ucShow.CmbIzdavac.SelectedItem == null)
            {
                valid = false;
                ucShow.CmbIzdavac.BackColor = Color.Coral;
                ucShow.LblMsgIzdavac.ForeColor = Color.Coral;
                ucShow.LblMsgIzdavac.Text = "Izdavac treba da bude selektovan.";
            }
            if (ucShow.CmbPovez.SelectedItem == null)
            {
                valid = false;
                ucShow.CmbPovez.BackColor = Color.Coral;
                ucShow.LblMsgPovez.ForeColor = Color.Coral;
                ucShow.LblMsgPovez.Text = "Povez treba da bude selektovan.";
            }
            if (ucShow.NudBrPrimeraka.Value <= 0)
            {
                valid = false;
                ucShow.NudBrPrimeraka.BackColor = Color.Coral;
                ucShow.LblMsgBrPrimeraka.ForeColor = Color.Coral;
                ucShow.LblMsgBrPrimeraka.Text = "Broj primeraka treba da bude veci od 0.";
            }
            if (ucShow.CmbZanr.SelectedItem == null)
            {
                valid = false;
                ucShow.CmbZanr.BackColor = Color.Coral;
                ucShow.LblMsgZanr.ForeColor = Color.Coral;
                ucShow.LblMsgZanr.Text = "Zanr treba da bude selektovan.";
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
        #endregion

        private void ResetUC(Mode mode, Knjiga knjiga = null)
        {
            switch (mode)
            {
                case Mode.Create:
                    isClicked = false;
                    //zanrovi = null;
                    isSaved=false;
                    ucShow.TxtISBN.Text = "";
                    ucShow.TxtGodinaIzdavanja.Text = "";
                    ucShow.TxtNaziv.Text = "";
                    ucShow.TxtBrStrana.Text = "";
                    UcitajComboBox();
                    ucShow.NudBrPrimeraka.ResetText();
                    ucShow.LblMessage.Text = "Unesite podatke o novoj knjizi.";
                    ucShow.BtnDelete.Visible = false;
                    ucShow.BtnDelete.Enabled = false;
                    ucShow.BtnSave.Visible = true;
                    ucShow.BtnSave.Enabled = true;
                    ucShow.BtnCancel.Visible = false;
                    ucShow.BtnCancel.Enabled = false;
                    ucShow.TxtBrStrana.Enabled = true;
                    ucShow.TxtGodinaIzdavanja.Enabled = true;
                    ucShow.TxtISBN.Enabled = true;
                    ucShow.TxtNaziv.Enabled = true;
                    ucShow.CmbAutor.Enabled = true;
                    ucShow.CmbIzdavac.Enabled = true;
                    ucShow.CmbPovez.Enabled = true;
                    ucShow.CmbZanr.Enabled = true;
                    ucShow.NudBrPrimeraka.Enabled=true;
                    ucShow.BtnCancel.Text = "Odustani";
                    ucShow.TxtDostupne.Enabled = false;
                    ucShow.TxtDostupne.Visible = false;
                    ucShow.LblBrDostupnih.Visible = false;
                    break;
                case Mode.Edit:
                    UcitajComboBox();
                    ucShow.LblTitle.Text = "Prikaz knjige";
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
                    ucShow.BtnDelete.Visible = true;
                    ucShow.BtnDelete.Enabled = true;
                    ucShow.TxtDostupne.Enabled = false;
                    ucShow.TxtDostupne.Visible = true;
                    ucShow.LblBrDostupnih.Visible = true;
                    if (primerci == null) { ucShow.TxtDostupne.Text = knjiga.BrojPrimeraka.ToString(); }
                    else { ucShow.TxtDostupne.Text = BrojDostupnih(knjiga).ToString(); }
                    ucShow.LblMessage.Text = "Sistem je ucitao knjigu.";
                    break;
                case Mode.ZaduziPrikaz:
                    UcitajComboBox();
                    ucShow.LblTitle.Text = "Prikaz knjige";
                    ucShow.LblMessage.Text = "Sistem je ucitao knjigu.";
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
                    ucShow.BtnSave.Enabled = true;
                    ucShow.BtnSave.Visible = true;
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
                    if (ucShow.TxtDostupne.Text == "0") { ucShow.TxtDostupne.BackColor = Color.LightCoral; ucShow.BtnSave.Enabled = false; }                   
                    break;
                default:
                    break;
            }
        }

        private void UcitajComboBox()
        {
            ucShow.CmbPovez.DataSource= Enum.GetValues(typeof(Povez));
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
    }
}
