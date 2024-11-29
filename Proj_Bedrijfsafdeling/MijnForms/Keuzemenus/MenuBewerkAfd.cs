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

namespace Proj_Bedrijfsafdeling.MijnForms.Keuzemenus
{
    public partial class MenuBewerkAfd : Form
    {
        public MenuBewerkAfd()
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
            AfdToevoegen nieuwForm = new AfdToevoegen();

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
            AfdAanpassen nieuwForm = new AfdAanpassen();

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
            AfdVerwijderen nieuwForm = new AfdVerwijderen();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }
    }
}
