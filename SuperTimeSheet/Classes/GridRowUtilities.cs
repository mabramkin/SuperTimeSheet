using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTimeSheet.Classes
{
    public class GridRowUtilities
    {        
        /// <summary>
        /// Returns the date cell value from grid row
        /// </summary>
        /// <param name="row">selected row</param>
        /// <returns></returns>
        public static string GetTaskDateFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_DATE].Value;
        }

        public static string GetTaskNameFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_NAME].Value;
        }

        public static string GetTaskDurationFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_DURATION].Value;
        }

        public static string GetTaskProjectFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_PROJECT].Value;
        }

        public static void CheckRowAndThrowExceptionIfNull(DataGridViewRow row)
        {
            if (row == null)
            {
                throw new ArgumentNullException("row", "Неверное значение аргумента");
            }
        }
    }
}
