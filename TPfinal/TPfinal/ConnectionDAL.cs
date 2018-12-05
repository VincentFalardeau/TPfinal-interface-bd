//DAL pour la connection à la BD
//
//Par Vincent Falardeau
//22 novembre 2018
//--------------------------------------------------------------

using System;
using Oracle.ManagedDataAccess.Client;

namespace TPfinal
{
    class ConnectionDAL
    {
       
        private OracleConnection mConnexion;
        private static ConnectionDAL smInstance;

        private ConnectionDAL ()
        {
            mConnexion = new OracleConnection();
        }

        public static ConnectionDAL GetInstance()
        {
            if (smInstance == null)
            {
                smInstance = new ConnectionDAL();
            }

            return smInstance;
        }

        public string GetState()
        {
            return mConnexion.State.ToString();
        }

        public  OracleConnection GetConnexion()
        {
            return mConnexion;
        }
        public void Connecter()
        {
            try
            {
                string dsource = "(DESCRIPTION="
                     + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                     + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                     + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                string chaineDeConnexion = "Data Source = " + dsource + "; User Id = FALARDEA; password = ORACLE1";

                mConnexion.ConnectionString = chaineDeConnexion;
                mConnexion.Open();

                //Change le format de date pour cette session
                string sql = "alter session set nls_date_format = 'DD-MM-YYYY'";
                OracleCommand mOracleCommand = new OracleCommand(sql, mConnexion);
                mOracleCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void  Deconnecter()
        {
            try
            {
                mConnexion.Close();
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }

       
    }
}
