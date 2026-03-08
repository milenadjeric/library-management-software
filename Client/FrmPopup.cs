using Client.GUIControllers;
using Common.Domain;
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
    public partial class FrmPopup : Form
    {

        public FrmPopup()
        {
            InitializeComponent();
            BtnDodaj.Click += (s, e) => KnjigaGUIController.Instance.DodajNovogAutora(this);
            this.FormClosed += (s, e) => KnjigaGUIController.Instance.LoadAutori();
        }

        public FrmPopup(Izdavac izdavac)
        {
            InitializeComponent();
            BtnDodaj.Click += (s, e) => KnjigaGUIController.Instance.DodajNovogIzdavaca(this);
            this.FormClosed += (s, e) => KnjigaGUIController.Instance.LoadIzdavaci();
        }
    }
}