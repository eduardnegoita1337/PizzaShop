using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ProiectPAW_NegoitaEduard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pizza p1 = new Pizza("Margherita", 10, 25, 40);
            Adresa a1 = new Adresa("Pitesti", "Calea Dragasani", 2);
            Client c1 = new Client("Negoita", "Eduard", a1, "0748018828");
            List<Pizza> lista = new List<Pizza>();
            lista.Add(p1);
            Comanda com1 = new Comanda(1, c1, lista, p1.Pret, DateTime.Now);
            ListViewItem lvi1 = new ListViewItem(com1.IdComanda.ToString());
            lvi1.SubItems.Add(com1.Client.Nume);
            lvi1.SubItems.Add(com1.ValoareComanda.ToString());
            lvi1.SubItems.Add(com1.DataComanda.ToString());
            lvi1.Tag = com1;
            listView1.Items.Add(lvi1);

            ListViewItem lvi2 = new ListViewItem(c1.Nume.ToString());
            lvi2.SubItems.Add(c1.Prenume);
            lvi2.SubItems.Add(c1.Adresa.ToString());
            lvi2.Tag = c1;
            listView2.Items.Add(lvi2);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
            listView1.Items.Add(lvi);
            List<Pizza> pizzas = new List<Pizza>();
            Adresa a = new Adresa("x", "x", 2);
            Client c = new Client("x", "x", a, "x");
            Comanda com = new Comanda(100, c, pizzas, 0, DateTime.Now);
            lvi.Tag = com;
            lvi.Selected = true;
            FormComanda fc = new FormComanda();
            fc.Text = "Adaugare comanda ";
            fc.parinte = this;
            fc.comanda = com;
            fc.ShowDialog();
            if (fc.DialogResult != DialogResult.OK) lvi.Remove();
        }

        public void AdaugaComandaDragDrop(Client c)
        {

            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
            listView1.Items.Add(lvi);
            List<Pizza> pizzas = new List<Pizza>();
            Adresa a = new Adresa("x", "x", 2);
            Client cli1 = new Client("x", "x", a, "x");
            Comanda com = new Comanda(100, cli1, pizzas, 0, DateTime.Now);
            lvi.Tag = com;
            lvi.Selected = true;
            FormComanda fc = new FormComanda();
            fc.Text = "Adaugare comanda ";
            fc.parinte = this;
            fc.comanda = com;
            fc.ShowDialog();
            if (fc.DialogResult != DialogResult.OK) lvi.Remove();
            com.Client = c;
        }
        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "" });
            listView2.Items.Add(lvi);
            Adresa a = new Adresa("x", "x", 1);
            Client c = new Client("x", "x", a, "x");
            lvi.Tag = c;
            lvi.Selected = true;
            FormClient fc = new FormClient();
            fc.parinte = this;
            fc.client = c;
            fc.ShowDialog();
            if (fc.DialogResult != DialogResult.OK)
                lvi.Remove();
        }
        public void UpdateItems()
        {
            foreach(ListViewItem lvi in listView2.Items)
            {
                Client c = (Client)lvi.Tag;
                lvi.Text = c.Nume;
                lvi.SubItems[1].Text = c.Prenume;
                lvi.SubItems[2].Text = c.Adresa.ToString();
            }
            foreach(ListViewItem lvi1 in listView1.Items)
            {
                Comanda c = (Comanda)lvi1.Tag;
                lvi1.Text = c.IdComanda.ToString();
                lvi1.SubItems[1].Text = c.Client.Nume;
                lvi1.SubItems[2].Text = c.ValoareComanda.ToString();
                lvi1.SubItems[3].Text = c.DataComanda.ToString();
            }
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count > 0)
            {
                Client c = (Client)listView2.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea clientului " +
                   c.Nume + " " + c.Prenume + " ?", "Confirmare stergere", 
                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) listView2.SelectedItems[0].Remove();
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Comanda c = (Comanda)listView1.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea comenzii " +
                   c.IdComanda+" ?", "Confirmare stergere",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) listView1.SelectedItems[0].Remove();
            }
        }

        private void salveazaXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("lista-clienti");
            List<Client> lista = listView2.Items.Cast<ListViewItem>()
                    .Select(Item => (Client)Item.Tag)
                    .ToList();
            foreach(Client c in lista)
            {
                writer.WriteStartElement("Client");
                writer.WriteElementString("Nume", c.Nume);
                writer.WriteElementString("Prenume", c.Prenume);
                writer.WriteElementString("Adresa", c.Adresa.ToString());
                writer.WriteElementString("NrTel", c.NrTel);
                writer.WriteEndElement();

            }
            writer.WriteEndElement(); 
            writer.WriteEndDocument();
            writer.Close();

            string xmlString = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();
            memStream.Dispose();

            StreamWriter sw = new StreamWriter("E:\\FAC 2020\\PAW\\Proiect\\ProiectPAW_NegoitaEduard\\XML files\\clienti.xml");
            sw.WriteLine(xmlString);
            sw.Close();
        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("lista-comenzi");
            List<Comanda> lista = listView1.Items.Cast<ListViewItem>()
                    .Select(Item => (Comanda)Item.Tag)
                    .ToList();
            foreach (Comanda c in lista)
            {
                writer.WriteStartElement("Comanda");
                writer.WriteElementString("Nume-client", c.Client.Nume);
                writer.WriteElementString("Prenume-client", c.Client.Prenume);
                writer.WriteElementString("Adresa-client", c.Client.Adresa.ToString());
                writer.WriteElementString("NrTel-client", c.Client.NrTel);
                int i = 0;
                foreach(Pizza p in c.Pizzas)
                {
                    i++;
                    writer.WriteElementString("Pizza-"+ i, p.Denumire);
                }
                writer.WriteElementString("Valoare-comanda", c.ValoareComanda.ToString());
                writer.WriteElementString("Data-comanda", c.DataComanda.ToString());
                writer.WriteEndElement();

            }
            writer.WriteEndElement(); 
            writer.WriteEndDocument();
            writer.Close();

            string xmlString = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();
            memStream.Dispose();

            StreamWriter sw = new StreamWriter("E:\\FAC 2020\\PAW\\Proiect\\ProiectPAW_NegoitaEduard\\XML files\\comenzi.xml");
            sw.WriteLine(xmlString);
            sw.Close();
        }

        private void restaureazaXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("E:\\FAC 2020\\PAW\\Proiect\\ProiectPAW_NegoitaEduard\\XML files\\clienti.xml");
            string str = sr.ReadToEnd();
            List<Client> lista = new List<Client>();
            XmlReader reader = XmlReader.Create(new StringReader(str));

            while (reader.Read())
            {
                if (reader.Name == "Client" && reader.NodeType == XmlNodeType.Element) 
                {
                    Client clocal;
                    while (reader.Read() && reader.Name != "Nume") { }
                    reader.Read(); 
                    string nume = reader.Value;

                    while (reader.Read() && reader.Name != "Prenume") { }
                    reader.Read(); 
                    string prenume = reader.Value;

                    while (reader.Read() && reader.Name != "Adresa") { }
                    reader.Read(); 
                    string adresa = reader.Value;

                    while (reader.Read() && reader.Name != "NrTel") { }
                    reader.Read(); 
                    string nrtel = reader.Value;
                    char[] delimiters = {','};
                    string[] words = adresa.Split(delimiters);
                    string oras, strada, numar;
                    oras = words[0];
                    strada = words[1];
                    numar = words[2];
                    Adresa alocal = new Adresa(oras, strada, Int32.Parse(numar));
                    clocal = new Client(nume,prenume,alocal,nrtel);
                    lista.Add(clocal);

                }
            }
            listView2.Items.Clear();
            foreach (Client c in lista)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", ""});
                lvi.Tag = c;
                listView2.Items.Add(lvi);
            }
            UpdateItems();
            sr.Close();
        }

        private void restaureazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("E:\\FAC 2020\\PAW\\Proiect\\ProiectPAW_NegoitaEduard\\XML files\\comenzi.xml");
            string str = sr.ReadToEnd();
            List<Comanda> lista = new List<Comanda>();
            XmlReader reader = XmlReader.Create(new StringReader(str));

            while (reader.Read())
            {
                if (reader.Name == "Comanda" && reader.NodeType == XmlNodeType.Element)
                {
                    Comanda clocal;
                    while (reader.Read() && reader.Name != "Nume-client") { }
                    reader.Read();
                    string numeClient = reader.Value;

                    while (reader.Read() && reader.Name != "Prenume-client") { }
                    reader.Read();
                    string prenumeClient = reader.Value;

                    while (reader.Read() && reader.Name != "Adresa-client") { }
                    reader.Read();
                    string adresaClient = reader.Value;

                    while (reader.Read() && reader.Name != "NrTel-client") { }
                    reader.Read();
                    string nrtelClient = reader.Value;

                    while (reader.Read() && reader.Name != "Pizza-1") { }
                    reader.Read();
                    string denumirePizza = reader.Value;
                    while (reader.Read() && reader.Name != "Valoare-comanda") { }
                    reader.Read();
                    string valoare = reader.Value;
                    while (reader.Read() && reader.Name != "Data-comanda") { }
                    reader.Read();
                    string dataComanda = reader.Value;

                    char[] delimiters = { ',' };
                    string[] words = adresaClient.Split(delimiters);
                    string oras, strada, numar;
                    oras = words[0];
                    strada = words[1];
                    numar = words[2];
                    Adresa alocal = new Adresa(oras, strada, Int32.Parse(numar));
                    Client cliLocal = new Client(numeClient, prenumeClient, alocal, nrtelClient);
                    List<Pizza> pizzasLocal = new List<Pizza>();
                    Pizza p1 = new Pizza("x", 2, 3, 4);
                    p1.Denumire = denumirePizza;
                    if (denumirePizza == "Diavola")
                    {
                        p1.Stoc = 10;
                        p1.Pret = 25;
                        p1.TimpPreparare = 40;
                        pizzasLocal.Add(p1);
                    }
                    else if(denumirePizza == "Margherita")
                    {
                        p1.Stoc = 15;
                        p1.Pret = 35;
                        p1.TimpPreparare = 45;
                        pizzasLocal.Add(p1);
                    }
                    else if (denumirePizza == "Calzone")
                    {
                        p1.Stoc = 7;
                        p1.Pret = 20;
                        p1.TimpPreparare = 30;
                        pizzasLocal.Add(p1);
                    }
                    else if (denumirePizza == "Quatrro Formagi")
                    {
                        p1.Stoc = 5;
                        p1.Pret = 50;
                        p1.TimpPreparare = 50;
                        pizzasLocal.Add(p1);
                    }
                    else if (denumirePizza == "Prosciuto")
                    {
                        p1.Stoc = 22;
                        p1.Pret = 30;
                        p1.TimpPreparare = 40;
                        pizzasLocal.Add(p1);
                    }
                    DateTime data = Convert.ToDateTime(dataComanda);
                    Random random = new Random();
                    clocal = new Comanda(random.Next(1, 250), cliLocal, pizzasLocal, Int32.Parse(valoare), data);
                    lista.Add(clocal);

                }
            }
            listView1.Items.Clear();
            foreach (Comanda c in lista)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", "","" });
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }
            UpdateItems();
            sr.Close();
        }

        private void labelComandaform1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPizzerie_Click(object sender, EventArgs e)
        {

        }

        private void labelClientiForm1_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            if(listView2.SelectedItems.Count > 0)
            {
                listView2.DoDragDrop(listView2.SelectedItems[0],DragDropEffects.Copy);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            Client c = (Client)((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Tag;
            AdaugaComandaDragDrop(c);
        }
    }
    }

