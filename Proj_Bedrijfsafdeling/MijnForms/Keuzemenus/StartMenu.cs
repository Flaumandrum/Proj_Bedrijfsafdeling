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

namespace Proj_Bedrijfsafdeling
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btnRaadplegen_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MenuRaadplegen nieuwForm = new MenuRaadplegen();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();

        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            //nieuw formulier aanmaken 
            MenuBewerken nieuwForm = new MenuBewerken();

            // dit form verbergen 
            Hide();

            // nieuwe form toneen 
            nieuwForm.ShowDialog();

            // dit form tonen
            Show();
        }
    }
}
