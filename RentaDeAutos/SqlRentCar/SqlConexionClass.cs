using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SqlRentCar
{
    public class SqlConexionClass
    {
        private SqlConnection connection;
    
        public SqlConexionClass()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-CTIDNPU\SQLEXPRESS;Initial Catalog=RENTCAR;Integrated Security=True");
        } 

        public DataTable FillTableCar()
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "SELECT * FROM Car";
                SqlDataReader dataReader;

                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                data.Load(dataReader);

                connection.Close();

                return data;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataTable TryConnection()
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "SELECT * FROM Purchase";
                SqlDataReader dataReader;

                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                
                data.Load(dataReader);

                connection.Close();

                return data;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
