using System;

namespace _03_carro_preco_ao_consumidor
{
    class Program
    {
        static void Main(string[] args)
        {

            Screens screans = new Screens();
            screans.AssembleScreensTop("Carros!!!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Entre com o valor de fabrica do veiculo: ");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                var veiculo = double.Parse(Console.ReadLine());



                Imposto icms = new ICMS();
                Orcamento orcamento = new Orcamento(veiculo);

                RetornaImposto calcImposto = new RetornaImposto();

                var impostoCalculado = calcImposto.RealizaCalculo(orcamento, icms);

                PercentualDistribuidor distribuidor = new ValorDistribuidor();

                RetornaComissaoDistribuidor calcDistribuidor = new RetornaComissaoDistribuidor();

                var distribuidorCalculado = calcDistribuidor.RealizaCalculo(orcamento, distribuidor);

                var totalVeiculo = veiculo + impostoCalculado + distribuidorCalculado;

                Console.WriteLine();
                Console.WriteLine("Valor de fabrica do veiculo:        {0}", veiculo);
                Console.WriteLine("Imposto ICMS:                       {0}", icms.Value);
                Console.WriteLine("Comissão:                           {0}", distribuidor.Value);
                Console.WriteLine("Valor do imposto:                   {0}", impostoCalculado);
                Console.WriteLine("Comissão calculado do distribuidor: {0}", distribuidorCalculado);
                Console.WriteLine("Valor final calculado do veiculo:   {0}", totalVeiculo);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ta errado Velho!!! tem que ser numerico!!! " + e.Message);
                Console.ResetColor();
            }

            screans.AssembleScreensFooter();
            Console.ReadKey();
        }
    }
}
