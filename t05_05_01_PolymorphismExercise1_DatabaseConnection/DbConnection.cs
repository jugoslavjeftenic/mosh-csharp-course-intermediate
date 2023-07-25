namespace t05_05_01_PolymorphismExercise1_DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString, int timeSpan = 5)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            Timeout = TimeSpan.FromSeconds(timeSpan);
        }

        public abstract void Open();
        public abstract void Close();
    }
}