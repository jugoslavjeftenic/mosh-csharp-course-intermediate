namespace t05_05_01_PolymorphismExercise1_DatabaseConnection
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, int timeSpan = 5) : base(connectionString, timeSpan)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Connection to Oracle database is open.");
        }

        public override void Close()
        {
            Console.WriteLine("Connection to Oracle database is closed.");
        }
    }
}
