using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Builder
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;
        public Veiculo Veiculo
        {
            get { return _veiculo; }    
        }

        // Processo de Construção
        public abstract void BuilderMotor();
        public abstract void BuilderPneus();
        public abstract void BuilderPortas();
    }
}
