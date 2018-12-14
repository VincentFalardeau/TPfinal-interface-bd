//Main form, projet final pour les cours:
//développement d'interfaces
//conception de bases de données
//
//Par Vincent Falardeau et Émile Ménard
//17 decembre 2018
//--------------------------------------------------------------
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
using System.Drawing.Drawing2D;

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

            Init_Controls();

        }

        private void Init_Controls()
        {
            FBTN_AddMonument.Visible = false;
            FBTN_AddMonument.Location = fbtnAjouter.Location;

            fbtnImage.Visible = false;
            fbtnImage.Location = fbtnModifier.Location;

            monumentToolStripMenuItem.Visible = false;
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
            if(!Properties.Settings.Default.DimensionsMain.IsEmpty)
            {
                this.Size = Properties.Settings.Default.DimensionsMain;
            }
            if (!Properties.Settings.Default.LocationMain.IsEmpty)
            {
                this.Location = Properties.Settings.Default.LocationMain;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DimensionsMain = this.Size;
            Properties.Settings.Default.LocationMain = this.Location;
            Properties.Settings.Default.Save();

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
            if (tabsControl.SelectedIndex == 0)
            {
                Ajouter();
            }
                
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
            if (tabsControl.SelectedIndex == 0)
            {
                Modifier();
            }
                


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
            if (tabsControl.SelectedIndex == 0)
            {
                Supprimer();
            }
        }

        private void fbtnEffacer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void Supprimer()
        {
            SupprimerMonumentForm scf = new SupprimerMonumentForm(dgvCircuits.CurrentRow.Cells[0].Value.ToString());
            scf.ShowDialog();
            UpdateDgvCircuits();
        }

        private void fbtnInformations_Click(object sender, EventArgs e)
        {
            VoirInfos();
        }

        private void voirInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabsControl.SelectedIndex == 0)
            {
                VoirInfos();
            }
               
        }

        private void VoirInfos()
        {
            InformationsCircuitForm icf = new InformationsCircuitForm(dgvCircuits.CurrentRow.Cells[0].Value.ToString());
            icf.ShowDialog();
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

        private void starsMonument_ValueChanged(object sender, EventArgs e)
        {
            if (cbxStarsMonument.Checked)
                UpdateDgvMonuments();
        }

        private void cbxStarsMonument_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDgvMonuments();
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
            if (tabsControl.SelectedIndex == 1)
            {
                AjouterUnMonument();
            }
        }

        private void FBTN_AddMonument_Click(object sender, EventArgs e)
        {
            AjouterUnMonument();
        }


        private void AjouterUnMonument()
        {
            AjouterMonumentForm ajoutMonument = new AjouterMonumentForm();
            if (ajoutMonument.ShowDialog() == DialogResult.OK)
            {
                Monument UnNouveauMonument = ajoutMonument.NouveauMonument;
                UpdateDgvMonuments();
            }
        }



        private void fbtnImage_Click(object sender, EventArgs e)
        {
            AfficherMonument();
        }

        private void afficherImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabsControl.SelectedIndex == 0)
            {
                AfficherMonument();
            }

        }

        private void AfficherMonument()
        {
            var Id = dgvMonuments.Rows[dgvMonuments.CurrentCell.RowIndex].Cells[5].Value.ToString();
            var Nom = dgvMonuments.Rows[dgvMonuments.CurrentCell.RowIndex].Cells[0].Value.ToString();
            AfficherImageMonument form = new AfficherImageMonument(Id, mConnexionDAL.GetConnexion());
            form.Text = Nom;
            form.ShowDialog();
        }

        private void dgvMonuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            UpdateDgvCircuitsMonuments();
        }

        private void dgvMonumentsCircuits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMonuments.CurrentRow.Selected = true;

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

       

      

        //--------------------------------------------------------------------------
        //
        //TabPage
        //
        //--------------------------------------------------------------------------



        private void TABPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsControl.SelectedIndex == 0)
            {

                monumentToolStripMenuItem.Visible = false;
                FBTN_AddMonument.Visible = false;
                fbtnImage.Visible = false;

                circuitToolStripMenuItem.Visible = true;
                fbtnAjouter.Visible = true;
                fbtnModifier.Visible = true;
                fbtnEffacer.Visible = true;
                fbtnInformations.Visible = true;

            }
            else if (tabsControl.SelectedIndex == 1)
            {
                monumentToolStripMenuItem.Visible = true;
                FBTN_AddMonument.Visible = true;
                fbtnImage.Visible = true;

                circuitToolStripMenuItem.Visible = false;
                fbtnAjouter.Visible = false;
                fbtnModifier.Visible = false;
                fbtnEffacer.Visible = false;
                fbtnInformations.Visible = false;

                UpdateDgvCircuitsMonuments();

            }
        }



        //--------------------------------------------------------------------------
        //
        //Aide / À propos
        //
        //--------------------------------------------------------------------------

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageAideOuAPropos pa = new PageAideOuAPropos(
               "Aide:" + '\t' + '\t' + '\t' + " Ctrl + A" + '\n' +
               '\n' +
               "Ajouter un circuit:" + '\t' + '\t' + " Alt + A" + '\n' +
               "Modifier un circuit:" + '\t' + '\t' + " Alt + M" + '\n' +
               "Supprimer un circuit:"  + '\t' + " Alt + S" + '\n' +
               "Voir infos circuit:" + '\t' + '\t' + " Alt + I" + '\n' +
               '\n' +
               "Ajouter un monument:" + '\t'  + " Alt + Shift + A" + '\n' +
               "Afficher photo monument:" + '\t' + " Alt+ Shift + I" + '\n' +
               '\n' +
               "À propos:" + '\t' + '\t' + '\t' + " Ctrl + I" + '\n', "Aide");

            pa.Show();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageAideOuAPropos pa = new PageAideOuAPropos(
              "Travail final" + '\n' + '\n' +
              "Réalisé par " + '\n' + '\n' +
              "Vincent Falardeau" + '\n' +
              "Émile Ménard" + '\n' + '\n' +
              "Pour le cours de développement d'interfaces" + '\n' +
              "et de conception de bases de données" + '\n' +
              "17 décembre 2018", "À propos");

            pa.Show();
        }

        //--------------------------------------------------------------------------
        //
        //Innovation
        //
        //--------------------------------------------------------------------------

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.White, Color.LightBlue, 0.5f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
