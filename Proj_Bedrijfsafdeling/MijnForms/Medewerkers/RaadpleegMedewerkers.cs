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

namespace Proj_Bedrijfsafdeling.MijnForms.Medewerkers
{
    public partial class RaadpleegMedewerkers : Form
    {
        public RaadpleegMedewerkers()
        {
            InitializeComponent();
            ResetAlleMw();
            VulCmbMw();
            rbAlleMw.Checked = true;

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Toont de formelementen op de juiste manier voor de selectie van alle afdelingen 
        private void ResetAlleMw()
        {
            cmbKiesMw.Visible = false;
            lblKiesMw.Visible = false;
        }
        // Toont de formelementen op de juiste manier voor de selectie van 1 specifieke afdeling 
        private void ResetSpecifiekeMw()
        {

            cmbKiesMw.Visible = true;
            lblKiesMw.Visible = true;
        }

        private void VulCmbMw()
        {
            // haal de lijst met namen van MW's op 
            List<string> mws = Program.StuurLijstMWDoor();

            // clear de cmb 
            cmbKiesMw.Items.Clear();

            // vul de cmb met de gegevns uit de lijst 
            foreach (string s in mws)
            {
                cmbKiesMw.Items.Add(s);
            }
        }

        private void rbAlleMw_CheckedChanged(object sender, EventArgs e)
        {
            // Zet de juiste formindeling op het scherm
            if (rbAlleMw.Checked)
            {
                ResetAlleMw();
            }
            else
            {
                ResetSpecifiekeMw();
            }
        }

        private void btnBevestingen_Click(object sender, EventArgs e)
        {
            // kijk welke radiobutten gekozen is, 
            if (rbAlleMw.Checked)
            {
                // vraag de lijst met afdelingsnamen uit de business
                List<string> medewerkers = Program.StuurLijstMWDoor();

                // overloop de lijst en toon deze in de txt
                foreach (string s in medewerkers)
                {
                    txtGegevens.Text += $"{s} {Environment.NewLine}";
                }


            }
            else
            {
                // kijk of er een afdeling is gekozen
                if (cmbKiesMw.SelectedIndex != -1)
                {
                    // Vraag de gegevens van deze afdeling op
                    Medewerker mw = Program.StuurMWDoor(cmbKiesMw.SelectedIndex);

                    // toon de MW's op het scherm
                    txtGegevens.Text = mw.GetAfdeling();
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
