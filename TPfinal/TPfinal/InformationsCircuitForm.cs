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
    }
}
