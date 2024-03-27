using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    internal class ParameterQueries
    {
            static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";
            static SqlConnection conn = null;
            static string sqlQuery = "Select * from ProductInventory " +
                                      "Where ProductName like @ProductName ";
       
        public static void showTable()
        {
            Console.WriteLine("Enter the producr name");
            string productname =Console.ReadLine();
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery,conn);
                cmd.Parameters.AddWithValue("ProductName", productname + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(" ID = " + reader.GetInt32(0) +
                        "  Product Name = " + reader.GetString(1) +
                        "  Quantity Available = " + reader.GetInt32(2));                }
            }
        }
    }
}
