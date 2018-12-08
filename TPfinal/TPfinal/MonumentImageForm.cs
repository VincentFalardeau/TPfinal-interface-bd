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
    public partial class MonumentImageForm : Form
    {
        public string ImageLink = ""; 
        private ValidationProvider ValidationProvider;

        public MonumentImageForm()
        {
            InitializeComponent();
           
        }


        private bool ValiderImage(ref string message)
        {
            message = "Erreur, l'image est invalide";
            bool valide = true;
            try
            {
                PBX_Dummy.Load(TBX_NewImage.Text);
            }
            catch (Exception)
            {

                valide = false;
            }
            if (valide)
                ImageLink = TBX_NewImage.Text;

            return valide;
        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            ImageLink = TBX_NewImage.Text;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void MonumentImageForm_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_NewImage, ValiderImage);
        }
    }
}
