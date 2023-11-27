using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorControlSystem
{
    internal class DatabaseConn
    {
        public void insert_record(string action)
        {
            string url = "datasource=localhost; Database=ElevatorSystem; port=3306; User=root; Password=rahul";
            string sql = "insert into ElevatorSystem.ElevatorRecord (Date,Time,Action) values (@date, @time, @action)";
            MySqlConnection conn = null;
            MySqlCommand command = null;
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToLongTimeString();

                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@action", action);
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public DataTable ViewData() //method to view the database record
        {
            string url = "datasource=localhost; Database=ElevatorSystem; port=3306; User=root; Password=rahul";
            string sql = "SELECT * FROM ElevatorSystem.ElevatorRecord";
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataAdapter adapter = null;

            try
            {
                conn = new MySqlConnection(url);
                conn.Open();

                command = new MySqlCommand(sql, conn);
                adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error: " + ex.Message);
                return null; // Or throw an exception
            }
            finally
            {
                if (conn != null)
                    conn.Close();

                if (adapter != null)
                    adapter.Dispose();
            }
        }

        public void erase() //method to delete the record to the database
        {
            string url = "datasource=localhost; Database=ElevatorSystem; port=3306; User=root; Password=rahul";
            string del = "DELETE  FROM ElevatorRecord";
            MySqlConnection conn = null;
            MySqlCommand command = null;

            conn = new MySqlConnection(url);
            conn.Open();
            command = new MySqlCommand(del, conn);

            command.ExecuteNonQuery();
        }
    }
}

