using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    internal class DeleteTableClass
    {
        private static string connString = @"Data Source = SANTHOSH\PRABHAT; Initial Catalog = STUDENT1 ; Integrated Security = TRUE;";
        private static string sqlUpadteQuery = @"DELETE FROM StudentInfo where StudentID = '8';";

        static SqlConnection conn = new SqlConnection(connString);
        public static void DeleteOperation()
        {
            try 
            {
                SqlCommand cmd = new SqlCommand(sqlUpadteQuery, conn);
                conn.Open();
                int noOfRowsAffected = cmd.ExecuteNonQuery();
                if (noOfRowsAffected > 0)
                {
                    Console.WriteLine("Row deleted from The table");
                }
                else
                {
                    Console.WriteLine("No row Deleted");
                }
            }
            catch (Exception e) 
            {
                 Console.WriteLine(e.Message);
            }
            finally 
            {
                conn.Close();
            }
        }
    }
}
