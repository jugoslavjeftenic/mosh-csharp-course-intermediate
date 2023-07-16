namespace t03_03_Composition
{
    internal class Installer
    {
        private readonly Logger _logger;

        internal Installer(Logger logger)
        {
            _logger = logger;
        }

        internal void Install()
        {
            _logger.Log("We are installing the aplication.");
        }
    }
}