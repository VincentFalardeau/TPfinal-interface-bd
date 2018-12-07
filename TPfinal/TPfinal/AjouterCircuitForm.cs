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
        }

       

        private void InitValidationProvider()
        {
            mValidationProvider.AddControlToValidate(tbxPrix, tbxPrix_Valider);
            mValidationProvider.AddControlToValidate(tbxNom, tbxNom_Valider);
        }

        //--------------------------------------------------------------------------
        //
        //Nom
        //
        //--------------------------------------------------------------------------

        private bool tbxNom_Valider(ref string message)
        {
            message = "Ce nom existe déjà";

            if (tbxPrix.Text == "")
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
        //Prix
        //
        //--------------------------------------------------------------------------
        private bool tbxPrix_Valider(ref string message)
        {
            message = "Le prix doit être supérieur ou égal à 50";

            if (tbxPrix.Text == "")
            {
                message = "Il doit y avoir un prix!";
            }

            return tbxPrix.Text != "" && Double.Parse(tbxPrix.Text) >= 50;
        }

        private void tbxPrix_Keyress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar))
            {
                //Donne la position du premier char point
                int indexPoint = tbxPrix.Text.IndexOf('.');
                //Si le char est un nombre
                if (char.IsDigit(e.KeyChar))
                {
                    //Si indexPoint n'est pas égal à -1, il y a déjà un point
                    //Si indexPoint <   tbxNvPrix.SelectionStart(ce qui donne la position courante), 
                    //le point est à gauche du curseur, 
                    //donc on ne peut pas ajouter plus de 2 caractères après cela
                    if (indexPoint != -1 && indexPoint < tbxPrix.SelectionStart && tbxPrix.Text.Substring(indexPoint + 1).Length >= 2)
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
                    e.Handled = e.KeyChar != '.' || indexPoint != -1 || tbxPrix.Text.Length == 0 || tbxPrix.SelectionStart + 2 < tbxPrix.Text.Length;
                }
            }
        }
    }
}
