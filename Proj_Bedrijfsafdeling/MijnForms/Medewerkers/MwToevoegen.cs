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
    public partial class MwToevoegen : Form
    {
        public MwToevoegen()
        {
            InitializeComponent();
            // Vul de cmb met de afdelingen 
            VulCmbAfd();
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

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if(txtVoornaam.Text != "" && txtAchternaam.Text != "" && cmbKiesAfd.SelectedIndex != -1) 
            {
                Program.MaakMwAan(txtVoornaam.Text, txtAchternaam.Text, cmbKiesAfd.SelectedIndex);

                // begeleid de gebruiker 
                MessageBox.Show("De medewerker werd toegevoegd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                txtVoornaam.Text = null;
                txtAchternaam.Text = null;
                cmbKiesAfd.SelectedIndex = -1;
                cmbKiesAfd.Text = null;
            }
            else
            {
                // Foutmelding 
                MessageBox.Show("U moet eerst een afdeling selecteren", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
