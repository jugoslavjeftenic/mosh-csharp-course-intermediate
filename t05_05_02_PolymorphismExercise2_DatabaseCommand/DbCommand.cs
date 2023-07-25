using t05_05_01_PolymorphismExercise1_DatabaseConnection;

namespace t05_05_02_PolymorphismExercise2_DatabaseCommand
{
    public class DbCommand
    {
        public DbConnection DbConn { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            DbConn = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
            Instruction = instruction ?? throw new ArgumentNullException(nameof(instruction));
        }

        public void Execute()
        {
            DbConn.Open();
            Console.WriteLine($"Execute: {Instruction}");
            DbConn.Close();
        }
    }
}