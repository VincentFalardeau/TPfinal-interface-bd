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
        private ConnectionDAL mConnexionDAL;
        private DataSet mDataSetCircuits;
        private DataSet mDataSetMonuments;
        private OracleDataAdapter mOda;

        public MainForm()
        {
            InitializeComponent();

            Connecter();

            mDataSetCircuits = new DataSet();
            mDataSetMonuments = new DataSet();
            mOda = new OracleDataAdapter();

            UpdateData();

        }

        private void UpdateData()
        {
            UpdateDgvCircuits();
            UpdateDgvMonuments();
            UpdateCbxVilleDepart();
            UpdateCbxMonument();
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
                mConnexionDAL = ConnectionDAL.GetInstance();
                mConnexionDAL.Connecter();
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
                mConnexionDAL.Deconnecter();
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
                string sql = TrouverSqlPourUpdateDvgCircuit();
                mOda.SelectCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());


                //Eviter qu'il se remplisse a l'infini
                if (mDataSetCircuits.Tables.Contains("listeCircuits"))
                {
                    mDataSetCircuits.Tables["listeCircuits"].Clear();
                }

                //Remplir le DataSet
                mOda.Fill(mDataSetCircuits, "listeCircuits");

                //Lier dgvCircuits
                dgvCircuits.DataSource = new BindingSource(mDataSetCircuits, "listeCircuits");

                mOda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string TrouverSqlPourUpdateDvgCircuit()
        {
            string sql = "select * from vue_circuit_5";
            try
            {
                if (cbxVille.Text != "" && cbxMonument.Text == "")
                {
                    sql = sql + " where depart = '" + cbxVille.Text + "'";

                    if (cbxPrix.Checked)
                    {
                        sql = sql + " and prix <= " + nudPrix.Value;
                    }
                }
                else if (cbxMonument.Text != "")
                {

                    sql = "select nom, depart, arrivee, prix from vue_circuit_6 where nom_monument = '" + cbxMonument.Text + "'";

                    if (cbxVille.Text != "")
                    {
                        sql = sql + " and depart = '" + cbxVille.Text + "'";
                    }
                    if (cbxPrix.Checked)
                    {
                        sql = sql + " and prix <= " + nudPrix.Value;
                    }

                }
                else
                {
                    if (cbxPrix.Checked)
                    {
                        sql = sql + " where prix <= " + nudPrix.Value;
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return sql;
        }

        private void UpdateCbxVilleDepart()
        {

            try
            {
                string sql = "select nomville from villes";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                cbxVille.Items.Clear();

                cbxVille.Items.Add("");

                while (oracleDataReader.Read())
                {
                    cbxVille.Items.Add(oracleDataReader.GetString(0));
                }

                oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UpdateCbxMonument()
        {
            try
            {
                string sql = "select nom from monuments";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                cbxMonument.Items.Clear();

                cbxMonument.Items.Add("");

                while (oracleDataReader.Read())
                {
                    cbxMonument.Items.Add(oracleDataReader.GetString(0));
                }

                oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDgvCircuits();
        }

        private void cbxMonument_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDgvCircuits();
        }

        private void cbxPrix_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDgvCircuits();
        }

        private void nudPrix_ValueChanged(object sender, EventArgs e)
        {
            if (cbxPrix.Checked)
            {
                UpdateDgvCircuits();
            }

        }

        private void dgvCircuits_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dgvCircuits_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Premet de valider le prix
            dgvCircuits.CurrentRow.ErrorText = "";
            double prix;

            if (!dgvCircuits.CurrentRow.IsNewRow && dgvCircuits.CurrentCellAddress.X == 3)
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out prix) || prix <= 50 || prix.ToString().Length > 6)
                {
                    e.Cancel = true;
                    dgvCircuits.CurrentRow.ErrorText = "Erreur, doit être un nombre supérieur ou égal à 50";

                }
            }
        }

        private void dgvCircuits_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nomCircuit = dgvCircuits.CurrentRow.Cells[0].Value.ToString();

                if (!dgvCircuits.CurrentRow.IsNewRow && dgvCircuits.CurrentCellAddress.X == 3)
                {
                    double prix = double.Parse(dgvCircuits.CurrentRow.Cells[3].Value.ToString());
                    string sql = "UPDATE circuits SET prix = " + prix + " where nomcircuit = '" + nomCircuit + "'";
                    OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                    oracleCommand.ExecuteNonQuery();
                    oracleCommand.Dispose();

                    MessageBox.Show("Prix édité avec succès");

                    UpdateDgvCircuits();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        

        private void dgvCircuits_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dgvCircuits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Permet d'éditer seulement le prix
            if (dgvCircuits.CurrentRow != null)
            {
                dgvCircuits.CurrentRow.ReadOnly = true;
                if (!dgvCircuits.CurrentRow.IsNewRow && dgvCircuits.CurrentCellAddress.X == 3)
                {
                    dgvCircuits.CurrentRow.Cells[3].ReadOnly = false;
                }
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
                string sql = "select * from vue_monument_1";
                OracleDataAdapter oda = new OracleDataAdapter(sql, mConnexionDAL.GetConnexion());


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
            if (tabsControl.SelectedIndex == 0)
            {
                Console.Write("Page 1");

            }
            else if (tabsControl.SelectedIndex == 1)
            {
                Console.Write("Page 2");
            }
        }

        
    }
}
