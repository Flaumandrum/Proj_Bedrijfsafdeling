using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Bedrijfsafdeling.MijnForms.Medewerkers;

namespace Proj_Bedrijfsafdeling.MijnForms.Keuzemenus
{
    public partial class MenuBewerkenMW : Form
    {
        public MenuBewerkenMW()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MwToevoegen nieuwForm = new MwToevoegen();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MwAanpassen nieuwForm = new MwAanpassen();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MwVerwijderen nieuwForm = new MwVerwijderen();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }
    }
}
