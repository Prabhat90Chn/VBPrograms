<<<<<<< HEAD
﻿using System;
=======
﻿ using System;
>>>>>>> 288a2fe (VBProg[Prabhat]: C# basic programs)
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace ADOQueries
{
    internal class UsingProcedureClass
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";
        static SqlConnection conn = null;
         static UsingProcedureClass() 
        {
         conn= new SqlConnection(conStr);
        }
        public static void showTable()
        {
            try 
            {
                string getStudentInfo = "sp_getStudentInfo";
                SqlCommand cmd = new SqlCommand(getStudentInfo, conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.CommandText= getStudentInfo;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                DataTableReader reader = dataset.CreateDataReader();
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
            catch (Exception e) 
            {
            Console.WriteLine(e);
            }
            finally 
            {
                conn.Close();
            }
        }

        public static void insertTable()
        {
            try
            {
                string insertStudentInfo = "sp_insertStudentInfo";
                SqlCommand cmd = new SqlCommand(insertStudentInfo,conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.CommandText= insertStudentInfo;
                cmd.Parameters.AddWithValue("@StudentID",8);
                cmd.Parameters.AddWithValue("@StudentName","meeta");
                cmd.Parameters.AddWithValue("@ParentName", "gulati");
                cmd.Parameters.AddWithValue("@PhoneNumber","123789" );
                cmd.Parameters.AddWithValue("@Adress", "Jwalapur");
                cmd.Parameters.AddWithValue("@City", "Haridwar");
                cmd.Parameters.AddWithValue("@Country", "India");
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Record Added");
                }
                else
                {
                    Console.WriteLine("No record added");
                }
            }
            catch (Exception e)   
            {
            Console.WriteLine (e.Message);
            }
            finally 
            {
                conn.Close ();
            }

        }

        public static void updateTable()
        {
            try
            {
                string updateStudentInfo = "sp_updateStudentInfo";
                SqlCommand cmd = new SqlCommand(updateStudentInfo, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = updateStudentInfo;
                cmd.Parameters.AddWithValue("@StudentID", 8);
                cmd.Parameters.AddWithValue("@City", "goa");
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Record altered succesfully");
                }
                else
                {
                    Console.WriteLine("No record altered");
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

        public static void deleteTable()
        {
            try
            {
                string deleteStudentInfo = "sp_deleteStudentInfo";
                SqlCommand cmd = new SqlCommand(deleteStudentInfo, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = deleteStudentInfo;
                cmd.Parameters.AddWithValue("@StudentID", 8);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Record deleted succesfully");
                }
                else
                {
                    Console.WriteLine("No record deleted");
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
