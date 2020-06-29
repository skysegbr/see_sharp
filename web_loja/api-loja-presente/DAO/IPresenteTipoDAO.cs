using System.Collections.Generic;
using api_loja_presente.Model;

namespace api_loja_presente.DAO
{
    public interface IPresenteTipoDAO
    {
        List<PresenteTipoEntity> ListarTipoPresente();
    }
}