//Dialogue qui permet d'ajouter un circuit à la BD
//
//Par Vincent Falardeau et Émile Ménard
//17 decembre 2018
//--------------------------------------------------------------

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
using Validation;

namespace TPfinal
{
    
    public partial class AjouterCircuitForm : Form
    {
        public string mNom;
        public string mVilleDepart;
        public string mVilleArrivee;
        public double mPrix;
        public List<string> mListeMonuments;

        private List<string> mListeNoms;

        private ConnectionDAL mConnexionDAL;
        private ValidationProvider mValidationProvider;

        public AjouterCircuitForm()
        {
            InitializeComponent();

            mValidationProvider = new ValidationProvider(this);
            InitValidationProvider();

            mConnexionDAL = ConnectionDAL.GetInstance();

            LoadListeNoms();
            InitCbxDepartArrivee();
            InitListToutMonuments();
        }

        private void AjouterCircuitForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LocationAjoutCircuit.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationAjoutCircuit;
            }
        }

        private void AjouterCircuitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationAjoutCircuit = this.Location;
            Properties.Settings.Default.Save();
        }



        private void InitValidationProvider()
        {
            mValidationProvider.AddControlToValidate(nudPrix, nudPrix_Valider);
            mValidationProvider.AddControlToValidate(tbxNom, tbxNom_Valider);
            mValidationProvider.AddControlToValidate(lbxMonuments, lbxMonuments_Valider);
        }

       

        //--------------------------------------------------------------------------
        //
        //Nom
        //
        //--------------------------------------------------------------------------

        private bool tbxNom_Valider(ref string message)
        {
            message = "Ce nom existe déjà";

            if (tbxNom.Text == "")
            {
                message = "Il doit y avoir un nom";
            }

            return tbxNom.Text != "" && EstUnique(tbxNom.Text);
        }

        private bool EstUnique(string nom)
        {
            bool unique = true;
            foreach(string nomExistant in mListeNoms)
            {
                if(nom == nomExistant)
                {
                    unique = false;
                    break;
                }
            }
            return unique;
        }

        private void LoadListeNoms()
        {
            try
            {
                mListeNoms = new List<string>();
                string sql = "select nomcircuit from circuits";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                while (oracleDataReader.Read())
                {
                    mListeNoms.Add(oracleDataReader.GetString(0));
                }

                oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //--------------------------------------------------------------------------
        //
        //Depart / Arrivee
        //
        //--------------------------------------------------------------------------

        private void InitCbxDepartArrivee()
        {

            try
            {
                string sql = "select nomville from villes";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                string ville = "";

                while (oracleDataReader.Read())
                {
                    ville = oracleDataReader.GetString(0);
                    cbxDepart.Items.Add(ville);
                    cbxArrivee.Items.Add(ville);
                }

                cbxDepart.SelectedIndex = 0;
                cbxArrivee.SelectedIndex = 0;

                oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //--------------------------------------------------------------------------
        //
        //Prix
        //
        //--------------------------------------------------------------------------
        private bool nudPrix_Valider(ref string message)
        {
            message = "Il doit y avoir un prix";
            return nudPrix.Text != "" && nudPrix.Text != null;
        }

        //--------------------------------------------------------------------------
        //
        //Monuments
        //
        //--------------------------------------------------------------------------
        private void InitListToutMonuments()
        {
            try
            {
                string sql = "select nom from monuments";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                while (oracleDataReader.Read())
                {
                    cbxMonuments.Items.Add(oracleDataReader.GetString(0));
                }

                oracleDataReader.Close();

                if (cbxMonuments.Items.Count > 0)
                {
                    cbxMonuments.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private bool lbxMonuments_Valider(ref string message)
        {
            message = "Un circuit doit comporter minimalement un monument";
            return lbxMonuments.Items.Count > 0;
        }

        private void fbtnAjouterMonument_Click(object sender, EventArgs e)
        {
            AjouterMonument();
        }

        private void AjouterMonument()
        {
            lbxMonuments.Items.Add(cbxMonuments.Text);
            cbxMonuments.Items.Remove(cbxMonuments.SelectedItem);
            if(cbxMonuments.Items.Count > 0)
            {
                fbtnAjouterMonument.Enabled = true;
                cbxMonuments.SelectedIndex = 0;
            }
            //si on a ajoute tout les monuments possibles
            else
            {
                fbtnAjouterMonument.Enabled = false;
            }

        }

        private void fbtnEffacerMonument_Click(object sender, EventArgs e)
        {
            cbxMonuments.Items.Add(lbxMonuments.Text);
            lbxMonuments.Items.Remove(lbxMonuments.SelectedItem);
            fbtnAjouterMonument.Enabled = true;
            if (cbxMonuments.Items.Count > 0)
            {
                cbxMonuments.SelectedIndex = 0;
            }
            if(lbxMonuments.Items.Count > 0)
            {
                lbxMonuments.SelectedIndex = 0;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormToDialog();
        }

        private void FormToDialog()
        {
            mListeMonuments = new List<string>();

            if (nudPrix.Text != "")
            {
                mNom = tbxNom.Text;
                mVilleDepart = cbxDepart.Text;
                mVilleArrivee = cbxArrivee.Text;
                mPrix = Double.Parse(nudPrix.Value.ToString());
                foreach (string monument in lbxMonuments.Items)
                {
                    mListeMonuments.Add(monument);
                }
            }
           
        }

        private void lbxMonuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxMonuments.SelectedItem != null)
            {
                fbtnEffacerMonument.Enabled = true;
            }
            else
            {
                fbtnEffacerMonument.Enabled = false;
            }
           
        }

        //--------------------------------------------------------------------------
        //
        //Innovation
        //
        //--------------------------------------------------------------------------

        private void AjouterCircuitForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.White, Color.LightBlue, 0.5f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
