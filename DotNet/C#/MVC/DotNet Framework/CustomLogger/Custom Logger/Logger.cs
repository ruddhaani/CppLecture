namespace Custom_Logger
{
    public static class Logger
    {
        static string GetFileName(string folderPath)
        {
            DateTime today = DateTime.UtcNow.AddHours(5.5).Date;
            string filePath = Path.Combine(folderPath, $"Log_{today:yyyy-MM-dd}.txt");
            return filePath;
        }

        public static void LogToFile(string messageType , string message , string folderPath)
        {
            string timestamp = DateTime.UtcNow.AddHours(5.5).ToString("yyyy-MM-dd HH:mm:ss");
            string logMessage = $"{timestamp}{Environment.NewLine}{messageType}{Environment.NewLine}Message: {message}{Environment.NewLine}{Environment.NewLine}";

            string filePath = GetFileName(folderPath);

            try
            {
                File.AppendAllText(filePath, logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging failed: {ex.Message}");
            }
        }
    }
}
