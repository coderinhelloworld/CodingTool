using ekko.amazon.Util;
using Newtonsoft.Json;
using ReplaceTool.Entity;
using ReplaceTool.Helper;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dgv = this.dataGridView1;
            ////根据Header和所有单元格的内容自动调整行的高度
            //添加三列
            for (int i = 0; i < 2; i++)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn());
                dgv.Columns[i].Width = 500;
                dgv.RowTemplate.Height = 30;


            }
            //三列的标题
            dgv.Columns[0].HeaderText = "需要替换的内容";
            dgv.Columns[1].HeaderText = "替换后的内容";
            //设置对齐方式和字体
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Font = new Font("微软雅黑", 11);
            var settings = GetLocalSettings();
            SettingListBox.DataSource = GetLocalSettings();
            SettingListBox.DisplayMember = "Name";
            //if (settings.Count > 0)
            //{
            //    SetDatagridViewSetting(settings[0]);
            //}

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersHeight = 30;
            dgv.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

            dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Inset;
            dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            //dgv.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;

        }
        public void SetDatagridViewSetting(Setting setting)
        {
            dataGridView1.Rows.Clear();

            if (!string.IsNullOrEmpty(setting.Input))
            {
                InputTextBox.Text = setting.Input;
            }
            var count = 0;
            foreach (var settingItem in setting.SettingItems)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = settingItem.NeedReplaceStr;
                dataGridView1.Rows[count].Cells[1].Value = settingItem.ReplaceStr;
                count++;
            }

        }

        public List<Setting> GetLocalSettings()
        {
            var pathPrefix = Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            var settingsStr = File.ReadAllText(pathPrefix + "/Setting/Settings.txt");
            var res = JsonConvert.DeserializeObject<List<Setting>>(settingsStr);
            if (res == null)
            {
                return new List<Setting>()
                {
                };
            }
            return res;
        }




        public Setting GetCurrentSetting()
        {
            Setting setting = new Setting()
            {
                SettingItems = new List<SettingItem>()
            };
            setting.Name = SettingNameBox.Text;
            setting.Input = InputTextBox.Text;
            var res = dataGridView1.Rows;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                SettingItem settingItem = new SettingItem();
                settingItem.NeedReplaceStr = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                settingItem.ReplaceStr = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                setting.SettingItems.Add(settingItem);
            }
            return setting;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var inputText = InputTextBox.Text;
            var sqlString = inputText.Split('[')[0];
            var paramList = inputText.Split('[')[1].Replace("]", "").Split('，');

            var count = 0;
            foreach (var item in paramList)
            {
                sqlString = sqlString.Replace("@p" + count, "'" + item + "'");
                count++;
            }
            OutPutTextBox.Text = sqlString;
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
            OutPutTextBox.Text = jsonHelper.GetClassString(contText);
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
            OutPutTextBox.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
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

                    sb.AppendLine($"[JsonProperty(\"{items[0].Trim()}\")]");
                    sb.AppendLine("public string " + items[0].ToPascal() + " {get;set;}");
                    sb.AppendLine();
                }

            }
            OutPutTextBox.Text = sb.ToString();
        }



        private void fromNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void RefreshSetting()
        {
            var settingList = GetLocalSettings();
            SettingListBox.DataSource = GetLocalSettings();
            SettingListBox.DisplayMember = "Name";
            if (settingList.Count > 0)
            {
                SetDatagridViewSetting(settingList[0]);
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
            OutPutTextBox.Text = sb.ToString();
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
                if (!item.IsNullOrEmpty()&&item.ToLower()!="the")
                {
                    //首字母大写
                    resStr += item.First().ToString().ToUpper() + item.Substring(1);
                }
            }
            return resStr;
        }

        public void GenerateToolBarText()
        {
            OutPutTextBox.Text = "";
            var inputText = InputTextBox.Text;
            inputText = GetToolBarTranslateContent(inputText);
            var tableName = new Regex(@"\$\(""\#(\w+)""\)").Match(inputText).Value.Replace(@"$(""#", "").Replace(@""")", "");
            var type = 1;
            if (inputText.Contains("treegrid"))
            {
                type = 2;
            }
            inputText = inputText.Replace(@"$("".lazyLoad"").css(""visibility"", ""visible"")", $"regPermission(\"{tableName}\", {type}); \r\n     $(\".lazyLoad\").css(\"visibility\",\"visible\")");
            OutPutTextBox.Text = inputText;

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

        private void htmlTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateToolBarText();
        }

        private void ReplaceBtn_Click_1(object sender, EventArgs e)
        {
            var settings = GetCurrentSetting();
            var inputText = InputTextBox.Text;
            if (inputText.Length > 0)
            {
                foreach (var setting in settings.SettingItems)
                {
                    if (setting.NeedReplaceStr.Length > 0)
                    {
                        inputText = inputText.Replace(setting.NeedReplaceStr, setting.ReplaceStr);
                    }

                }
                OutPutTextBox.Text = inputText;
            }
        }

        private void SettingListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SettingNameBox.Text = SettingListBox.Text;
            var settings = GetLocalSettings();
            var setting = settings.FirstOrDefault(x => x.Name == SettingListBox.Text);
            if (setting != null)
            {
                SetDatagridViewSetting(setting);
            }
            else
            {
                InputTextBox.Text = "";
            }
            ReplaceBtn_Click_1(sender, e);
        }

        private void BtdAddRow_Click_1(object sender, EventArgs e)
        {
            var setting = GetCurrentSetting();

            List<Setting> settings = GetLocalSettings();
            if (settings == null)
            {
                settings.Add(setting);
            }
            else
            {
                var existSettings = settings.FirstOrDefault(x => x.Name == setting.Name);
                if (existSettings == null)
                {
                    settings.Add(setting);
                }
                else
                {
                    settings.Remove(existSettings);
                    settings.Add(setting);
                }
            }
            var path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            File.WriteAllText(path + "/Setting/Settings.txt", JsonConvert.SerializeObject(settings));
            RefreshSetting();
        }

        private void ConfigDelBtn_Click(object sender, EventArgs e)
        {
            var setting = GetCurrentSetting();

            List<Setting> settings = GetLocalSettings();
            if (settings == null)
            {
            }
            else
            {
                var existSettings = settings.FirstOrDefault(x => x.Name == setting.Name);
                if (existSettings == null)
                {
                }
                else
                {
                    settings.Remove(existSettings);
                }
            }
            var path = Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            File.WriteAllText(path + "/Setting/Settings.txt", JsonConvert.SerializeObject(settings));
            RefreshSetting();
        }

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
            OutPutTextBox.Text = sb.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            var inputText = InputTextBox.Text;
            var res = inputText.Replace("\r\n", "").Replace("\"", "\\\"").Replace(" ", "");
            OutPutTextBox.Text = res;

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
            OutPutTextBox.Text = res;

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
            OutPutTextBox.Text = outputStr;
        }


        private void AddAuthCodeBtn_Click(object sender, EventArgs e)
        {
            OutPutTextBox.Text = "";
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
                OutPutTextBox.Text += item+"\r\n";
            }

        }

        public string   GetToolBarTranslateContent(string input)
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

        public string GetRegPermissionCode(string toolbarAndIdContent,string tableName)
        {

            var type = 1;
            if (toolbarAndIdContent.Contains("treegrid"))
            {
                type = 2;
            }
            var regPermissionCode= $"regPermission(\"{tableName}\", {type}); \r\n            $(\".lazyLoad\").css(\"visibility\",\"visible\")";
            return regPermissionCode;
        }

        private void CheckRegCodeBtn_Click(object sender, EventArgs e)
        {
            OutPutTextBox.Text = "";
            var filePathList = FileHelper.GetDirAllFiles(InputTextBox.Text);            
            foreach (var item in filePathList)
            {
 
                var html = File.ReadAllText(item);
                if (html.Contains("id:\"<"))
                {
                    OutPutTextBox.Text += item + "\r\n";
                }
                

            }
            OutPutTextBox.Text += "Ending." + "\r\n";
        }
    }
}
