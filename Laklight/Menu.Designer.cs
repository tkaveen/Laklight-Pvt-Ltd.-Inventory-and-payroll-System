namespace Laklight
{
    partial class Menu
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
            this.cxFlatSimpleButton1 = new CxFlatUI.CxFlatSimpleButton();
            this.cxFlatSimpleButton2 = new CxFlatUI.CxFlatSimpleButton();
            this.cxFlatSimpleButton3 = new CxFlatUI.CxFlatSimpleButton();
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
            this.materialTabSelector3.TabIndex = 9;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // cxFlatSimpleButton1
            // 
            this.cxFlatSimpleButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatSimpleButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatSimpleButton1.Location = new System.Drawing.Point(370, 337);
            this.cxFlatSimpleButton1.Name = "cxFlatSimpleButton1";
            this.cxFlatSimpleButton1.Size = new System.Drawing.Size(279, 149);
            this.cxFlatSimpleButton1.TabIndex = 13;
            this.cxFlatSimpleButton1.Text = "Inventory Management";
            this.cxFlatSimpleButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatSimpleButton1.Click += new System.EventHandler(this.cxFlatSimpleButton1_Click);
            // 
            // cxFlatSimpleButton2
            // 
            this.cxFlatSimpleButton2.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatSimpleButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatSimpleButton2.Location = new System.Drawing.Point(771, 337);
            this.cxFlatSimpleButton2.Name = "cxFlatSimpleButton2";
            this.cxFlatSimpleButton2.Size = new System.Drawing.Size(279, 149);
            this.cxFlatSimpleButton2.TabIndex = 14;
            this.cxFlatSimpleButton2.Text = "Payroll System";
            this.cxFlatSimpleButton2.TextColor = System.Drawing.Color.White;
            this.cxFlatSimpleButton2.Click += new System.EventHandler(this.cxFlatSimpleButton2_Click);
            // 
            // cxFlatSimpleButton3
            // 
            this.cxFlatSimpleButton3.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatSimpleButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatSimpleButton3.Location = new System.Drawing.Point(1172, 337);
            this.cxFlatSimpleButton3.Name = "cxFlatSimpleButton3";
            this.cxFlatSimpleButton3.Size = new System.Drawing.Size(279, 149);
            this.cxFlatSimpleButton3.TabIndex = 15;
            this.cxFlatSimpleButton3.Text = "Add New User";
            this.cxFlatSimpleButton3.TextColor = System.Drawing.Color.White;
            this.cxFlatSimpleButton3.Click += new System.EventHandler(this.cxFlatSimpleButton3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.cxFlatSimpleButton3);
            this.Controls.Add(this.cxFlatSimpleButton2);
            this.Controls.Add(this.cxFlatSimpleButton1);
            this.Controls.Add(this.materialTabSelector3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private CxFlatUI.CxFlatSimpleButton cxFlatSimpleButton1;
        private CxFlatUI.CxFlatSimpleButton cxFlatSimpleButton2;
        private CxFlatUI.CxFlatSimpleButton cxFlatSimpleButton3;
    }
}