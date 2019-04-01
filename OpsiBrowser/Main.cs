using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Data.OleDb;

namespace OpsiBrowser
{
    public partial class Main : MaterialForm
    {
        OleDbConnection cnnOpsi = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bin/database/opsi.accdb");
        OleDbConnection cnnUser = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bin/database/user.accdb");
        string homePage;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // program girişi mod seçim
            cnnUser.Open();
            OleDbCommand cmdMode = new OleDbCommand("select * from settings",cnnUser);
            OleDbDataReader readerMode = cmdMode.ExecuteReader();
            while (readerMode.Read())
            {
                if (readerMode["mode"].ToString() == "normal")
                {
                    NormalMode();
                }

                else if (readerMode["mode"].ToString() == "night")
                {
                    NightMode();
                }
            }
            cnnUser.Close();

            pnlSettings.Visible = false;

            //version from database
            cnnOpsi.Open();
            OleDbCommand cmdVersion = new OleDbCommand("select * from version", cnnOpsi);
            OleDbDataReader readerVersion = cmdVersion.ExecuteReader();
            while (readerVersion.Read())
            {
                lblVersion.ForeColor = Color.DarkGray;
                lblVersion.Text = readerVersion["version"].ToString();
            }
            cnnOpsi.Close();

            // giriş sayfası
            cnnUser.Open();
            OleDbCommand cmdHomePage = new OleDbCommand("select home_page from settings",cnnUser);
            OleDbDataReader readerHomePage = cmdHomePage.ExecuteReader();
            while (readerHomePage.Read())
            {
                webBrowser.Navigate(readerHomePage["home_page"].ToString());
            }
            cnnUser.Close();
        }

        // normal mod
        void NormalMode()
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey50, Primary.Orange500,
                Primary.Yellow900, Accent.Pink400,
                TextShade.BLACK
            );

            lblVersion.ForeColor = Color.DarkGray;

            this.BackColor = Color.White;

            pnlSettings.BackColor = Color.White;
        }

        // gece modu
        void NightMode()
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey800,
                Primary.Yellow900, Accent.Orange400,
                TextShade.WHITE
            );

            lblVersion.ForeColor = Color.White;

            this.BackColor = Color.DarkGray;

            pnlSettings.BackColor = Color.Gray;
        }
        
        // ayarlar butonu
        private void BttnSettings_Click(object sender, EventArgs e)
        {
            if (webBrowser.Visible == true && pnlSettings.Visible == false)
            {
                webBrowser.Visible = false;
                pnlSettings.Visible = true;
            }

            else if (webBrowser.Visible == false && pnlSettings.Visible == true)
            {
                webBrowser.Visible = true;
                pnlSettings.Visible = false;
            }

            // ayarlar bölümü home page kısmı
            cnnUser.Open();
            OleDbCommand cmdHomePage = new OleDbCommand("select home_page from settings",cnnUser);
            OleDbDataReader readerHomePage = cmdHomePage.ExecuteReader();
            while (readerHomePage.Read())
            {
                txtHomePage.Text = readerHomePage["home_page"].ToString()+" (geçerli)";
            }
            cnnUser.Close();
        }

        // ayarları kaydet butonu
        private void BttnSaveSettings_Click(object sender, EventArgs e)
        {
            cnnUser.Open();

            if (txtHomePage.Text.Length>3)
            {
                homePage = txtHomePage.Text;
                OleDbCommand cmdSave = new OleDbCommand("update settings set home_page=@home_page", cnnUser);
                cmdSave.Parameters.AddWithValue("@home_page", homePage);
                cmdSave.ExecuteNonQuery();
            }

            cnnUser.Close();
            MessageBox.Show("Ayarlar başarıyla kaydedildi.");
        }

        // mod değiştir seçeneği
        private void ChckNightMode_CheckedChanged(object sender, EventArgs e)
        {
            cnnUser.Open();
            if (chckNightMode.Checked == true)
            {
                NightMode();
                OleDbCommand cmd = new OleDbCommand("update settings set mode='night'", cnnUser);
                cmd.ExecuteNonQuery();
            }

            else if (chckNightMode.Checked == false)
            {
                NormalMode();
                OleDbCommand cmd = new OleDbCommand("update settings set mode='normal'", cnnUser);
                cmd.ExecuteNonQuery();
            }
            cnnUser.Close();
        }

        // adrese git butonu
        private void İmgGo_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length>3)
            {
                webBrowser.Navigate(txtSearch.Text);
            }

            else
            {
                webBrowser.Document.Write("<html><body><p style='text-align: center;'>EN AZ 3 KARAKTER GİRMELİSİNİZ!</p></body></html>");
            }
        }

        private void İmgHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(homePage);
        }
    }
}
