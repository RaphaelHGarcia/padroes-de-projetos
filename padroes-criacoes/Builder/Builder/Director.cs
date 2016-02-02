using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void Construir(VeiculoBuilder builder) {
            builder.BuilderMotor();
            builder.BuilderPneus();
            builder.BuilderPortas();
        }
    }
}
