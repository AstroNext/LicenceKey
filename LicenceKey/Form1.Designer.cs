namespace LicenceKey
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtday = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtserial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lbl_cr = new MetroFramework.Controls.MetroLabel();
            this.lbl_day = new MetroFramework.Controls.MetroLabel();
            this.lbl_seph = new MetroFramework.Controls.MetroLabel();
            this.lbl_hash = new MetroFramework.Controls.MetroLabel();
            this.lbl_ex = new MetroFramework.Controls.MetroLabel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 73);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Day :";
            // 
            // txtday
            // 
            this.txtday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtday.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtday.Location = new System.Drawing.Point(74, 72);
            this.txtday.Margin = new System.Windows.Forms.Padding(10);
            this.txtday.Name = "txtday";
            this.txtday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtday.Size = new System.Drawing.Size(122, 23);
            this.txtday.TabIndex = 1;
            this.txtday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile1.Location = new System.Drawing.Point(74, 116);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(10);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(164, 23);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Generate Licence";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_password.Location = new System.Drawing.Point(309, 72);
            this.txt_password.Margin = new System.Windows.Forms.Padding(10);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.Size = new System.Drawing.Size(233, 23);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(216, 73);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Password :";
            // 
            // txtserial
            // 
            this.txtserial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtserial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtserial.Location = new System.Drawing.Point(74, 159);
            this.txtserial.Margin = new System.Windows.Forms.Padding(10);
            this.txtserial.Name = "txtserial";
            this.txtserial.ReadOnly = true;
            this.txtserial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtserial.Size = new System.Drawing.Size(425, 23);
            this.txtserial.TabIndex = 6;
            this.txtserial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 159);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Serial :";
            // 
            // metroTile2
            // 
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile2.Location = new System.Drawing.Point(258, 116);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(10);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(134, 23);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Check Validate";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile3.Location = new System.Drawing.Point(408, 116);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(10);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(134, 23);
            this.metroTile3.TabIndex = 7;
            this.metroTile3.Text = "Refresh";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 199);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Creation date : ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(459, 199);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Day :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(216, 199);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Expier Date  : ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(17, 239);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Secret Phase :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(42, 279);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(44, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Hash :";
            // 
            // lbl_cr
            // 
            this.lbl_cr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cr.AutoSize = true;
            this.lbl_cr.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_cr.Location = new System.Drawing.Point(134, 199);
            this.lbl_cr.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_cr.Name = "lbl_cr";
            this.lbl_cr.Size = new System.Drawing.Size(15, 19);
            this.lbl_cr.TabIndex = 35;
            this.lbl_cr.Text = "-";
            this.lbl_cr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_day
            // 
            this.lbl_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_day.AutoSize = true;
            this.lbl_day.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_day.Location = new System.Drawing.Point(513, 199);
            this.lbl_day.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(15, 19);
            this.lbl_day.TabIndex = 36;
            this.lbl_day.Text = "-";
            this.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_seph
            // 
            this.lbl_seph.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_seph.AutoSize = true;
            this.lbl_seph.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_seph.Location = new System.Drawing.Point(134, 239);
            this.lbl_seph.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_seph.Name = "lbl_seph";
            this.lbl_seph.Size = new System.Drawing.Size(15, 19);
            this.lbl_seph.TabIndex = 37;
            this.lbl_seph.Text = "-";
            this.lbl_seph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hash
            // 
            this.lbl_hash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_hash.Location = new System.Drawing.Point(134, 279);
            this.lbl_hash.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(15, 19);
            this.lbl_hash.TabIndex = 38;
            this.lbl_hash.Text = "-";
            this.lbl_hash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ex
            // 
            this.lbl_ex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ex.AutoSize = true;
            this.lbl_ex.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_ex.Location = new System.Drawing.Point(325, 199);
            this.lbl_ex.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_ex.Name = "lbl_ex";
            this.lbl_ex.Size = new System.Drawing.Size(15, 19);
            this.lbl_ex.TabIndex = 39;
            this.lbl_ex.Text = "-";
            this.lbl_ex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile4
            // 
            this.metroTile4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile4.Location = new System.Drawing.Point(519, 158);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(10);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(25, 25);
            this.metroTile4.TabIndex = 5;
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile5.Location = new System.Drawing.Point(89, 279);
            this.metroTile5.Margin = new System.Windows.Forms.Padding(10);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(25, 25);
            this.metroTile5.TabIndex = 40;
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(576, 317);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.lbl_ex);
            this.Controls.Add(this.lbl_hash);
            this.Controls.Add(this.lbl_seph);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.lbl_cr);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LicenceKey";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtday;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtserial;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lbl_cr;
        private MetroFramework.Controls.MetroLabel lbl_day;
        private MetroFramework.Controls.MetroLabel lbl_seph;
        private MetroFramework.Controls.MetroLabel lbl_hash;
        private MetroFramework.Controls.MetroLabel lbl_ex;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}

