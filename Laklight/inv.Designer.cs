namespace Laklight
{
    partial class inv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.panelfomularios = new System.Windows.Forms.Panel();
            this.cxFlatButton3 = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatButton4 = new CxFlatUI.Controls.CxFlatButton();
            this.SuspendLayout();
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = null;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(1921, 29);
            this.materialTabSelector3.TabIndex = 0;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton1.Location = new System.Drawing.Point(5, 98);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(228, 54);
            this.cxFlatButton1.TabIndex = 5;
            this.cxFlatButton1.Text = "Add Inventory";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.cxFlatButton1_Click);
            // 
            // panelfomularios
            // 
            this.panelfomularios.Location = new System.Drawing.Point(242, 100);
            this.panelfomularios.Name = "panelfomularios";
            this.panelfomularios.Size = new System.Drawing.Size(1667, 975);
            this.panelfomularios.TabIndex = 7;
            // 
            // cxFlatButton3
            // 
            this.cxFlatButton3.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton3.Location = new System.Drawing.Point(5, 158);
            this.cxFlatButton3.Name = "cxFlatButton3";
            this.cxFlatButton3.Size = new System.Drawing.Size(228, 54);
            this.cxFlatButton3.TabIndex = 8;
            this.cxFlatButton3.Text = "Status";
            this.cxFlatButton3.TextColor = System.Drawing.Color.White;
            this.cxFlatButton3.Click += new System.EventHandler(this.cxFlatButton3_Click);
            // 
            // cxFlatButton4
            // 
            this.cxFlatButton4.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton4.Location = new System.Drawing.Point(5, 218);
            this.cxFlatButton4.Name = "cxFlatButton4";
            this.cxFlatButton4.Size = new System.Drawing.Size(228, 54);
            this.cxFlatButton4.TabIndex = 9;
            this.cxFlatButton4.Text = "Home";
            this.cxFlatButton4.TextColor = System.Drawing.Color.White;
            this.cxFlatButton4.Click += new System.EventHandler(this.cxFlatButton4_Click);
            // 
            // inv
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.cxFlatButton4);
            this.Controls.Add(this.cxFlatButton3);
            this.Controls.Add(this.panelfomularios);
            this.Controls.Add(this.cxFlatButton1);
            this.Controls.Add(this.materialTabSelector3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "inv";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.inv_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
        private System.Windows.Forms.Panel panelfomularios;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton3;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton4;
    }
}