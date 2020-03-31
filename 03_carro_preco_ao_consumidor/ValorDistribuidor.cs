using System;

namespace _03_carro_preco_ao_consumidor
{
    class ValorDistribuidor : PercentualDistribuidor
    {
        private double value = 0.28;

        public double Value
        {
            get
            {
                return value;
            }
        }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * value;
        }


    }
}