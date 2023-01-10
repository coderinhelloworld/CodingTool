using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
namespace ReplaceTool.Global
{
    public static class Components
    {
        public static Form MainForm;
        public static System.Windows.Forms.RichTextBox InputTextBox;
        public static ICSharpCode.TextEditor.TextEditorControl OutPutTextBox;
        #region 多字符串替换
        public static DataGridView ReplaceDataGridView;
        public static ComboBox SettingNameList;        
        #endregion
    }
}
