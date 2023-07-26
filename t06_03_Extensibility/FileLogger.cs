namespace t06_03_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, LogType.ERROR);
        }

        public void LogInfo(string message)
        {
            Log(message, LogType.INFO);
        }

        public void Log(string message, LogType logType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{logType}: {message}");
            }
        }
    }
}