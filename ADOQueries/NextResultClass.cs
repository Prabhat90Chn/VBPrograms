using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Markup;

namespace ADOQueries
{
    internal class NextResultClass
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";
        static string query = @"Select * from ProductInventory; Select * from ProductCategory";
        public static void showTable()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                
                SqlCommand cmd = new SqlCommand("Select * from ProductInventory; Select* from ProductCategory", conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader != null)
                    {
                        Console.WriteLine(reader.HasRows);
                    }    
                    
                    
                }
            }
        }
    }
}