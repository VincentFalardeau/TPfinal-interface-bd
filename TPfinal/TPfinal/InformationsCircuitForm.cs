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
        public InformationsCircuitForm()
        {
            InitializeComponent();
            mConnexionDAL = ConnectionDAL.GetInstance();
            InitCbxCircuits();
        }

        private void InitCbxCircuits()
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

                cbxCircuits.SelectedIndex = 0;
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

                    pbxMonument.Load(oracleReader.GetString(0));
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
    }
}
