using System.IO;

namespace EduCal
{
    public static class FileHandler
    {
        public static void SaveToFile(string content, int year)
        {
            string fileName = $"Calendar_{year}.txt";

            // Save to the application's directory
            File.WriteAllText(fileName, content);
        }
    }
}
