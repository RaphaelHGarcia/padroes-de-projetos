namespace AbstractFactory
{
    public abstract class DBFactory
    {
        public abstract DBConnection createConnection();
        public abstract DBCommand createComand();
    }
}
