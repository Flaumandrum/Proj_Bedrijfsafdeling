using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Bedrijfsafdeling.MijnForms.Keuzemenus;

namespace Proj_Bedrijfsafdeling.MijnForms.Keuzemenus
{
    public partial class MenuBewerken : Form
    {
        public MenuBewerken()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        


        private void btnBewerkAfd_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MenuBewerkAfd nieuwForm = new MenuBewerkAfd();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }

        private void btnBewerkMw_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MenuBewerkenMW nieuwForm = new MenuBewerkenMW();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }
    
    }
}
