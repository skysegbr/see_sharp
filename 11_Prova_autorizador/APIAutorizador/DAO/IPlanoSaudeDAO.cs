using System.Collections.Generic;
using APIAutorizador.Entity;

namespace APIautorizador.DAO
{
    interface IPlanoSaudeDAO
    {
        List<PlanoSaudeEntity> Listar(string nome);
    }

}