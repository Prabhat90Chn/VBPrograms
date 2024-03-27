using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Net.Http.Headers;

namespace ADOQueries
{
    internal class CachingDataset
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security= TRUE;";

        public static void showTable()
        {
            /*if (Cache["Data"]==null)
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from ProductInventory", conn);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    //This will enter our data set into cache with key as "Data"
                    Cache["Data"] = ds;
                }
            }
            else
            {
                //Taking cache value with key as "Data"
                var res= (Dataset)Cache["Data"]
            }
           */
        }
    }
}
