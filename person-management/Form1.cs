using System;
using System.Windows.Forms;

/*Filippa Colbin, filippa.colbin@hotmail.se, (colfil-4)
*L0002B
*Inlämningsuppgift 3
*/

namespace PersonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrollera_Click(object sender, EventArgs e)
        {
            Person personen = new Person(txtFornamn.Text, txtEfternamn.Text, txtPersonnummer.Text);

            bool giltigt = personen.KontrolleraPersonnummer();
            string kon = personen.KollaKon();

            txtResultat.Text = "Namn: " + personen.Fornamn + " " + personen.Efternamn + "\r\n";
            txtResultat.Text += "Kön: " + kon + "\r\n";

            //If-sats som kontrollerar om personnummret är giltigt
            if (giltigt)
                txtResultat.Text += "Personnumret är giltigt!";
            else
                txtResultat.Text += "Personnumret är ogiltigt!";
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            txtFornamn.Clear();
            txtEfternamn.Clear();
            txtPersonnummer.Clear();
            txtResultat.Clear();

        }

        private void MenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void registeraEnPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFornamn.Visible = true;
            txtEfternamn.Visible = true;
            txtPersonnummer.Visible = true;
            txtResultat.Visible = true;
            btnKontrollera.Visible = true;
            btnRensa.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            label5.Visible = false;
            label6.Visible = false;

            //Töm textfälten
            txtFornamn.Clear();
            txtEfternamn.Clear();
            txtPersonnummer.Clear();
            txtResultat.Clear();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult svar = MessageBox.Show("Vill du verkligen avsluta?", "Avsluta", MessageBoxButtons.YesNo);
            if (svar == DialogResult.Yes)
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gömmer fälten innan användaren har valt att registrera en person
            txtFornamn.Visible = false;
            txtEfternamn.Visible = false;
            txtPersonnummer.Visible = false;
            txtResultat.Visible = false;
            btnKontrollera.Visible = false;
            btnRensa.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            //Visar välkomsttexten när programmet startas
            label5.Visible = true;
            label6.Visible = true;
        }
    }
}
