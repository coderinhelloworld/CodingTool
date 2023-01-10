using ekko.amazon.Util;
using ICSharpCode.TextEditor.Document;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReplaceTool.Entity;
using ReplaceTool.Enums;
using ReplaceTool.Global;
using ReplaceTool.Helper;
using ReplaceTool.Service;
using ReplaceTool.Setting;
using ReplaceTool.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
namespace ReplaceTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            OutPutTextBox.Document.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000; // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX; // 允许最小化操作
                return cp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Components.ReplaceDataGridView = dataGridView1;
            Components.SettingNameList = this.SettingListBox;
            Components.InputTextBox = this.InputTextBox;
            Components.OutPutTextBox = this.OutPutTextBox;
            Components.MainForm = this;
            MultiReplace.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            var inputText = InputTextBox.Text;
            //删除inputText中的所有的[符号,保留最后一个
            var inputTextList = inputText.Split(new string[] { "[" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lastStr ="["+ inputTextList.Last();
            inputTextList.Remove(inputTextList.Last());
            inputText = string.Join("", inputTextList) + lastStr;
            //删除inputText中的所有的]符号,保留最后一个
            inputTextList = inputText.Split(new string[] { "]" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            inputText = string.Join("", inputTextList) + "]";
            var sqlString = inputText.Split('[')[0];
            var paramList = inputText.Split('[')[1].Replace("]", "").Split('，');
            var count = 1;
            if (inputText.Contains("@p0"))
            {
                count = 0;
            }
            foreach (var item in paramList)
            {
                var replaceStr = "@p" + count + ",";
                var replaceStr2 = "@p" + count + " ";
                var replaceStr3 = "@p" + count + ")";
                var afterReplaceStr = "'" + item + "'" + ",";
                var afterReplaceStr2 = "'" + item + "'" + " ";
                var afterReplaceStr3 = "'" + item + "'" + ")";
                if (count== paramList.Count())
                {
                    replaceStr = "@p" + count;
                    afterReplaceStr = "'" + item + "'";
                }
                sqlString = sqlString.Replace(replaceStr, afterReplaceStr);
                sqlString = sqlString.Replace(replaceStr2, afterReplaceStr2);
                sqlString = sqlString.Replace(replaceStr3, afterReplaceStr3);
                count++;
            }
            UtilHelper.ShowMsg(sqlString);
        }
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var contText = InputTextBox.Text;
            var jsonHelper = new JsonHelper();
            UtilHelper.ShowMsg(jsonHelper.GetClassString(contText));
        }
        private void propertyGenerateBtn_Click(object sender, EventArgs e)
        {
            var inputText = InputTextBox.Text;
            var sb = new StringBuilder();
            var textList = inputText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (var item in textList)
            {
                sb.AppendLine($"[JsonProperty(\"{item}\")]");
                sb.AppendLine("public string " + item.ToPascal() + " {get;set;}");
                sb.AppendLine();
            }
            UtilHelper.ShowMsg(sb.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var inputText = InputTextBox.Text;
                if (colNo.Text.IsNullOrEmpty())
                {
                    var textList = inputText.Split(new string[] { "\n" }, StringSplitOptions.None);
                    var desList = textList.Where(x => x.Contains("//")).ToList();
                    var propertyList= textList.Where(x =>! x.Contains("//")).ToList();
                    var sb = new StringBuilder();
                    for (int i = 0; i < propertyList.Count(); i++)
                    {
                        var des = desList[i].Replace("//", "");
                        sb.AppendLine("/// <summary>");
                        sb.AppendLine($"/// {des}");
                        sb.AppendLine("/// </summary>");
                        sb.AppendLine($"[Column(\"{propertyList[i]}\", \"{des}\")]");
                        sb.AppendLine("public string " + propertyList[i].ToPascal() + " {get;set;}");
                        sb.AppendLine();
                    }
                    UtilHelper.ShowMsg(sb.ToString());
                }else
                {
                    var col = int.Parse(colNo.Text);
                    var sb = new StringBuilder();
                    var textList = inputText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    foreach (var text in textList)
                    {
                        var items = text.Split('\t');
                        if (items.Length > 0)
                        {
                            sb.AppendLine("/// <summary>");
                            sb.AppendLine($"/// {items[col]}");
                            sb.AppendLine("/// </summary>");
                            sb.AppendLine($"[JsonProperty(\"{items[0].Trim()}\")]");
                            sb.AppendLine("public string " + items[0].ToPascal() + " {get;set;}");
                            sb.AppendLine();
                        }
                    }
                    UtilHelper.ShowMsg(sb.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var inputText = InputTextBox.Text;
            var col = int.Parse(colNo.Text);
            var sb = new StringBuilder();
            var textList = inputText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (var text in textList)
            {
                var items = text.Split('\t');
                if (items.Length > 0)
                {
                    sb.AppendLine("/// <summary>");
                    sb.AppendLine($"/// {items[col]}");
                    sb.AppendLine("/// </summary>");
                    sb.AppendLine("[DataMember]");
                    sb.AppendLine($" private String {items[0].Trim()};");
                    sb.AppendLine();
                }
            }
            foreach (var text in textList)
            {
                var items = text.Split('\t');
                if (items.Length > 0)
                {
                    var str = $@" public String get{items[0].ToPascal()}() 
                                {{
                                    return {items[0].Trim()};
                                }}
                                public void set{items[0].ToPascal()}(String value) 
                                {{
                                    {items[0].Trim()} = value;
                                }}";
                    sb.AppendLine(str);
                }
            }
            UtilHelper.ShowMsg(sb.ToString());
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public class Translate
        {
            public string Value { get; set; }
            public string Key { get; set; }
        }
        public string GetTranslate(string input)
        {
            var res = AzureTranslateHelper.AzureTranaslte(input, new string[] { "en" }).Result;
            var resStr = "";
            foreach (var item in res[0].Split(' '))
            {
                if (!item.IsNullOrEmpty() && item.ToLower() != "the")
                {
                    //首字母大写
                    resStr += item.First().ToString().ToUpper() + item.Substring(1);
                }
            }
            return resStr;
        }
        public void GenerateToolBarText()
        {
            UtilHelper.ShowMsg("");
            var inputText = InputTextBox.Text;
            inputText = GetToolBarTranslateContent(inputText);
            var tableName = new Regex(@"\$\(""\#(\w+)""\)").Match(inputText).Value.Replace(@"$(""#", "").Replace(@""")", "");
            var type = 1;
            if (inputText.Contains("treegrid"))
            {
                type = 2;
            }
            inputText = inputText.Replace(@"$("".lazyLoad"").css(""visibility"", ""visible"")", $"regPermission(\"{tableName}\", {type}); \r\n     $(\".lazyLoad\").css(\"visibility\",\"visible\")");
            UtilHelper.ShowMsg(inputText);
        }
        private void GenerateToolBarTextBtn_Click(object sender, EventArgs e)
        {
            GenerateToolBarText();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwdn, int wMsg, int mParam, int IParam);
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }
        /// <summary>
        /// 替换探秘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplaceBtn_Click_1(object sender, EventArgs e)
        {
            var settings = SettingHelper.GetCurrentSetting();
            var saveGroupSettingName = settings.SettingItems.Where(x=>x.Group!="").Select(x => x.Group);
            //获取saveGroupSettingName中相同的数量



            var inputText = InputTextBox.Text;
            if (inputText.Length > 0)
            {
                foreach (var name in saveGroupSettingName)
                {
                    var saveGroupSetting = settings.SettingItems.Where(x => x.Group == name);
                    foreach (var item in saveGroupSetting)
                    {



                    }
                }



                foreach (var setting in settings.SettingItems)
                {
                    if (setting.NeedReplaceStr.Length > 0)
                    {
                        if (setting.ReplaceType ==ReplaceWay.正则表达式替换.ToString())
                        {
                            Regex reg = new Regex(setting.NeedReplaceStr);
                            var res = reg.Match(inputText);
                            inputText = inputText.Replace(res.ToString(), "");
                        }
                        if (setting.ReplaceType == ReplaceWay.替换.ToString())
                        {
                            inputText = inputText.Replace(setting.NeedReplaceStr, setting.ReplaceStr);
                        }
                    }
                }
                UtilHelper.ShowMsg(inputText);
            }
        }
        private void SettingListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {  
            var settings = SettingHelper.GetLocalSettings();
            var currentSettingName = SettingListBox.Text;
            var setting = settings.FirstOrDefault(x => x.Name == currentSettingName);
            if (setting != null)
            {
                MultiReplace.SetDatagridViewSetting(setting);
            }
            else
            {
                InputTextBox.Text = "";
            }
        }

        #region 多字符串替换
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtdAddRow_Click_1(object sender, EventArgs e)
        {
            MultiReplace.SaveSetting();
        }
        /// <summary>
        /// 删除配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigDelBtn_Click(object sender, EventArgs e)
        {
            MultiReplace.DeleteSetting();
        }


        #endregion

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.IconColor = Color.FromArgb(232, 17, 35);
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Close;
        }
        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.IconColor = Color.FromArgb(253, 96, 88);
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
        }
        /// <summary>
        /// 转驼峰
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            var inputText = InputTextBox.Text;
            var sb = new StringBuilder();
            var textList = inputText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (var item in textList)
            {
                sb.AppendLine(item.ToPascal());
            }
            UtilHelper.ShowMsg(sb.ToString());
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            var inputText = InputTextBox.Text;
            var res = inputText.Replace("\r\n", "").Replace("\"", "\\\"").Replace(" ", "");
            UtilHelper.ShowMsg(res);
        }
        private void contactTxtBtn_Click_1(object sender, EventArgs e)
        {
            var contText = contactText.Text;
            var inputText = InputTextBox.Text;
            inputText = inputText.Replace('\t', ' ').Replace('\n', ' ');
            var str = inputText.Split(' ');
            var sb = new StringBuilder();
            foreach (var item in str)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    sb.Append(item + contText);
                }
            }
            var res = sb.ToString();
            res = res.Substring(0, res.Length - 1);
            UtilHelper.ShowMsg(res);
        }
        private void AddItSelf_Click_1(object sender, EventArgs e)
        {
            var inputText = InputTextBox.Text;
            var fromNumber = Convert.ToInt32(fromNumberBox.Text);
            var toNumber = Convert.ToInt32(toNumberBox.Text);
            var outputStr = inputText;
            for (int i = fromNumber; i < toNumber; i++)
            {
                outputStr += inputText.Replace(fromNumber.ToString(), (i + 1).ToString()) + "\r\n";
            }
            UtilHelper.ShowMsg(outputStr);
        }
        private void AddAuthCodeBtn_Click(object sender, EventArgs e)
        {
            UtilHelper.ShowMsg("");
            var filePathList = FileHelper.GetDirAllFiles(InputTextBox.Text);
            foreach (var item in filePathList)
            {
                if (item.ToLower().Contains("edit.htm") || item.ToLower().Contains("add.htm"))
                {
                    continue;
                }
                var html = File.ReadAllText(item);
                //获取名称
                var toolbarAndIdHtml = new Regex(@"\$\(""\#([\s\S]*)toolbar").Match(html).Value;
                var tableName = new Regex(@"\$\(""\#(\w+)""\)").Match(toolbarAndIdHtml).Value.Replace(@"$(""#", "").Replace(@""")", "");
                //获取toolbar信息并添加id和翻译
                var toolbarContent = new Regex(@"toolbar:([\s\S]*?)\]").Match(html).Value;
                if (string.IsNullOrEmpty(toolbarContent))
                {
                    continue;
                }
                var changedToolbarContent = GetToolBarTranslateContent(toolbarContent);
                //权限验证函数
                var lazyLoadString = @"$("".lazyLoad"").css(""visibility"", ""visible"")";
                var regPermissionCode = GetRegPermissionCode(toolbarAndIdHtml, tableName);
                //替换文本
                html = html.Replace(toolbarContent, changedToolbarContent).Replace(lazyLoadString, regPermissionCode);
                File.WriteAllText(item, html, Encoding.UTF8);
                OutPutTextBox.Text += item + "\r\n";
            }
        }
        public string GetToolBarTranslateContent(string input)
        {
            var translateList = new List<Translate>();
            translateList.Add(new Translate() { Key = "查询", Value = "Search" });
            translateList.Add(new Translate() { Key = "新增", Value = "Save" });
            translateList.Add(new Translate() { Key = "添加", Value = "Save" });
            translateList.Add(new Translate() { Key = "编辑", Value = "Update" });
            translateList.Add(new Translate() { Key = "删除", Value = "Delete" });
            translateList.Add(new Translate() { Key = "导出", Value = "Export" });
            translateList.Add(new Translate() { Key = "导入", Value = "Import" });
            translateList.Add(new Translate() { Key = "详细", Value = "Detail" });
            var inputText = input;
            //匹配toolbar文本内容
            var regStr = @"text:.*?,";
            var m1 = Regex.Matches(inputText, regStr);
            foreach (var item in m1)
            {
                var text = item.ToString();
                var res = Regex.Match(text, "'.*'");
                var needTranslateKey = res.ToString().Trim('\'').Trim();
                var keyTranlate = translateList.FirstOrDefault(x => x.Key == needTranslateKey);
                if (keyTranlate != null)
                {
                    inputText = inputText.Replace(text, text + $"id: \"{keyTranlate.Value}\",");
                }
                else
                {
                    var translateRes = GetTranslate(needTranslateKey);
                    inputText = inputText.Replace(text, text + $"id: \"{translateRes}\",");
                }
            }
            return inputText;
        }
        public string GetRegPermissionCode(string toolbarAndIdContent, string tableName)
        {
            var type = 1;
            if (toolbarAndIdContent.Contains("treegrid"))
            {
                type = 2;
            }
            var regPermissionCode = $"regPermission(\"{tableName}\", {type}); \r\n            $(\".lazyLoad\").css(\"visibility\",\"visible\")";
            return regPermissionCode;
        }
        private void CheckRegCodeBtn_Click(object sender, EventArgs e)
        {
            UtilHelper.ShowMsg("");
            var filePathList = FileHelper.GetDirAllFiles(InputTextBox.Text);
            foreach (var item in filePathList)
            {
                var html = File.ReadAllText(item);
                if (html.Contains("editor: { type: 'combobox'") && html.Contains("multiple: true") && html.Contains("treegrid"))
                {
                    OutPutTextBox.Text += item + "\r\n";
                }
            }
            OutPutTextBox.Text += "Ending." + "\r\n";
        }
        private void PdmGetCSharpCodeBtn_Click(object sender, EventArgs e)
        {
            var tableName = TableNameBox.Text;
            var inputText = InputTextBox.Text;
            if (tableName.IsNullOrEmpty())
            {
                MessageBox.Show("表名不能为空");
                return;
            }
            if (inputText.IsNullOrEmpty())
            {
                MessageBox.Show("输入内容不能为空");
                return;
            }
            var sb = new StringBuilder();
            var textList = inputText.Split(new string[] { "\n" }, StringSplitOptions.None);
            foreach (var text in textList)
            {
                var items = GetStrFields(text).Split(' ');
                if (items.Length > 0)
                {
                    sb.AppendLine("/// <summary>");
                    sb.AppendLine($"/// {items[0]}");
                    sb.AppendLine("/// </summary>");
                    sb.AppendLine($" [Column(\"{items[1]}\", \"{items[0]}\")]");
                    sb.AppendLine("public string " + items[1].ToPascal() + " {get;set;}");
                    sb.AppendLine();
                }
            }
            var res = $@"[Table(""{tableName}"", ""餐次信息"")]
 public class {tableName.ToPascal()}Eo : FrameEo
 {{
                   {sb.ToString()}
             }}";
            UtilHelper.ShowMsg(res);
        }
        public static string GetStrFields(string strWords)
        {
            Regex replaceSpace = new Regex(@"\s{1,}", RegexOptions.IgnoreCase);
            return replaceSpace.Replace(strWords, " ").Trim();
        }
        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MinBtn_MouseHover(object sender, EventArgs e)
        {
            MinBtn.IconColor = Color.FromArgb(255, 128, 0);
            this.MinBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
        }
        private void MinBtn_MouseLeave(object sender, EventArgs e)
        {
            MinBtn.IconColor = Color.FromArgb(251, 190, 47);
            this.MinBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
        }
        /// <summary>
        /// 文件更改成UTF-8格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangToUtf8Btn_Click(object sender, EventArgs e)
        {
            var act = new Action(ChangeFileToUTF8);
            act.BeginInvoke(ar => act.EndInvoke(ar), null);
        }
        private void ChangeFileToUTF8()
        {
            UtilHelper.ShowMsg("");
            try
            {
                var filePathList = FileHelper.GetDirAllFiles(InputTextBox.Text);
                foreach (var path in filePathList)
                {
                    var html = File.ReadAllText(path, FileHelper.GetType(path));
                    UtilHelper.ShowMsg(path + "\r\n", false);
                    var utf8WithoutBom = new System.Text.UTF8Encoding(false);//使用构造函数布尔参数指定是否含BOM头，示例false为不含。
                    File.WriteAllText(path, html, utf8WithoutBom);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void JsonFormatBtn_Click(object sender, EventArgs e)
        {
            Task task1 = Task.Run(() =>
            {
                try
                {
                    string jsonStr = InputTextBox.Text.Trim();
                    var res = new JsonHelper().ConvertJsonString(jsonStr);
                    UtilHelper.ShowMsg(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }
        private void PageGenerateBtn_Click(object sender, EventArgs e)
        {
            var path = Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + "/HtmlModels/Index.text";
            var html = File.ReadAllText(path);
            var pagePath = PagePathBox.Text;
            html = html.Replace("{{AddHtmlPath}}", pagePath + "/" + PageTableNameBox.Text + "Add.htm");
            html = html.Replace("{{EditHtmlPath}}", pagePath + "/" + PageTableNameBox.Text + "Edit.htm");
            html = html.Replace("{{HandlerPath}}", HandlerPathBox.Text);
            html = html.Replace("{{TableTitle}}", TableTitleBox.Text);
            UtilHelper.ShowMsg(html);
        }
        private void HtmlFormatterBtn_Click(object sender, EventArgs e)
        {
            Task task1 = Task.Run(() =>
            {
                try
                {
                    string jsonStr = InputTextBox.Text.Trim();
                    var res = HtmlCodeFormat.Format(jsonStr);
                    UtilHelper.ShowMsg(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            string selectedItem = combo.Text;//拿到选择后的值
            if (dataGridView1.CurrentCell != null)
                dataGridView1.CurrentCell.Value = selectedItem;
        }
    }
}
