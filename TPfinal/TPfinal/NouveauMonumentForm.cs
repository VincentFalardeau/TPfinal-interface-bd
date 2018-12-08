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
    public partial class NouveauMonumentForm : Form
    {


        public string ImageLink = "";


        public NouveauMonumentForm()
        {
            InitializeComponent();
        }

        private void FBTN_AddImage_Click(object sender, EventArgs e)
        {
            MonumentImageForm form = new MonumentImageForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(form.ImageLink);
              
            }
        }



    }
}
