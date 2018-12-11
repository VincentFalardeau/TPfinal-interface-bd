﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class SupprimerCircuitForm : Form
    {
        private ConnectionDAL mConnexionDAL;
        public SupprimerCircuitForm(string nomCircuit = "")
        {
            InitializeComponent();
            mConnexionDAL = ConnectionDAL.GetInstance();
            UpdateClbxCircuits(nomCircuit);

            if(clbxCircuits.CheckedItems.Count <= 0)
            {
                fbtnEffacer.Enabled = false;
            }
        }

        private void UpdateClbxCircuits(string nomCircuit = "")
        {
            try
            {
                string sql = "select nomcircuit from circuits";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                clbxCircuits.Items.Clear();

                while (oracleDataReader.Read())
                {
                    clbxCircuits.Items.Add(oracleDataReader.GetString(0));
                }

                oracleDataReader.Close();

                if(nomCircuit != "")
                {
                    clbxCircuits.SetItemChecked(clbxCircuits.Items.IndexOf(nomCircuit), true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void fbtnEffacer_Click(object sender, EventArgs e)
        {
            foreach(var item in clbxCircuits.CheckedItems.OfType<string>().ToList())
            {
                Effacer(item.ToString());
                clbxCircuits.Items.Remove(item);
            }
            MessageBox.Show("Circuits effacés avec succès!");
            UpdateClbxCircuits();
            
        }

        private void Effacer(string nomCircuit)
        {
            try
            {
                string sql = "delete circuits where nomcircuit = '" + nomCircuit + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                oracleCommand.ExecuteNonQuery();
                oracleCommand.Dispose();
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

        private void clbxCircuits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(clbxCircuits.CheckedItems.Count > 0)
            {
                fbtnEffacer.Enabled = true;
            }
            else
            {
                fbtnEffacer.Enabled = false;
            }
        }
    }

   
}
