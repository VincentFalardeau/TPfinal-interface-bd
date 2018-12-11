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
using System.Net;

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

            FBTN_AddMonument.Visible = false;
            FBTN_AddMonument.Location = fbtnAjouter.Location;

            fbtnImage.Visible = false;
            fbtnImage.Location = fbtnModifier.Location;

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

                //Ordonner par etoiles, puis cacher la colonne           
                dgvCircuits.Sort(dgvCircuits.Columns[4], ListSortDirection.Descending);
                if(cbxMonument.Text != "" || cbxVille.Text != "" || cbxPrix.Checked)
                {
                    dgvCircuits.Columns[4].Visible = false;
                }
                else
                {
                    dgvCircuits.Columns[4].Visible = true;
                }

                mOda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string TrouverSqlPourUpdateDvgCircuit()
        {
            string sql = "select distinct nom, depart, arrivee, prix, etoiles from vue_circuit_monument";
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
                    sql = "select distinct nom, depart, arrivee, prix from vue_circuit_monument where nom_monument = '" + cbxMonument.Text + "'";

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

        private void fbtnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void Ajouter()
        {
            AjouterCircuitForm acf = new AjouterCircuitForm();
            if (acf.ShowDialog() == DialogResult.OK)
            {
                AjouterCircuit(acf.mNom, acf.mVilleDepart, acf.mVilleArrivee, acf.mPrix, acf.mListeMonuments);
                MessageBox.Show("Circuit ajouté avec succès!");
            }
        }

        private void AjouterCircuit(string nom, string villeDepart, string villeArrivee, double prix, List<string> listeMonuments)
        {
            try
            {
                string sql = "insert into circuits values(sqCircuits.nextval, :codevilledépart,:codevillearrivée, :nomcircuit, :prix, 1, 10)";

                OracleParameter paramVilleDepart = new OracleParameter(":codevilledépart", OracleDbType.Char, 3);
                OracleParameter paramVilleArrivee = new OracleParameter(":codevillearrivée", OracleDbType.Char, 3);
                OracleParameter paramNom = new OracleParameter(":nomcircuit", OracleDbType.Varchar2, 20);
                OracleParameter paramPrix = new OracleParameter(":prix", OracleDbType.Double, 8);

                paramVilleDepart.Value = ObtenirIdVille(villeDepart);
                paramVilleArrivee.Value = ObtenirIdVille(villeArrivee);
                paramNom.Value = nom;
                paramPrix.Value = prix;

                OracleCommand commande = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                commande.CommandType = CommandType.Text;

                commande.Parameters.Add(paramVilleDepart);
                commande.Parameters.Add(paramVilleArrivee);
                commande.Parameters.Add(paramNom);
                commande.Parameters.Add(paramPrix);

                commande.ExecuteNonQuery();

                commande = new OracleCommand(sql, mConnexionDAL.GetConnexion());

                int i = 1;
                int idmonument;
                //Creation des enregistrements dans circuits_monuments
                foreach (string nommonument in listeMonuments)
                {
                    idmonument = ObtenirIdMonument(nommonument);
                    sql = "insert into circuitsmonuments values (" + idmonument + ", sqCircuits.currval, " + i + ")";
                    commande = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                    commande.ExecuteNonQuery();
                    i++;
                }

                UpdateDgvCircuits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        private int ObtenirIdVille(string nomVille)
        {
            int id = 0;
            try
            {
                string sql = "select codeville from villes where nomville = '"+ nomVille  + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();
                id = Int32.Parse(oracleDataReader.GetString(0));

                oracleDataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return id;
        }

        private int ObtenirIdMonument(string nommonument)
        {
            int id = 0;
            try
            {
                string sql = "select idmonument from monuments where nom = '" + nommonument + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();
                id = Int32.Parse(oracleDataReader.GetDecimal(0).ToString());

                oracleDataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return id;
        }

        private void fbtnModifier_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier();


        }

        private void Modifier()
        {
            ModifierCircuitForm mcf = new ModifierCircuitForm(dgvCircuits.CurrentRow.Cells[0].Value.ToString());
            if (mcf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Prix modifié avec succès!");
                UpdateCircuit(mcf.mNomCircuit, mcf.mPrix);
            }
        }

        

        private void UpdateCircuit(object nomCircuit, double prix)
        {
            try
            {
                string sql = "update circuits set prix = " + prix + " where nomcircuit = '" + nomCircuit + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                oracleCommand.ExecuteNonQuery();
                oracleCommand.Dispose();

                UpdateDgvCircuits();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void fbtnEffacer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void Supprimer()
        {
            SupprimerCircuitForm scf = new SupprimerCircuitForm();
            scf.ShowDialog();
            UpdateDgvCircuits();
        }

        private void fbtnInformations_Click(object sender, EventArgs e)
        {
            VoirInfos();
        }

        private void voirInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoirInfos();
        }

        private void VoirInfos()
        {
            InformationsCircuitForm icf = new InformationsCircuitForm(dgvCircuits.CurrentRow.Cells[0].Value.ToString());
            icf.ShowDialog();
        }

        private void dgvCircuits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCircuits.CurrentRow.Selected = true;
        }


        //--------------------------------------------------------------------------
        //
        //Monuments
        //
        //--------------------------------------------------------------------------

        Image getImageFromUrl(string url )
        {


            var request = WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
               return System.Drawing.Image.FromStream(stream);
            }
        }

        private void UpdateDgvMonuments()
        {
            dgvMonuments.Rows.Clear();
            dgvMonumentsCircuits.Rows.Clear();
            try
            {

                string sql;

                if (cbxStarsMonument.Checked)
                {
                  sql = "SELECT NOM, DATECONSTRUCTION, HISTOIRE, PRIX, ETOILES, IDMONUMENT FROM MONUMENTS WHERE ETOILES =" + starsMonument.Value.ToString();
                }
                else
                {
                  sql = "SELECT NOM, DATECONSTRUCTION, HISTOIRE, PRIX, ETOILES, IDMONUMENT FROM MONUMENTS";
                }

            
                OracleDataAdapter oda = new OracleDataAdapter(sql, mConnexionDAL.GetConnexion());
                OracleCommand cmd = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleReader = cmd.ExecuteReader();
                while (oracleReader.Read())
                {

                        dgvMonuments.Rows.Add(oracleReader.GetString(0), oracleReader.GetDateTime(1).ToString("dd-MM-yyyy"), oracleReader.GetString(2), oracleReader.GetDecimal(3).ToString(), oracleReader.GetInt32(4).ToString(), oracleReader.GetInt32(5).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void STRIP_AjouterMonument_Click(object sender, EventArgs e)
        {
            AjouterUnMonument();
        }

        private void FBTN_AddMonument_Click(object sender, EventArgs e)
        {
            AjouterUnMonument();
        }


        private void AjouterUnMonument()
        {
            NouveauMonumentForm ajoutMonument = new NouveauMonumentForm();
            if (ajoutMonument.ShowDialog() == DialogResult.OK)
            {
                Monument UnNouveauMonument = ajoutMonument.NouveauMonument;
                UpdateDgvMonuments();
            }
        }

        private void dgvMonuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (dgvMonuments.CurrentCell.ColumnIndex == 0)
        //    {
        //        foreach (DataGridViewRow row in dgvMonuments.Rows)
        //        {
        //            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
        //            if (chk.Value == chk.TrueValue)
        //            {
        //                chk.Value = chk.FalseValue;
        //            }
        //        }

        //        DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dgvMonuments.CurrentCell;

        //        bool isChecked = (bool)checkbox.EditedFormattedValue;


        //        var Id = dgvMonuments.Rows[dgvMonuments.CurrentCell.RowIndex].Cells[6].Value;


        //        dgvMonumentsCircuits.Rows.Clear();

        //        try
        //        {
        //            string sql = "SELECT NOMCIRCUIT, ORDRESURCIRCUIT FROM ODREDANSCIRCUIT  WHERE IDMONUMENT = " + Id.ToString();
        //            OracleCommand cmd = new OracleCommand(sql, mConnexionDAL.GetConnexion());
        //            OracleDataReader oracleReader = cmd.ExecuteReader();
        //            while (oracleReader.Read())
        //            {

        //                dgvMonumentsCircuits.Rows.Add(oracleReader.GetString(0), oracleReader.GetInt32(1).ToString());
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message.ToString());
        //        }

        //    }
        //    else if (dgvMonuments.CurrentCell.ColumnIndex == 6)
        //    {
               

        //    }

        }

        private void fbtnImage_Click(object sender, EventArgs e)
        {
            var Id = dgvMonuments.Rows[dgvMonuments.CurrentCell.RowIndex].Cells[5].Value.ToString();
            var Nom = dgvMonuments.Rows[dgvMonuments.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ImageMonument form = new ImageMonument(Id, mConnexionDAL.GetConnexion());
            form.Text = Nom;
            form.ShowDialog();
        }

        private void dgvMonuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMonuments.CurrentRow.Selected = true;

            UpdateDgvCircuitsMonuments();
         
            

        }

        private void UpdateDgvCircuitsMonuments()
        {
            int Id = Int32.Parse(dgvMonuments.CurrentRow.Cells[5].Value.ToString());


            dgvMonumentsCircuits.Rows.Clear();

            try
            {
                string sql = "SELECT NOMCIRCUIT, ORDRESURCIRCUIT FROM ODREDANSCIRCUIT  WHERE IDMONUMENT = " + Id;
                OracleCommand cmd = new OracleCommand(sql, mConnexionDAL.GetConnexion());
                OracleDataReader oracleReader = cmd.ExecuteReader();
                while (oracleReader.Read())
                {

                    dgvMonumentsCircuits.Rows.Add(oracleReader.GetString(0), oracleReader.GetInt32(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvMonumentsCircuits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMonuments.CurrentRow.Selected = true;

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

                FBTN_AddMonument.Visible = false;
                fbtnImage.Visible = false;

                fbtnAjouter.Visible = true;
                fbtnModifier.Visible = true;
                fbtnEffacer.Visible = true;
                fbtnInformations.Visible = true;

            }
            else if (tabsControl.SelectedIndex == 1)
            {

                FBTN_AddMonument.Visible = true;
                fbtnImage.Visible = true;

                fbtnAjouter.Visible = false;
                fbtnModifier.Visible = false;
                fbtnEffacer.Visible = false;
                fbtnInformations.Visible = false;

            }
        }

        private void starsMonument_ValueChanged(object sender, EventArgs e)
        {
            if(cbxStarsMonument.Checked)
             UpdateDgvMonuments();
        }

        private void cbxStarsMonument_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDgvMonuments();
        }

        
    }
}
