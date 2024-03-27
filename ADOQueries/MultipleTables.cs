using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ADOQueries
{
    internal class MultipleTables
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security= TRUE;";
        private static DataTable table0;
        private static DataTable table1;
        private static object[] arr;

        public static void showTable()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("sp_MultiTable", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ds.Tables[0].TableName = "ProductInventory";
                ds.Tables[1].TableName = "ProductCategory";
                table0 = ds.Tables["ProductInventory"];
                foreach (DataRow dr in table0.Rows)
                {
                    arr = dr.ItemArray;
                    foreach (object o in arr) 
                    { 
                    Console.WriteLine(o.ToString());
                    }
                }
            }
        }
    }
}

