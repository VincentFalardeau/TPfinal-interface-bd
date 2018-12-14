//Dialogue qui les informations d'un circuit
//
//Par Vincent Falardeau et Émile Ménard
//17 decembre 2018
//--------------------------------------------------------------
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
    public partial class InformationsCircuitForm : Form
    {
        private ConnectionDAL mConnexionDAL;
        private DB_Images DB_Images;
        public InformationsCircuitForm(string nomCircuit = "", bool fixedMode = false)
        {
            InitializeComponent();
            mConnexionDAL = ConnectionDAL.GetInstance();
            DB_Images = new DB_Images("Emile", "Salut123");
            InitCbxCircuits(nomCircuit);
            if(fixedMode)
            {
                cbxCircuits.Enabled = false;
                this.Text = "Meilleur circuit";
            }

        }

        private void InformationsCircuitForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LocationInfosCircuit.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationInfosCircuit;
            }
        }

        private void InformationsCircuitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationInfosCircuit = this.Location;
            Properties.Settings.Default.Save();
        }

        private void InitCbxCircuits(string nomCircuit = "")
        {
            try
            {
                string sql = "select nomcircuit from circuits";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                while (oracleDataReader.Read())
                {
                    cbxCircuits.Items.Add(oracleDataReader.GetString(0));
                }

                oracleDataReader.Close();

                if(nomCircuit != "")
                {
                    cbxCircuits.SelectedIndex = cbxCircuits.Items.IndexOf(nomCircuit);
                }
                else
                {
                    cbxCircuits.SelectedIndex = 0;
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbxCircuits_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLbxMonuments();
        }

        private void UpdateLbxMonuments()
        {
            try
            {
                string sql = "select nom from vue_circuit_monument_1 where nomcircuit = '" + cbxCircuits.Text + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                lbxMonuments.Items.Clear();
               

                while (oracleDataReader.Read())
                {
                    lbxMonuments.Items.Add(oracleDataReader.GetString(0));
                }

                lbxMonuments.SelectedIndex = 0;

                oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbxMonuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRtbInfos();
            UpdatePxbImage();
        }

        private void UpdatePxbImage()
        {
            try
            {
                string sql = "SELECT IMAGE FROM MONUMENTS WHERE nom = '" + lbxMonuments.Text + "'";
                OracleCommand cmd = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleReader = cmd.ExecuteReader();
                while (oracleReader.Read())
                {
                    Image image = DB_Images.Find(oracleReader.GetString(0));

                    if (image != null)
                        pbxMonument.BackgroundImage = image;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UpdateRtbInfos()
        {
            try
            {
                string sql = "select nom, prix, dateconstruction, histoire, etoiles from monuments where nom = '" + lbxMonuments.Text + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();
                rtbInfos.Text = lbxMonuments.SelectedIndex + 1 + " " + oracleDataReader.GetString(0) + " - " + oracleDataReader.GetDouble(1) + "$" + "\n";
                rtbInfos.Text += "Construit le " + oracleDataReader.GetDateTime(2).ToShortDateString() + "\n";
                rtbInfos.Text += oracleDataReader.GetString(3);
                starsMonument.Value = Int32.Parse(oracleDataReader.GetDecimal(4).ToString());

               oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //--------------------------------------------------------------------------
        //
        //Innovation
        //
        //--------------------------------------------------------------------------

        private void InformationsCircuitForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.White, Color.LightSkyBlue, 0.5f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
