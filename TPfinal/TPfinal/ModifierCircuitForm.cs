﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Validation;

namespace TPfinal
{
    public partial class ModifierCircuitForm : Form
    {
        public string mNomCircuit;
        public double mPrix;

        private ConnectionDAL mConnexionDAL;
        private ValidationProvider mValidationProvider;
        public ModifierCircuitForm(string nomCircuit = "")
        {
            InitializeComponent();

            mValidationProvider = new ValidationProvider(this);
            mValidationProvider.AddControlToValidate(nudNvPrix, nudNvPrix_Valider);

            mConnexionDAL = ConnectionDAL.GetInstance();

            UpdateCbxCircuits(nomCircuit);
        }

       

        private void UpdateCbxCircuits(string nomCircuit = "")
        {
            try
            {
                string sql = "select nomcircuit from circuits";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                cbxCircuits.Items.Clear();

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
            try
            {
                string sql = "select prix from circuits where nomcircuit = '" + cbxCircuits.Text + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();

                tbxPrix.Text = oracleDataReader.GetDouble(0).ToString();

                oracleDataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private bool nudNvPrix_Valider(ref string message)
        {
            message = "Il doit y avoir un prix!";

            return nudNvPrix.Text != "";
        }

       
        

        private void btnModifier_Click(object sender, EventArgs e)
        {
            mNomCircuit = cbxCircuits.Text;
            if(nudNvPrix.Text != "")
            {
                mPrix = Double.Parse(nudNvPrix.Value.ToString());
            }
            
        }
    }
}
