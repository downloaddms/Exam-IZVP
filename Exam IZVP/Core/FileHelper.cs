using System.IO;

namespace Exam_IZVP.Core
{
    public static class FileHelper
    {
        public static void CreateFolder(string folderName)
        {
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);
        }

        public static string GetDataPath() => "Data";
        public static string GetExportPath() => "Exports";
    }
}