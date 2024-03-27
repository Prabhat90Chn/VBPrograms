using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    internal class ParameterizedStoredProcedure
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";

        public static void showTable()
        {
           
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_addProductInventory", conn);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", "iPhone11");
                cmd.Parameters.AddWithValue("@QuantityAvailable", "111");

                SqlParameter output = new SqlParameter();
                output.ParameterName = "@id";
                output.SqlDbType = System.Data.SqlDbType.Int;
                output.Direction=System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(output);
                conn.Open();
               cmd.ExecuteNonQuery();
                string id = output.Value.ToString();
                Console.WriteLine("id of enetred row is = "+id);

            }
        }

    }
}
