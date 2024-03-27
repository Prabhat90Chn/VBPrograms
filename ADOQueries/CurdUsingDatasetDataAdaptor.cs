using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Data.Common;

namespace ADOQueries
{
    internal class CurdUsingDatasetDataAdaptor
    {
        static string conStr = @"Data Source =SANTHOSH\PRABHAT; Initial Catalog = STUDENT1; Integrated Security = TRUE;";
        static SqlConnection conn = null;
        static string sqlQuery = "Select * from StudentInfo";
        static CurdUsingDatasetDataAdaptor()
        {
            conn = new SqlConnection(conStr);
        }
        public static void showTable()
        {
            try
            {
                string getStudentInfo = "sp_getStudentInfo";
                SqlCommand cmd = new SqlCommand(getStudentInfo, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = getStudentInfo;
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

        public static void updateTable()
        {
            // string insertQuery = @"INSERT INTO StudentInfo values('08','Meeta','Gulati','0123534','Channna','Delhi','India');";
            using (conn)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo",
                  conn)
                {
                    UpdateCommand = new SqlCommand(
                   "UPDATE StudentInfo SET StudentName = @StudentName " +
                   "WHERE StudentID = @StudentID", conn)
                };

                dataAdapter.UpdateCommand.Parameters.Add(
                   "@StudentName", SqlDbType.NVarChar, 15, "StudentName");

                SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add(
                  "@StudentID", SqlDbType.Int);
                parameter.SourceColumn = "StudentID";
                parameter.SourceVersion = DataRowVersion.Original;

                DataTable categoryTable = new DataTable();
                dataAdapter.Fill(categoryTable);

                DataRow categoryRow = categoryTable.Rows[0];
                categoryRow["StudentName"] = "Meeta";

                dataAdapter.Update(categoryTable);

                Console.WriteLine("Rows after update.");
                foreach (DataRow row in categoryTable.Rows)
                {
                    {
                        Console.WriteLine("{0}: {1}", row[0]);
                    }
                }
            }
        }

        }
}
