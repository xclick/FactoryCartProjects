using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryCartsControlCenter.Utils
{
    public class UIUtils
    {
        public static void SetColumn(DataGridView gridView, string columnName, string headerText, int width)
        {
            SetColumn(gridView, columnName, headerText, width, true);
        }

        public static void SetColumn(DataGridView gridView, string columnName, string headerText, int width, bool visiable)
        {
            gridView.Columns[columnName].HeaderText = headerText;
            gridView.Columns[columnName].Width = width;
            gridView.Columns[columnName].Visible = visiable;
        }
    }
}
