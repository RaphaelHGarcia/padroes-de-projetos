namespace AbstractFactory
{

    // Fabrica Concreta
    public class SQLFactory : DBFactory
    {
        public override DBCommand createComand()
        {
            return new SQLCommand();
        }

        public override DBConnection createConnection()
        {
            return new SQLConnection();
        }
    }
}
