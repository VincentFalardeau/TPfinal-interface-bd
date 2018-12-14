using DB_Images_Utilities;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPfinal
{
    public partial class AfficherImageMonument : Form
    {
        private DB_Images DB_Images;
        bool FullScreen = false;
        public AfficherImageMonument(string id, OracleConnection connection)
        {
            InitializeComponent();
            DB_Images = new DB_Images("Emile", "Salut123");
            try
            {
                string sql = "SELECT IMAGE FROM MONUMENTS WHERE IDMONUMENT = " + id;
                OracleCommand cmd = new OracleCommand(sql, connection);
                OracleDataReader oracleReader = cmd.ExecuteReader();
                while (oracleReader.Read())
                {

                    PBX_Image.BackgroundImage = DB_Images.Find(oracleReader.GetString(0));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void ImageMonument_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { 
                case Keys.F11: Toggle_FullScreen(); break;
                case Keys.Escape: this.Close(); break;
            }
        }

        private void Toggle_FullScreen()
        {
            FullScreen = !FullScreen;

            if (FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
