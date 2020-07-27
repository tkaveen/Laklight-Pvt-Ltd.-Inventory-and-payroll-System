using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laklight
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\csharpe\Laklight\Laklight\Laklight\inventory.mdf;Integrated Security=True");

        public Login()
        {
         
            InitializeComponent();
            MaterialSkin.MaterialSkinManager m = MaterialSkin.MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600,
            MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green300,
            MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where username= '" + materialSingleLineTextField1.Text + "'and  password = '" + materialSingleLineTextField2.Text + "' ";
            DataTable dt = new DataTable();
            SqlDataAdapter kl = new SqlDataAdapter(cmd);
            kl.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Username and Passsword mismatch");
            }
            else
            {
                this.Hide();
                Menu mdi = new Menu();
                mdi.Show();
            }
        }
    }
}
