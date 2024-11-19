using System.Text;

namespace TodoApp.Services
{
    public class MarkdownExporter
    {
        public void ExportToMarkdown(string content, string filePath)
        {
            // Create directory if it doesn't exist
            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Write content to the file
            File.WriteAllText(filePath, content, Encoding.UTF8);
        }
    }
}
