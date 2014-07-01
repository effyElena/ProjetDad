using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class CL_CAD
    {
        string m_connectionString = null;

        public string getConnexionString()
        {
            return m_connectionString;
        }

        private SqlConnection m_cnn;
        private SqlDataReader return1;
        private string bddServer;
        private string bddBase;
        private string bddLogin;
        private string bddMdp;

        public CL_CAD()
        {
            //this.bddServer = 
            //this.bddBase = 


            //this.bddLogin = 
            //this.bddMdp = 


            this.m_connectionString = "Data Source=" + this.bddServer + ";Initial Catalog=" + this.bddBase + ";User ID=" + this.bddLogin + ";Password=" + this.bddMdp;
        }

        private void connection()
        {
            this.m_connectionString = null;
            this.m_connectionString = "Data Source=" + this.bddServer + ";Initial Catalog=" + this.bddBase + ";User ID=" + this.bddLogin + ";Password=" + this.bddMdp;
            this.m_cnn = new SqlConnection(m_connectionString);

            try
            {

                m_cnn.Open();
#if _debug
                Debug.WriteLine("Connection established");
#endif
            }
            catch (Exception ex)
            {
#if _debug
                Debug.WriteLine("Can not open connection !");
                Debug.WriteLine("Reason: "+ ex);
#endif
            }
        }
        private void deconnection()
        {
            if (m_cnn.State.ToString() == "Open")
            {
                try
                {
                    m_cnn.Close();
#if _debug
                   Debug.WriteLine("Connection close");
#endif
                }
                catch (Exception ex)
                {
#if _debug
                   Debug.WriteLine("Error while disconnecting: " + ex);
#endif
                }

            }
            else
            {
                m_cnn = null;
#if _debug
               Debug.WriteLine("state of the connection is null");
#endif
            }
        }

        public void executeProcedure(SqlCommand commande)
        {
            this.connection();
            commande.Connection = m_cnn;
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                commande.ExecuteNonQuery();
#if _debug
               Debug.WriteLine("Procedure launched");
#endif
            }
            catch (Exception ex)
            {
#if _debug
               Debug.WriteLine("Error while procedure launch:" + ex);
#endif
            }
            this.deconnection();
        }

    }
    
}