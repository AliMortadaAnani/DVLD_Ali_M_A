using System.Data;

namespace DVLD_General
{

    public enum enGender
    {
        Male = 0,
        Female = 1
    };
    public enum enApplicationStatus
    {
        New = 1,
        Cancelled = 2,
        Completed = 3
    };

    public enum enIssueReason
    {

        FirstTime=1,
        Renew=2,
        Replacement_for_Damaged=3,
        Replacement_for_Lost=4
    };


    /*public static class DataTableExt // from StackOverflow
    {
        public static void ConvertColumnType(this DataTable dt, string columnName, Type newType)
        {
            using (DataColumn dc = new DataColumn(columnName + "_new", newType))
            {
                // Add the new column which has the new type, and move it to the ordinal of the old column
                int ordinal = dt.Columns[columnName].Ordinal;
                dt.Columns.Add(dc);
                dc.SetOrdinal(ordinal);

                // Get and convert the values of the old column, and insert them into the new
                foreach (DataRow dr in dt.Rows)
                    dr[dc.ColumnName] = Convert.ChangeType(dr[columnName], newType);

                // Remove the old column
                dt.Columns.Remove(columnName);

                // Give the new column the old column's name
                dc.ColumnName = columnName;
            }
        }
    }*/


    public class DataTypes
    {

    }
}
