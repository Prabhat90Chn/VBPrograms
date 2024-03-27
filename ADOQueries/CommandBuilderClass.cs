using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    internal class CommandBuilderClass
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security= TRUE;";

        public static void showTable()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string sqlquery = "Select * from ProductInventory where id ='1'";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds,"Products");
                /*ViewState["SQL_QUERY"] = sqlquery;
                ViewState["DATASET"] = ds;*/
                if (ds.Tables["Products"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Products"].Rows[0];
                    Console.WriteLine(dr["id"].ToString());
                    Console.WriteLine(dr["ProductName"].ToString());
                    Console.WriteLine(dr["QuantityAvailable"].ToString());

                }else {
                    Console.WriteLine("No row found with given id");
                }

            }
        }
        public static void UpdateOperation()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string sqlquery = "Select * from ProductInventory where id ='2'";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, conn);
                // Based on the sql select query, SQLCommandBuilder has automatically
                //generated the isert,update, delete query for us. 
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Products");
                if (ds.Tables["Products"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Products"].Rows[0];
                    dr["QuantityAvailable"] = 333;
                }
                else {
                    Console.WriteLine("No row present");
                }
                int res = adapter.Update(ds, "Products");
                Console.WriteLine("No of rows uppdated = "+res);

            }
        }
    }
}
