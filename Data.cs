using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.ComponentModel.Design.Serialization;

namespace Todolistappp
{
    internal class Data
    {
        string root = string.Empty;//TODO: get root of database
        string connectionString = @"URI=file:C:\Users\sysadmin\source\repos\Todolistappp\Files\mydatas.db";
        string table = "Tasks" ;

        public Data()
        {
            

            var create_table = $"CREATE TABLE '{table}' (id INTEGER PRIMARY KEY, Name TEXT, DueDate TEXT)";
            var remove_table = $"DROP TABLE '{table}' ";
            var exist_table = $"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='{table}';";
            //var insert_table = $"INSERT INTO '{table}' (id, Name, DueDate) VALUES (1, 'test', '2/11/2023');";//for the test purpose

            using var connection = new SQLiteConnection(connectionString);
            connection.Open();


            var ComCreateTable = new SQLiteCommand(create_table, connection);
            var ComRemoveTable = new SQLiteCommand(remove_table, connection);
            var ComExistTable = new SQLiteCommand(exist_table, connection);
            //var ComTest = new SQLiteCommand(insert_table, connection);

            


            
            object result = ComExistTable.ExecuteScalar();
            int resultCount = Convert.ToInt32(result);


            if (resultCount > 0)
            {
                MessageBox.Show("table "+table+" is exist");
                //start recovering data

            }
            else
            {
                MessageBox.Show("table "+table+" does not exist");
                ComCreateTable.ExecuteNonQuery();
            }

            //ComTest.ExecuteNonQuery();//for the test purpose
            connection.Close();
            
            




        }

        public List<Task> GetDatabase()
        {
            List<Task> list = new List<Task> ();
            var query1 = "SELECT Id, Name, DueDate FROM " + table + "";
            var query2 = "SELECT Name FROM " + table + "";
            var query3 = "SELECT DueDate FROM " + table + "";
            var query = "SELECT *FROM " + table + "";

            var connection = new SQLiteConnection(connectionString);
            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand(query1, connection))
            using (var reader = cmd.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    list.Add(new Task { Id = Convert.ToInt16(reader["id"]), Name = Convert.ToString(reader["Name"]), DueDate = Convert.ToDateTime(reader["DueDate"]) });

                }
            }
            
            return list;

        }

        public void SetDatabase(List<Task> tasks)
        {
            //remove every item in table and instert all tasks from ram
            var data = tasks;
            var query1 = $"DELETE FROM {table}";
            var connection = new SQLiteConnection (connectionString);

            connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query1, connection))
                {
                    cmd.ExecuteNonQuery();
                }

            
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
                foreach (var item in data)
                {


                    var id = item.Id;
                    var name = item.Name;
                    var duedate = item.DueDate;
                    var query = $"INSERT INTO '{table}' (id, Name, DueDate) VALUES ({id}, '{name}', '{duedate}');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();



                }


        }


    }

}
