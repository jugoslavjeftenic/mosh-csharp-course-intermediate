namespace t03_03_Composition
{
    internal class DbMigrator
    {
        private readonly Logger _logger;

        internal DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        internal void Migrate()
        {
            _logger.Log("We are migrating.");
        }
    }
}