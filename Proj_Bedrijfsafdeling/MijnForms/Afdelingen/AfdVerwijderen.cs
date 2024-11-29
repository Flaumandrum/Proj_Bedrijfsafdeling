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
    public partial class AfdVerwijderen : Form
    {
        public AfdVerwijderen()
        {
            InitializeComponent();
            // Vul de combobox bij het opstarten van het formulier
            VulCmbAfd();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (cmbKiesAfd.SelectedIndex != -1)
            {
                // neem de nieuwe gegevens en stuur ze door naar de business
                Program.VerwAfd(cmbKiesAfd.SelectedIndex);

                // begeleid de gebruiker 
                MessageBox.Show("De afdeling werd verwijderd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // reset form 
                cmbKiesAfd.Text = null;
                cmbKiesAfd.SelectedIndex = -1;

                // Vul de cmb met de meest recente gegevens
                VulCmbAfd();
            }
            else
            {
                // Foutmelding 
                MessageBox.Show("U moet eerst een afdeling selecteren", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
