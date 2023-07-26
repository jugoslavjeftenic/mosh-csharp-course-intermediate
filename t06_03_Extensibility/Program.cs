namespace t06_03_Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());

            string filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
            string fileName = "log.txt";

            var dbMigrator = new DbMigrator(new FileLogger($"{filePath}{fileName}"));
            dbMigrator.Migrate();
        }
    }
}