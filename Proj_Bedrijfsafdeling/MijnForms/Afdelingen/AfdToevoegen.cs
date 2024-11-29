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
    public partial class AfdToevoegen : Form
    {
        public AfdToevoegen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // Bekijken of er overal iets is ingevuld
            if(txtAfdNaam.Text != "" && txtAfdHoofd.Text != "")
            {
                // Stuur de gegevens door naar de business
                Program.MaakAfdAan(txtAfdNaam.Text, txtAfdHoofd.Text);

                // Reset het fomr
                txtAfdHoofd.Text = null;
                txtAfdNaam.Text = null;

                // Begeleid de gebruiker 
                MessageBox.Show("Deze afdeling werd toegevoegd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       

            else
            {
                // foutmelding
                MessageBox.Show("U vulde niet alles in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
