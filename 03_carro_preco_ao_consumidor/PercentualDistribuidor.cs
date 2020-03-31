using System;

namespace _03_carro_preco_ao_consumidor
{
    public interface PercentualDistribuidor
    {
        double Calcula(Orcamento orcamento);
        double Value { get; }
    }
}