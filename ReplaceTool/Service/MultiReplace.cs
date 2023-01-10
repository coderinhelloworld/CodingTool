using Newtonsoft.Json;
using ReplaceTool.Entity;
using ReplaceTool.Enums;
using ReplaceTool.Global;
using ReplaceTool.Setting;
using ReplaceTool.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ReplaceTool.Service
{
    public static class MultiReplace
    {
        public static void  Init()
        {
            var dgv = Components.ReplaceDataGridView;
            var settingBox = Components.SettingNameList;
            ////根据Header和所有单元格的内容自动调整行的高度
            //添加三列
            for (int i = 0; i < 4; i++)
            {
                if (i==2)
                {
                    DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                    var enumList= EnumsHelper.GetEnumList(typeof(ReplaceWay));
                    enumList.Add("");
                    column.DataSource = enumList;
                    dgv.Columns.Add(column);
                }
                else
                {
                    dgv.Columns.Add(new DataGridViewTextBoxColumn());
                }
                dgv.Columns[i].Width = 500;
                dgv.RowTemplate.Height = 30;
            }
            //三列的标题
            dgv.Columns[0].HeaderText = "需要替换的内容";
            dgv.Columns[1].HeaderText = "替换后的内容";
            dgv.Columns[2].HeaderText = "替换方式";
            dgv.Columns[3].HeaderText = "组别";
            //设置对齐方式和字体
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Font = new Font("微软雅黑", 11);
            var settings = SettingHelper.GetLocalSettings();
            settingBox.DataSource = settings;
            settingBox.DisplayMember = "Name";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //首列Header
            dgv.RowHeadersVisible = true;
            dgv.RowHeadersWidth = 25;
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
        }

        public static void SaveSetting()
        {
            var setting = SettingHelper.GetCurrentSetting();
            List<Settings> settings = SettingHelper.GetLocalSettings();
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
            RefreshSetting(setting.Name);
        }

        public static void RefreshSetting(string name)
        {
            var settingList = SettingHelper.GetLocalSettings();
            var InputTextBox = Components.InputTextBox;
            var settingListBox = Components.SettingNameList;
            settingListBox.DataSource = SettingHelper.GetLocalSettings();
            settingListBox.DisplayMember = "Name";
            if (settingList.Count > 0)
            {
                var currentSetting = settingList.FirstOrDefault(x => x.Name == name);
                if (currentSetting != null)
                {
                    SetDatagridViewSetting(currentSetting);
                    settingListBox.Text = currentSetting.Name;
                    InputTextBox.Text = currentSetting.Input;
                }
            }
        }

        public static void SetDatagridViewSetting(Settings setting)
        {
            var dataGridView1 = Components.ReplaceDataGridView;
            var inputTextBox = Components.InputTextBox;
            var outPutBox = Components.OutPutTextBox;
            dataGridView1.Rows.Clear();
            inputTextBox.Text = setting.Input;
            outPutBox.Text = string.Empty;
            var count = 0;
            foreach (var settingItem in setting.SettingItems)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = settingItem.NeedReplaceStr;
                dataGridView1.Rows[count].Cells[1].Value = settingItem.ReplaceStr;
                dataGridView1.Rows[count].Cells[2].Value = settingItem.ReplaceType;
                dataGridView1.Rows[count].Cells[3].Value = settingItem.Group;
                count++;
            }
        }

        public static void DeleteSetting()
        {
            var setting = SettingHelper.GetCurrentSetting();
            List<Settings> settings = SettingHelper.GetLocalSettings();
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
            MultiReplace.RefreshSetting(setting.Name);
        }
    }
}
