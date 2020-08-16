using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTimeSheet.Classes
{
    /// <summary>
    /// Utility methods for working with files
    /// </summary>
    public class PersistenceUtilities
    {
        public static string GetDataStringForFile(DataGridView gridTasks, double totalTaskDurationInHours)
        {
            string result = "";
            if (gridTasks.Rows == null || gridTasks.Rows.Count == 0)
            {
                return result;
            }

            
            foreach (DataGridViewRow row in gridTasks.Rows)
            {
                string rowData = "";
                if (row.Cells == null || row.IsNewRow)
                {
                    continue;
                }

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (!"".Equals(rowData))
                        {
                            rowData += "|";
                        }
                        rowData += cell.Value.ToString();
                    }

                }
                result += rowData + "\r\n";
            }
            result += "###\r\n" + totalTaskDurationInHours.ToString();
            

            return result;
        }
    }
}
