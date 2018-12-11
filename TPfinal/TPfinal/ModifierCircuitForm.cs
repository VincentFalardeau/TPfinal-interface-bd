using System;
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
            mValidationProvider.AddControlToValidate(tbxNvPrix, tbxNvPrix_Valider);

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

        private bool tbxNvPrix_Valider(ref string message)
        {
            message = "Le prix doit être supérieur ou égal à 50";

            if (tbxNvPrix.Text == "")
            {
                message = "Il doit y avoir un prix!";
            }
           
            return tbxNvPrix.Text != "" && Double.Parse(tbxNvPrix.Text) >= 50;
        }

        private void tbxNvPrix_Keyress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar))
            {
                //Donne la position du premier char point
                int indexPoint = tbxNvPrix.Text.IndexOf('.');
                //Si le char est un nombre
                if (char.IsDigit(e.KeyChar))     
                {
                    //Si indexPoint n'est pas égal à -1, il y a déjà un point
                    //Si indexPoint <   tbxNvPrix.SelectionStart(ce qui donne la position courante), 
                    //le point est à gauche du curseur, 
                    //donc on ne peut pas ajouter plus de 2 caractères après cela
                    if (indexPoint != -1 &&  indexPoint < tbxNvPrix.SelectionStart && tbxNvPrix.Text.Substring(indexPoint + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                //Si ce n'est pas un nombre
                else
                {
                    //On ne peut pas l'accepter si ce n'est pas un point, 
                    //s'il y a déjà un point, 
                    //Si c'est le premier char, 
                    //si il y a déjà 2 nombres après le point
                    e.Handled = e.KeyChar != '.' || indexPoint != -1 || tbxNvPrix.Text.Length == 0 || tbxNvPrix.SelectionStart + 2 < tbxNvPrix.Text.Length;
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            mNomCircuit = cbxCircuits.Text;
            if(tbxNvPrix.Text != "")
            {
                mPrix = Double.Parse(tbxNvPrix.Text);
            }
            
        }
    }
}
