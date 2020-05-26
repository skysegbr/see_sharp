using System;
using System.Collections.Generic;
using System.Text.Json;
using APIautorizador.DAO;
using APIAutorizador.Entity;

namespace APIAutorizador
{
    class Testes
    {
        static void testePlano()
        {
            string jsonString;
            List<PlanoSaudeEntity> listaPlanos = new List<PlanoSaudeEntity>();
            PlanoSaudeEntity plano = new PlanoSaudeEntity();
            IPlanoSaudeDAO planoDao = new PlanoSaudeDAO();
            listaPlanos = planoDao.Listar("sulamerica");
            
            foreach (PlanoSaudeEntity p in listaPlanos)
            {
                //Console.WriteLine(p.NomePlas);
                jsonString = JsonSerializer.Serialize(p);
                Console.WriteLine(jsonString);
            }

            Console.WriteLine("Testes");

        }
        // static void Main(string[] args)
        // {
        //     var r = new RetornaPlanosSaude();
        //     r.ListaPlanos("sulamerica");
            
        // }
    }
}
