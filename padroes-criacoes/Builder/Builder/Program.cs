using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();

            builder = new CarroBuilder();
            director.Construir(builder);
            builder.Veiculo.Mostrar();

            builder = new MotoBuilder();
            director.Construir(builder);
            builder.Veiculo.Mostrar();

            Console.ReadLine();
        }
    }
}
