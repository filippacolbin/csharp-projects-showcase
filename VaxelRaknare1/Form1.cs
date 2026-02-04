using System;
using System.Windows.Forms;

//Flippa Colbin (colfil-4)
namespace VaxelRaknare1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerakna_Click(object sender, EventArgs e)
        {
            //Rensa textrutan för resultatet
            txtResultat.Clear();

            //If-sats för att läsa in priset
            if (!int.TryParse(txtPris.Text, out int pris))
            {
                MessageBox.Show("Ange ett giltigt pris.");
                return;
            }

            //If-sats för att läsa in beloppet
            if (!int.TryParse(txtBetalt.Text, out int betalt))
            {
                MessageBox.Show("Ange ett giltigt betalt belopp.");
                return;
            }

            //Int som beräknar växeln
            int vaxel = betalt - pris;

            if (vaxel < 0)
            {
                txtResultat.Text = ("För lite betalt. " + (-vaxel) + " kr saknas.");
                return;

            }
            else if (vaxel == 0)
            {
                txtResultat.Text = "Ingen växel behövs.";
                return;
            }

            txtResultat.Text = "Växel tillbaka: " + Environment.NewLine +
                   vaxel + " kr" + Environment.NewLine + Environment.NewLine;

            //Valörer
            int[] valorer = { 500, 200, 100, 50, 20, 10, 5, 1 };
            string[] namn = { "femhundralapp", "tvåhundralapp", "hundralapp", "femtiolapp", "tjuga", "tiokrona", "femkrona", "enkrona" };

            //For-loop som loopar igenom alla valorer och räknar ut antal sedlar/mynt i växeln
            for (int i = 0; i < valorer.Length; i++)
            {
                int antal = vaxel / valorer[i];
                vaxel %= valorer[i];

                //if-sats ifall man ska ge ut något av valören
                if (antal > 0)
                {
                    //tom textvariabel som resultatet senare står i
                    string text;

                    //If-sats om vi bara ska ge ut en
                    if (antal == 1)
                    {
                        text = "1 " + namn[i];
                    }
                    else
                    {
                        //If-satser för korrekt pluralform
                        if (namn[i] == "tjuga")
                            text = antal + " tjugor";
                        else if (namn[i] == "tiokrona")
                            text = antal + " tiokronor";
                        else if (namn[i] == "femkrona")
                            text = antal + " femkronor";
                        else if (namn[i] == "enkrona")
                            text = antal + " enkronor";
                        else
                            text = antal + " " + namn[i] + "ar";
                    }

                    txtResultat.AppendText(text + Environment.NewLine);
                }
            }
        }

        //Metod för att rensa pris, betalt och resultat
        private void btnRensa_Click(object sender, EventArgs e)
        {
            txtPris.Clear();
            txtBetalt.Clear();
            txtResultat.Clear();
            txtPris.Focus();
        }

        //Metod som avslutar programmet
        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            DialogResult svar = MessageBox.Show(
                "Vill du verkligen avsluta programmet?",
                "Avsluta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //If-sats ifall användaren klickar Ja
            if (svar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
