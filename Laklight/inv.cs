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
    public partial class inv : MaterialSkin.Controls.MaterialForm
    {
        public inv()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager m = MaterialSkin.MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
            MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green300,
            MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void inv_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mdi = new Menu();
            mdi.Show();
        }

        private void inv_Resize(object sender, EventArgs e)
        {
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            this.Width = intX;
            this.Height = intY;
            this.Top = 0;
            this.Left = 0;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            abrirformulario<de>();
        }

        private void inv_Load_1(object sender, EventArgs e)
        {
            cxFlatButton1.BackColor = Color.FromArgb(221, 79, 67);
        }

        private void abrirformulario<MiForm>() where MiForm : Form, new()
        {
            Form fomulario;
            fomulario = panelfomularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (fomulario == null)
            {
                fomulario = new MiForm();
                fomulario.TopLevel = false;
                fomulario.FormBorderStyle = FormBorderStyle.None;
                fomulario.Dock = DockStyle.Fill;
                panelfomularios.Controls.Add(fomulario);
                panelfomularios.Tag = fomulario;
                fomulario.Show();
            }
            else
            {
                fomulario.BringToFront();
            }
        }

        private void cxFlatButton2_Click(object sender, EventArgs e)
        {
            abrirformulario<update>();
        }

        private void cxFlatButton3_Click(object sender, EventArgs e)
        {
            abrirformulario<status>();
        }

        private void cxFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mdi = new Menu();
            mdi.Show();
        }
    }
}
