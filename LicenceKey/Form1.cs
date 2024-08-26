using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceKey
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hash;
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtday.Text) && 
                !string.IsNullOrEmpty(txt_password.Text))
            {
                try
                {
                    if (Convert.ToInt32(txtday.Text) <= 999)
                    {
                        hash = GetMd5Hash(txt_password.Text);
                        SKGL.Generate generator = new SKGL.Generate();
                        generator.secretPhase = hash;
                        txtserial.Text = generator.doKey(Convert.ToInt32(txtday.Text));
                    }
                    else
                    {
                        MessageBox.Show("Day Should Be Between 1 - 999", "Error");
                    }
                }
                catch (Exception ext)
                {
                    MessageBox.Show($"{ext.Message}");
                    txtday.ResetText();
                    txt_password.ResetText();
                    txtserial.ResetText();
                    lbl_seph.Text = "-";
                    lbl_hash.Text = "-";
                    lbl_day.Text = ".";
                    lbl_ex.Text = ".";
                    lbl_cr.Text = ".";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtserial.Text))
            {
                try
                {
                    SKGL.Validate validate = new SKGL.Validate();
                    validate.secretPhase = hash;
                    validate.Key = txtserial.Text;

                    lbl_cr.Text = validate.CreationDate.ToString("yyyy/MM/dd");
                    lbl_ex.Text = validate.ExpireDate.ToString("yyyy/MM/dd");
                    lbl_day.Text = validate.DaysLeft.ToString();

                    lbl_seph.Text = validate.secretPhase;
                    lbl_hash.Text = hash;
                }
                catch (Exception ext)
                {
                    MessageBox.Show(ext.Message);
                }
            }
            
            
        }
        static string GetMd5Hash(string input)//converter
        {
            using (MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] vs = mD5.ComputeHash(uTF8.GetBytes(input));
                return Convert.ToBase64String(vs);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtday.ResetText();
            txt_password.ResetText();
            txtserial.ResetText();
            lbl_seph.Text = "-";
            lbl_hash.Text = "-";
            lbl_day.Text = "-";
            lbl_ex.Text = "-";
            lbl_cr.Text = "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtserial.Text))
            Clipboard.SetText(txtserial.Text);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_hash.Text))
                Clipboard.SetText(lbl_hash.Text);
        }
    }
}
