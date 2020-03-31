using System;

namespace _03_carro_preco_ao_consumidor
{
   class RetornaImposto
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            return valor;            
        }
    }
}