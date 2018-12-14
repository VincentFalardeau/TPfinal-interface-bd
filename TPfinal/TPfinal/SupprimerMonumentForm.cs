//Dialogue qui permet la supression de monuments dans un circuits
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


namespace TPfinal
{
    
    public partial class SupprimerMonumentForm : Form
    {
        private ConnectionDAL mConnexionDAL;
        public SupprimerMonumentForm(string nomCircuit)
        {
            InitializeComponent();
            mConnexionDAL = ConnectionDAL.GetInstance();
            InitCbxCircuits(nomCircuit);

            if (clbxMonuments.CheckedItems.Count <= 1)
            {
                fbtnEffacer.Enabled = false;
            }
        }

        private void SupprimerMonumentForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LocationSuppCircuit.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationSuppCircuit;
            }
        }

        private void SupprimerMonumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationSuppCircuit = this.Location;
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

                if (nomCircuit != "")
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
            UpdateClbxMonuments();
        }

        private void UpdateClbxMonuments()
        {
            try
            {
                string sql = "select nom from vue_circuit_monument_1 where nomcircuit = '" + cbxCircuits.Text + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                clbxMonuments.Items.Clear();


                while (oracleDataReader.Read())
                {
                    clbxMonuments.Items.Add(oracleDataReader.GetString(0));
                }

                clbxMonuments.SelectedIndex = 0;

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

        private void fbtnEffacer_Click(object sender, EventArgs e)
        {
            var confirmer = MessageBox.Show("Êtes-vous certain de vouloir effacer ces monuments de ce circuit?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmer == DialogResult.Yes)
            {
                foreach (var item in clbxMonuments.CheckedItems.OfType<string>().ToList())
                {
                    Effacer(item.ToString());
                    clbxMonuments.Items.Remove(item);
                }
                MessageBox.Show("Circuits effacés avec succès!");
            }
                
            UpdateClbxMonuments();

        }

        private void Effacer(string nomMonument)
        {
            try
            {
                string sql = "delete from circuitsmonuments where idmonument = (select idmonument from monuments where nom = '" + nomMonument + "' ) and idcircuit = (select idcircuit from circuits where nomcircuit = '" + cbxCircuits.Text +"')";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                oracleCommand.ExecuteNonQuery();
                oracleCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void clbxMonuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbxMonuments.CheckedItems.Count > 0 && clbxMonuments.CheckedItems.Count < clbxMonuments.Items.Count)
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
