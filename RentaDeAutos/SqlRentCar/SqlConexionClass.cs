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

        public void InsertData(DateTime DateStart,DateTime DateEnd,Double Amount,string Name, string Cel, string Address, string LastName ,int Id)
        {
            try
            {
                connection.Open();

                SqlCommand command;
                string sql = "INSERT INTO Purchase (DateStart,DateEnd,Amount,Name,Cel,AddressP,LastName,CarID) values (@DateStart,@DateEnd,@Amount,@Name,@Cel,@Address,@LastName,@Id)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@DateStart", DateStart);
                command.Parameters.AddWithValue("@DateEnd", DateEnd);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Cel", Cel);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
