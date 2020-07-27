using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laklight
{
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager m = MaterialSkin.MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600,
            MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green300,
            MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inv mdi = new inv();
            mdi.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            payroll mdi = new payroll();
            mdi.Show();
        }

        private void cxFlatSimpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inv mdi = new inv();
            mdi.Show();
        }

        private void cxFlatSimpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            payroll mdi = new payroll();
            mdi.Show();
        }

        private void cxFlatSimpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            newuser mdi = new newuser();
            mdi.Show();
        }
    }
}
