using System.Collections.Generic;
using api_loja_presente.Model;

namespace api_loja_presente.DAO
{
    public interface IPresenteMarcaDAO
    {
        List<PresenteMarcaEntity> ListarMarcaPresente();
    }
}