using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace HtmlGenerator
{
    internal class TheFileManager
    {
        public static String SaveStringToFile(string fileContents, string fileName)
        {
            string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);

            string theFolderName = Path.Combine(desktopPath, "HTML Generated");
            if (!Directory.Exists(theFolderName))
            {
                Directory.CreateDirectory(theFolderName);
            }

            string filePath = Path.Combine(theFolderName, fileName);

            File.WriteAllText(filePath, fileContents);
            return filePath;
        }
        public static bool OpenFileLocationExplorer(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
                return true;
            }
            else
            {
                MessageBox.Show("File no longer exist");
                return false;
            }
        }
    }
}
