namespace oop
{
    public class Composition
    {
        private readonly Logger _logger;

        public Composition(Logger logger)
        {
            _logger = logger;
        }

        public void compose()
        {
            _logger.Log("Logging a composition");
        }
    }
}




