using System.Data;
using Aquality.Selenium.Browsers;

namespace DatabaseTest.Util
{
    internal static class Utils
    {
        public static void ShowTable(DataTable dataTable)
        {
            string result = "\t\n";
            result += dataTable.TableName;
            foreach (DataColumn column in dataTable.Columns)
                result += "\t" + column.ColumnName;

            result += "\n";

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                    result += "\t" + row[column];
                result += "\t\n";
            }
            AqualityServices.Logger.Info(result);
        }
    }
}
