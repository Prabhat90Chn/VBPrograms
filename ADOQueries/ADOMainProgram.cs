using System;

namespace ADOQueries
{
    internal class ADOMainProgram
    {
        static void Main(string[] args)
        {
            /*FirstConnection.CreateConnection();
            InsertTableClass.checkStudentCount(); 
            InsertTableClass.insertStudent();
           UpdateTable.TakeTableSnapshot();
            UpdateTable.UpdateOperation();
           DeleteTableClass.DeleteOperation();
            UsingProcedureClass.showTable();
            UsingProcedureClass.insertTable();
            UsingProcedureClass.updateTable(); 
            UsingProcedureClass.deleteTable();
            CurdUsingDatasetDataAdaptor.updateTable();
            ParameterQueries.showTable();
            ParameterizedStoredProcedure.showTable();
            DataTableDataRow.showTable();
            NextResultClass.showTable(); 
            MultipleTables.showTable();
            CommandBuilderClass.showTable(); 
             */
            CommandBuilderClass.UpdateOperation();



        }
    }
}
