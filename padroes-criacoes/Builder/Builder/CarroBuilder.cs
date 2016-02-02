using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Concrete Builder
    public class CarroBuilder : VeiculoBuilder
    {

        public CarroBuilder() {
            _veiculo = new Veiculo("Carro");
        }

        public override void BuilderMotor()
        {
            _veiculo["motor"] = "127c";
        }

        public override void BuilderPneus()
        {
            _veiculo["portas"] = "4";
        }

        public override void BuilderPortas()
        {
            _veiculo["pneus"] = "4";
        }
    }
}
