using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ADOQueries
{
    internal class UpdateTable
    {
        private static string connString = @"Data Source = SANTHOSH\PRABHAT; Initial Catalog = STUDENT1 ; Integrated Security = TRUE;";
        private static string sqlUpadteQuery = @"UPDATE StudentInfo Set StudentName='Kate', ParentName ='Becket', 
                                                 AddressOfStudent='precint', City='NewYork', Country='USA'
                                                 WHERE StudentID=08;";
        private static string sqlSelelctQuery = @"Select * from StudentInfo";

        //Using Data Adaptors. We dont need to create connection for Data Adaptors
        public static void TakeTableSnapshot()
        {
            // Here we are taking snapshot of table in opur local and displaying it
            // No changes has been made into data set yet
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelelctQuery, connString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DataTableReader ds = dataSet.CreateDataReader();

                while (ds.Read())
                {
                    Console.WriteLine(" ID = " + ds.GetInt32(0) +
                        "  Student Name = " + ds.GetString(1) +
                    "  Parent Name = " + ds.GetString(2) +
                        "  Phone number = " + ds.GetInt64(3) +
                    "  AddressOfStudent = " + ds.GetString(4) +
                        "  City = " + ds.GetString(5) +
                        "  Country = " + ds.GetString(6));
                }
            }catch (Exception ex) 
            {
            Console.WriteLine(ex.ToString());
            }      
        }

        public static void UpdateOperation()
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                
                SqlCommand cmd = new SqlCommand(sqlUpadteQuery, conn);
                conn.Open();
                int noOfRowsAffected = cmd.ExecuteNonQuery();
                if (noOfRowsAffected > 0) 
                {
                Console.WriteLine("Record updated succesfully");
                }
                else {
                    Console.WriteLine("No row updated");  
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            finally 
            {
            conn.Close();
            }
        }
     }
}
