using System.Windows.Forms;

namespace Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.clanoviMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeClanaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaClanaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKnjiguItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziKnjiguItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaduzenjaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaduziKnjiguItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razduziKnjiguItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clanoviMenuItem,
            this.knjigeMenuItem,
            this.zaduzenjaMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1067, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // clanoviMenuItem
            // 
            this.clanoviMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeClanaItem,
            this.pretragaClanaItem});
            this.clanoviMenuItem.Name = "clanoviMenuItem";
            this.clanoviMenuItem.Size = new System.Drawing.Size(72, 24);
            this.clanoviMenuItem.Text = "Članovi";
            // 
            // kreiranjeClanaItem
            // 
            this.kreiranjeClanaItem.Name = "kreiranjeClanaItem";
            this.kreiranjeClanaItem.Size = new System.Drawing.Size(218, 26);
            this.kreiranjeClanaItem.Text = "Dodaj novog člana";
            // 
            // pretragaClanaItem
            // 
            this.pretragaClanaItem.Name = "pretragaClanaItem";
            this.pretragaClanaItem.Size = new System.Drawing.Size(218, 26);
            this.pretragaClanaItem.Text = "Pretraga članova";
            // 
            // knjigeMenuItem
            // 
            this.knjigeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKnjiguItem,
            this.pretraziKnjiguItem});
            this.knjigeMenuItem.Name = "knjigeMenuItem";
            this.knjigeMenuItem.Size = new System.Drawing.Size(65, 24);
            this.knjigeMenuItem.Text = "Knjige";
            // 
            // dodajKnjiguItem
            // 
            this.dodajKnjiguItem.Name = "dodajKnjiguItem";
            this.dodajKnjiguItem.Size = new System.Drawing.Size(186, 26);
            this.dodajKnjiguItem.Text = "Dodaj knjigu";
            // 
            // pretraziKnjiguItem
            // 
            this.pretraziKnjiguItem.Name = "pretraziKnjiguItem";
            this.pretraziKnjiguItem.Size = new System.Drawing.Size(186, 26);
            this.pretraziKnjiguItem.Text = "Pretraži knjigu";
            // 
            // zaduzenjaMenuItem
            // 
            this.zaduzenjaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaduziKnjiguItem,
            this.razduziKnjiguItem});
            this.zaduzenjaMenuItem.Name = "zaduzenjaMenuItem";
            this.zaduzenjaMenuItem.Size = new System.Drawing.Size(92, 24);
            this.zaduzenjaMenuItem.Text = "Zaduženja";
            // 
            // zaduziKnjiguItem
            // 
            this.zaduziKnjiguItem.Name = "zaduziKnjiguItem";
            this.zaduziKnjiguItem.Size = new System.Drawing.Size(188, 26);
            this.zaduziKnjiguItem.Text = "Zaduži knjigu";
            // 
            // razduziKnjiguItem
            // 
            this.razduziKnjiguItem.Name = "razduziKnjiguItem";
            this.razduziKnjiguItem.Size = new System.Drawing.Size(188, 26);
            this.razduziKnjiguItem.Text = "Razduži knjigu";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(193)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(951, 1);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 554);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Biblioteka";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem clanoviMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeClanaItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaClanaItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKnjiguItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziKnjiguItem;
        private System.Windows.Forms.Button btnLogout;
        private Panel pnlMain;
        private ToolStripMenuItem zaduzenjaMenuItem;
        private ToolStripMenuItem zaduziKnjiguItem;
        private ToolStripMenuItem razduziKnjiguItem;

        public MenuStrip MainMenu { get => mainMenu; set => mainMenu = value; }
        public ToolStripMenuItem ClanoviMenuItem { get => clanoviMenuItem; set => clanoviMenuItem = value; }
        public ToolStripMenuItem KreiranjeClanaItem { get => kreiranjeClanaItem; set => kreiranjeClanaItem = value; }
        public ToolStripMenuItem PretragaClanaItem { get => pretragaClanaItem; set => pretragaClanaItem = value; }
        public ToolStripMenuItem KnjigeMenuItem { get => knjigeMenuItem; set => knjigeMenuItem = value; }
        public ToolStripMenuItem ZaduziKnjiguItem { get => zaduziKnjiguItem; set => zaduziKnjiguItem = value; }
        public ToolStripMenuItem RazduziKnjiguItem { get => razduziKnjiguItem; set => razduziKnjiguItem = value; }
        public ToolStripMenuItem DodajKnjiguItem { get => dodajKnjiguItem; set => dodajKnjiguItem = value; }
        public ToolStripMenuItem PretraziKnjiguItem { get => pretraziKnjiguItem; set => pretraziKnjiguItem = value; }
        public Button BtnLogout { get => btnLogout; set => btnLogout = value; }





    }
}