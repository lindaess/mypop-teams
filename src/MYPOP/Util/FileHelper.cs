using System.IO;


namespace MYPOP.Util
{
    public static class FileHelper
    {
        public static void CreateFile(string filePath)
        {
            // Create the file
            Console.WriteLine("Creating file: " + filePath);
            File.Create("transcripts/" + filePath);
        }

        public static void UpdateFile(string filePath, string content)
        {
            // Write the content to the file
            File.AppendAllText("transcripts/" + filePath, content);
        }

        public static string ReadFile(string filePath)
        {
            // Read the content of the file
            return File.ReadAllText("transcripts/" + filePath);
        }

        public static void DeleteFile(string filePath)
        {
            // Delete the file
            File.Delete("transcripts/" + filePath);
        }

        public static bool FileExists(string filePath)
        {
            // Check if the file exists
            return File.Exists("transcripts/" + filePath);
        }
    }
}