using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory db = new SQLFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createComand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}
