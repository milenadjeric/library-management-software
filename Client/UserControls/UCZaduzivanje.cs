using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCZaduzivanje : UserControl
    {
        public UCZaduzivanje()
        {
            InitializeComponent();
        }


        internal void ChangePanel(Control control, Panel panel)
        {
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.Dock = DockStyle.None;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}