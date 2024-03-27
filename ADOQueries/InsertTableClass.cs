using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ADOQueries
{
    internal class InsertTableClass
    {
        //Count no of students and then insert new studnet and check if student row is added
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";
        static string insertQuery = @"INSERT INTO StudentInfo values('08','Meeta','Gulati','0123534','Channna','Delhi','India');";
        static string countQuery = @"SELECT COUNT(*) AS 'StudentCount' FROM StudentInfo;";
        

        static SqlConnection conn = null;

        static InsertTableClass()
        {
            try
            {
                Console.WriteLine("Constructor running");
                conn = new SqlConnection(conStr);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void checkStudentCount()
        {
            try
            {
                if(conn != null)
                {
                    SqlCommand cmd =  new SqlCommand(countQuery, conn);
                    conn.Open();
                    int totalCount =Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("Total number of student = "+totalCount);
                }
                
            }   catch (Exception ex)
            {
                Console.WriteLine (ex.Message); 
            }finally 
            {
                if (conn != null)
                conn.Close();
            }
        }
        public static void insertStudent()
        {
            /*
             When we need to take value from the UI
            string addRow = @"Insert into StudentInfo VALUES(@StudentID,@StudentName,@ParentName,@Phonenumber,
                                                             @AddressOfStudent,@City,@Country)"
            SqlCommand cmd = new SqlCommand(addRow, conn);
            cmd.Parameters.AddWithValue("@StudentID",txtStudentID.text)

             */
            checkStudentCount();
            try
            {
                if (conn != null)
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if(rowsAffected > 0) 
                    {
                        Console.WriteLine(rowsAffected+ " Number of rows inserted succesfully");
                    }
                    else
                    {
                        Console.WriteLine("No new row added");
                    }
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            checkStudentCount();
        }
    }
}
