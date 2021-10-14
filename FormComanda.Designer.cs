
namespace ProiectPAW_NegoitaEduard
{
    partial class FormComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComanda));
            this.labelClient = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxPizza = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdaugaCom = new System.Windows.Forms.Button();
            this.labelComanda = new System.Windows.Forms.Label();
            this.labelNumeClient = new System.Windows.Forms.Label();
            this.labelPrenumeClient = new System.Windows.Forms.Label();
            this.labelClientOras = new System.Windows.Forms.Label();
            this.labelClientStrada = new System.Windows.Forms.Label();
            this.labelClientNumar = new System.Windows.Forms.Label();
            this.labelClientNrTel = new System.Windows.Forms.Label();
            this.labelPizzaDenumire = new System.Windows.Forms.Label();
            this.labelPizza = new System.Windows.Forms.Label();
            this.textBoxClientPrenume = new System.Windows.Forms.TextBox();
            this.textBoxClientOras = new System.Windows.Forms.TextBox();
            this.textBoxClientStrada = new System.Windows.Forms.TextBox();
            this.textBoxClientNumar = new System.Windows.Forms.TextBox();
            this.textBoxClientNrTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.BackColor = System.Drawing.Color.Black;
            this.labelClient.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.Silver;
            this.labelClient.Location = new System.Drawing.Point(110, 26);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(53, 25);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Client";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Black;
            this.labelData.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Silver;
            this.labelData.Location = new System.Drawing.Point(597, 94);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 19);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data";
            this.labelData.Click += new System.EventHandler(this.labelData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 3;
            // 
            // textBoxClient
            // 
            this.textBoxClient.BackColor = System.Drawing.Color.Black;
            this.textBoxClient.ForeColor = System.Drawing.Color.White;
            this.textBoxClient.Location = new System.Drawing.Point(96, 86);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxClient.TabIndex = 4;
            this.textBoxClient.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPizza
            // 
            this.textBoxPizza.BackColor = System.Drawing.Color.Black;
            this.textBoxPizza.ForeColor = System.Drawing.Color.White;
            this.textBoxPizza.Location = new System.Drawing.Point(379, 86);
            this.textBoxPizza.Name = "textBoxPizza";
            this.textBoxPizza.Size = new System.Drawing.Size(100, 20);
            this.textBoxPizza.TabIndex = 5;
            this.textBoxPizza.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(664, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonAdaugaCom
            // 
            this.buttonAdaugaCom.AllowDrop = true;
            this.buttonAdaugaCom.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdaugaCom.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaCom.ForeColor = System.Drawing.Color.Black;
            this.buttonAdaugaCom.Location = new System.Drawing.Point(424, 249);
            this.buttonAdaugaCom.Name = "buttonAdaugaCom";
            this.buttonAdaugaCom.Size = new System.Drawing.Size(235, 76);
            this.buttonAdaugaCom.TabIndex = 7;
            this.buttonAdaugaCom.Text = "Adauga";
            this.buttonAdaugaCom.UseVisualStyleBackColor = false;
            this.buttonAdaugaCom.Click += new System.EventHandler(this.buttonAdaugaCom_Click);
            // 
            // labelComanda
            // 
            this.labelComanda.AutoSize = true;
            this.labelComanda.BackColor = System.Drawing.Color.Black;
            this.labelComanda.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComanda.ForeColor = System.Drawing.Color.Silver;
            this.labelComanda.Location = new System.Drawing.Point(640, 25);
            this.labelComanda.Name = "labelComanda";
            this.labelComanda.Size = new System.Drawing.Size(77, 25);
            this.labelComanda.TabIndex = 8;
            this.labelComanda.Text = "Comanda";
            // 
            // labelNumeClient
            // 
            this.labelNumeClient.AutoSize = true;
            this.labelNumeClient.BackColor = System.Drawing.Color.Black;
            this.labelNumeClient.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeClient.ForeColor = System.Drawing.Color.Silver;
            this.labelNumeClient.Location = new System.Drawing.Point(24, 87);
            this.labelNumeClient.Name = "labelNumeClient";
            this.labelNumeClient.Size = new System.Drawing.Size(39, 19);
            this.labelNumeClient.TabIndex = 9;
            this.labelNumeClient.Text = "Nume";
            // 
            // labelPrenumeClient
            // 
            this.labelPrenumeClient.AutoSize = true;
            this.labelPrenumeClient.BackColor = System.Drawing.Color.Black;
            this.labelPrenumeClient.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenumeClient.ForeColor = System.Drawing.Color.Silver;
            this.labelPrenumeClient.Location = new System.Drawing.Point(24, 156);
            this.labelPrenumeClient.Name = "labelPrenumeClient";
            this.labelPrenumeClient.Size = new System.Drawing.Size(57, 19);
            this.labelPrenumeClient.TabIndex = 10;
            this.labelPrenumeClient.Text = "Prenume";
            // 
            // labelClientOras
            // 
            this.labelClientOras.AutoSize = true;
            this.labelClientOras.BackColor = System.Drawing.Color.Black;
            this.labelClientOras.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientOras.ForeColor = System.Drawing.Color.Silver;
            this.labelClientOras.Location = new System.Drawing.Point(24, 223);
            this.labelClientOras.Name = "labelClientOras";
            this.labelClientOras.Size = new System.Drawing.Size(34, 19);
            this.labelClientOras.TabIndex = 11;
            this.labelClientOras.Text = "Oras";
            // 
            // labelClientStrada
            // 
            this.labelClientStrada.AutoSize = true;
            this.labelClientStrada.BackColor = System.Drawing.Color.Black;
            this.labelClientStrada.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientStrada.ForeColor = System.Drawing.Color.Silver;
            this.labelClientStrada.Location = new System.Drawing.Point(24, 280);
            this.labelClientStrada.Name = "labelClientStrada";
            this.labelClientStrada.Size = new System.Drawing.Size(45, 19);
            this.labelClientStrada.TabIndex = 12;
            this.labelClientStrada.Text = "Strada";
            // 
            // labelClientNumar
            // 
            this.labelClientNumar.AutoSize = true;
            this.labelClientNumar.BackColor = System.Drawing.Color.Black;
            this.labelClientNumar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNumar.ForeColor = System.Drawing.Color.Silver;
            this.labelClientNumar.Location = new System.Drawing.Point(24, 332);
            this.labelClientNumar.Name = "labelClientNumar";
            this.labelClientNumar.Size = new System.Drawing.Size(45, 19);
            this.labelClientNumar.TabIndex = 13;
            this.labelClientNumar.Text = "Numar";
            // 
            // labelClientNrTel
            // 
            this.labelClientNrTel.AutoSize = true;
            this.labelClientNrTel.BackColor = System.Drawing.Color.Black;
            this.labelClientNrTel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNrTel.ForeColor = System.Drawing.Color.Silver;
            this.labelClientNrTel.Location = new System.Drawing.Point(24, 382);
            this.labelClientNrTel.Name = "labelClientNrTel";
            this.labelClientNrTel.Size = new System.Drawing.Size(39, 19);
            this.labelClientNrTel.TabIndex = 14;
            this.labelClientNrTel.Text = "Nr Tel";
            // 
            // labelPizzaDenumire
            // 
            this.labelPizzaDenumire.AutoSize = true;
            this.labelPizzaDenumire.BackColor = System.Drawing.Color.Black;
            this.labelPizzaDenumire.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzaDenumire.ForeColor = System.Drawing.Color.Silver;
            this.labelPizzaDenumire.Location = new System.Drawing.Point(294, 90);
            this.labelPizzaDenumire.Name = "labelPizzaDenumire";
            this.labelPizzaDenumire.Size = new System.Drawing.Size(60, 19);
            this.labelPizzaDenumire.TabIndex = 15;
            this.labelPizzaDenumire.Text = "Denumire";
            this.labelPizzaDenumire.Click += new System.EventHandler(this.labelPizzaDenumire_Click);
            // 
            // labelPizza
            // 
            this.labelPizza.AutoSize = true;
            this.labelPizza.BackColor = System.Drawing.Color.Black;
            this.labelPizza.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizza.ForeColor = System.Drawing.Color.Silver;
            this.labelPizza.Location = new System.Drawing.Point(350, 25);
            this.labelPizza.Name = "labelPizza";
            this.labelPizza.Size = new System.Drawing.Size(48, 25);
            this.labelPizza.TabIndex = 1;
            this.labelPizza.Text = "Pizza";
            // 
            // textBoxClientPrenume
            // 
            this.textBoxClientPrenume.BackColor = System.Drawing.Color.Black;
            this.textBoxClientPrenume.ForeColor = System.Drawing.Color.White;
            this.textBoxClientPrenume.Location = new System.Drawing.Point(96, 155);
            this.textBoxClientPrenume.Name = "textBoxClientPrenume";
            this.textBoxClientPrenume.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientPrenume.TabIndex = 16;
            // 
            // textBoxClientOras
            // 
            this.textBoxClientOras.BackColor = System.Drawing.Color.Black;
            this.textBoxClientOras.ForeColor = System.Drawing.Color.White;
            this.textBoxClientOras.Location = new System.Drawing.Point(96, 222);
            this.textBoxClientOras.Name = "textBoxClientOras";
            this.textBoxClientOras.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientOras.TabIndex = 17;
            // 
            // textBoxClientStrada
            // 
            this.textBoxClientStrada.BackColor = System.Drawing.Color.Black;
            this.textBoxClientStrada.ForeColor = System.Drawing.Color.White;
            this.textBoxClientStrada.Location = new System.Drawing.Point(96, 282);
            this.textBoxClientStrada.Name = "textBoxClientStrada";
            this.textBoxClientStrada.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientStrada.TabIndex = 18;
            // 
            // textBoxClientNumar
            // 
            this.textBoxClientNumar.BackColor = System.Drawing.Color.Black;
            this.textBoxClientNumar.ForeColor = System.Drawing.Color.White;
            this.textBoxClientNumar.Location = new System.Drawing.Point(96, 334);
            this.textBoxClientNumar.Name = "textBoxClientNumar";
            this.textBoxClientNumar.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientNumar.TabIndex = 19;
            // 
            // textBoxClientNrTel
            // 
            this.textBoxClientNrTel.BackColor = System.Drawing.Color.Black;
            this.textBoxClientNrTel.ForeColor = System.Drawing.Color.White;
            this.textBoxClientNrTel.Location = new System.Drawing.Point(96, 384);
            this.textBoxClientNrTel.Name = "textBoxClientNrTel";
            this.textBoxClientNrTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientNrTel.TabIndex = 20;
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.textBoxClientNrTel);
            this.Controls.Add(this.textBoxClientNumar);
            this.Controls.Add(this.textBoxClientStrada);
            this.Controls.Add(this.textBoxClientOras);
            this.Controls.Add(this.textBoxClientPrenume);
            this.Controls.Add(this.labelPizzaDenumire);
            this.Controls.Add(this.labelClientNrTel);
            this.Controls.Add(this.labelClientNumar);
            this.Controls.Add(this.labelClientStrada);
            this.Controls.Add(this.labelClientOras);
            this.Controls.Add(this.labelPrenumeClient);
            this.Controls.Add(this.labelNumeClient);
            this.Controls.Add(this.labelComanda);
            this.Controls.Add(this.buttonAdaugaCom);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPizza);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPizza);
            this.Controls.Add(this.labelClient);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormComanda";
            this.Text = "Adauga comanda";
            this.Load += new System.EventHandler(this.FormComanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxPizza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAdaugaCom;
        private System.Windows.Forms.Label labelComanda;
        private System.Windows.Forms.Label labelNumeClient;
        private System.Windows.Forms.Label labelPrenumeClient;
        private System.Windows.Forms.Label labelClientOras;
        private System.Windows.Forms.Label labelClientStrada;
        private System.Windows.Forms.Label labelClientNumar;
        private System.Windows.Forms.Label labelClientNrTel;
        private System.Windows.Forms.Label labelPizzaDenumire;
        private System.Windows.Forms.Label labelPizza;
        private System.Windows.Forms.TextBox textBoxClientPrenume;
        private System.Windows.Forms.TextBox textBoxClientOras;
        private System.Windows.Forms.TextBox textBoxClientStrada;
        private System.Windows.Forms.TextBox textBoxClientNumar;
        private System.Windows.Forms.TextBox textBoxClientNrTel;
    }
}