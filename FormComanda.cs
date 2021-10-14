using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_NegoitaEduard
{
    
    public partial class FormComanda : Form
    {
        public Comanda comanda;
        public Form1 parinte;
        ErrorProvider errorProvider = new ErrorProvider();
        public FormComanda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaCom_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            if(textBoxClient.Text.Length < 3)
            {
                errorProvider.SetError(textBoxClient, "Numele clientului este prea scurt!");
                eroare = true;
            }
            if (textBoxPizza.Text == "Margherita" || textBoxPizza.Text == "Prosciuto" 
                || textBoxPizza.Text == "Diavola" || textBoxPizza.Text == "Calzone"
                || textBoxPizza.Text == "Quattro Formagi")
            {
                
            }
            else
            {
                errorProvider.SetError(textBoxPizza, "Alegeti o pizza dintre: Margherita, Prosciuto," +
                    " Diavola, Calzone, Quattro Formagi");
                eroare = true;
            }
            if (!eroare)
            {
                this.DialogResult = DialogResult.OK;
                comanda.Client.Nume = textBoxClient.Text;
                comanda.Client.Prenume = textBoxClientPrenume.Text;
                comanda.Client.Adresa.Oras = textBoxClientOras.Text;
                comanda.Client.Adresa.Strada = textBoxClientStrada.Text;
                comanda.Client.Adresa.Numar = Int32.Parse(textBoxClientNumar.Text);
                comanda.Client.NrTel = textBoxClientNrTel.Text;
                Random random = new Random();
                comanda.IdComanda = random.Next(1, 250);
                if(textBoxPizza.Text == "Diavola")
                {
                    Pizza p = new Pizza(textBoxPizza.Text, 10, 25, 40);
                    comanda.Pizzas.Add(p);
                    comanda.ValoareComanda = p.Pret;
                }
                else if(textBoxPizza.Text == "Margherita")
                {
                    Pizza p = new Pizza(textBoxPizza.Text, 15, 35, 45);
                    comanda.Pizzas.Add(p);
                    comanda.ValoareComanda = p.Pret;
                }
                else if(textBoxPizza.Text == "Calzone")
                {
                    Pizza p = new Pizza(textBoxPizza.Text, 7, 20, 30);
                    comanda.Pizzas.Add(p);
                    comanda.ValoareComanda = p.Pret;
                }
                else if(textBoxPizza.Text == "Quattro Formagi")
                {
                    Pizza p = new Pizza(textBoxPizza.Text, 5, 50, 50);
                    comanda.Pizzas.Add(p);
                    comanda.ValoareComanda = p.Pret;
                }
                else if(textBoxPizza.Text == "Prosciuto")
                {
                    Pizza p = new Pizza(textBoxPizza.Text, 22, 30, 40);
                    comanda.Pizzas.Add(p);
                    comanda.ValoareComanda = p.Pret;
                }
                comanda.DataComanda = dateTimePicker1.Value;
                this.parinte.UpdateItems();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormComanda_Load(object sender, EventArgs e)
        {

        }

        private void labelPizzaDenumire_Click(object sender, EventArgs e)
        {

        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }
    }
}
