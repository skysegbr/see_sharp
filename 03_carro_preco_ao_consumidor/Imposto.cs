using System;

namespace _03_carro_preco_ao_consumidor
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
        double Value { get; }
    }
}
