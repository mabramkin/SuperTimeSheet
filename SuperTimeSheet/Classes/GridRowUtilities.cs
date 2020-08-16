using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTimeSheet.Classes
{
    /// <summary>
    /// Utility methods for working with DataGridView rows
    /// </summary>
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

        /// <summary>
        /// Gets the name of the task from row
        /// </summary>
        /// <param name="row">row object</param>
        /// <returns>the name of the task</returns>
        public static string GetTaskNameFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_NAME].Value;
        }

        /// <summary>
        /// Get task duration from row
        /// </summary>
        /// <param name="row">row object</param>
        /// <returns>task duration as string value</returns>
        public static string GetTaskDurationFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_DURATION].Value;
        }

        /// <summary>
        /// Get project of task from row
        /// </summary>
        /// <param name="row">row object</param>
        /// <returns>name of the project for task</returns>
        public static string GetTaskProjectFromGridRow(DataGridViewRow row)
        {
            CheckRowAndThrowExceptionIfNull(row);
            return (string)row.Cells[GridColumnIndexes.COLUMN_INDEX_TASK_PROJECT].Value;
        }

        /// <summary>
        /// Checks if row is null and throws ArgumentNullException
        /// </summary>
        /// <param name="row"></param>
        public static void CheckRowAndThrowExceptionIfNull(DataGridViewRow row)
        {
            if (row == null)
            {
                throw new ArgumentNullException("row", "Неверное значение аргумента");
            }
        }
    }
}
