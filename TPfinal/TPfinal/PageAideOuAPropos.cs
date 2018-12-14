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
    public partial class PageAideOuAPropos : Form
    {
        public PageAideOuAPropos(string textRtb, string textPage)
        {
            
            InitializeComponent();
            richTextBox1.Text = textRtb;
            this.Text = textPage;
        }

        private void PageAideOuAPropos_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LocationAideAPropos.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationAideAPropos;
            }
        }

        private void PageAide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                
                this.Close();
                
            }
        }

        private void SaveLocation(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationAideAPropos = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
