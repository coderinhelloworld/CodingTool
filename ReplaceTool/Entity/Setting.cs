using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTool.Entity
{
   public class Setting
    {
        public string Name { get; set; }     
        public string Input { get; set; }     
        public List<SettingItem> SettingItems { get; set; }
    }


    public class SettingItem
    {
        public string NeedReplaceStr { get; set; }
        public string ReplaceStr { get; set; }
    }
}
