
namespace ProiectPAW_NegoitaEduard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelComandaform1 = new System.Windows.Forms.Label();
            this.labelClientiForm1 = new System.Windows.Forms.Label();
            this.labelPizzerie = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderClient,
            this.columnHeaderValoare,
            this.columnHeaderData});
            this.listView1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(289, 334);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 37;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Client";
            // 
            // columnHeaderValoare
            // 
            this.columnHeaderValoare.Text = "Valoare";
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 127;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderAdresa});
            this.listView2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(462, 135);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(289, 334);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDown);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            // 
            // columnHeaderAdresa
            // 
            this.columnHeaderAdresa.Text = "Adresa";
            this.columnHeaderAdresa.Width = 164;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandaToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.salveazaXMLToolStripMenuItem,
            this.restaureazaXMLToolStripMenuItem});
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.comandaToolStripMenuItem.Text = "Comanda";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // salveazaXMLToolStripMenuItem
            // 
            this.salveazaXMLToolStripMenuItem.Name = "salveazaXMLToolStripMenuItem";
            this.salveazaXMLToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salveazaXMLToolStripMenuItem.Text = "Salveaza XML";
            this.salveazaXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem_Click);
            // 
            // restaureazaXMLToolStripMenuItem
            // 
            this.restaureazaXMLToolStripMenuItem.Name = "restaureazaXMLToolStripMenuItem";
            this.restaureazaXMLToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.restaureazaXMLToolStripMenuItem.Text = "Restaureaza XML";
            this.restaureazaXMLToolStripMenuItem.Click += new System.EventHandler(this.restaureazaXMLToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.stergeToolStripMenuItem1,
            this.salveazaXMLToolStripMenuItem1,
            this.restaureazaXMLToolStripMenuItem1});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.adaugaToolStripMenuItem1.Text = "Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // salveazaXMLToolStripMenuItem1
            // 
            this.salveazaXMLToolStripMenuItem1.Name = "salveazaXMLToolStripMenuItem1";
            this.salveazaXMLToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.salveazaXMLToolStripMenuItem1.Text = "Salveaza XML";
            this.salveazaXMLToolStripMenuItem1.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem1_Click);
            // 
            // restaureazaXMLToolStripMenuItem1
            // 
            this.restaureazaXMLToolStripMenuItem1.Name = "restaureazaXMLToolStripMenuItem1";
            this.restaureazaXMLToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.restaureazaXMLToolStripMenuItem1.Text = "Restaureaza XML";
            this.restaureazaXMLToolStripMenuItem1.Click += new System.EventHandler(this.restaureazaXMLToolStripMenuItem1_Click);
            // 
            // labelComandaform1
            // 
            this.labelComandaform1.AutoSize = true;
            this.labelComandaform1.BackColor = System.Drawing.Color.Black;
            this.labelComandaform1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComandaform1.ForeColor = System.Drawing.Color.Silver;
            this.labelComandaform1.Location = new System.Drawing.Point(127, 81);
            this.labelComandaform1.Name = "labelComandaform1";
            this.labelComandaform1.Size = new System.Drawing.Size(95, 35);
            this.labelComandaform1.TabIndex = 3;
            this.labelComandaform1.Text = "Comenzi";
            this.labelComandaform1.Click += new System.EventHandler(this.labelComandaform1_Click);
            // 
            // labelClientiForm1
            // 
            this.labelClientiForm1.AutoSize = true;
            this.labelClientiForm1.BackColor = System.Drawing.Color.Black;
            this.labelClientiForm1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientiForm1.ForeColor = System.Drawing.Color.Silver;
            this.labelClientiForm1.Location = new System.Drawing.Point(571, 81);
            this.labelClientiForm1.Name = "labelClientiForm1";
            this.labelClientiForm1.Size = new System.Drawing.Size(77, 35);
            this.labelClientiForm1.TabIndex = 4;
            this.labelClientiForm1.Text = "Clienti";
            this.labelClientiForm1.Click += new System.EventHandler(this.labelClientiForm1_Click);
            // 
            // labelPizzerie
            // 
            this.labelPizzerie.AutoSize = true;
            this.labelPizzerie.BackColor = System.Drawing.Color.Black;
            this.labelPizzerie.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzerie.ForeColor = System.Drawing.Color.Silver;
            this.labelPizzerie.Location = new System.Drawing.Point(317, 36);
            this.labelPizzerie.Name = "labelPizzerie";
            this.labelPizzerie.Size = new System.Drawing.Size(153, 58);
            this.labelPizzerie.TabIndex = 5;
            this.labelPizzerie.Text = "Pizzerie";
            this.labelPizzerie.Click += new System.EventHandler(this.labelPizzerie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.labelPizzerie);
            this.Controls.Add(this.labelClientiForm1);
            this.Controls.Add(this.labelComandaform1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pizzerie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.ColumnHeader columnHeaderValoare;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaureazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaureazaXMLToolStripMenuItem1;
        private System.Windows.Forms.Label labelComandaform1;
        private System.Windows.Forms.Label labelClientiForm1;
        private System.Windows.Forms.Label labelPizzerie;
    }
}

