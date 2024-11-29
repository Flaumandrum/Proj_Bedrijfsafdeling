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
    public partial class MwAanpassen : Form
    {
        public MwAanpassen()
        {
            InitializeComponent();
            // Vul de lijst van de mw's en van de afdelingen 
            VulCmbMw();
            VulCmbAfd();
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
        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKiesMw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKiesMw.SelectedIndex != -1)
            {
                Medewerker mw = Program.StuurMWDoor(cmbKiesMw.SelectedIndex);

                txtVoornaam.Text = mw.PropVoornaam;
                txtAchternaam.Text = mw.PropAchternaam;

                // Haal de lijst met afdelingsnamen op 
                List<string> afdelingen = Program.StuurLijstAfdDoor();

                for (int i = 0; i < afdelingen.Count(); i++)
                {
                    if(mw.PropAfdeling.PropAfdNaam == afdelingen[i])
                    {
                        cmbKiesAfd.SelectedIndex = i;
                        break;
                    }
                }

            }
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            if(cmbKiesMw.SelectedIndex != -1)
            {
                if(txtVoornaam.Text != "" && txtAchternaam.Text != "" && cmbKiesAfd.SelectedIndex != -1)
                {
                    // stuur alle gegevens door naar de business
                    Program.PasMwAan(cmbKiesMw.SelectedIndex, txtVoornaam.Text, txtAchternaam.Text, cmbKiesAfd.SelectedIndex);

                    // begeleiden 
                    MessageBox.Show("Deze medewerker werd aangepast", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                    // reset form
                    cmbKiesMw.SelectedIndex = -1;
                    cmbKiesMw.Text = null;
                    VulCmbMw();

                    txtVoornaam.Text = null;
                    txtAchternaam.Text = null;

                    cmbKiesAfd.Text = null;
                    cmbKiesMw.SelectedIndex = -1;

                    
                }
                else
                {
                    // Foutmelding 
                    MessageBox.Show("Vul alle gegevens in", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                // Foutmelding 
                MessageBox.Show("U moet eerst een medewerker selecteren", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
