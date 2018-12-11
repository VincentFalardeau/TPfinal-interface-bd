
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
using Validation;

namespace TPfinal
{
    public partial class NouveauMonumentForm : Form
    {

        public Monument NouveauMonument;


        private ConnectionDAL DAL;
        private ValidationProvider ValidationProvider;
        private Image Image;
        List<string> mListeNoms;

        private DB_Images DB_Images;

        public NouveauMonumentForm()
        {
            InitializeComponent();

            DAL = ConnectionDAL.GetInstance();

            LoadListeNoms();
        }

        private void FBTN_AddImage_Click(object sender, EventArgs e)
        {
           
           
        }

        private void NouveauMonumentForm_Load(object sender, EventArgs e)
        {
            DB_Images = new DB_Images("Emile", "Salut123");

            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_Nom, ValiderNom);
            ValidationProvider.AddControlToValidate(tbxPrix, ValiderPrix);
            ValidationProvider.AddControlToValidate(RTBX_Histoire, ValiderHistoire);
            ValidationProvider.AddControlToValidate(DATE_Monument, ValiderDate);
            ValidationProvider.AddControlToValidate(Control_Stars, ValiderStars);
        }

        private void LoadListeNoms()
        {
            try
            {
                mListeNoms = new List<string>();
                string sql = "select nom from monuments";
                OracleCommand oracleCommand = new OracleCommand(sql, DAL.GetConnexion());
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

        

        private void BTN_Accepter_Click(object sender, EventArgs e)
        {

             if(TBX_Nom.Text != "" && TBX_Nom.Text != null 
                &&
                RTBX_Histoire.Text != "" && RTBX_Histoire.Text != null
                &&
                DATE_Monument.Text != "" && DATE_Monument.Text != null
                &&
                DATE_Monument.Text != "" && DATE_Monument.Text != null
                && Control_Stars.Value != 0)
            {


                NouveauMonument = new Monument
                {
                    Nom = TBX_Nom.Text,
                    Prix = decimal.Parse(tbxPrix.Text),
                    Etoiles = Control_Stars.Value,
                    DateConstruction = DATE_Monument.Value,
                    Image = DB_Images.Add(Image),
                    Histoire = RTBX_Histoire.Text
                };
               SaveData(NouveauMonument);
            }
        
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValiderNom(ref string message)
        {
            message = "Ce nom existe déjà";

            if (TBX_Nom.Text == "")
            {
                message = "Il doit y avoir un nom";
            }

            return TBX_Nom.Text != "" && EstUnique(TBX_Nom.Text);
        }

        private bool EstUnique(string nom)
        {
            bool unique = true;
            foreach (string nomExistant in mListeNoms)
            {
                if (nom == nomExistant)
                {
                    unique = false;
                    break;
                }
            }
            return unique;
        }

        private bool ValiderHistoire(ref string message)
        {
            message = "Il doit y avoir une histoire";
            return RTBX_Histoire.Text != "" && RTBX_Histoire.Text != null;
        }

        private bool ValiderDate(ref string message)
        {
            message = "Il doit y avoir une date";
            return DATE_Monument.Text != "" && DATE_Monument.Text != null;
        }

        private bool ValiderPrix(ref string message)
        {
            message = "Il doit y avoir un prix";
            return tbxPrix.Text != "" && tbxPrix.Text != null;
        }

        private bool ValiderStars(ref string message)
        {
            //message = "Il doit y avoir un nombre d'étoiles";
            //return Control_Stars.Value != 0;
            return true;
        }


        private void SaveData(Monument monument)
        {

            try
            {

                string sql = "insert into monuments values (sqMonuments.nextval, :monument_nom, :monument_date, :monument_histoire, :monument_image, :monument_prix, :monument_etoiles)";

                OracleParameter ParamNom = new OracleParameter(":monument_nom", OracleDbType.Varchar2, 30);
                OracleParameter ParamDate = new OracleParameter(":monument_date", OracleDbType.Date);
                OracleParameter ParamHistoire = new OracleParameter(":monument_histoire", OracleDbType.Varchar2, 100);
                OracleParameter ParamImage = new OracleParameter(":monument_image", OracleDbType.Varchar2, 300);
                OracleParameter ParamPrix = new OracleParameter(":monument_prix", OracleDbType.Decimal, 6);
                OracleParameter ParamEtoiles = new OracleParameter(":monument_etoiles", OracleDbType.Int32, 1);
 


                ParamNom.Value = monument.Nom;
                ParamDate.Value = monument.DateConstruction;
                ParamHistoire.Value = monument.Histoire;
                ParamEtoiles.Value = monument.Etoiles;
                ParamPrix.Value = monument.Prix;
                ParamImage.Value = monument.Image;

                OracleCommand commande = new OracleCommand(sql, DAL.GetConnexion());
                commande.CommandType = CommandType.Text;


                commande.Parameters.Add(ParamNom);
                commande.Parameters.Add(ParamDate);
                commande.Parameters.Add(ParamHistoire);
                commande.Parameters.Add(ParamImage);
                commande.Parameters.Add(ParamPrix);
                commande.Parameters.Add(ParamEtoiles);


                commande.ExecuteNonQuery();

            }
            catch (Exception)
            {

                MessageBox.Show("Il y a eu une erreur en ajoutant les données à la base de donnée!");
            }


        }

        private void PBX_Monument_BackgroundImageChanged(object sender, EventArgs e)
        {
            Image = PBX_Monument.BackgroundImage;
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
