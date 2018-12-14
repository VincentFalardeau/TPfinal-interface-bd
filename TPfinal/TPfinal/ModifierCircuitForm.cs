//Dialogue qui permet de modifier le prix d'un circuit
//
//Par Vincent Falardeau et Émile Ménard
//17 decembre 2018
//--------------------------------------------------------------

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
            mValidationProvider.AddControlToValidate(nudNvPrix, nudNvPrix_Valider);

            mConnexionDAL = ConnectionDAL.GetInstance();

            UpdateCbxCircuits(nomCircuit);
        }

        private void ModifierCircuitForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LocationModCircuit.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationModCircuit;
            }
        }

        private void ModifierCircuitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationModCircuit = this.Location;
            Properties.Settings.Default.Save();
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


        //--------------------------------------------------------------------------
        //
        //Innovation
        //
        //--------------------------------------------------------------------------

        private void ModifierCircuitForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.White, Color.LightBlue, 0.5f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
