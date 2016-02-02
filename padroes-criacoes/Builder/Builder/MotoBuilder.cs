using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MotoBuilder : VeiculoBuilder
    {

        public MotoBuilder()
        {
            _veiculo = new Veiculo("Moto");    
        }

        public override void BuilderMotor()
        {
            _veiculo["motor"] = "125";
        }

        public override void BuilderPneus()
        {
            _veiculo["portas"] = "0";
        }

        public override void BuilderPortas()
        {
            _veiculo["pneus"] = "2";
        }
    }
}
