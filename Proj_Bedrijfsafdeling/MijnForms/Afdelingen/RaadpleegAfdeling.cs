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
    public partial class RaadpleegAfdeling : Form
    {
        public RaadpleegAfdeling()
        {
            InitializeComponent();
            // vul de cmb
            VulCmbAfd();
            //zorg dat rb alle afdelingen aangeduid is
            rbAlleAfd.Checked = true;
            // Zorg dat de form juist getoond wordt
            ResetAlleAfd();

        }

        // Toont de formelementen op de juiste manier voor de selectie van alle afdelingen 
        private void ResetAlleAfd()
        {
            cmbKiesAfd.Visible = false;
            lblKiesAfd.Visible=false;
        }
        // Toont de formelementen op de juiste manier voor de selectie van 1 specifieke afdeling 
        private void ResetSpecifiekeAfd()
        {
            
            cmbKiesAfd.Visible = true;
            lblKiesAfd.Visible = true;
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        void VulCmbAfd()
        {
            // Haal de lijst met afdelingsnamen op 
            List<string> afdelingen = Program.StuurLijstAfdDoor();

            // maak de cmb leeg 
            cmbKiesAfd.Items.Clear();

            // vul de cmb
            foreach (string s in afdelingen)
            {
                cmbKiesAfd.Items.Add(s);
            }

        }

        private void rbAlleAfd_CheckedChanged(object sender, EventArgs e)
        {
            // Zet de juiste formindeling op het scherm
            if(rbAlleAfd.Checked)
            {
                ResetAlleAfd();
            }
            else
            {
                ResetSpecifiekeAfd();
            }
        }

        private void btnBevestingen_Click(object sender, EventArgs e)
        {
            // kijk welke radiobutten gekozen is, 
            if(rbAlleAfd.Checked)
            {
                // vraag de lijst met afdelingsnamen uit de business
                List<string> afdelingen = Program.StuurLijstAfdDoor();

                // overloop de lijst en toon deze in de txt
                foreach(string s in afdelingen)
                {
                    txtGegevens.Text += $"{s} {Environment.NewLine}";
                }

                
            }
            else
            {
                // kijk of er een afdeling is gekozen
                if (cmbKiesAfd.SelectedIndex != -1)
                {
                    // Vraag de gegevens van deze afdeling op
                    Afdeling afd = Program.StuurAfdDoor(cmbKiesAfd.SelectedIndex);

                    // toon de MW's op het scherm
                    txtGegevens.Text = afd.GetAlleMedewerkers();
                }
            
                else
                {
                    // Foutmelding 
                    MessageBox.Show("U moet eerst een afdeling selecteren", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
