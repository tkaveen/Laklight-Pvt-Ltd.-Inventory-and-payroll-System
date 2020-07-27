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
    public partial class newuser : MaterialSkin.Controls.MaterialForm
    {
       /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\csharpe\Laklight\Laklight\Laklight\inventory.mdf;Integrated Security=True"); */
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\csharpe\Laklight\Laklight\Laklight\inventory.mdf;Integrated Security=True ";
        public newuser()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager m = MaterialSkin.MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600,
            MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green300,
            MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }

        private void newuser_Load(object sender, EventArgs e)
        {
          /*  if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Close(); */
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }



        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT COUNT(*) FROM registration WHERE username='" + materialSingleLineTextField3.Text + "' "; 

            String sqlQuery = "INSERT INTO registration(firstname,lastname,username,password,contact,email) " +
                                "VALUES ('" + materialSingleLineTextField1.Text + "','" + materialSingleLineTextField2.Text + "','" + materialSingleLineTextField3.Text + "','" + materialSingleLineTextField4.Text + "','" + materialSingleLineTextField5.Text + "','" + materialSingleLineTextField6.Text + "')";

            //String sqlQuery eke meka (EmployeeNic,Name,Dob,Email,Phone,EmployeeType,UserName,Password) athualata ube table eke colomn names dapan

            SqlDataAdapter sda = new SqlDataAdapter(query1, getConnection());

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("This username already taken");
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand(sqlQuery, getConnection());
                cmd1.ExecuteNonQuery();
                getConnection().Close();
                MessageBox.Show("Successfully Added");

            }



            /*  int i = 0;
              SqlCommand cmd = con.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "select * from registration where username= '" + materialSingleLineTextField3.Text + "' ";
              DataTable dt = new DataTable();
              SqlDataAdapter kl = new SqlDataAdapter(cmd);
              kl.Fill(dt);
              i = Convert.ToInt32(dt.Rows.Count.ToString());
              if (i == 0)
              {
                  SqlCommand cmd1 = con.CreateCommand();
                  cmd1.CommandType = CommandType.Text;
                  cmd1.CommandText = "insert into registration values('"+ materialSingleLineTextField1.Text + "','"+ materialSingleLineTextField2.Text + "','"+ materialSingleLineTextField3 .Text+ "','"+ materialSingleLineTextField4.Text + "','"+ materialSingleLineTextField5.Text + "','"+ materialSingleLineTextField6.Text + "')";

                  materialSingleLineTextField1.Text = ""; materialSingleLineTextField2.Text = ""; materialSingleLineTextField3.Text = "";
                  materialSingleLineTextField4.Text = ""; materialSingleLineTextField5.Text = ""; materialSingleLineTextField6.Text = "";

                  MessageBox.Show("Successfully Added");


              }
              else
              {
                  MessageBox.Show("This username already taken");
              } */
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mdi = new Menu();
            mdi.Show();
        }
    }
}
