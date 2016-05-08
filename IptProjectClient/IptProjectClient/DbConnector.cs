using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IptProjectClient
{
    class DbConnector
    {
        String status;
        String DataSource, uid, pwd, InitialCatalog;



        public DbConnector()
        {
            string ip = System.IO.File.ReadAllText(@"D:\Desktop Backup\Bitbucket\IptProjectClient\IptProjectClient\bin\Debug\ip.txt");

            this.DataSource = "Data Source = '.';";   //192.168.0.100
            this.uid = "uid = ambala;";
            this.pwd = "pwd = fast123;";
            this.InitialCatalog = "Initial Catalog = ProjectInfo;";
        }    



        public String statusTeller()
        {
            return status;
        }



        public void Connector()
        {
            //using (SqlConnection con = ConnectionOpen())
            SqlConnection con = ConnectionOpen();
            // {

            try
            {

                // Check the connection state

                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    status = "Connected";
                    ConnectionClose(con);
                }

                else
                {
                    status = "Connection Failed";
                }

            }

            catch (Exception ex)
            {
                DateTime saveNow = DateTime.Now;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Desktop Backup\Bitbucket\IptProjectClient\IptProjectClient\bin\Debug\IPTLogs.txt", true))
                {
                    file.WriteLine(Environment.NewLine + saveNow.ToString() + Environment.NewLine + ex.Message);
                }

            }
            //}

        }



        private string ConnectionString()
        {

            // Create SQL Server 2005 connection string, change the credentials here

            StringBuilder strConn = new StringBuilder();
            strConn.Append(DataSource);
            strConn.Append(uid);
            strConn.Append(pwd);
            strConn.Append(InitialCatalog);
            return strConn.ToString();
        }



        private SqlConnection ConnectionOpen()
        {
            return new SqlConnection(ConnectionString().ToString());
        }



        private void ConnectionClose(SqlConnection xConnection)
        {
            xConnection.Close();
            xConnection.Dispose();
        }



        public DataTable tableGenerator(string _Query)
        {
            SqlDataAdapter sqlAdapter;
            DataTable sqlTable = new DataTable();
            sqlAdapter = new SqlDataAdapter(_Query, ConnectionOpen());
            sqlAdapter.Fill(sqlTable);
            return sqlTable;
        }



        public void InsertRecord(string _Query)
        {
            //using (SqlConnection con = ConnectionOpen())
            SqlConnection con = ConnectionOpen();
            // {

            try
            {

                // Check the connection state

                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    status = "Connected";
                    //ConnectionClose(con);
                    SqlCommand cmd = new SqlCommand(_Query, con);
                    cmd.ExecuteNonQuery();
                    
                }

                else
                {
                    status = "Connection Failed";
                }

            }

            catch (Exception ex)
            {
                DateTime saveNow = DateTime.Now;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Desktop Backup\Bitbucket\IptProjectClient\IptProjectClient\bin\Debug\IPTLogs.txt", true))
                {
                    file.WriteLine(Environment.NewLine + saveNow.ToString() + Environment.NewLine + ex.Message);
                }
            }
            //}
        }

        public SqlDataReader GetRecord(string _Query)
        {
            //using (SqlConnection con = ConnectionOpen())
            SqlConnection con = ConnectionOpen();
            SqlDataReader reader;
            

            try
            {

                // Check the connection state
                
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    status = "Connected";
                    //ConnectionClose(con);
                    SqlCommand cmd = new SqlCommand(_Query, con);
                   
                    reader = cmd.ExecuteReader();
                    return reader;    
                }

                else
                {
                    status = "Connection Failed";
                    reader = null;
                    return reader;
                }
                

            }

            catch (Exception ex)
            {
                DateTime saveNow = DateTime.Now;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Desktop Backup\Bitbucket\IptProjectClient\IptProjectClient\bin\Debug\IPTLogs.txt", true))
                {
                    file.WriteLine(Environment.NewLine + saveNow.ToString() + Environment.NewLine + ex.Message);
                }
                reader = null;
                return reader;
            }
            
        }
        public int TotalRecord(string _Query)
        {
            //using (SqlConnection con = ConnectionOpen())
            SqlConnection con = ConnectionOpen();
            int total = 0;

            try
            {

                // Check the connection state

                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    status = "Connected";
                    //ConnectionClose(con);
                    SqlCommand cmd = new SqlCommand(_Query, con);
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                    
                }

                else
                {
                    status = "Connection Failed";
                }
                return total;
            }

            catch (Exception ex)
            {
                DateTime saveNow = DateTime.Now;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Desktop Backup\Bitbucket\IptProjectClient\IptProjectClient\bin\Debug\IPTLogs.txt", true))
                {
                    file.WriteLine(Environment.NewLine + saveNow.ToString() + Environment.NewLine + ex.Message);
                }
                return total;
            }
            //}
        }
    }

}
