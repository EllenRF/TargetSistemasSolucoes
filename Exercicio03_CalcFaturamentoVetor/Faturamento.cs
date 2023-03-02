using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercicio03_CalcFaturamentoVetor
{
    [Serializable]
    public class Faturamento
    {
        public int dia { get; set; }
        public float valor { get; set; }

       
    }
}
