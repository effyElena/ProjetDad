using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class CL_CAD
    {
        string m_connectionString = null;
        private SqlConnection sqlConnexion;
        private string bddServer;
        private string bddBase;
        private string bddLogin;
        private string bddMdp;

        public CL_CAD()
        {
            this.bddServer = "10.33.126.116";
            //this.bddServer = "192.168.1.78";
            this.bddBase = "ProjetDAD";
            this.bddLogin = "root";
            this.bddMdp = "azerty";

            this.m_connectionString = "Data Source=" + this.bddServer + ";Initial Catalog=" + this.bddBase + ";User ID=" + this.bddLogin + ";Password=" + this.bddMdp;
        }

        private void connection()
        {
            this.m_connectionString = null;
            this.m_connectionString = "Data Source=" + this.bddServer + ";Initial Catalog=" + this.bddBase + ";User ID=" + this.bddLogin + ";Password=" + this.bddMdp;
            this.sqlConnexion = new SqlConnection(m_connectionString);

            try
            {

                sqlConnexion.Open();
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
            if (sqlConnexion.State.ToString() == "Open")
            {
                try
                {
                    sqlConnexion.Close();
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
                sqlConnexion = null;
#if _debug
               Debug.WriteLine("state of the connection is null");
#endif
            }
        }
        
        public object[][] executeSql(string sql)
        {
            this.connection();
            SqlCommand sqlCommand = new SqlCommand(sql, this.sqlConnexion );
            object[][] data = new object[100][];

            using (IDataReader reader = sqlCommand.ExecuteReader())
            {
                int j = 0;
                while (reader.Read())
                {
                    data[j] = new object[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data[j][i] = reader.GetValue(i);

                    }
                    j++;

                }
            }
            
            this.deconnection();
            return data;
        }

    }
    
}