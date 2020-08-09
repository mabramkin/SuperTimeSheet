using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTimeSheet.Classes
{
    /// <summary>
    /// Utilities for working with DagaGridView cells
    /// </summary>
    public class GridCellUtilities
    {
        public static void SetCellValidStyle(DataGridViewCell cell)
        {
            cell.Style.ForeColor = Color.Green;
            cell.Style.BackColor = Color.LightGreen;
        }

        public static void SetCellInvalidStyle(DataGridViewCell cell)
        {
            cell.Style.ForeColor = Color.Red;
            cell.Style.BackColor = Color.LightPink;
        }
    }
}
