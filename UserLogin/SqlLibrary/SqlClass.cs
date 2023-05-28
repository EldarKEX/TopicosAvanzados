using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace SqlLibrary
{
    public class SqlClass
    {
        private SqlConnection sqlConnection;
        private string database;
        public SqlClass()
        {
            
        }

        public SqlClass(string server, string dataBase, string user, string password)
        {
            database = dataBase;
            sqlConnection = new SqlConnection(ConnectionString(server, dataBase, user, password));
        }

        public string ConnectionString(string server,string dataBase, string user, string password)
        {
            string sql = $"Data Source={server};Initial Catalog={dataBase};User Id={user};Password={password};";
            return sql;
        }

        public bool TryConnection()
        {
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion, datos incorrectos");
                return false;
            }
        }

        public DataTable GetSelectedTable(string table)
        {
            try
            {
                sqlConnection.Open();

                string query = "SELECT * FROM " + table;

                SqlCommand command;

                command = new SqlCommand(query,sqlConnection);

                SqlDataReader dataReader = command.ExecuteReader();


                DataTable data = new DataTable();
                data.Load(dataReader);

                sqlConnection.Close();

                return data;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion, datos incorrectos");
                return null;
            }
        }

        public DataTable GetAllTable()
        {
            try
            {
                sqlConnection.Open();

                DataTable dataTable = sqlConnection.GetSchema("Tables");

                sqlConnection.Close();

                return dataTable;
            

            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion, datos incorrectos");
                return null;
            }
        }

    }
}
