using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareToets
{
    public partial class Form1 : Form
    {
        //Fields
        Administratie admin;

        public Form1()
        {
            InitializeComponent();

            admin = new Administratie();
        }

        private void btnNieuweVerhuringToevoegen_Click(object sender, EventArgs e)
        {
            DateTime date = dtpNieuweVerhuringTijdstip.Value;
            int uren = (int) nudNieuweVerhuringUren.Value;

            if (cbNieuweVerhuring.Text == "Feestzaal")
            {
                Feestzaal a = new Feestzaal(date, uren);

                admin.VoegToe(a);
            }
            else if (cbNieuweVerhuring.Text == "Kleine zaal")
            {
                KleineZaal a = new KleineZaal(date, uren);

                admin.VoegToe(a);
            }
            else if (cbNieuweVerhuring.Text == "Sportzaal")
            {
                Sportzaal a = new Sportzaal(date, uren);

                admin.VoegToe(a);
            }
            else
                MessageBox.Show("Selecteer a.u.b. een soort verhuring");

            lbVerhuringen.Items.Clear();

            foreach (Verhuur a in admin.Verhuringen)
            {
                lbVerhuringen.Items.Add(a.ToString());
            }
        }

        private void btnNieuweVerkoopToevoegen_Click(object sender, EventArgs e)
        {
            int aantal = (int)nudNieuweVerkoopAantal.Value;

            if (cbNieuweVerkoop.Text == "Sterke drank")
            {
                Sterkedrank a = new Sterkedrank(aantal);

                admin.VoegToe(a);
            }
            else if (cbNieuweVerkoop.Text == "Warme drank")
            {
                WarmeDrank a = new WarmeDrank(aantal);

                admin.VoegToe(a);
            }
            else if (cbNieuweVerkoop.Text == "frisdrank")
            {
                Frisdrank a = new Frisdrank(aantal);

                admin.VoegToe(a);
            }
            else
                MessageBox.Show("Selecteer a.u.b. een soort verkoop");

            lbVerkopen.Items.Clear();

            foreach (Verkoop a in admin.Verkopen)
            {
                lbVerkopen.Items.Add(a.ToString());
            }
        }
    }
}
