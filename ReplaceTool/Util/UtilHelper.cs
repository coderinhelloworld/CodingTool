using ReplaceTool.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ReplaceTool.Util
{
    public static class UtilHelper
    {
        /// <summary>
        /// 更新输出内容
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="clearBefore"></param>
        public static void ShowMsg(string msg, bool clearBefore = true)
        {
            var outPutTextBox = Components.OutPutTextBox;
            var _this = Components.MainForm;
            MethodInvoker mi = new MethodInvoker(() =>
            {
                if (clearBefore)
                {
                    outPutTextBox.Text = msg;
                }
                else
                {
                    outPutTextBox.Text += msg;
                }
            });
            _this.BeginInvoke(mi);
        }
    }
}
