using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Bedrijfsafdeling.MijnForms.Afdelingen;
using Proj_Bedrijfsafdeling.MijnForms.Medewerkers;

namespace Proj_Bedrijfsafdeling.MijnForms.Keuzemenus
{
    public partial class MenuRaadplegen : Form
    {
        public MenuRaadplegen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRaadplegenMW_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            RaadpleegMedewerkers nieuwForm = new RaadpleegMedewerkers();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }

        private void btnRaadplegenAfd_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            RaadpleegAfdeling nieuwForm = new RaadpleegAfdeling();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }
    }
}
