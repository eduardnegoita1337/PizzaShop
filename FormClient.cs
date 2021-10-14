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
    public partial class FormClient : Form
    {
        public Client client;
        public Form1 parinte;
        ErrorProvider errorProvider1 = new ErrorProvider();
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            if (textBoxNume.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxNume, "Numele trebuie sa aiba minim 3 caractere!");
                eroare = true;
            }
            if (textBoxPrenume.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxPrenume, "Prenumele trebuie sa aiba minim 3 caractere!");
                eroare = true;
            }
            if (textBoxOras.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxOras, "Orasul trebuie sa aiba minim 3 caractere!");
                eroare = true;
            }
            if (textBoxStrada.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxStrada, "Strada trebuie sa aiba minim 3 caractere!");
                eroare = true;
            }
            if (textBoxNumar.Text ==null)
            {
                errorProvider1.SetError(textBoxNumar, "Numar invalid!");
                eroare = true;
            }
            if (textBoxNrTel.Text.Length < 10)
            {
                errorProvider1.SetError(textBoxNrTel, "Numarul de telefon este invalid!");
                eroare = true;
            }
            if (!eroare)
            {
                this.DialogResult = DialogResult.OK;
                client.Nume = textBoxNume.Text;
                client.Prenume = textBoxPrenume.Text;
                client.Adresa.Oras = textBoxOras.Text;
                client.Adresa.Strada = textBoxStrada.Text;
                client.Adresa.Numar = Int32.Parse(textBoxNumar.Text);
                client.NrTel = textBoxNrTel.Text;
                this.parinte.UpdateItems();
            }


        }
    }
}
