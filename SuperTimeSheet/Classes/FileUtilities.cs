using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTimeSheet.Classes
{
    /// <summary>
    /// Utilities for working with files
    /// </summary>
    public class FileUtilities
    {
        /// <summary>
        /// Check for error in file name
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>true if error and false otherwise</returns>
        public static bool CheckFileNameAndShowErrorIfNull(string fileName)
        {
            if (fileName == null && "".Equals(fileName))
            {
                MessageBox.Show("Имя файла должно быть задано корректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        
    }
}
