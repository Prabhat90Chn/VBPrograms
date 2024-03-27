using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    internal class DataTableDataRow
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";
        static string query = @"Select id,ProductName,QuantityAvailable from ProductInventory";
        public static void showTable()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ProductID");
                    table.Columns.Add("PName");
                    table.Columns.Add("QuantityAail");
                    table.Columns.Add("NewQuantity");

                    while(reader.Read())
                    {
                        DataRow dataRow = table.NewRow();
                        
                        // we can use query
                        //select Select id,ProductName,QuantityAvailable,(QuantityAvailable*0.9) as discountedPrice from ProductInventory
                        //this will remove next two lines of the code and need to create new data row 
                       
                        int orgQuantity = Convert.ToInt32(reader["QuantityAvailable"]);
                        double newQuantity = orgQuantity * 0.9;
                       

                        dataRow["ProductID"] = reader["id"];
                        dataRow["PName"] = reader["ProductName"];
                        dataRow["QuantityAail"] = reader["QuantityAvailable"];
                        dataRow["NewQuantity"] = newQuantity;
                        table.Rows.Add(dataRow);
                    }
                foreach (DataRow dr in table.Rows) 
                    {
                        Console.WriteLine(dr["ProductID"]);
                        Console.WriteLine(dr["PName"]);
                        Console.WriteLine(dr["QuantityAail"]);
                        Console.WriteLine(dr["NewQuantity"]);
                    }
                }
            }
        }
    }
}
