
namespace DesignPatterns.Architectural.Singleton
{
    public class Singleton
    {
        private static Singleton? instance;

        // private constructor so other classes cant instantiate this
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
