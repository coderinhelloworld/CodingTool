using ekko.amazon.Util;
using Newtonsoft.Json;
using ReplaceTool.Entity;
using ReplaceTool.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ReplaceTool.Setting
{
    public static class SettingHelper
    {
        public static List<Settings> GetLocalSettings()
        {
            var pathPrefix = Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
            var settingsStr = File.ReadAllText(pathPrefix + "/Setting/Settings.txt");
            var res = JsonConvert.DeserializeObject<List<Settings>>(settingsStr);
            if (res == null)
            {
                return new List<Settings>()
                {
                };
            }
            return res;
        }
        public static Settings GetCurrentSetting()
        {
            var dataGridView1 = Components.ReplaceDataGridView;
            var inputTextBox = Components.InputTextBox;
            Settings setting = new Settings()
            {
                SettingItems = new List<SettingItem>()
            };
            setting.Name = Components.SettingNameList.Text;
            setting.Input = inputTextBox.Text;
            var res = dataGridView1.Rows;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                SettingItem settingItem = new SettingItem();
                settingItem.NeedReplaceStr = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                settingItem.ReplaceStr = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                settingItem.ReplaceType = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                settingItem.Group = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                if (settingItem.NeedReplaceStr.IsNullOrEmpty()&& settingItem.ReplaceStr.IsNullOrEmpty()&& settingItem.ReplaceType.IsNullOrEmpty())
                {
                    continue;
                }
                setting.SettingItems.Add(settingItem);
            }
            return setting;
        }
    }
}
