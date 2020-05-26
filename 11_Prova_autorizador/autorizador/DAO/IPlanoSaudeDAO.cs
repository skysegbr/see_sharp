using Entities;
using System.Collections.Generic;


namespace DAO
{

    interface IPlanoSaudeDAO
    {
        List<PlanoSaudeEntity> Listar(string nome);
    }

}

