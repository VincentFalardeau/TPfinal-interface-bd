﻿using Oracle.ManagedDataAccess.Client;
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

        public MainForm()
        {
            InitializeComponent();

            Connecter();

            mDataSetCircuits = new DataSet();
            mDataSetMonuments = new DataSet();

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
                OracleDataAdapter oda = new OracleDataAdapter(sql, mConnexionDAL.GetConnexion());


                //Eviter qu'il se remplisse a l'infini
                if (mDataSetCircuits.Tables.Contains("listeCircuits"))
                {
                    mDataSetCircuits.Tables["listeCircuits"].Clear();
                }

                //Remplir le DataSet
                oda.Fill(mDataSetCircuits, "listeCircuits");

                //Lier dgvCircuits
                dgvCircuits.DataSource = new BindingSource(mDataSetCircuits, "listeCircuits");

                oda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string TrouverSqlPourUpdateDvgCircuit()
        {
            string sql = "select * from vue_circuit_2";
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
                   
                    sql = "select nom, depart, arrivee, prix from vue_circuit_3 where nom_monument = '" + cbxMonument.Text + "'";

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
            if(cbxPrix.Checked)
            {
                UpdateDgvCircuits();
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
