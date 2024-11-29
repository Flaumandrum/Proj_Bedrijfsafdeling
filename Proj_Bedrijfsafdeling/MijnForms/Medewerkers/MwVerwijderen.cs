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
    public partial class MwVerwijderen : Form
    {
        public MwVerwijderen()
        {
            InitializeComponent();
            VulCmbMw();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if(cmbKiesMw.SelectedIndex != -1)
            {
                
                Program.VerwMw(cmbKiesMw.SelectedIndex);

                // begeleid de gebruiker 
                MessageBox.Show("De medewerker werd verwijderd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                cmbKiesMw.SelectedIndex = -1;
                cmbKiesMw.Text = null;
                VulCmbMw();


            }
            else
            {
                // Foutmelding 
                MessageBox.Show("Vul alle gegevens in", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
