using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReplaceTool.Util
{
    public static class EnumsHelper
    {
       public static List<string> GetEnumList(Type e)
        {
            //获取枚举类型的所有字段的名称
            var names = Enum.GetNames(e);
            var list = new List<string>();
            foreach (var name in names)
            {
                list.Add(name);
            }
            return list;
        }
    }
}
