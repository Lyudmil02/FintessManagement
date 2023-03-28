using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessProject.Database
{
    class MYDB
    {
        //the connection
        private SqlConnection sqlConnection = new SqlConnection
            (@"Data Source=DESKTOP-5RI515C\SQLEXPRESS01;Initial Catalog=Fitness;Integrated Security=True");

        //func to open a connection
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //func to close a connection
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //func to return connection
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        //func to return a table of data
        public DataTable getData(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //func to set data and execute a query
        public int setData(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            OpenConnection();

            int commandState = command.ExecuteNonQuery();

            CloseConnection();
            
            return commandState;
        }

    }
}
