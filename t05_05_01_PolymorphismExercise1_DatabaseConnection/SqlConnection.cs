﻿namespace t05_05_01_PolymorphismExercise1_DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, int timeSpan = 5) : base(connectionString, timeSpan)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Connection to SQL Server is open.");
        }

        public override void Close()
        {
            Console.WriteLine("Connection to SQL Server is closed.");
        }
    }
}