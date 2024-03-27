using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    public  class FirstConnection
    {

        public static void CreateConnection() 
        {
            SqlConnection sqlConnection= null;
            try
            {
                // Create Connection String
                string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";

                //Create Connection Object
                 sqlConnection = new SqlConnection(conStr);

                //Create SQL Query
                string sqlQuery = "Select * from StudentInfo";

                //Create Command Object
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                // Open the connection
                sqlConnection.Open();

                //Read the data from Database using Command object
                SqlDataReader reader = sqlCommand.ExecuteReader();


                while (reader.Read())
                {
                    Console.WriteLine(" ID = " + reader.GetInt32(0) +
                        "  Student Name = " + reader.GetString(1) +
                        "  Parent Name = " + reader.GetString(2) +
                        "  Phone number = " + reader.GetInt64(3) +
                        "  Address = " + reader.GetString(4) +
                        "  City = " + reader.GetString(5) +
                        "  Country = " + reader.GetString(6));
                }
            }
            catch (Exception ex) 
            { 
            Console.WriteLine(ex.Message);
            }
            finally 
            {
                sqlConnection.Close();
            }
                                              
        }
        
     }
}
