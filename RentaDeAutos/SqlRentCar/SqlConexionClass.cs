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

        public void UpdateRecord(int Id, DateTime DateStart, DateTime DateEnd, Double Amount, string Name, string Cel, string Address, string LastName, int CarId)
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "UPDATE Purchase SET DateStart = @DateStart, DateEnd = @DateEnd, Amount = @Amount, Name = @Name, Cel = @Cel,  AddressP = @Address, LastName = @LastName, CarID = @CarID WHERE PurchaseID = @Id ";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@DateStart", DateStart);
                command.Parameters.AddWithValue("@DateEnd", DateEnd);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Cel", Cel);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@CarID", CarId);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataRow GetRecordPurchase(int id)
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "SELECT * FROM Purchase WHERE PurchaseID = @Id ";
                SqlDataReader dataReader;

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", id);

                dataReader = command.ExecuteReader();



                if (!dataReader.HasRows)
                {
                    connection.Close();
                    return null;
                }

                data.Load(dataReader);

                connection.Close();
                return data.Rows[0];

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
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

        //Sobrecarga con Folio
        public void InsertData(int IdFolio, DateTime DateStart, DateTime DateEnd, Double Amount, string Name, string Cel, string Address, string LastName, int Id)
        {
            try
            {
                connection.Open();

                SqlCommand command;
                string sql =
                   "SET IDENTITY_INSERT Purchase " +
                   "ON INSERT INTO Purchase (PurchaseID,DateStart,DateEnd,Amount,Name,Cel,AddressP,LastName,CarID) values (@IdFolio,@DateStart,@DateEnd,@Amount,@Name,@Cel,@Address,@LastName,@Id) " +
                   "SET IDENTITY_INSERT Purchase ON";

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdFolio", IdFolio);
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
        public void InsertData(DateTime DateStart, DateTime DateEnd, Double Amount, string Name, string Cel, string Address, string LastName, int Id)
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

        public void DeleteRecordId(int id)
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "Delete from Purchase where PurchaseID = @id";

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable FillPurchase()
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "SELECT * FROM Purchase INNER JOIN Car On Purchase.CarID = Car.CarID";
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
        
        public DataTable GetByFilter(int id, DateTime dateStart, DateTime dateEnd)
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;

                string sql = "SELECT * FROM Purchase INNER JOIN Car On Purchase.CarID = Car.CarID Where Purchase.CarID = " + id.ToString() + " and DateStart between '" + dateStart.Date.ToString("yyyy-MM-dd")  +"' and  '" + dateEnd.Date.ToString("yyyy-MM-dd") + "'";

                //select* from Purchase where CarID = 2 and DateStart between '2023-04-01' and '2023-05-30'



                if (id == 0)
                {
                    sql = "SELECT * FROM Purchase INNER JOIN Car On Purchase.CarID = Car.CarID Where DateStart between '" + dateStart.Date.ToString("yyyy-MM-dd") + "' and '" + dateEnd.Date.ToString("yyyy-MM-dd")+"'";
                }

 
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

        public DataRow GetNextId()
        {
            try
            {
                connection.Open();
                DataTable data = new DataTable();
                SqlCommand command;
                string sql = "select IDENT_CURRENT('Purchase')";
                SqlDataReader dataReader;

                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                data.Load(dataReader);

                connection.Close();

                return data.Rows[0];

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


    }
}
