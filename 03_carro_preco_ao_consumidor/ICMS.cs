using System;

namespace _03_carro_preco_ao_consumidor
{
    class ICMS : Imposto
    {
        private double value = 0.45;

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