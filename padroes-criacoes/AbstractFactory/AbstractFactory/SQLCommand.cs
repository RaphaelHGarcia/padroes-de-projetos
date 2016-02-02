using System;

namespace AbstractFactory
{

    // Produto Concreto
    public class SQLCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Ecute de SQLCommand foi chamado");
        }
    }
}
