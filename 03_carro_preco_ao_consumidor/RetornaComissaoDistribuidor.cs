using System;

namespace _03_carro_preco_ao_consumidor
{
   class RetornaComissaoDistribuidor
    {
        public double RealizaCalculo(Orcamento orcamento, PercentualDistribuidor distribuidor)
        {
            double valor = distribuidor.Calcula(orcamento);
            return valor;            
        }
    }
}