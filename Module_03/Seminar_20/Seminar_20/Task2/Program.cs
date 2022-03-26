using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace Task2
{
    class Program
    {
        private static DataTable ExecuteSQL_DataTable(string connectionString, string SQL, params Tuple<string, string>[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                using (SqliteCommand cmd = new SqliteCommand(SQL, con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (var tuple in parameters)
                        cmd.Parameters.Add(new SqliteParameter(tuple.Item1, tuple.Item2));
                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; i++)
                        dt.Columns.Add(new DataColumn(reader.GetName(i)));



                    int rowIndex = 0;
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        dt.Rows.Add(row);
                        for (int i = 0; i < reader.FieldCount; i++)
                            dt.Rows[rowIndex][i] = (reader.GetValue(i));
                        rowIndex++;
                    }
                }
            }
            return dt;
        }




        static void Main(string[] args)
        {
            string connectionString = "Data Source=AdventureWorksLT.db";
            string SQL = "SELECT * FROM Product";
            string SQL2 = "SELECT * FROM Product WHERE ProductID = 680";
            string SQL3 = "SELECT * FROM Product WHERE ListPrice > 680 and ListPrice < 1000";
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL3);



            foreach (DataRow row in dt.Rows)
            {
                foreach (var t in row.ItemArray)
                    Console.Write(t + " ");
                Console.WriteLine();
            }
        }
    }
}
