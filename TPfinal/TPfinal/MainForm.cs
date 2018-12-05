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
using Oracle.ManagedDataAccess.Types;


namespace TPfinal
{
    public partial class MainForm : Form
    {
        private ConnectionDAL mConnectionDAL;
        private DataSet mDataSetCircuits;
        private DataSet mDataSetMonuments;

        public MainForm()
        {
            InitializeComponent();

            Connecter();

            mDataSetCircuits = new DataSet();
            mDataSetMonuments = new DataSet();

            UpdateDgvCircuits();
            UpdateDgvMonuments();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Deconnecter();
        }

        //--------------------------------------------------------------------------
        //
        //Connexion/Deconnexion
        //
        //--------------------------------------------------------------------------

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
        }

        //--------------------------------------------------------------------------
        //
        //Circuits
        //
        //--------------------------------------------------------------------------
        private void UpdateDgvCircuits()
        {
            try
            {
                string sql = "select * from circuits";
                OracleDataAdapter oda = new OracleDataAdapter(sql, mConnectionDAL.GetConnexion());


                //Eviter qu'il se remplisse a l'infini
                if (mDataSetCircuits.Tables.Contains("listeCircuits"))
                {
                    mDataSetCircuits.Tables["listeCircuits"].Clear();
                }

                //Remplir le DataSet
                oda.Fill(mDataSetCircuits, "listeCircuits");

                //Vider le dgv
                dgvCircuits.Rows.Clear();

                //Lier dgvCircuits
                dgvCircuits.DataSource = new BindingSource(mDataSetCircuits, "listeCircuits");

                oda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //--------------------------------------------------------------------------
        //
        //Monuments
        //
        //--------------------------------------------------------------------------
        private void UpdateDgvMonuments()
        {
            try
            {
                string sql = "select * from monuments";
                OracleDataAdapter oda = new OracleDataAdapter(sql, mConnectionDAL.GetConnexion());


                //Eviter qu'il se remplisse a l'infini
                if (mDataSetMonuments.Tables.Contains("listeMonuments"))
                {
                    mDataSetMonuments.Tables["listeMonuments"].Clear();
                }

                //Remplir le DataSet
                oda.Fill(mDataSetMonuments, "listeMonuments");

                //Vider le dgv
                dgvMonuments.Rows.Clear();

                //Lier dgvCircuits
                dgvMonuments.DataSource = new BindingSource(mDataSetMonuments, "listeMonuments");

                oda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //--------------------------------------------------------------------------
        //
        //Tests
        //
        //--------------------------------------------------------------------------
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TABPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabsControl.SelectedIndex == 0)
            {
                Console.Write("Page 1");

            } else if(tabsControl.SelectedIndex == 1)
            {
                Console.Write("Page 2");
            }
        }

       
    }
}
