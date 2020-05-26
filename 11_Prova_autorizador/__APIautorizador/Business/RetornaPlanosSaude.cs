using System;
using System.Collections.Generic;
using System.Text.Json;
using APIautorizador.DAO;
using APIautorizador.Entity;

namespace APIautorizador.Business
{
    class RetornaPlanosSaude
    {
        public void ListaPlanos(string plano)
        {
            string jsonString;
            List<PlanoSaudeEntity> listaPlanos = new List<PlanoSaudeEntity>();
            IPlanoSaudeDAO planoDao = new PlanoSaudeDAO();
            listaPlanos = planoDao.Listar(plano);
            
            foreach (PlanoSaudeEntity p in listaPlanos)
            {
                //Console.WriteLine(p.NomePlas);
                jsonString = JsonSerializer.Serialize(p);
                Console.WriteLine(jsonString);
            }

            Console.WriteLine("Testes");
        }

    }
}