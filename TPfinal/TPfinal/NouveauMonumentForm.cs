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

        private ValidationProvider ValidationProvider;
        private string ImageLink = "";

        public NouveauMonumentForm()
        {
            InitializeComponent();
        }

        private void FBTN_AddImage_Click(object sender, EventArgs e)
        {
            MonumentImageForm form = new MonumentImageForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                ImageLink = form.ImageLink;
                PBX_Monument.Load(ImageLink);
              
            }
        }

        private void NouveauMonumentForm_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_Nom, ValiderNom);
            ValidationProvider.AddControlToValidate(TBX_Prix, ValiderPrix);
            ValidationProvider.AddControlToValidate(RTBX_Histoire, ValiderHistoire);
            ValidationProvider.AddControlToValidate(DATE_Monument, ValiderDate);
            ValidationProvider.AddControlToValidate(Control_Stars, ValiderStars);
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
            NouveauMonument = new Monument{
                Nom = TBX_Nom.Text,
                Prix = decimal.Parse(TBX_Prix.Text),
                Etoiles = Control_Stars.Value,
                DateConstruction = DATE_Monument.Value,
                Image = ImageLink,
                Histoire = RTBX_Histoire.Text
            };
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {

        }


        private bool ValiderNom(ref string message)
        {
            message = "Veuillez entrer le nom du monument";
            return TBX_Nom.Text != "" && TBX_Nom.Text != null;
        }

        private bool ValiderHistoire(ref string message)
        {
            message = "Veuillez entrer l'histoire";
            return RTBX_Histoire.Text != "" && RTBX_Histoire.Text != null;
        }

        private bool ValiderDate(ref string message)
        {
            message = "Veuillez entrer le nom du monument";
            return DATE_Monument.Text != "" && DATE_Monument.Text != null;
        }

        private bool ValiderPrix(ref string message)
        {
            message = "Veuillez entrer le prix du guide du circuit";
            return TBX_Prix.Text != "" && TBX_Prix.Text != null;
        }

        private bool ValiderStars(ref string message)
        {
            message = "Veuillez entrer le score du monument";
            return Control_Stars.Value != 0;
        }

        private void TBX_Prix_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
