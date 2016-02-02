using System;

namespace AbstractFactory
{
    // Produto Concreto (Concret Product)
    public class SQLConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método open do SQL Connection foi chamado");
        }
    }
}
