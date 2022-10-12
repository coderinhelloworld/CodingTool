using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTool.Helper
{
   public static class FileHelper
    {
        public static List<string> GetDirAllFiles(string path)
        {
            var fileList = new List<string>();
            DirectoryInfo TheFolder = new DirectoryInfo(path);
            var fileInfoList = GetAllFileInfo(TheFolder);
            foreach (var item in fileInfoList)
            {
                fileList.Add(item.FullName);
            }
            ////遍历文件夹
            //foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
            //{
            //    //遍历文件
            //    foreach (FileInfo NextFile in NextFolder.GetFiles())
            //    {
            //        fileList.Add(NextFile.FullName);
            //    }
            //}
            ////遍历文件
            //foreach (FileInfo NextFile in TheFolder.GetFiles())
            //{
            //    fileList.Add(NextFile.FullName);
            //}
            return fileList;
        }
        public static  System.IO.FileInfo[] GetAllFileInfo(System.IO.DirectoryInfo dir)
        {
            return dir.GetFiles(".", System.IO.SearchOption.AllDirectories);

        }
    }
}
