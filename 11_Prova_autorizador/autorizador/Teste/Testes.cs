
using DAO;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Teste
{
    class Testes
    {
        static void Main(string[] args)
        {

            //List<string> json = new List<string>();

            List<PlanoSaudeEntity> listaPlanos = new List<PlanoSaudeEntity>();
            //PlanoSaudeEntity plano = new PlanoSaudeEntity();
            PlanoSaudeDAO planoDao = new PlanoSaudeDAO();
            listaPlanos = planoDao.Listar("sulamerica");

            foreach (PlanoSaudeEntity p in listaPlanos)
            {
                Console.WriteLine(p.NomePlas);
            }




            //foreach (DbDataRecord s in reader)
            //{
            //    string val = s.GetString(0);
            //    Console.WriteLine(val);
            //}

        }
    }
}
