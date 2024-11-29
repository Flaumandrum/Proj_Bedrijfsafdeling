using Klasses_BedrAfd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Bedrijfsafdeling.MijnForms.Afdelingen
{
    public partial class AfdAanpassen : Form
    {
        public AfdAanpassen()
        {
            InitializeComponent();
            // Vul de combobox bij het opstarten van het formulier
            VulCmbAfd();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // Check of de gebruiker een afdeling heeft geselecteerd
            if(cmbKiesAfd.SelectedIndex != -1)
            {
                // neem de nieuwe gegevens en stuur ze door naar de business
                Program.PasAfdAan(cmbKiesAfd.SelectedIndex, txtAfdNaam.Text, txtAfdHoofd.Text);

                // begeleid de gebruiker 
                MessageBox.Show("De afdeling werd aangepast", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // reset form 
                cmbKiesAfd.Text = null;
                cmbKiesAfd.SelectedIndex = -1;
                txtAfdNaam.Text = null;
                txtAfdHoofd.Text = null; 
                
                // Vul de cmb met de meest recente gegevens
                VulCmbAfd();
            }

            else
            {
                // Foutmelding 
                MessageBox.Show("U moet eerst een afdeling selecteren", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            


        }

        void VulCmbAfd ()
        {
            // Haal de lijst met afdelingsnamen op 
            List<string> afdelingen = Program.StuurLijstAfdDoor();

            // maak de cmb leeg 
            cmbKiesAfd.Items.Clear();

            // vul de cmb
            foreach(string s in afdelingen)
            {
                cmbKiesAfd.Items.Add(s);
            }

        }

        private void cmbKiesAfd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ga na of de gebruiker een afdeling heeft geselecteerd
            if (cmbKiesAfd.SelectedIndex != -1) 
            {
                // Haal de gegevens van de geselecteerde afdeling op uit de business
                Afdeling afd = Program.StuurAfdDoor(cmbKiesAfd.SelectedIndex);

                // Vul de gegevens in bij de juiste tekstbox
                txtAfdNaam.Text = afd.PropAfdNaam;
                txtAfdHoofd.Text =afd.PropAfdHoofd;

            }
        }
    }
}
