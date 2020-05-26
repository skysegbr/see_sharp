using System.Collections.Generic;
using APIautorizador.Entity;

namespace APIautorizador.DAO
{
    interface IPlanoSaudeDAO
    {
        List<PlanoSaudeEntity> Listar(string nome);
    }

}