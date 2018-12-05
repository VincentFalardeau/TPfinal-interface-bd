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


namespace TPfinal
{
    public partial class Form1 : Form
    {
        private ConnectionDAL mConnectionDAL;
        private DataSet mDataSet;
        public Form1()
        {
            InitializeComponent();
            Connecter();
            mDataSet = new DataSet();
        }

        private void Connecter()
        {
            try
            {
                mConnectionDAL = ConnectionDAL.GetInstance();
                mConnectionDAL.Connecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Deconnecter()
        {
            try
            {
                mConnectionDAL.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add("Test");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TABPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TABS_Controls.SelectedIndex == 0)
            {
                Console.Write("Page 1");

            } else if(TABS_Controls.SelectedIndex == 1)
            {
                Console.Write("Page 2");
            }
        }
    }
}
